using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verse;
using RimWorld;

namespace BipassedAddons
{
    public class Building_PornCamera : Building
    {
        public Dictionary<Pawn, float> pawnHediffSeverity = new Dictionary<Pawn, float>();
    }
}
