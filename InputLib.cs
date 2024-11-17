using UnityEngine;
using UnityEngine.XR;

namespace tagmonkevr.on.discord
{
    internal class tagmonkevr
    {
        public static bool LeftGrip()
        {
            return ControllerInputPoller.instance.leftGrab;
        }

        public static bool RightGrip()
        {
            return ControllerInputPoller.instance.rightGrab;
        }

        public static bool LeftTrigger()
        {
            return ControllerInputPoller.TriggerFloat(XRNode.LeftHand) > 0.5f;
        }

        public static bool RightTrigger()
        {
            return ControllerInputPoller.TriggerFloat(XRNode.RightHand) > 0.5f;
        }

        public static bool LeftPrimary()
        {
            return ControllerInputPoller.instance.leftControllerPrimaryButton;
        }

        public static bool RightPrimary()
        {
            return ControllerInputPoller.instance.rightControllerPrimaryButton;
        }

        public static bool LeftSecondary()
        {
            return ControllerInputPoller.instance.leftControllerSecondaryButton;
        }

        public static bool RightSecondary()
        {
            return ControllerInputPoller.instance.rightControllerSecondaryButton;
        }

        public static Vector2 LeftJoystickAxis()
        {
            return ControllerInputPoller.instance.leftControllerPrimary2DAxis;
        }

        public static Vector2 RightJoystickAxis()
        {
            return ControllerInputPoller.instance.rightControllerPrimary2DAxis;
        }
    }
}
