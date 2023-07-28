using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verse;
using RimWorld;
using rjw;

namespace BipassedAddons
{
    // Masturbation = 5s
    // Normal sex = 20s
    // Bestiality = 50s
    // Rape = 100s
    // Necro = 150s
    public class HediffComp_Recording : HediffWithComps
    {
        public ThingDef thingDef;
        public static bool Sexperience = ModsConfig.IsActive("rjw.sexperience");
        public override void Tick()
        {
            Pawn pawn = this.pawn;
            if (pawn.health.hediffSet.GetFirstHediffOfDef(VariousDefOf.BI_RecordingHediff).Severity >= 1f)
            {
                Random random = new Random();
                // Normal sex
                if (pawn.jobs.curJob.def == VariousDefOf.JoinInBed || pawn.jobs.curJob.def == VariousDefOf.GettinLoved || pawn.jobs.curJob.def == VariousDefOf.GettinLicked || pawn.jobs.curJob.def == VariousDefOf.GettinSucked || pawn.jobs.curJob.def == VariousDefOf.Quickie || pawn.jobs.curJob.def == VariousDefOf.GettingQuickie)
                {
                    pawn.health.hediffSet.GetFirstHediffOfDef(VariousDefOf.BI_RecordingHediff).Severity = 0.01f;
                    if (Sexperience)
                    {
                        int skillLevel = pawn.skills.GetSkill(VariousDefOf.Sex).Level;
                        if (skillLevel <= 2) // Awful 0-2
                        {
                            thingDef = VariousDefOf.BI_NormalPornAwful;
                            Util.SpawnItem(thingDef, 1, pawn);
                        }
                        else if (skillLevel <= 5 && skillLevel >= 3) // Poor 3-5
                        {
                            thingDef = VariousDefOf.BI_NormalPornPoor;
                            Util.SpawnItem(thingDef, 1, pawn);
                        }
                        else if (skillLevel <= 8 && skillLevel >= 6) // Normal 6-8
                        {
                            thingDef = VariousDefOf.BI_NormalPornNormal;
                            Util.SpawnItem(thingDef, 1, pawn);
                        }
                        else if (skillLevel <= 12 && skillLevel >= 9) // Good 9-12
                        {
                            thingDef = VariousDefOf.BI_NormalPornGood;
                            Util.SpawnItem(thingDef, 1, pawn);
                        }
                        else if (skillLevel <= 16 && skillLevel >= 13) // Excellent 13-16
                        {
                            thingDef = VariousDefOf.BI_NormalPornExcellent;
                            Util.SpawnItem(thingDef, 1, pawn);
                        }
                        else if (skillLevel <= 20 && skillLevel >= 17) // Masterwork 17-20
                        {
                            thingDef = VariousDefOf.BI_NormalPornMasterwork;
                            Util.SpawnItem(thingDef, 1, pawn);
                            //5% chance for Legendary
                            if (random.Next(100) > 5) { }
                            {
                                thingDef = VariousDefOf.BI_NormalPornLegendary;
                                Util.SpawnItem(thingDef, 1, pawn);
                            }
                        }
                    }
                    else
                    {
                        int skillLevel = pawn.skills.GetSkill(VariousDefOf.Social).Level;
                        if (skillLevel <= 2) // Awful 0-2
                            {
                            thingDef = VariousDefOf.BI_NormalPornAwful;
                            Util.SpawnItem(thingDef, 1, pawn);
                            }
                        else if (skillLevel <= 5 && skillLevel >= 3) // Poor 3-5
                            {
                            thingDef = VariousDefOf.BI_NormalPornPoor;
                            Util.SpawnItem(thingDef, 1, pawn);
                        }
                        else if (skillLevel <= 8 && skillLevel >= 6) // Normal 6-8
                            {
                            thingDef = VariousDefOf.BI_NormalPornNormal;
                            Util.SpawnItem(thingDef, 1, pawn);
                        }
                        else if (skillLevel <= 12 && skillLevel >= 9) // Good 9-12
                            {
                            thingDef = VariousDefOf.BI_NormalPornGood;
                            Util.SpawnItem(thingDef, 1, pawn);
                        }
                        else if (skillLevel <= 16 && skillLevel >= 13) // Excellent 13-16
                            {
                            thingDef = VariousDefOf.BI_NormalPornExcellent;
                            Util.SpawnItem(thingDef, 1, pawn);
                        }
                        else if (skillLevel <= 20 && skillLevel >= 17) // Masterwork 17-20
                        {
                            thingDef = VariousDefOf.BI_NormalPornMasterwork;
                            Util.SpawnItem(thingDef, 1, pawn);
                            //5% chance for Legendary
                            if (random.Next(100) > 5)
                                {
                                thingDef = VariousDefOf.BI_NormalPornLegendary;
                                Util.SpawnItem(thingDef, 1, pawn);
                            }
                        }
                    }
                }
                // Masturbation
                if (pawn.jobs.curJob.def == VariousDefOf.RJW_Masturbate)
                {
                    pawn.health.hediffSet.GetFirstHediffOfDef(VariousDefOf.BI_RecordingHediff).Severity = 0.01f;
                    if (Sexperience)
                    {
                        int skillLevel = pawn.skills.GetSkill(VariousDefOf.Sex).Level;
                        if (skillLevel <= 2) // Awful 0-2
                            {
                            thingDef = VariousDefOf.BI_MasturbationPornAwful;
                            Util.SpawnItem(thingDef, 1, pawn);
                        }
                        else if (skillLevel <= 5 && skillLevel >= 3) // Poor 3-5
                            {
                            thingDef = VariousDefOf.BI_MasturbationPornPoor;
                            Util.SpawnItem(thingDef, 1, pawn);
                        }
                        else if (skillLevel <= 8 && skillLevel >= 6) // Normal 6-8
                            {
                            thingDef = VariousDefOf.BI_MasturbationPornNormal;
                            Util.SpawnItem(thingDef, 1, pawn);
                        }
                        else if (skillLevel <= 12 && skillLevel >= 9) // Good 9-12
                            {
                            thingDef = VariousDefOf.BI_MasturbationPornGood;
                            Util.SpawnItem(thingDef, 1, pawn);
                        }
                        else if (skillLevel <= 16 && skillLevel >= 13) // Excellent 13-16
                            {
                            thingDef = VariousDefOf.BI_MasturbationPornExcellent;
                            Util.SpawnItem(thingDef, 1, pawn);
                        }
                        else if (skillLevel <= 20 && skillLevel >= 17) // Masterwork 17-20
                        {
                            thingDef = VariousDefOf.BI_MasturbationPornMasterwork;
                            Util.SpawnItem(thingDef, 1, pawn);
                            //5% chance for Legendary
                            if (random.Next(100) > 5)
                                {
                                thingDef = VariousDefOf.BI_MasturbationPornLegendary;
                                Util.SpawnItem(thingDef, 1, pawn);
                            }
                        }
                    }
                    else
                    {
                        int skillLevel = pawn.skills.GetSkill(VariousDefOf.Social).Level;
                        if (skillLevel <= 2) // Awful 0-2
                        {
                            thingDef = VariousDefOf.BI_MasturbationPornAwful;
                            Util.SpawnItem(thingDef, 1, pawn);
                        }
                        else if (skillLevel <= 5 && skillLevel >= 3) // Poor 3-5
                        {
                            thingDef = VariousDefOf.BI_MasturbationPornPoor;
                            Util.SpawnItem(thingDef, 1, pawn);
                        }
                        else if (skillLevel <= 8 && skillLevel >= 6) // Normal 6-8
                        {
                            thingDef = VariousDefOf.BI_MasturbationPornNormal;
                            Util.SpawnItem(thingDef, 1, pawn);
                        }
                        else if (skillLevel <= 12 && skillLevel >= 9) // Good 9-12
                        {
                            thingDef = VariousDefOf.BI_MasturbationPornGood;
                            Util.SpawnItem(thingDef, 1, pawn);
                        }
                        else if (skillLevel <= 16 && skillLevel >= 13) // Excellent 13-16
                        {
                            thingDef = VariousDefOf.BI_MasturbationPornExcellent;
                            Util.SpawnItem(thingDef, 1, pawn);
                        }
                        else if (skillLevel <= 20 && skillLevel >= 17) // Masterwork 17-20
                        {
                            thingDef = VariousDefOf.BI_MasturbationPornMasterwork;
                            Util.SpawnItem(thingDef, 1, pawn);
                            //5% chance for Legendary
                            if (random.Next(100) > 5)
                                {
                                thingDef = VariousDefOf.BI_MasturbationPornLegendary;
                                Util.SpawnItem(thingDef, 1, pawn);
                            }
                        }
                    }
                }
                // Bestiality
                if (pawn.jobs.curJob.def == VariousDefOf.GettinBred || pawn.jobs.curJob.def == VariousDefOf.Breed || pawn.jobs.curJob.def == VariousDefOf.RJW_Mate || pawn.jobs.curJob.def == VariousDefOf.Bestiality || pawn.jobs.curJob.def == VariousDefOf.BestialityForFemale)
                {
                    pawn.health.hediffSet.GetFirstHediffOfDef(VariousDefOf.BI_RecordingHediff).Severity = 0.01f;
                    if (Sexperience)
                    {
                        int skillLevel = pawn.skills.GetSkill(VariousDefOf.Sex).Level;
                        if (skillLevel <= 2) // Awful 0-2
                        {
                            thingDef = VariousDefOf.BI_BestialityPornAwful;
                            Util.SpawnItem(thingDef, 1, pawn);
                        }
                        else if (skillLevel <= 5 && skillLevel >= 3) // Poor 3-5
                        {
                            thingDef = VariousDefOf.BI_BestialityPornPoor;
                            Util.SpawnItem(thingDef, 1, pawn);
                        }
                        else if (skillLevel <= 8 && skillLevel >= 6) // Normal 6-8
                        {
                            thingDef = VariousDefOf.BI_BestialityPornNormal;
                            Util.SpawnItem(thingDef, 1, pawn);
                        }
                        else if (skillLevel <= 12 && skillLevel >= 9) // Good 9-12
                        {
                            thingDef = VariousDefOf.BI_BestialityPornGood;
                            Util.SpawnItem(thingDef, 1, pawn);
                        }
                        else if (skillLevel <= 16 && skillLevel >= 13) // Excellent 13-16
                        {
                            thingDef = VariousDefOf.BI_BestialityPornExcellent;
                            Util.SpawnItem(thingDef, 1, pawn);
                        }
                        else if (skillLevel <= 20 && skillLevel >= 17) // Masterwork 17-20
                        {
                            thingDef = VariousDefOf.BI_BestialityPornMasterwork;
                            Util.SpawnItem(thingDef, 1, pawn);
                            //5% chance for Legendary
                            if (random.Next(100) > 5)
                            {
                                thingDef = VariousDefOf.BI_BestialityPornLegendary;
                                Util.SpawnItem(thingDef, 1, pawn);
                            }
                        }
                    }
                    else
                    {
                        int skillLevel = pawn.skills.GetSkill(VariousDefOf.Social).Level;
                        if (skillLevel <= 2) // Awful 0-2
                            {
                            thingDef = VariousDefOf.BI_BestialityPornAwful;
                            Util.SpawnItem(thingDef, 1, pawn);
                        }
                        else if (skillLevel <= 5 && skillLevel >= 3) // Poor 3-5
                            {
                            thingDef = VariousDefOf.BI_BestialityPornPoor;
                            Util.SpawnItem(thingDef, 1, pawn);
                        }
                        else if (skillLevel <= 8 && skillLevel >= 6) // Normal 6-8
                            {
                            thingDef = VariousDefOf.BI_BestialityPornNormal;
                            Util.SpawnItem(thingDef, 1, pawn);
                        }
                        else if (skillLevel <= 12 && skillLevel >= 9) // Good 9-12
                            {
                            thingDef = VariousDefOf.BI_BestialityPornGood;
                            Util.SpawnItem(thingDef, 1, pawn);
                        }
                        else if (skillLevel <= 16 && skillLevel >= 13) // Excellent 13-16
                            {
                            thingDef = VariousDefOf.BI_BestialityPornExcellent;
                            Util.SpawnItem(thingDef, 1, pawn);
                        }
                        else if (skillLevel <= 20 && skillLevel >= 17) // Masterwork 17-20
                        {
                            thingDef = VariousDefOf.BI_BestialityPornMasterwork;
                            Util.SpawnItem(thingDef, 1, pawn);
                            //5% chance for Legendary
                            if (random.Next(100) > 5)
                                {
                                thingDef = VariousDefOf.BI_BestialityPornLegendary;
                                Util.SpawnItem(thingDef, 1, pawn);
                            }
                        }
                    }
                }
                // Rape
                if (pawn.jobs.curJob.def == VariousDefOf.GettinRaped || pawn.jobs.curJob.def == VariousDefOf.RapeComfortPawn || pawn.jobs.curJob.def == VariousDefOf.RandomRape)
                {
                    pawn.health.hediffSet.GetFirstHediffOfDef(VariousDefOf.BI_RecordingHediff).Severity = 0.01f;
                    Pawn target = (Pawn)pawn.jobs.curJob.targetA;
                    if (Sexperience)
                    {
                        int skillLevel = pawn.skills.GetSkill(VariousDefOf.Sex).Level;
                        if (target.IsAnimal()) // Bestiality + Rape
                        {
                            if (skillLevel <= 2) // Awful 0-2
                            {
                                thingDef = VariousDefOf.BI_BestialityRapePornAwful;
                                Util.SpawnItem(thingDef, 1, pawn);
                            }
                            else if (skillLevel <= 5 && skillLevel >= 3) // Poor 3-5
                            {
                                thingDef = VariousDefOf.BI_BestialityRapePornPoor;
                                Util.SpawnItem(thingDef, 1, pawn);
                            }
                            else if (skillLevel <= 8 && skillLevel >= 6) // Normal 6-8
                            {
                                thingDef = VariousDefOf.BI_BestialityRapePornNormal;
                                Util.SpawnItem(thingDef, 1, pawn);
                            }
                            else if (skillLevel <= 12 && skillLevel >= 9) // Good 9-12
                            {
                                thingDef = VariousDefOf.BI_BestialityRapePornGood;
                                Util.SpawnItem(thingDef, 1, pawn);
                            }
                            else if (skillLevel <= 16 && skillLevel >= 13) // Excellent 13-16
                            {
                                thingDef = VariousDefOf.BI_BestialityRapePornExcellent;
                                Util.SpawnItem(thingDef, 1, pawn);
                            }
                            else if (skillLevel <= 20 && skillLevel >= 17) // Masterwork 17-20
                            {
                                thingDef = VariousDefOf.BI_BestialityRapePornMasterwork;
                                Util.SpawnItem(thingDef, 1, pawn);
                                //5% chance for Legendary
                                if (random.Next(100) > 5)
                                {
                                    thingDef = VariousDefOf.BI_BestialityRapePornLegendary;
                                    Util.SpawnItem(thingDef, 1, pawn);
                                }
                            }
                        }
                        else // Just rape
                        {
                            if (skillLevel <= 2) // Awful 0-2
                            {
                                thingDef = VariousDefOf.BI_RapePornAwful;
                                Util.SpawnItem(thingDef, 1, pawn);
                            }
                            else if (skillLevel <= 5 && skillLevel >= 3) // Poor 3-5
                            {
                                thingDef = VariousDefOf.BI_RapePornPoor;
                                Util.SpawnItem(thingDef, 1, pawn);
                            }
                            else if (skillLevel <= 8 && skillLevel >= 6) // Normal 6-8
                            {
                                thingDef = VariousDefOf.BI_RapePornNormal;
                                Util.SpawnItem(thingDef, 1, pawn);
                            }
                            else if (skillLevel <= 12 && skillLevel >= 9) // Good 9-12
                            {
                                thingDef = VariousDefOf.BI_RapePornGood;
                                Util.SpawnItem(thingDef, 1, pawn);
                            }
                            else if (skillLevel <= 16 && skillLevel >= 13) // Excellent 13-16
                            {
                                thingDef = VariousDefOf.BI_RapePornExcellent;
                                Util.SpawnItem(thingDef, 1, pawn);
                            }
                            else if (skillLevel <= 20 && skillLevel >= 17) // Masterwork 17-20
                            {
                                thingDef = VariousDefOf.BI_RapePornMasterwork;
                                Util.SpawnItem(thingDef, 1, pawn);
                                //5% chance for Legendary
                                if (random.Next(100) > 5)
                                {
                                    thingDef = VariousDefOf.BI_RapePornLegendary;
                                    Util.SpawnItem(thingDef, 1, pawn);
                                }
                            }
                        }
                    }
                    else
                    {
                        int skillLevel = pawn.skills.GetSkill(VariousDefOf.Social).Level;
                        if (target.IsAnimal()) // BeastRape
                        {
                            if (skillLevel <= 2) // Awful 0-2
                            {
                                thingDef = VariousDefOf.BI_BestialityRapePornAwful;
                                Util.SpawnItem(thingDef, 1, pawn);
                            }
                            else if (skillLevel <= 5 && skillLevel >= 3) // Poor 3-5
                            {
                                thingDef = VariousDefOf.BI_BestialityRapePornPoor;
                                Util.SpawnItem(thingDef, 1, pawn);
                            }
                            else if (skillLevel <= 8 && skillLevel >= 6) // Normal 6-8
                            {
                                thingDef = VariousDefOf.BI_BestialityRapePornNormal;
                                Util.SpawnItem(thingDef, 1, pawn);
                            }
                            else if (skillLevel <= 12 && skillLevel >= 9) // Good 9-12
                            {
                                thingDef = VariousDefOf.BI_BestialityRapePornGood;
                                Util.SpawnItem(thingDef, 1, pawn);
                            }
                            else if (skillLevel <= 16 && skillLevel >= 13) // Excellent 13-16
                            {
                                thingDef = VariousDefOf.BI_BestialityRapePornExcellent;
                                Util.SpawnItem(thingDef, 1, pawn);
                            }
                            else if (skillLevel <= 20 && skillLevel >= 17) // Masterwork 17-20
                            {
                                thingDef = VariousDefOf.BI_BestialityRapePornMasterwork;
                                Util.SpawnItem(thingDef, 1, pawn);
                                //5% chance for Legendary
                                if (random.Next(100) > 5)
                                {
                                    thingDef = VariousDefOf.BI_BestialityRapePornLegendary;
                                    Util.SpawnItem(thingDef, 1, pawn);
                                }
                            }
                        }
                        else // Rape
                        {
                            if (skillLevel <= 2) // Awful 0-2
                            {
                                thingDef = VariousDefOf.BI_RapePornAwful;
                                Util.SpawnItem(thingDef, 1, pawn);
                            }
                            else if (skillLevel <= 5 && skillLevel >= 3) // Poor 3-5
                            {
                                thingDef = VariousDefOf.BI_RapePornPoor;
                                Util.SpawnItem(thingDef, 1, pawn);
                            }
                            else if (skillLevel <= 8 && skillLevel >= 6) // Normal 6-8
                            {
                                thingDef = VariousDefOf.BI_RapePornNormal;
                                Util.SpawnItem(thingDef, 1, pawn);
                            }
                            else if (skillLevel <= 12 && skillLevel >= 9) // Good 9-12
                            {
                                thingDef = VariousDefOf.BI_RapePornGood;
                                Util.SpawnItem(thingDef, 1, pawn);
                            }
                            else if (skillLevel <= 16 && skillLevel >= 13) // Excellent 13-16
                            {
                                thingDef = VariousDefOf.BI_RapePornExcellent;
                                Util.SpawnItem(thingDef, 1, pawn);
                            }
                            else if (skillLevel <= 20 && skillLevel >= 17) // Masterwork 17-20
                            {
                                thingDef = VariousDefOf.BI_RapePornMasterwork;
                                Util.SpawnItem(thingDef, 1, pawn);
                                //5% chance for Legendary
                                if (random.Next(100) > 5)
                                {
                                    thingDef = VariousDefOf.BI_RapePornLegendary;
                                    Util.SpawnItem(thingDef, 1, pawn);
                                }
                            }
                        }
                    }
                }
                // Necro
                if (pawn.jobs.curJob.def == VariousDefOf.ViolateCorpse)
                {
                    pawn.health.hediffSet.GetFirstHediffOfDef(VariousDefOf.BI_RecordingHediff).Severity = 0.01f;
                    Pawn target = (Pawn)pawn.jobs.curJob.targetA;
                    if (Sexperience)
                    {
                        int skillLevel = pawn.skills.GetSkill(VariousDefOf.Sex).Level;
                        if (target.IsAnimal())
                        {
                            if (skillLevel <= 2) // Awful 0-2
                            {
                                thingDef = VariousDefOf.BI_NecroBestialityPornAwful;
                                Util.SpawnItem(thingDef, 1, pawn);
                            }
                            else if (skillLevel <= 5 && skillLevel >= 3) // Poor 3-5
                            {
                                thingDef = VariousDefOf.BI_NecroBestialityPornPoor;
                                Util.SpawnItem(thingDef, 1, pawn);
                            }
                            else if (skillLevel <= 8 && skillLevel >= 6) // Normal 6-8
                            {
                                thingDef = VariousDefOf.BI_NecroBestialityPornNormal;
                                Util.SpawnItem(thingDef, 1, pawn);
                            }
                            else if (skillLevel <= 12 && skillLevel >= 9) // Good 9-12
                            {
                                thingDef = VariousDefOf.BI_NecroBestialityPornGood;
                                Util.SpawnItem(thingDef, 1, pawn);
                            }
                            else if (skillLevel <= 16 && skillLevel >= 13) // Excellent 13-16
                            {
                                thingDef = VariousDefOf.BI_NecroBestialityPornExcellent;
                                Util.SpawnItem(thingDef, 1, pawn);
                            }
                            else if (skillLevel <= 20 && skillLevel >= 17) // Masterwork 17-20
                            {
                                thingDef = VariousDefOf.BI_NecroBestialityPornMasterwork;
                                Util.SpawnItem(thingDef, 1, pawn);
                                //5% chance for Legendary
                                if (random.Next(100) > 5)
                                {
                                    thingDef = VariousDefOf.BI_NecroBestialityPornLegendary;
                                    Util.SpawnItem(thingDef, 1, pawn);
                                }
                            }
                        }
                        else
                        {
                            if (skillLevel <= 2) // Awful 0-2
                            {
                                thingDef = VariousDefOf.BI_NecroPornAwful;
                                Util.SpawnItem(thingDef, 1, pawn);
                            }
                            else if (skillLevel <= 5 && skillLevel >= 3) // Poor 3-5
                            {
                                thingDef = VariousDefOf.BI_NecroPornPoor;
                                Util.SpawnItem(thingDef, 1, pawn);
                            }
                            else if (skillLevel <= 8 && skillLevel >= 6) // Normal 6-8
                            {
                                thingDef = VariousDefOf.BI_NecroPornNormal;
                                Util.SpawnItem(thingDef, 1, pawn);
                            }
                            else if (skillLevel <= 12 && skillLevel >= 9) // Good 9-12
                            {
                                thingDef = VariousDefOf.BI_NecroPornGood;
                                Util.SpawnItem(thingDef, 1, pawn);
                            }
                            else if (skillLevel <= 16 && skillLevel >= 13) // Excellent 13-16
                            {
                                thingDef = VariousDefOf.BI_NecroPornExcellent;
                                Util.SpawnItem(thingDef, 1, pawn);
                            }
                            else if (skillLevel <= 20 && skillLevel >= 17) // Masterwork 17-20
                            {
                                thingDef = VariousDefOf.BI_NecroPornMasterwork;
                                Util.SpawnItem(thingDef, 1, pawn);
                                //5% chance for Legendary
                                if (random.Next(100) > 5)
                                {
                                    thingDef = VariousDefOf.BI_NecroPornLegendary;
                                    Util.SpawnItem(thingDef, 1, pawn);
                                }
                            }
                        }
                    }
                    else
                    {
                        int skillLevel = pawn.skills.GetSkill(VariousDefOf.Social).Level;
                        if (target.IsAnimal())
                        {
                            if (skillLevel <= 2) // Awful 0-2
                            {
                                thingDef = VariousDefOf.BI_NecroBestialityPornAwful;
                                Util.SpawnItem(thingDef, 1, pawn);
                            }
                            else if (skillLevel <= 5 && skillLevel >= 3) // Poor 3-5
                            {
                                thingDef = VariousDefOf.BI_NecroBestialityPornPoor;
                                Util.SpawnItem(thingDef, 1, pawn);
                            }
                            else if (skillLevel <= 8 && skillLevel >= 6) // Normal 6-8
                            {
                                thingDef = VariousDefOf.BI_NecroBestialityPornNormal;
                                Util.SpawnItem(thingDef, 1, pawn);
                            }
                            else if (skillLevel <= 12 && skillLevel >= 9) // Good 9-12
                            {
                                thingDef = VariousDefOf.BI_NecroBestialityPornGood;
                                Util.SpawnItem(thingDef, 1, pawn);
                            }
                            else if (skillLevel <= 16 && skillLevel >= 13) // Excellent 13-16
                            {
                                thingDef = VariousDefOf.BI_NecroBestialityPornExcellent;
                                Util.SpawnItem(thingDef, 1, pawn);
                            }
                            else if (skillLevel <= 20 && skillLevel >= 17) // Masterwork 17-20
                            {
                                thingDef = VariousDefOf.BI_NecroBestialityPornMasterwork;
                                Util.SpawnItem(thingDef, 1, pawn);
                                //5% chance for Legendary
                                if (random.Next(100) > 5)
                                {
                                    thingDef = VariousDefOf.BI_NecroBestialityPornLegendary;
                                    Util.SpawnItem(thingDef, 1, pawn);
                                }
                            }
                        }
                        else
                        {
                            if (skillLevel <= 2) // Awful 0-2
                            {
                                thingDef = VariousDefOf.BI_NecroPornAwful;
                                Util.SpawnItem(thingDef, 1, pawn);
                            }
                            else if (skillLevel <= 5 && skillLevel >= 3) // Poor 3-5
                            {
                                thingDef = VariousDefOf.BI_NecroPornPoor;
                                Util.SpawnItem(thingDef, 1, pawn);
                            }
                            else if (skillLevel <= 8 && skillLevel >= 6) // Normal 6-8
                            {
                                thingDef = VariousDefOf.BI_NecroPornNormal;
                                Util.SpawnItem(thingDef, 1, pawn);
                            }
                            else if (skillLevel <= 12 && skillLevel >= 9) // Good 9-12
                            {
                                thingDef = VariousDefOf.BI_NecroPornGood;
                                Util.SpawnItem(thingDef, 1, pawn);
                            }
                            else if (skillLevel <= 16 && skillLevel >= 13) // Excellent 13-16
                            {
                                thingDef = VariousDefOf.BI_NecroPornExcellent;
                                Util.SpawnItem(thingDef, 1, pawn);
                            }
                            else if (skillLevel <= 20 && skillLevel >= 17) // Masterwork 17-20
                            {
                                thingDef = VariousDefOf.BI_NecroPornMasterwork;
                                Util.SpawnItem(thingDef, 1, pawn);
                                //5% chance for Legendary
                                if (random.Next(100) > 5)
                                {
                                    thingDef = VariousDefOf.BI_NecroPornLegendary;
                                    Util.SpawnItem(thingDef, 1, pawn);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
