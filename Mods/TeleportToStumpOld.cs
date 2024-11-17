using UnityEngine;
using GorillaLocomotion;

namespace RK_Shadow.Mods
{
    public class TeleportUtils
    {
        public static void TeleportPlayer()
        {
            // Access the Player instance
            Player player = Player.Instance;
            if (player == null)
            {
                Debug.LogError("Player instance not found!");
                return;
            }

            // Teleport Body
            player.transform.position = new Vector3(-64.02674f, 12.04384f, -83.02224f);
            player.transform.rotation = new Quaternion(0f, 0.6704524f, -6.249934E-10f, -0.7419525f);

            // Attempt to find Head Transform
            Transform headTransform = player.transform.Find("Head");
            if (headTransform != null)
            {
                headTransform.position = new Vector3(-64.09381f, 12.35247f, -83.01543f);
                headTransform.rotation = new Quaternion(-0.04405238f, 0.6692692f, -0.03974193f, -0.7406474f);
            }
            else
            {
                Debug.LogWarning("Head transform not found!");
            }

            // Attempt to find Left Hand Transform
            Transform leftHandTransform = player.transform.Find("LeftHand");
            if (leftHandTransform != null)
            {
                leftHandTransform.position = new Vector3(99998.99f, 99998.58f, 99999.07f);
                leftHandTransform.rotation = new Quaternion(0.003798485f, -0.5898114f, -0.4506791f, 0.670072f);
            }
            else
            {
                Debug.LogWarning("Left hand transform not found!");
            }

            // Attempt to find Right Hand Transform
            Transform rightHandTransform = player.transform.Find("RightHand");
            if (rightHandTransform != null)
            {
                rightHandTransform.position = new Vector3(99999.05f, 99998.58f, 99999.05f);
                rightHandTransform.rotation = new Quaternion(0.1468907f, 0.7722497f, 0.426086f, 0.4477772f);
            }
            else
            {
                Debug.LogWarning("Right hand transform not found!");
            }
        }
    }
}