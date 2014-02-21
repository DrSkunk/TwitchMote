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
        public string Command { get ; set; }
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

        public KeyboardSetting(string command, string displayKey)
        {
            this.Command = command;
            this.DisplayKey = displayKey;
        }

        public static VirtualKeyCode ParseKey(string key)
        {
            switch (key.ToLower())
            {
                default:
                    return new VirtualKeyCode();
                case "return":
                    return VirtualKeyCode.RETURN;
                case "enter":
                    return VirtualKeyCode.RETURN;
                case "backspace":
                    return VirtualKeyCode.BACK;
                case "space":
                    return VirtualKeyCode.SPACE;
                case "numpad0":
                    return VirtualKeyCode.NUMPAD0;
                case "numpad1":
                    return VirtualKeyCode.NUMPAD1;
                case "numpad2":
                    return VirtualKeyCode.NUMPAD2;
                case "numpad3":
                    return VirtualKeyCode.NUMPAD3;
                case "numpad4":
                    return VirtualKeyCode.NUMPAD4;
                case "numpad5":
                    return VirtualKeyCode.NUMPAD5;
                case "numpad6":
                    return VirtualKeyCode.NUMPAD6;
                case "numpad7":
                    return VirtualKeyCode.NUMPAD7;
                case "numpad8":
                    return VirtualKeyCode.NUMPAD8;
                case "numpad9":
                    return VirtualKeyCode.NUMPAD9;
                case "num0":
                    return VirtualKeyCode.NUMPAD0;
                case "num1":
                    return VirtualKeyCode.NUMPAD1;
                case "num2":
                    return VirtualKeyCode.NUMPAD2;
                case "num3":
                    return VirtualKeyCode.NUMPAD3;
                case "num4":
                    return VirtualKeyCode.NUMPAD4;
                case "num5":
                    return VirtualKeyCode.NUMPAD5;
                case "num6":
                    return VirtualKeyCode.NUMPAD6;
                case "num7":
                    return VirtualKeyCode.NUMPAD7;
                case "num8":
                    return VirtualKeyCode.NUMPAD8;
                case "num9":
                    return VirtualKeyCode.NUMPAD9;
                case "0":
                    return VirtualKeyCode.VK_0;
                case "1":
                    return VirtualKeyCode.VK_1;
                case "2":
                    return VirtualKeyCode.VK_2;
                case "3":
                    return VirtualKeyCode.VK_3;
                case "4":
                    return VirtualKeyCode.VK_4;
                case "5":
                    return VirtualKeyCode.VK_5;
                case "6":
                    return VirtualKeyCode.VK_6;
                case "7":
                    return VirtualKeyCode.VK_7;
                case "8":
                    return VirtualKeyCode.VK_8;
                case "9":
                    return VirtualKeyCode.VK_9;
                case "tab":
                    return VirtualKeyCode.TAB;
                case "left":
                    return VirtualKeyCode.LEFT;
                case "right":
                    return VirtualKeyCode.RIGHT;
                case "up":
                    return VirtualKeyCode.UP;
                case "down":
                    return VirtualKeyCode.DOWN;
                case "esc":
                    return VirtualKeyCode.ESCAPE;
                case "escape":
                    return VirtualKeyCode.ESCAPE;
                case "shift":
                    return VirtualKeyCode.SHIFT;
                case "lshift":
                    return VirtualKeyCode.LSHIFT;
                case "rshift":
                    return VirtualKeyCode.RSHIFT;
                case "ctrl":
                    return VirtualKeyCode.CONTROL;
                case "lctrl":
                    return VirtualKeyCode.LCONTROL;
                case "rctrl":
                    return VirtualKeyCode.RCONTROL;
                case "control":
                    return VirtualKeyCode.CONTROL;
                case "lcontrol":
                    return VirtualKeyCode.LCONTROL;
                case "rcontrol":
                    return VirtualKeyCode.RCONTROL;
                case "f1":
                    return VirtualKeyCode.F1;
                case "f2":
                    return VirtualKeyCode.F2;
                case "f3":
                    return VirtualKeyCode.F3;
                case "f4":
                    return VirtualKeyCode.F4;
                case "f5":
                    return VirtualKeyCode.F5;
                case "f6":
                    return VirtualKeyCode.F6;
                case "f7":
                    return VirtualKeyCode.F7;
                case "f8":
                    return VirtualKeyCode.F8;
                case "f9":
                    return VirtualKeyCode.F9;
                case "f10":
                    return VirtualKeyCode.F10;
                case "f11":
                    return VirtualKeyCode.F11;
                case "f12":
                    return VirtualKeyCode.F12;
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
