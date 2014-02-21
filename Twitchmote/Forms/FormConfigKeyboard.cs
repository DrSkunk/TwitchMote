using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Twitchmote.Classes;
using Twitchmote.Properties;
using WindowsInput.Native;

namespace Twitchmote
{
    public partial class FormConfigKeyboard : Form
    {
        BindingList<KeyboardSetting> keyboardSettings;

        public FormConfigKeyboard()
        {
            InitializeComponent();
        }

        private void FormConfigKeyboard_Load(object sender, EventArgs e)
        {
            keyboardSettings = new BindingList<KeyboardSetting>();
            foreach (string key in ConfigurationManager.AppSettings)
            {
                string[] value = ConfigurationManager.AppSettings[key].Split(';');
                string modifier = string.Empty;
                if (value.Length == 2)
                    modifier = value[1];
                keyboardSettings.Add(new KeyboardSetting(key, value[0], modifier));
            }

            BindingSource source = new BindingSource(keyboardSettings, null);
            dataGridViewKeyboard.DataSource = source;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Configuration.Configuration config =
             ConfigurationManager.OpenExeConfiguration
                        (ConfigurationUserLevel.None);

            config.AppSettings.Settings.Clear();

            foreach (KeyboardSetting keyboardSetting in keyboardSettings)
            {
                if (keyboardSetting.Command == null)
                    MessageBox.Show("Command cannot be empty.", "Save error");
                else if (keyboardSetting.DisplayKey == "0")
                    MessageBox.Show("Key cannot be 0.", "Save error");
                else
                {
                    config.AppSettings.Settings.Add(keyboardSetting.Command, keyboardSetting.DisplayKey + ";" + keyboardSetting.DisplayModifier);
                }
            }

            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");

            ((FormMain)this.Owner).WriteConsole("Keybindings saved.");
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
