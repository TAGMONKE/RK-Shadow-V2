using System;
using System.Collections.Generic;
using System.Text;
using StupidTemplate.Notifications;
using System.Linq;
using BepInEx;
using UnityEngine;
using UnityEngine.UI;
using static StupidTemplate.Settings;

namespace RK_Shadow.Mods
{
    internal class BanCheaters
    {
        public static void BanCheatersMod()
        {

            NotifiLib.ClearAllNotifications();

            NotifiLib.SendNotification("(Short delay) Reporting/Banning Cheaters");
        }
    }
}

