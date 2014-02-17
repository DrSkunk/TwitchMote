using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsInput.Native;

namespace Twitchmote.Classes
{
    class KeyboardSetting
    {
        public string Command { get; set; }
        public VirtualKeyCode Key { get; set; }
        public string DisplayKey
        {
            get
            {
                if(Key == new VirtualKeyCode())
                    return Key.ToString();
                else
                    return Key.ToString()[3].ToString();
            }
            set
            {
                Key = ParseKey(value);
            }
        }

        public KeyboardSetting() { }

        public KeyboardSetting(string command, VirtualKeyCode key)
        {
            this.Command = command;
            this.Key = key;
        }

        private VirtualKeyCode ParseKey(string key)
        {
            switch (key.ToLower())
            {
                default:
                    return VirtualKeyCode.VK_A;
                case "a":
                    return VirtualKeyCode.VK_A;
                case "b":
                    return VirtualKeyCode.VK_B;
                case "c":
                    return VirtualKeyCode.VK_C;
                case "d":
                    return VirtualKeyCode.VK_D;
                case "e":
                    return VirtualKeyCode.VK_E;
                case "f":
                    return VirtualKeyCode.VK_F;
                case "g":
                    return VirtualKeyCode.VK_G;
                case "h":
                    return VirtualKeyCode.VK_H;
                case "i":
                    return VirtualKeyCode.VK_I;
                case "j":
                    return VirtualKeyCode.VK_J;
                case "k":
                    return VirtualKeyCode.VK_K;
                case "l":
                    return VirtualKeyCode.VK_L;
                case "m":
                    return VirtualKeyCode.VK_M;
                case "n":
                    return VirtualKeyCode.VK_N;
                case "o":
                    return VirtualKeyCode.VK_O;
                case "p":
                    return VirtualKeyCode.VK_P;
                case "q":
                    return VirtualKeyCode.VK_Q;
                case "r":
                    return VirtualKeyCode.VK_R;
                case "s":
                    return VirtualKeyCode.VK_S;
                case "t":
                    return VirtualKeyCode.VK_T;
                case "u":
                    return VirtualKeyCode.VK_U;
                case "v":
                    return VirtualKeyCode.VK_V;
                case "w":
                    return VirtualKeyCode.VK_W;
                case "x":
                    return VirtualKeyCode.VK_X;
                case "y":
                    return VirtualKeyCode.VK_Y;
                case "z":
                    return VirtualKeyCode.VK_Z;
            }
        }
    }
}
