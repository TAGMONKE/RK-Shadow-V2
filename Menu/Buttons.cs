using RK_Shadow.Mods;
using StupidTemplate.Classes;
using StupidTemplate.Mods;
using StupidTemplate.Notifications;
using static StupidTemplate.Settings;

namespace StupidTemplate.Menu
{
    internal class Buttons
    {
        public static ButtonInfo[][] buttons = new ButtonInfo[][]
        {
            new ButtonInfo[] { // Main Mods
                new ButtonInfo { buttonText = "Settings", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Opens the main settings page for the menu."},
                new ButtonInfo { buttonText = "stfu", method =() => ClearNotifs.NotifFalse(), toolTip = "SHUT UP!!! (0/100)", isTogglable = false},
                new ButtonInfo { buttonText = "BanSelf [DISABLED] [OP] [D!]", method =() => ModOFF.DisabledMod(), toolTip = "Bans you. D! (100/100)", isTogglable = false},
                new ButtonInfo { buttonText = "HandLockBeta", method =() => ModOFF.DisabledMod(), toolTip = "Bans you. D! (100/100)", isTogglable = true},
                new ButtonInfo { buttonText = "SliderToggle", method =() => ModOFF.DisabledMod(), toolTip = "Bans you. D! (100/100)", isTogglable = false},
                new ButtonInfo { buttonText = "Master RPCs", method =() => NotifiLib.ClearAllNotifications(), toolTip = "Makes you RPC Master", isTogglable = true},
                new ButtonInfo { buttonText = "Ban Cheaters [OP] [UND]", method =() => BanCheaters.BanCheatersMod(), toolTip = "Bans all (not you) cheaters within restart of game (cheaters end)", isTogglable = false},
                new ButtonInfo { buttonText = "SS Cosmetic X [OP] [UND]", method =() => ModOFF.DisabledMod(), toolTip = "ooooh fancy. D! (100/100)", isTogglable = true},
                new ButtonInfo { buttonText = "LAG ALL [UND]", method =() => ModOFF.DisabledMod(), toolTip = "LAG ALL. UND (0/100)", isTogglable = true},
                new ButtonInfo { buttonText = "fix files", method =() => filedir.dirmod(), toolTip = "creates directories (0/100)", isTogglable = true},
                new ButtonInfo { buttonText = "tp to og spawn", method =() => ModOFF.DisabledMod(), toolTip = "creates directories (0/100)", isTogglable = true},
                new ButtonInfo { buttonText = "Ban Evade", method =() => banevade.BanExadeMod(), toolTip = "UN-Bans you. D (49/100)", isTogglable = false},
                new ButtonInfo { buttonText = "togglable placeholder 6"},
            },

            new ButtonInfo[] { // Settings
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                new ButtonInfo { buttonText = "Menu", method =() => SettingsMods.MenuSettings(), isTogglable = false, toolTip = "Opens the settings for the menu."},
                new ButtonInfo { buttonText = "Movement", method =() => SettingsMods.MovementSettings(), isTogglable = false, toolTip = "Opens the movement settings for the menu."},
                new ButtonInfo { buttonText = "Projectile", method =() => SettingsMods.ProjectileSettings(), isTogglable = false, toolTip = "Opens the projectile settings for the menu."},
            },

            new ButtonInfo[] { // Menu Settings
                new ButtonInfo { buttonText = "Return to Settings", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Returns to the main settings page for the menu."},
                new ButtonInfo { buttonText = "Right Hand", enableMethod =() => SettingsMods.RightHand(), disableMethod =() => SettingsMods.LeftHand(), toolTip = "Puts the menu on your right hand."},
                new ButtonInfo { buttonText = "Mod Checker", enableMethod =() => SettingsMods.EnableNotifications(), disableMethod =() => SettingsMods.DisableNotifications(), enabled = !disableNotifications, toolTip = "Toggles the notifications."},
                new ButtonInfo { buttonText = "FPS Counter", enableMethod =() => SettingsMods.EnableFPSCounter(), disableMethod =() => SettingsMods.DisableFPSCounter(), enabled = fpsCounter, toolTip = "Toggles the FPS counter."},
                new ButtonInfo { buttonText = "Disconnect Button", enableMethod =() => SettingsMods.EnableDisconnectButton(), disableMethod =() => SettingsMods.DisableDisconnectButton(), enabled = disconnectButton, toolTip = "Toggles the disconnect button."},
            },
            

            new ButtonInfo[] { // Movement Settings
                new ButtonInfo { buttonText = "Return to Settings", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Returns to the main settings page for the menu."}
            },

            new ButtonInfo[] { // Projectile Settings
                new ButtonInfo { buttonText = "Return to Settings", method =() => SettingsMods.MenuSettings(), isTogglable = false, toolTip = "Opens the settings for the menu."},
            },
        };
    }
}
