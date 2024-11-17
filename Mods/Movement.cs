using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace RK_Shadow.Mods
{
    internal class Movement
    {
        public static void PlatformsPatch()

        {

        }

        
         private static GameObject Rplat = GameObject.CreatePrimitive(PrimitiveType.Cube);
        private static GameObject Lplat = GameObject.CreatePrimitive(PrimitiveType.Cube);
        private static bool IsNotHoldingR;
        private static bool IsSpawnedR;
        private static bool IsNotHoldingL;
        private static bool IsSpawnedL;
        private static Vector3 lastLeftHandPosition;

        public static void PlatForms()
        {
            if (ControllerInputPoller.instance.rightGrab)
            {
                if (!IsNotHoldingR && !IsSpawnedR)
                {
                    Rplat.transform.position = GorillaLocomotion.Player.Instance.rightControllerTransform.transform.position;
                    IsSpawnedR = true;
                }
                IsNotHoldingR = false;

                Rplat.transform.localScale = new Vector3(0.3f, 0.02f, 0.3f);
                Rplat.AddComponent<BoxCollider>();
            }
            else if (!ControllerInputPoller.instance.rightGrab)
            {
                Rplat.transform.position = new Vector3(0, 100, 0);
                IsNotHoldingR = true;
                IsSpawnedR = false;
            }

            if (ControllerInputPoller.instance.leftGrab)
            {
                if (!IsNotHoldingL && !IsSpawnedL)
                {
                    Lplat.transform.position = GorillaLocomotion.Player.Instance.leftControllerTransform.transform.position;
                    IsSpawnedL = true;
                }
                IsNotHoldingL = false;

                Lplat.transform.localScale = new Vector3(0.3f, 0.02f, 0.3f);
                Lplat.AddComponent<BoxCollider>();

                lastLeftHandPosition = GorillaLocomotion.Player.Instance.leftControllerTransform.transform.position;
            }
            else if (!ControllerInputPoller.instance.leftGrab)
            {
                if (IsSpawnedL)
                {
                    Lplat.transform.position = lastLeftHandPosition;
                }
                IsNotHoldingL = true;
                IsSpawnedL = false;
                IsNotHoldingR = true;
                IsSpawnedR = false;
            }
        }
        public static void TriggerPlatForms()
        {
            if (ControllerInputPoller.instance.rightControllerIndexFloat > 0.1f)
            {
                if (!IsNotHoldingR && !IsSpawnedR)
                {
                    Rplat.transform.position = GorillaLocomotion.Player.Instance.rightControllerTransform.transform.position;
                    IsSpawnedR = true;
                }
                IsNotHoldingR = false;

                Rplat.transform.localScale = new Vector3(0.3f, 0.02f, 0.3f);
                Rplat.AddComponent<BoxCollider>();
            }
            else if (!(ControllerInputPoller.instance.leftControllerIndexFloat > 0.1f))
            {
                Rplat.transform.position = new Vector3(0, 100, 0);
                IsNotHoldingR = true;
                IsSpawnedR = false;
            }

            if (ControllerInputPoller.instance.leftControllerIndexFloat > 0.1f)
            {
                if (!IsNotHoldingL && !IsSpawnedL)
                {
                    Lplat.transform.position = GorillaLocomotion.Player.Instance.leftControllerTransform.transform.position;
                    IsSpawnedL = true;
                }
                IsNotHoldingL = false;

                Lplat.transform.localScale = new Vector3(0.3f, 0.02f, 0.3f);
                Lplat.AddComponent<BoxCollider>();

                lastLeftHandPosition = GorillaLocomotion.Player.Instance.leftControllerTransform.transform.position;
            }
            else if (!(ControllerInputPoller.instance.leftControllerIndexFloat > 0.1f))
            {
                if (IsSpawnedL)
                {
                    Lplat.transform.position = lastLeftHandPosition;
                }
                IsNotHoldingL = true;
                IsSpawnedL = false;
                IsNotHoldingR = true;
                IsSpawnedR = false;
            }
        }
    }
    
}
