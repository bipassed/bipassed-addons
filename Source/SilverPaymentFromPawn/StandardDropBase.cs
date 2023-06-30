using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verse;

namespace BipassedAddons
{
    public class StandardDropBase : HediffWithComps
    {
        public static float pawnWorth = 1;
        Thing dropThing = ThingMaker.MakeThing(VariousDefOf.Silver);
        public override void Tick()
        {
            Pawn pawn = this.pawn;
            if (pawn.IsHashIntervalTick(60000)) // Approximately one in-game day, 60000
            {
                if (pawn.IsColonist || pawn.IsPrisoner || pawn.IsSlave)
                {
                    pawnWorth = (float)(pawn.MarketValue * 0.1); // 10% of a pawn's worth, may change in future
                    dropThing.stackCount = (int)pawnWorth;
                    GenPlace.TryPlaceThing(dropThing, pawn.Position, pawn.Map, ThingPlaceMode.Near);

                }
            }
        }
    }
}
