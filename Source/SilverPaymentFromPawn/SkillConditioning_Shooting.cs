using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verse;

namespace BipassedAddons
{
    class SkillConditioning_Shooting : StandardDropBase
    {
        public override void Tick()
        {
            Pawn pawn = this.pawn;
            if (pawn.IsHashIntervalTick(60000)) // Approximately one in-game day, 60000
            {
                if (pawn.IsColonist || pawn.IsPrisoner || pawn.IsSlave)
                {
                    // Raise shooting skill by X amount per day
                    // For shooting specifically, add a 0.01% chance for a pawn to die
                }
            }
        }
    }
}
