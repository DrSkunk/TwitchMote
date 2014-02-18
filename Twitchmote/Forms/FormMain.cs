using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
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
        Irc irc;
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
            wait = Properties.Settings.Default.keyWait;
            textBoxGame.Text = game;
            textBoxServer.Text = server;
            textBoxRoom.Text = room;
            textBoxUser.Text = user;
            textBoxPassword.Text = password;
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
            this.WriteConsole("Irc stopped.");
            irc.Stop();
            started = false;
            buttonStart.Text = "Start";
        }

        private void StartIrc()
        {

            this.WriteConsole("Irc started.");
            irc = new Irc(this);
            irc.Start();
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
                string value = ConfigurationManager.AppSettings[key];
                keyboardSettings.Add(new KeyboardSetting(key, value));
            }
            WriteConsole("Keybinds loaded.");
        }

        private void AddCommandToList(string text)
        {
            if (this.consoleTB.InvokeRequired)
            {
                ParseInputCallback d = new ParseInputCallback(AddCommandToList);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                string command = text.Split(':')[1];

                VirtualKeyCode keyCode = new VirtualKeyCode();
                foreach (KeyboardSetting keyboardSetting in keyboardSettings)
                {
                    if (command == keyboardSetting.Command.ToLower())
                    {
                        keyCode = keyboardSetting.Key;
                        break;
                    }
                }

                if (keyCode != new VirtualKeyCode())
                {
                    formCommands.AddCommandToList(text);
                    inputSimulator.Keyboard.KeyDown(keyCode);
                    System.Threading.Thread.Sleep(wait);
                    inputSimulator.Keyboard.KeyUp(keyCode);
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
            Properties.Settings.Default.keyWait= Convert.ToInt32(numericUpDownKeyWait.Value);
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

    }
}
