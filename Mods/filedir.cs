using System.IO;

namespace RK_Shadow.Mods
{
    internal class filedir
    {
        public static void dirmod()
        {
            Directory.CreateDirectory("RKShadow");
            Directory.CreateDirectory("RKShadow/Settings");
        }
    }
}
