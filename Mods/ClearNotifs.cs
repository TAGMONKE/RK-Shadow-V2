using StupidTemplate.Notifications;
using System;
using System.Collections.Generic;
using System.Text;

namespace RK_Shadow.Mods
{
    internal class ClearNotifs
    {
        public static void NotifFalse()
        {
            NotifiLib.ClearAllNotifications();
            NotifiLib.SendNotification("Cleared Notification Log");
        }
    }
}
