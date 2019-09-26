﻿using UnityEngine;
using Verse;

namespace RimConnection
{
    public class RimConnection: Mod
    {
        Settings settings;


        public RimConnection(ModContentPack content) : base(content)
        {
            this.settings = GetSettings<Settings>();
            Log.Message("Hello World!");

            new ServerInitialise();
        }

        public override void DoSettingsWindowContents(Rect inRect)
        {
            Settings.DoSettingsWindowContents(inRect);
        }

        public override string SettingsCategory()
        {
            return "RimConnection";
        }
    }
}
