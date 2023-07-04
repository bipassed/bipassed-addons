using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verse;
using RimWorld;

namespace BipassedAddons
{
    public class HediffComp_VirtualRealityLewd : HediffWithComps
    {
        public static TraitDef[] lewdTraitList = { VariousDefOf.Rapist, VariousDefOf.Necrophiliac, VariousDefOf.Nymphomaniac, VariousDefOf.Zoophile, VariousDefOf.CumSlut, VariousDefOf.FootSlut, VariousDefOf.ButtSlut };
        public static bool Sexperience = ModsConfig.IsActive("rjw.sexperience");
        public static float pawnWorth = 1;
        public override void Tick()
        {
            Pawn pawn = this.pawn;
            Random random = new Random();
            if (pawn.IsHashIntervalTick(60000)) // Approximately one day 60000
            {
                if (pawn.IsColonist || pawn.IsPrisoner || pawn.IsSlave)
                {
                    // Higher silver drop
                    Thing dropThing = ThingMaker.MakeThing(VariousDefOf.Silver);
                    pawnWorth = (float)(pawn.MarketValue * 0.14); // % of a pawn's worth, may change in future
                    dropThing.stackCount = (int)pawnWorth;
                    GenPlace.TryPlaceThing(dropThing, pawn.Position, pawn.Map, ThingPlaceMode.Near);

                    // Gain recreation
                    pawn.needs.joy.GainJoy(100000, VariousDefOf.Gaming_Cerebral);

                    // Gain sexperience skill
                    if (Sexperience == true)
                    {
                        if (random.Next(2) == 0) // 50/50
                        {
                            int xpGained = random.Next(1, 501);
                            pawn.skills.Learn(VariousDefOf.Sex, xpGained, true);
                            Find.LetterStack.ReceiveLetter("BI_SkillGain".Translate(), "BI_SkillGainMessage".Translate(pawn, xpGained, VariousDefOf.Sex), LetterDefOf.PositiveEvent, pawn);
                        }
                    }
                    // Random sex trait additions
                    if (random.Next(200) == 0) // 1 in 200
                    {
                        int randomLewdIndex = random.Next(lewdTraitList.Length);
                        TraitDef randomTraitDef = lewdTraitList[randomLewdIndex];
                        if (pawn.story.traits.HasTrait(randomTraitDef))
                        {
                            Log.Message("Pawn already has trait");
                            return;
                        }
                        Trait randomTrait = new Trait(randomTraitDef); // Converts the TraitDef to a Trait
                        pawn.story.traits.GainTrait(randomTrait);
                        Find.LetterStack.ReceiveLetter("BI_TraitAdded".Translate(randomTrait.Label), "BI_TraitAddedMessage".Translate(pawn, randomTrait.Label), LetterDefOf.PositiveEvent, pawn);
                    }
                    // Random chance for a 30 day mood bonus
                    else if (random.Next(100) == 0) // 1 in 100
                    {
                        pawn.health.AddHediff(VariousDefOf.BI_VirtualRealityTemporaryBoost_Mood);
                        Find.LetterStack.ReceiveLetter("BI_VRBoost".Translate(), "BI_VRBoostMessageMood".Translate(pawn), LetterDefOf.PositiveEvent, pawn);
                    }
                    // Random chance for a heart attack hediff
                    else if (random.Next(400) == 0) // 1 in 400
                    {
                        //Log.Message("Pawn is getting a heart attack");
                        pawn.health.AddHediff(VariousDefOf.HeartAttack);
                        Find.LetterStack.ReceiveLetter("BI_HeartAttack".Translate(), "BI_HeartAttackMessage".Translate(pawn), LetterDefOf.ThreatSmall, pawn);
                    }
                }
            }
            if (pawn.IsHashIntervalTick(15000)) // Six hours 15000
            {
                if (pawn.IsColonist || pawn.IsPrisoner || pawn.IsSlave)
                {
                    // Spawns cum filth
                    int filthToSpawn = random.Next(1, 3);
                    FilthMaker.TryMakeFilth(pawn.PositionHeld, pawn.MapHeld, VariousDefOf.FilthCum, filthToSpawn);
                }
            }
        }
    }
}
