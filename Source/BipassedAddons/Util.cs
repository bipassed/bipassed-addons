using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verse;

namespace BipassedAddons
{
    public class Util
    {
        public static void SpawnItem(ThingDef def, int stackCount, Pawn pawn)
        {
            Thing thing = ThingMaker.MakeThing(def);
            thing.stackCount = stackCount;
            GenPlace.TryPlaceThing(thing, pawn.Position, pawn.Map, ThingPlaceMode.Near);
        }
    }
}
