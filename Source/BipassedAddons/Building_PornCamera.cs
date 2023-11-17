using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RimWorld;
using rjw;
using Verse;

namespace BipassedAddons
{
    public class Building_PornCamera : Building
    {
        private static bool sexperience = ModsConfig.IsActive("rjw.sexperience");
        private const float radius = 6f;
        private static Random random = new Random();
        private int ticksPassed = 0;
        private int ticksToSpawnPorn = 1000;

        public override void Tick()
        {
            base.Tick();
            ticksPassed++;
            if (ticksPassed >= ticksToSpawnPorn)
            {
                ticksPassed = 0;
                Map map = Find.CurrentMap;
                if (Find.World != null && map != null)
                {
                    foreach (var pawn in map.mapPawns.AllPawns)
                    {
                        if (pawn.Position.DistanceTo(Position) <= radius)
                        {
                            if (pawn.IsAnimal())
                                return;
                            if (pawn.skills == null)
                                return;
                            if (pawn.jobs == null)
                                return;
                            var currentJob = pawn.jobs.curJob.def;
                            var skillLevel = pawn.skills.GetSkill(VariousDefOf.Social).Level;
                            if (sexperience)
                                skillLevel = pawn.skills.GetSkill(VariousDefOf.Sex).Level;
                            if (currentJob == VariousDefOf.JoinInBed || currentJob == VariousDefOf.GettinLoved || currentJob == VariousDefOf.GettinLicked || currentJob == VariousDefOf.GettinSucked || currentJob == VariousDefOf.Quickie || currentJob == VariousDefOf.GettingQuickie)
                                SpawnPorn(skillLevel, "n");
                            else if (currentJob == VariousDefOf.RJW_Masturbate)
                                SpawnPorn(skillLevel, "m");
                            else if (currentJob == VariousDefOf.Bestiality || currentJob == VariousDefOf.BestialityForFemale || currentJob == VariousDefOf.RJW_Mate || currentJob == VariousDefOf.Breed || currentJob == VariousDefOf.GettinBred)
                                SpawnPorn(skillLevel, "b");
                            else if (currentJob == VariousDefOf.GettinRaped || currentJob == VariousDefOf.RapeComfortPawn || currentJob == VariousDefOf.RandomRape)
                            {
                                if (pawn.jobs.curJob.targetA != null)
                                {
                                    Pawn target = (Pawn)pawn.jobs.curJob.targetA;
                                    if (target.IsAnimal())
                                        SpawnPorn(skillLevel, "br");
                                    else
                                        SpawnPorn(skillLevel, "r");
                                }
                            }
                            else if (currentJob == VariousDefOf.ViolateCorpse)
                            {
                                if (pawn.jobs.curJob.targetA != null)
                                {
                                    Corpse target = (Corpse)pawn.jobs.curJob.targetA;
                                    if (target.InnerPawn.IsAnimal())
                                        SpawnPorn(skillLevel, "neb");
                                    else
                                        SpawnPorn(skillLevel, "ne");
                                }
                            }
                        }
                    }
                }
            }
        }

        private void SpawnPorn(int skillLevel, string porn)
        {
            Thing thing = null;
            var r = random.Next(0, skillLevel + 1);
            if (porn == "n")
            {
                if (r <= 4)
                {
                    thing = ThingMaker.MakeThing(VariousDefOf.BI_NormalPornAwful);
                }
                else if (r <= 6)
                {
                    thing = ThingMaker.MakeThing(VariousDefOf.BI_NormalPornPoor);
                }
                else if (r <= 10)
                {
                    thing = ThingMaker.MakeThing(VariousDefOf.BI_NormalPornNormal);
                }
                else if (r <= 14)
                {
                    thing = ThingMaker.MakeThing(VariousDefOf.BI_NormalPornGood);
                }
                else if (r <= 16)
                {
                    thing = ThingMaker.MakeThing(VariousDefOf.BI_NormalPornExcellent);
                }
                else if (r <= 19)
                {
                    thing = ThingMaker.MakeThing(VariousDefOf.BI_NormalPornMasterwork);
                }
                else if (r <= 20)
                {
                    thing = ThingMaker.MakeThing(VariousDefOf.BI_NormalPornLegendary);
                }
            }
            else if (porn == "m")
            {
                if (r <= 4)
                {
                    thing = ThingMaker.MakeThing(VariousDefOf.BI_MasturbationPornAwful);
                }
                else if (r <= 6)
                {
                    thing = ThingMaker.MakeThing(VariousDefOf.BI_MasturbationPornPoor);
                }
                else if (r <= 10)
                {
                    thing = ThingMaker.MakeThing(VariousDefOf.BI_MasturbationPornNormal);
                }
                else if (r <= 14)
                {
                    thing = ThingMaker.MakeThing(VariousDefOf.BI_MasturbationPornGood);
                }
                else if (r <= 16)
                {
                    thing = ThingMaker.MakeThing(VariousDefOf.BI_MasturbationPornExcellent);
                }
                else if (r <= 19)
                {
                    thing = ThingMaker.MakeThing(VariousDefOf.BI_MasturbationPornMasterwork);
                }
                else if (r <= 20)
                {
                    thing = ThingMaker.MakeThing(VariousDefOf.BI_MasturbationPornLegendary);
                }
            }
            else if (porn == "b")
            {
                if (r <= 4)
                {
                    thing = ThingMaker.MakeThing(VariousDefOf.BI_BestialityPornAwful);
                }
                else if (r <= 6)
                {
                    thing = ThingMaker.MakeThing(VariousDefOf.BI_BestialityPornPoor);
                }
                else if (r <= 10)
                {
                    thing = ThingMaker.MakeThing(VariousDefOf.BI_BestialityPornNormal);
                }
                else if (r <= 14)
                {
                    thing = ThingMaker.MakeThing(VariousDefOf.BI_BestialityPornGood);
                }
                else if (r <= 16)
                {
                    thing = ThingMaker.MakeThing(VariousDefOf.BI_BestialityPornExcellent);
                }
                else if (r <= 19)
                {
                    thing = ThingMaker.MakeThing(VariousDefOf.BI_BestialityPornMasterwork);
                }
                else if (r <= 20)
                {
                    thing = ThingMaker.MakeThing(VariousDefOf.BI_BestialityPornLegendary);
                }
            }
            else if (porn == "r")
            {
                if (r <= 4)
                {
                    thing = ThingMaker.MakeThing(VariousDefOf.BI_RapePornAwful);
                }
                else if (r <= 6)
                {
                    thing = ThingMaker.MakeThing(VariousDefOf.BI_RapePornPoor);
                }
                else if (r <= 10)
                {
                    thing = ThingMaker.MakeThing(VariousDefOf.BI_RapePornNormal);
                }
                else if (r <= 14)
                {
                    thing = ThingMaker.MakeThing(VariousDefOf.BI_RapePornGood);
                }
                else if (r <= 16)
                {
                    thing = ThingMaker.MakeThing(VariousDefOf.BI_RapePornExcellent);
                }
                else if (r <= 19)
                {
                    thing = ThingMaker.MakeThing(VariousDefOf.BI_RapePornMasterwork);
                }
                else if (r <= 20)
                {
                    thing = ThingMaker.MakeThing(VariousDefOf.BI_RapePornLegendary);
                }
            }
            else if (porn == "br")
            {
                if (r <= 4)
                {
                    thing = ThingMaker.MakeThing(VariousDefOf.BI_BestialityRapePornAwful);
                }
                else if (r <= 6)
                {
                    thing = ThingMaker.MakeThing(VariousDefOf.BI_BestialityRapePornPoor);
                }
                else if (r <= 10)
                {
                    thing = ThingMaker.MakeThing(VariousDefOf.BI_BestialityRapePornNormal);
                }
                else if (r <= 14)
                {
                    thing = ThingMaker.MakeThing(VariousDefOf.BI_BestialityRapePornGood);
                }
                else if (r <= 16)
                {
                    thing = ThingMaker.MakeThing(VariousDefOf.BI_BestialityRapePornExcellent);
                }
                else if (r <= 19)
                {
                    thing = ThingMaker.MakeThing(VariousDefOf.BI_BestialityRapePornMasterwork);
                }
                else if (r <= 20)
                {
                    thing = ThingMaker.MakeThing(VariousDefOf.BI_BestialityRapePornLegendary);
                }
            }
            else if (porn == "ne")
            {
                if (r <= 4)
                {
                    thing = ThingMaker.MakeThing(VariousDefOf.BI_NecroPornAwful);
                }
                else if (r <= 6)
                {
                    thing = ThingMaker.MakeThing(VariousDefOf.BI_NecroPornPoor);
                }
                else if (r <= 10)
                {
                    thing = ThingMaker.MakeThing(VariousDefOf.BI_NecroPornNormal);
                }
                else if (r <= 14)
                {
                    thing = ThingMaker.MakeThing(VariousDefOf.BI_NecroPornGood);
                }
                else if (r <= 16)
                {
                    thing = ThingMaker.MakeThing(VariousDefOf.BI_NecroPornExcellent);
                }
                else if (r <= 19)
                {
                    thing = ThingMaker.MakeThing(VariousDefOf.BI_NecroPornMasterwork);
                }
                else if (r <= 20)
                {
                    thing = ThingMaker.MakeThing(VariousDefOf.BI_NecroPornLegendary);
                }
            }
            else if (porn == "neb")
            {
                if (r <= 4)
                {
                    thing = ThingMaker.MakeThing(VariousDefOf.BI_NecroBestialityPornAwful);
                }
                else if (r <= 6)
                {
                    thing = ThingMaker.MakeThing(VariousDefOf.BI_NecroBestialityPornPoor);
                }
                else if (r <= 10)
                {
                    thing = ThingMaker.MakeThing(VariousDefOf.BI_NecroBestialityPornNormal);
                }
                else if (r <= 14)
                {
                    thing = ThingMaker.MakeThing(VariousDefOf.BI_NecroBestialityPornGood);
                }
                else if (r <= 16)
                {
                    thing = ThingMaker.MakeThing(VariousDefOf.BI_NecroBestialityPornExcellent);
                }
                else if (r <= 19)
                {
                    thing = ThingMaker.MakeThing(VariousDefOf.BI_NecroBestialityPornMasterwork);
                }
                else if (r <= 20)
                {
                    thing = ThingMaker.MakeThing(VariousDefOf.BI_NecroBestialityPornLegendary);
                }
            }
            GenSpawn.Spawn(thing, Position, Find.CurrentMap);
        }
    }
}
