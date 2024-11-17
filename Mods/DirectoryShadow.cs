using System.IO;
using StupidTemplate;
using System;
using UnityEngine;

namespace RK_Shadow.Mods
{
    internal class DirectoryShadow
    {
        public static void directories()
        {
            Directory.CreateDirectory("BepInEx/");
        }
    }
}

