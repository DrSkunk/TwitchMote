using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitchmote.Classes
{
    class KeyboardSetting
    {
        public string Key { get; set; }
        public string Value { get; set; }

        public KeyboardSetting() { }

        public KeyboardSetting(string key, string value)
        {
            this.Key = key;
            this.Value = value;
        }
    }
}
