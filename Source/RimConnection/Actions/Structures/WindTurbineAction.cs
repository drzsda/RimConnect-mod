﻿using RimWorld;

namespace RimConnection
{
    class WindTurbineAction : Action
    {
        public WindTurbineAction()
        {
            this.name = "Wind Turbine";
            this.description = "You spin me right round baby, right round, round round";
            this.category = "Structures";
        }

        public override void execute(int amount)
        {
            DropPodManager.createDropFromDef(ThingDefOf.WindTurbine, 1, name, description);
        }
    }
}
