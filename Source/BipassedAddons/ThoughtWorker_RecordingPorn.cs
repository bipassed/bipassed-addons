using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verse;

namespace BipassedAddons
{
    public class ThoughtWorker_RecordingPorn : ThoughtWorker
    {
        private const float radius = 5f;

        protected override ThoughtState CurrentStateInternal(Pawn p)
        {
            if (!p.Spawned)
            {
                return false;
            }

            List<Thing> list = p.Map.listerThings.ThingsOfDef(VariousDefOf.BI_PornCamera);
            for (int i = 0; i < list.Count; i++)
            {
                Building_PornCamera building = list[i] as Building_PornCamera;
                if (building != null)
                {
                    CompPowerTrader compPowerTrader = list[i].TryGetComp<CompPowerTrader>();
                    if ((compPowerTrader == null || compPowerTrader.PowerOn) && p.Position.InHorDistOf(list[i].Position, radius))
                    {
                        if (p.health.hediffSet.GetFirstHediffOfDef(VariousDefOf.BI_RecordingHediff) == null)
                        {
                            if (building.pawnHediffSeverity.TryGetValue(p, out float severity))
                            {
                                //Log.Message("Pawn has a stored value! Yay!.");
                                p.health.AddHediff(VariousDefOf.BI_RecordingHediff);
                                p.health.hediffSet.GetFirstHediffOfDef(VariousDefOf.BI_RecordingHediff).Severity = severity + 0.25f;
                            }
                            else
                            {
                                //Log.Message("Pawn does NOT have stored value, setting to 1.");
                                p.health.AddHediff(VariousDefOf.BI_RecordingHediff);
                                building.pawnHediffSeverity[p] = 1f;
                                p.health.hediffSet.GetFirstHediffOfDef(VariousDefOf.BI_RecordingHediff).Severity = building.pawnHediffSeverity[p];
                            }
                        }
                        return true;
                    }
                    else if (!p.Position.InHorDistOf(list[i].Position, radius))
                    {
                        // Remove the pawn's Hediff and store the severity value before returning false
                        Hediff hediff = p?.health?.hediffSet?.GetFirstHediffOfDef(VariousDefOf.BI_RecordingHediff);
                        if (hediff != null)
                        {
                            //Log.Message("Storing the pawn's severity value.");
                            building.pawnHediffSeverity[p] = hediff.Severity;
                            p.health.RemoveHediff(hediff);
                        }
                        return false;
                    }
                }
            }
            return false;
        }
    }
}
