﻿using RimWorld;
using Verse;

namespace RimConnection
{
    class GoldenShowerAction : Action
    {
        public GoldenShowerAction()
        {
            Name = "Golden Shower";
            Description = "Gold rains from the skies";
            Category = "Event";
            Prefix = "Trigger";
        }

        public override void Execute(int amount)
        {
            var amountOfDrops = 100;

            for(int i = 0; i < amountOfDrops; i ++ )
            {
                DropPodManager.createDropFromDef(ThingDefOf.Gold, amount, Name, Description, false);
            }

            AlertManager.NormalEventNotification("Your viewers have sent a Golden Shower!");
        }
    }
}
