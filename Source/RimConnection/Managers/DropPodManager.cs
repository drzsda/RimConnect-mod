﻿using RimWorld;
using Verse;

namespace RimConnection
{
    class DropPodManager
    {
        public static void createDrop(ThingDef thingDef, int amount, string title, string desc)
        {
            Thing newthing = ThingMaker.MakeThing(thingDef);
            newthing.stackCount = amount;
            if(newthing != null)
            {
                string labelString = "RimConnectionDroppodMailLabel".Translate() ;
                string messageString = "RimConnectionPositiveDroppodMailBody".Translate(amount, title, desc);
                var currentMap = Find.CurrentMap;
                IntVec3 dropVector = DropCellFinder.TradeDropSpot(Find.CurrentMap);
                TradeUtility.SpawnDropPod(dropVector, currentMap, newthing);
                Find.LetterStack.ReceiveLetter(labelString, messageString, LetterDefOf.PositiveEvent, new TargetInfo(dropVector, currentMap));
            }
        }

    }
}
