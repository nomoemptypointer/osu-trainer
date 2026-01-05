using System;
using System.Windows.Forms;

namespace osu_trainer
{
    public static class Settings
    {
        // Folder path
        public static string SongsFolder = string.Empty;

        // Boolean flags
        public static bool NoSpinners = false;
        public static bool ChangePitch = false;
        public static bool HighARODMessageShown = false;
        public static bool DoNotCheckForUpdates = false;
        public static bool HPLockedState = false;
        public static bool CSLockedState = false;
        public static bool ARLockedState = false;
        public static bool ODLockedState = false;
        public static bool BpmLockedState = false;
        public static bool HighQualityMp3s = false;

        // Decimal settings
        public static decimal LockedHPSetting = 4m;
        public static decimal LockedCSSetting = 4m;
        public static decimal LockedARSetting = 9m;
        public static decimal LockedODSetting = 8m;
        public static decimal BpmRate = 1m;

        // Integer settings
        public static int LockedBpmSetting = 200;

        // Hotkeys
        public static Keys HotkeyCreateMap = Keys.X;
        public static Keys HotkeyProfile1 = Keys.A;
        public static Keys HotkeyProfile2 = Keys.S;
        public static Keys HotkeyProfile3 = Keys.D;
        public static Keys HotkeyProfile4 = Keys.F;
    }
}
