using ChatSharp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Twitchmote.Classes;
using WindowsInput;
using WindowsInput.Native;

namespace Twitchmote
{
    public partial class FormMain : Form
    {
        FormCommands formCommands;
        Boolean started = false;
        IrcClient client;
        InterceptKeys interceptKeys;
        InputSimulator inputSimulator = new InputSimulator();
        List<KeyboardSetting> keyboardSettings = new List<KeyboardSetting>();
        int wait = 100;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            formCommands = new FormCommands();
            formCommands.Show();

            this.WriteConsole("F10: globale Start/Stop");

            string game = Properties.Settings.Default.game;
            string server = Properties.Settings.Default.server;
            string room = Properties.Settings.Default.room;
            string user = Properties.Settings.Default.user;
            string password = Properties.Settings.Default.password;
            string nickserv = Properties.Settings.Default.nickserv;
            wait = Properties.Settings.Default.keyWait;
            textBoxGame.Text = game;
            textBoxServer.Text = server;
            textBoxRoom.Text = room;
            textBoxUser.Text = user;
            textBoxPassword.Text = password;
            textBoxNickserv.Text = nickserv;
            numericUpDownKeyWait.Value = wait;

            interceptKeys = new InterceptKeys(this);
            interceptKeys.Start();
            ReloadKeybinds();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            ToggleIrc();
        }

        private void StopIrc()
        {
            try
            {
                client.Quit();
            }
            catch (Exception e) { }

            this.WriteConsole("irc service stopped");
            started = false;
            buttonStart.Text = "Start";
        }

        private void StartIrc()
        {
            var user = new IrcUser("");
            if (Properties.Settings.Default.nickserv == string.Empty)
                user = new IrcUser("twitchplaysagame", "twitchplaysagame");
            else
                user = new IrcUser(Properties.Settings.Default.user, Properties.Settings.Default.user);
            client = new IrcClient(Properties.Settings.Default.server, user);
            client.NetworkError += (s, e) => WriteConsole("Error: " + e.SocketError);

            client.ChannelMessageRecieved += (s, e) =>
            {
                ParseInput(e.PrivateMessage.User.Nick + ":" + e.PrivateMessage.Message);
            };
            client.ConnectionComplete += (s, e) =>
            {
                client.SendRawMessage("PRIVMSG {0} :{1}", "nickserv", "identify " + Properties.Settings.Default.nickserv);
                client.Channels.Join(Properties.Settings.Default.room);
                WriteConsole("Connected");
            };
            client.ConnectAsync();

            this.WriteConsole("Starting irc service");
            started = true;
            buttonStart.Text = "Stop";
        }

        /// <summary>
        /// Access key hook
        /// </summary>
        /// <param name="txt"></param>

        public void ToggleIrcThreaded(string txt = "") //don't know why, but works
        {
            ToggleIrc();
        }

        delegate void InterceptKeyCallback();

        private void ToggleIrc()
        {
            if (this.consoleTB.InvokeRequired)
            {
                ParseInputCallback d = new ParseInputCallback(ToggleIrcThreaded);
                this.Invoke(d, new object[] { "" });
            }
            else
            {
                if (started)
                    StopIrc();
                else
                    StartIrc();
            }
        }

        /// <summary>
        /// Parse irc messages
        /// </summary>
        /// <param name="txt"></param>

        public void ParseInput(string txt)
        {
            AddCommandToList(txt);
        }

        delegate void ParseInputCallback(string text);

        public void ReloadKeybinds()
        {
            foreach (string key in ConfigurationManager.AppSettings)
            {
                string[] value = ConfigurationManager.AppSettings[key].Split(';');
                string modifier = string.Empty;
                if (value.Length == 2)
                    modifier = value[1];
                keyboardSettings.Add(new KeyboardSetting(key, value[0], modifier));
            }
            WriteConsole("Keybinds loaded.");
        }

        private void AddCommandToList(string txt)
        {
            if (this.consoleTB.InvokeRequired)
            {
                ParseInputCallback d = new ParseInputCallback(AddCommandToList);
                this.Invoke(d, new object[] { txt });
            }
            else
            {
                WriteConsole(txt);
                string command = txt.Split(':')[1];
                VirtualKeyCode keyCode = new VirtualKeyCode();
                VirtualKeyCode modifierKeyCode = new VirtualKeyCode();
                foreach (KeyboardSetting keyboardSetting in keyboardSettings)
                {
                    if (command.ToLower() == keyboardSetting.Command.ToLower())
                    {
                        keyCode = keyboardSetting.Key;
                        modifierKeyCode = keyboardSetting.Modifier;
                        break;
                    }
                }

                if (keyCode != new VirtualKeyCode())
                {
                    formCommands.AddCommandToList(txt);

                    if(modifierKeyCode != new VirtualKeyCode())
                        inputSimulator.Keyboard.KeyDown(modifierKeyCode);

                    inputSimulator.Keyboard.KeyDown(keyCode);
                    System.Threading.Thread.Sleep(wait);
                    inputSimulator.Keyboard.KeyUp(keyCode);

                    if (modifierKeyCode != new VirtualKeyCode())
                        inputSimulator.Keyboard.KeyUp(modifierKeyCode);
                }
            }
        }

        /// <summary>
        /// Write to console
        /// </summary>
        /// <param name="txt"></param>

        public void WriteConsole(string txt)
        {
            SetConsoleText(txt);
        }

        delegate void SetConsoleTextCallback(string text);

        private void SetConsoleText(string text)
        {
            if (this.consoleTB.InvokeRequired)
            {
                SetConsoleTextCallback d = new SetConsoleTextCallback(SetConsoleText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                if (consoleTB.Lines.Count() == 200)
                    consoleTB.Text = string.Empty;

                string previous = consoleTB.Text;
                this.consoleTB.Text = text + Environment.NewLine + previous + Environment.NewLine;
            }
        }

        private void textBoxGame_TextChanged(object sender, EventArgs e)
        {
            formCommands.SetGame(textBoxGame.Text);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.game = textBoxGame.Text;
            Properties.Settings.Default.server = textBoxServer.Text;
            Properties.Settings.Default.room = textBoxRoom.Text;
            Properties.Settings.Default.user = textBoxUser.Text;
            Properties.Settings.Default.password = textBoxPassword.Text;
            Properties.Settings.Default.keyWait = Convert.ToInt32(numericUpDownKeyWait.Value);
            Properties.Settings.Default.nickserv = textBoxNickserv.Text;
            Properties.Settings.Default.Save();
            this.WriteConsole("Settings saved.");
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            consoleTB.Text = string.Empty;
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            interceptKeys.Stop();
            StopIrc();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            interceptKeys.Stop();
        }

        private void buttonConfigKeyboard_Click(object sender, EventArgs e)
        {
            FormConfigKeyboard formConfigKeyboard = new FormConfigKeyboard();
            formConfigKeyboard.ShowDialog(this);
            ReloadKeybinds();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            submitCommand();
        }

        private void textBoxCommand_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return && textBoxCommand.Text != string.Empty)
                submitCommand();
        }

        private void submitCommand()
        {
            AddCommandToList(textBoxUser.Text + ":" + textBoxCommand.Text);
            textBoxCommand.Text = string.Empty;
        }

    }
}
