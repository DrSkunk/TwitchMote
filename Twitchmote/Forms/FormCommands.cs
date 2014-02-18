using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Twitchmote
{
    public partial class FormCommands : Form
    {
        List<string> commands = new List<string>();
        TimeSpan elapsed = new TimeSpan();

        public FormCommands()
        {
            InitializeComponent();
        }

        public void AddCommandToList(string text)
        {
            if (commands.Count == 10)
                commands.RemoveAt(0);

            commands.Add(text);
            labelCommands.Text = string.Empty;
            string totalCommand = string.Empty;
            foreach (string command in commands)
            {
                totalCommand += command + Environment.NewLine;
            }
            labelCommands.Text = totalCommand;

        }

        public void SetGame(string text)
        {
            labelGame.Text = "plays " + text;
        }

        private void FormCommands_Load(object sender, EventArgs e)
        {
            labelCommands.Text = string.Empty;
            labelGame.Text = string.Empty;
            elapsed = (TimeSpan)Properties.Settings.Default["elapsed"];
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            labelServerTime.Text = currentTime.ToLongTimeString();

            labelTimer.Text = elapsed.Days + "d " + elapsed.Hours + "h " + elapsed.Minutes + "m " + elapsed.Seconds + "s";
            elapsed = elapsed.Add(TimeSpan.FromSeconds(1));
            if (elapsed.Seconds == 0)
                Properties.Settings.Default["elapsed"] = elapsed;
        }
    }
}
