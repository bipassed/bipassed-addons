using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RimWorld;
using Verse;

namespace BipassedAddons
{
    public class Building_VirtualRealityBed : Building_Bed
    {
        public override void Tick()
        {
            base.Tick();
            // Check if bed has any occupants, then if so increase needs every three hours
            if (AnyOccupants && HasPowerConnection(this))
            {
                //Log.Message("Pawn is in bed");
                Pawn pawn = GetCurOccupant(0);
                if (pawn.IsHashIntervalTick(5000)) // Two hours 5000
                {
                    //Log.Message("Providing pawn with needs");
                    if (pawn.needs?.rest != null)
                        pawn.needs.rest.CurLevel += 100;
                    if (pawn.needs?.food != null)
                        pawn.needs.food.CurLevel += 100;
                }
            }
            else
                return;
        }
        public bool HasPowerConnection(Building building)
        {
            CompPowerTrader powerComp = building.TryGetComp<CompPowerTrader>(); // Check if the building has a power trader component
            if (powerComp != null && powerComp.PowerNet != null)
                return true;
            return false;
        }
    }
}
