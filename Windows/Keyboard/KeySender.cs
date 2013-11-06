﻿using System.Collections.Generic;
using System.Linq;

namespace nucs.Windows.Keyboard {
    public static class KeySender {
        public static void SendText(string text) {
            InputSimulator.SimulateTextEntry(text);
        }

        public static void PressKey(KeyCode key) {
            InputSimulator.SimulateKeyPress((VirtualKeyCode)((ushort)(key)));
        }

        public static void PressKey(IEnumerable<KeyCode> modifiers, KeyCode key) {
            InputSimulator.SimulateModifiedKeyStroke(modifiers.Select(j => (VirtualKeyCode)((ushort)(j))), (VirtualKeyCode)((ushort)(key)));
        }

        public static void PressKey(KeyCode modifier, KeyCode key) {
            InputSimulator.SimulateModifiedKeyStroke((VirtualKeyCode)((ushort)(modifier)), (VirtualKeyCode)((ushort)(key)));
        }

        public static void PressKeys(IEnumerable<KeyCode> modifiers, IEnumerable<KeyCode> keys) {
            InputSimulator.SimulateModifiedKeyStroke(modifiers.Select(j => (VirtualKeyCode)((ushort)(j))), keys.Select(j => (VirtualKeyCode)((ushort)(j))));
        }

        public static void PressKeys(KeyCode modifier, IEnumerable<KeyCode> keys) {
            InputSimulator.SimulateModifiedKeyStroke((VirtualKeyCode)((ushort)(modifier)), keys.Select(j => (VirtualKeyCode)((ushort)(j))));
        }
    }

    public enum KeyCode : ushort {
        LBUTTON = (ushort)1,
        RBUTTON = (ushort)2,
        CANCEL = (ushort)3,
        MBUTTON = (ushort)4,
        XBUTTON1 = (ushort)5,
        XBUTTON2 = (ushort)6,
        BACK = (ushort)8,
        TAB = (ushort)9,
        CLEAR = (ushort)12,
        RETURN = (ushort)13,
        SHIFT = (ushort)16,
        CONTROL = (ushort)17,
        MENU = (ushort)18,
        PAUSE = (ushort)19,
        CAPITAL = (ushort)20,
        HANGEUL = (ushort)21,
        HANGUL = (ushort)21,
        KANA = (ushort)21,
        JUNJA = (ushort)23,
        FINAL = (ushort)24,
        HANJA = (ushort)25,
        KANJI = (ushort)25,
        ESCAPE = (ushort)27,
        CONVERT = (ushort)28,
        NONCONVERT = (ushort)29,
        ACCEPT = (ushort)30,
        MODECHANGE = (ushort)31,
        SPACE = (ushort)32,
        PRIOR = (ushort)33,
        NEXT = (ushort)34,
        END = (ushort)35,
        HOME = (ushort)36,
        LEFT = (ushort)37,
        UP = (ushort)38,
        RIGHT = (ushort)39,
        DOWN = (ushort)40,
        SELECT = (ushort)41,
        PRINT = (ushort)42,
        EXECUTE = (ushort)43,
        SNAPSHOT = (ushort)44,
        INSERT = (ushort)45,
        DELETE = (ushort)46,
        HELP = (ushort)47,
        VK_0 = (ushort)48,
        VK_1 = (ushort)49,
        VK_2 = (ushort)50,
        VK_3 = (ushort)51,
        VK_4 = (ushort)52,
        VK_5 = (ushort)53,
        VK_6 = (ushort)54,
        VK_7 = (ushort)55,
        VK_8 = (ushort)56,
        VK_9 = (ushort)57,
        VK_A = (ushort)65,
        VK_B = (ushort)66,
        VK_C = (ushort)67,
        VK_D = (ushort)68,
        VK_E = (ushort)69,
        VK_F = (ushort)70,
        VK_G = (ushort)71,
        VK_H = (ushort)72,
        VK_I = (ushort)73,
        VK_J = (ushort)74,
        VK_K = (ushort)75,
        VK_L = (ushort)76,
        VK_M = (ushort)77,
        VK_N = (ushort)78,
        VK_O = (ushort)79,
        VK_P = (ushort)80,
        VK_Q = (ushort)81,
        VK_R = (ushort)82,
        VK_S = (ushort)83,
        VK_T = (ushort)84,
        VK_U = (ushort)85,
        VK_V = (ushort)86,
        VK_W = (ushort)87,
        VK_X = (ushort)88,
        VK_Y = (ushort)89,
        VK_Z = (ushort)90,
        LWIN = (ushort)91,
        RWIN = (ushort)92,
        APPS = (ushort)93,
        SLEEP = (ushort)95,
        NUMPAD0 = (ushort)96,
        NUMPAD1 = (ushort)97,
        NUMPAD2 = (ushort)98,
        NUMPAD3 = (ushort)99,
        NUMPAD4 = (ushort)100,
        NUMPAD5 = (ushort)101,
        NUMPAD6 = (ushort)102,
        NUMPAD7 = (ushort)103,
        NUMPAD8 = (ushort)104,
        NUMPAD9 = (ushort)105,
        MULTIPLY = (ushort)106,
        ADD = (ushort)107,
        SEPARATOR = (ushort)108,
        SUBTRACT = (ushort)109,
        DECIMAL = (ushort)110,
        DIVIDE = (ushort)111,
        F1 = (ushort)112,
        F2 = (ushort)113,
        F3 = (ushort)114,
        F4 = (ushort)115,
        F5 = (ushort)116,
        F6 = (ushort)117,
        F7 = (ushort)118,
        F8 = (ushort)119,
        F9 = (ushort)120,
        F10 = (ushort)121,
        F11 = (ushort)122,
        F12 = (ushort)123,
        F13 = (ushort)124,
        F14 = (ushort)125,
        F15 = (ushort)126,
        F16 = (ushort)127,
        F17 = (ushort)128,
        F18 = (ushort)129,
        F19 = (ushort)130,
        F20 = (ushort)131,
        F21 = (ushort)132,
        F22 = (ushort)133,
        F23 = (ushort)134,
        F24 = (ushort)135,
        NUMLOCK = (ushort)144,
        SCROLL = (ushort)145,
        LSHIFT = (ushort)160,
        RSHIFT = (ushort)161,
        LCONTROL = (ushort)162,
        RCONTROL = (ushort)163,
        LMENU = (ushort)164,
        RMENU = (ushort)165,
        BROWSER_BACK = (ushort)166,
        BROWSER_FORWARD = (ushort)167,
        BROWSER_REFRESH = (ushort)168,
        BROWSER_STOP = (ushort)169,
        BROWSER_SEARCH = (ushort)170,
        BROWSER_FAVORITES = (ushort)171,
        BROWSER_HOME = (ushort)172,
        VOLUME_MUTE = (ushort)173,
        VOLUME_DOWN = (ushort)174,
        VOLUME_UP = (ushort)175,
        MEDIA_NEXT_TRACK = (ushort)176,
        MEDIA_PREV_TRACK = (ushort)177,
        MEDIA_STOP = (ushort)178,
        MEDIA_PLAY_PAUSE = (ushort)179,
        LAUNCH_MAIL = (ushort)180,
        LAUNCH_MEDIA_SELECT = (ushort)181,
        LAUNCH_APP1 = (ushort)182,
        LAUNCH_APP2 = (ushort)183,
        OEM_1 = (ushort)186,
        OEM_PLUS = (ushort)187,
        OEM_COMMA = (ushort)188,
        OEM_MINUS = (ushort)189,
        OEM_PERIOD = (ushort)190,
        OEM_2 = (ushort)191,
        OEM_3 = (ushort)192,
        OEM_4 = (ushort)219,
        OEM_5 = (ushort)220,
        OEM_6 = (ushort)221,
        OEM_7 = (ushort)222,
        OEM_8 = (ushort)223,
        OEM_102 = (ushort)226,
        PROCESSKEY = (ushort)229,
        PACKET = (ushort)231,
        ATTN = (ushort)246,
        CRSEL = (ushort)247,
        EXSEL = (ushort)248,
        EREOF = (ushort)249,
        PLAY = (ushort)250,
        ZOOM = (ushort)251,
        NONAME = (ushort)252,
        PA1 = (ushort)253,
        OEM_CLEAR = (ushort)254,
    }
}