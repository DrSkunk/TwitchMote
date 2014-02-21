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
        public VirtualKeyCode Modifier { get; set; }
        public string DisplayKey
        {
            get
            {
                if (Key == new VirtualKeyCode())
                    return Key.ToString();
                else
                    return Key.ToString();
            }
            set
            {
                Key = ParseKey(value);
            }
        }

        public string DisplayModifier
        {
            get
            {
                if (Modifier == new VirtualKeyCode())
                    return Modifier.ToString();
                else
                    return Modifier.ToString();
            }
            set
            {
                Modifier = ParseKey(value);
            }
        }

        public KeyboardSetting() { }

        public KeyboardSetting(string command, VirtualKeyCode key, VirtualKeyCode modifier)
        {
            this.Command = command;
            this.Key = key;
            this.Modifier = modifier;
        }

        public KeyboardSetting(string command, string displayKey, string displayModifier)
        {
            this.Command = command;
            this.DisplayKey = displayKey;
            this.DisplayModifier = displayModifier;
        }

        public static VirtualKeyCode ParseKey(string key)
        {
            if(key == null)
                return new VirtualKeyCode();
            switch (key.ToUpper())
            {
                default:
                    return new VirtualKeyCode();
                case "":
                    return new VirtualKeyCode();
                case "RETURN":
                    return VirtualKeyCode.RETURN;
                case "BACK":
                    return VirtualKeyCode.BACK;
                case "MENU":
                    return VirtualKeyCode.MENU;
                case "SPACE":
                    return VirtualKeyCode.SPACE;
                case "NUMPAD0":
                    return VirtualKeyCode.NUMPAD0;
                case "NUMPAD1":
                    return VirtualKeyCode.NUMPAD1;
                case "NUMPAD2":
                    return VirtualKeyCode.NUMPAD2;
                case "NUMPAD3":
                    return VirtualKeyCode.NUMPAD3;
                case "NUMPAD4":
                    return VirtualKeyCode.NUMPAD4;
                case "NUMPAD5":
                    return VirtualKeyCode.NUMPAD5;
                case "NUMPAD6":
                    return VirtualKeyCode.NUMPAD6;
                case "NUMPAD7":
                    return VirtualKeyCode.NUMPAD7;
                case "NUMPAD8":
                    return VirtualKeyCode.NUMPAD8;
                case "NUMPAD9":
                    return VirtualKeyCode.NUMPAD9;
                case "VK_0":
                    return VirtualKeyCode.VK_0;
                case "VK_1":
                    return VirtualKeyCode.VK_1;
                case "VK_2":
                    return VirtualKeyCode.VK_2;
                case "VK_3":
                    return VirtualKeyCode.VK_3;
                case "VK_4":
                    return VirtualKeyCode.VK_4;
                case "VK_5":
                    return VirtualKeyCode.VK_5;
                case "VK_6":
                    return VirtualKeyCode.VK_6;
                case "VK_7":
                    return VirtualKeyCode.VK_7;
                case "VK_8":
                    return VirtualKeyCode.VK_8;
                case "VK_9":
                    return VirtualKeyCode.VK_9;
                case "TAB":
                    return VirtualKeyCode.TAB;
                case "LEFT":
                    return VirtualKeyCode.LEFT;
                case "RIGHT":
                    return VirtualKeyCode.RIGHT;
                case "UP":
                    return VirtualKeyCode.UP;
                case "DOWN":
                    return VirtualKeyCode.DOWN;
                case "ESCAPE":
                    return VirtualKeyCode.ESCAPE;
                case "SHIFT":
                    return VirtualKeyCode.SHIFT;
                case "LSHIFT":
                    return VirtualKeyCode.LSHIFT;
                case "RSHIFT":
                    return VirtualKeyCode.RSHIFT;
                case "CONTROL":
                    return VirtualKeyCode.CONTROL;
                case "LCONTROL":
                    return VirtualKeyCode.LCONTROL;
                case "RCONTROL":
                    return VirtualKeyCode.RCONTROL;
                case "F1":
                    return VirtualKeyCode.F1;
                case "F2":
                    return VirtualKeyCode.F2;
                case "F3":
                    return VirtualKeyCode.F3;
                case "F4":
                    return VirtualKeyCode.F4;
                case "F5":
                    return VirtualKeyCode.F5;
                case "F6":
                    return VirtualKeyCode.F6;
                case "F7":
                    return VirtualKeyCode.F7;
                case "F8":
                    return VirtualKeyCode.F8;
                case "F9":
                    return VirtualKeyCode.F9;
                case "F10":
                    return VirtualKeyCode.F10;
                case "F11":
                    return VirtualKeyCode.F11;
                case "F12":
                    return VirtualKeyCode.F12;
                case "VK_A":
                    return VirtualKeyCode.VK_A;
                case "VK_B":
                    return VirtualKeyCode.VK_B;
                case "VK_C":
                    return VirtualKeyCode.VK_C;
                case "VK_D":
                    return VirtualKeyCode.VK_D;
                case "VK_E":
                    return VirtualKeyCode.VK_E;
                case "VK_F":
                    return VirtualKeyCode.VK_F;
                case "VK_G":
                    return VirtualKeyCode.VK_G;
                case "VK_H":
                    return VirtualKeyCode.VK_H;
                case "VK_I":
                    return VirtualKeyCode.VK_I;
                case "VK_J":
                    return VirtualKeyCode.VK_J;
                case "VK_K":
                    return VirtualKeyCode.VK_K;
                case "VK_L":
                    return VirtualKeyCode.VK_L;
                case "VK_M":
                    return VirtualKeyCode.VK_M;
                case "VK_N":
                    return VirtualKeyCode.VK_N;
                case "VK_O":
                    return VirtualKeyCode.VK_O;
                case "VK_P":
                    return VirtualKeyCode.VK_P;
                case "VK_Q":
                    return VirtualKeyCode.VK_Q;
                case "VK_R":
                    return VirtualKeyCode.VK_R;
                case "VK_S":
                    return VirtualKeyCode.VK_S;
                case "VK_T":
                    return VirtualKeyCode.VK_T;
                case "VK_U":
                    return VirtualKeyCode.VK_U;
                case "VK_V":
                    return VirtualKeyCode.VK_V;
                case "VK_W":
                    return VirtualKeyCode.VK_W;
                case "VK_X":
                    return VirtualKeyCode.VK_X;
                case "VK_Y":
                    return VirtualKeyCode.VK_Y;
                case "VK_Z":
                    return VirtualKeyCode.VK_Z;
            }
        }
    }
}
