using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
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

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            formCommands = new FormCommands();
            formCommands.Show();

            this.WriteConsole("F10: globale Start/Stop");

            string game = Properties.Settings.Default["game"].ToString();
            string room = Properties.Settings.Default["room"].ToString();
            string user = Properties.Settings.Default["user"].ToString();
            string password = Properties.Settings.Default["password"].ToString();
            textBoxGame.Text = game;
            textBoxRoom.Text = room;
            textBoxUser.Text = user;
            textBoxPassword.Text = password;

            interceptKeys = new InterceptKeys(this);
            interceptKeys.Start();
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

        private void AddCommandToList(string text)
        {
            if (this.consoleTB.InvokeRequired)
            {
                ParseInputCallback d = new ParseInputCallback(AddCommandToList);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                formCommands.AddCommandToList(text);
                string key = text.Split(':')[1];
                int wait = 100;
                switch (key)
                {
                    case "a":
                        inputSimulator.Keyboard.KeyDown(VirtualKeyCode.VK_R);
                        System.Threading.Thread.Sleep(wait);
                        inputSimulator.Keyboard.KeyUp(VirtualKeyCode.VK_R);
                        //SendKeys.SendWait("a");
                        break;
                    case "b":
                        inputSimulator.Keyboard.KeyDown(VirtualKeyCode.VK_F);
                        System.Threading.Thread.Sleep(wait);
                        inputSimulator.Keyboard.KeyUp(VirtualKeyCode.VK_F);
                        //SendKeys.SendWait("b");
                        break;
                    case "up":
                        inputSimulator.Keyboard.KeyDown(VirtualKeyCode.VK_Y);
                        System.Threading.Thread.Sleep(wait);
                        inputSimulator.Keyboard.KeyUp(VirtualKeyCode.VK_Y);
                        //SendKeys.SendWait("o");
                        break;
                    case "down":
                        inputSimulator.Keyboard.KeyDown(VirtualKeyCode.VK_H);
                        System.Threading.Thread.Sleep(wait);
                        inputSimulator.Keyboard.KeyUp(VirtualKeyCode.VK_H);
                        //SendKeys.SendWait("l");
                        break;
                    case "left":
                        inputSimulator.Keyboard.KeyDown(VirtualKeyCode.VK_G);
                        System.Threading.Thread.Sleep(wait);
                        inputSimulator.Keyboard.KeyUp(VirtualKeyCode.VK_G);
                        //SendKeys.SendWait("k");
                        break;
                    case "right":
                        inputSimulator.Keyboard.KeyDown(VirtualKeyCode.VK_C);
                        System.Threading.Thread.Sleep(wait);
                        inputSimulator.Keyboard.KeyUp(VirtualKeyCode.VK_C);
                        //SendKeys.SendWait("m");
                        break;
                    case "start":
                        inputSimulator.Keyboard.KeyDown(VirtualKeyCode.VK_B);
                        System.Threading.Thread.Sleep(wait);
                        inputSimulator.Keyboard.KeyUp(VirtualKeyCode.VK_B);
                        //SendKeys.SendWait("i");
                        break;
                    case "select":
                        inputSimulator.Keyboard.KeyDown(VirtualKeyCode.VK_V);
                        System.Threading.Thread.Sleep(wait);
                        inputSimulator.Keyboard.KeyUp(VirtualKeyCode.VK_V);
                        //SendKeys.SendWait("p");
                        break;
                }
                //SendKeys.Send("{ENTER}");
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
            Properties.Settings.Default["game"] = textBoxGame.Text;
            Properties.Settings.Default["room"] = textBoxRoom.Text;
            Properties.Settings.Default["user"] = textBoxUser.Text;
            Properties.Settings.Default["password"] = textBoxPassword.Text;
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
        }

    }
}
