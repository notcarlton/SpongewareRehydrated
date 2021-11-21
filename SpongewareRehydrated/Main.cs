using System;
using System.IO;
using UnityEngine;

namespace SpongewareRehydrated
{
    public class Main : MonoBehaviour
    {
        public AssetBundle SpongewareAssets;
        public GUISkin SpongewareSkin;

        private void Start()
        {
            SpongewareAssets =
                AssetBundle.LoadFromFile("c:\\spoung assets");
            SpongewareSkin = SpongewareAssets.LoadAsset<GUISkin>("spoung gui");
        }

        private void OnGUI()
        {
            GUI.Label(new Rect(0, 0, 10000, 500), "this should be in comic sans", SpongewareSkin.GetStyle("Label"));
        }
    }
}