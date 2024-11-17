using Photon.Pun;
using StupidTemplate.Notifications;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace RK_Shadow.Mods
{
    internal class CrashSelf
    {
        public static void CrashSelftool()
        {
            
            PhotonNetwork.Disconnect();
            PhotonNetwork.Disconnect();
            PhotonNetwork.Disconnect();
            PhotonNetwork.Disconnect();
            PhotonNetwork.Disconnect();
            PhotonNetwork.Disconnect();
            PhotonNetwork.Disconnect();
            PhotonNetwork.Disconnect();
            PhotonNetwork.Disconnect();
            PhotonNetwork.Disconnect();
            NotifiLib.SendNotification("CrashHandler: Game crashed! UNABLE TO RECOVER!");
            Application.Quit();
        }
    }
}
