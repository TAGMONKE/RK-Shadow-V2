using System;
using UnityEngine;

namespace RK_Shadow.Mods
{
    internal class localPlayer
    {
        public static void InvisMonkeMod()
        {
            bool Invis = false;
            if (ControllerInputPoller.instance.rightControllerIndexFloat > 0.5)
            {
                if (Invis == true)
                {
                    Invis = false;
                }
                else if (Invis == false)
                {
                    Invis = true;
                }
            }
            if (Invis == true)
            {
                GorillaTagger.Instance.offlineVRRig.enabled = false;
                GorillaTagger.Instance.offlineVRRig.transform.position = new Vector3(99999f, 99999f, 99999f);
            }
            else
            {
                GorillaTagger.Instance.offlineVRRig.enabled = true;
                GorillaTagger.Instance.offlineVRRig.headBodyOffset.x = 0.0f;
            }
        }
    }
}
