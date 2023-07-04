using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verse;
using RimWorld;

namespace BipassedAddons
{
    public class HediffComp_VirtualReality : HediffWithComps
    {
        public static float pawnWorth = 1;
        public static TraitDef[] positiveTraitList = { VariousDefOf.Kind, VariousDefOf.Transhumanist, VariousDefOf.Bisexual, VariousDefOf.Nimble, VariousDefOf.FastLearner, VariousDefOf.Undergrounder }; // Array of positive traits
        public static TraitDef[] negativeTraitList = { VariousDefOf.Jealous, VariousDefOf.SlowLearner, VariousDefOf.Bloodlust, VariousDefOf.DislikesMen, VariousDefOf.DislikesWomen, VariousDefOf.Greedy }; // Array of negative traits
        public static SkillDef[] allSkillsList = { VariousDefOf.Animals, VariousDefOf.Artistic, VariousDefOf.Construction, VariousDefOf.Cooking, VariousDefOf.Crafting, VariousDefOf.Intellectual, VariousDefOf.Medicine, VariousDefOf.Melee, VariousDefOf.Mining, VariousDefOf.Plants, VariousDefOf.Shooting, VariousDefOf.Social };
        public static HediffDef[] boostList = { VariousDefOf.BI_VirtualRealityTemporaryBoost_Manipulation, VariousDefOf.BI_VirtualRealityTemporaryBoost_Moving, VariousDefOf.BI_VirtualRealityTemporaryBoost_Talking };
        public override void Tick()
        {
            Pawn pawn = this.pawn;
            if (pawn.IsHashIntervalTick(60000)) // Approximately one in-game day, 60000
            {
                Random random = new Random();
                if (pawn.IsColonist || pawn.IsPrisoner || pawn.IsSlave)
                {
                    // Silver drop
                    Thing dropThing = ThingMaker.MakeThing(VariousDefOf.Silver);
                    pawnWorth = (float)(pawn.MarketValue * 0.07); // 7% of a pawn's worth, may change in future
                    dropThing.stackCount = (int)pawnWorth;
                    GenPlace.TryPlaceThing(dropThing, pawn.Position, pawn.Map, ThingPlaceMode.Near);

                    // Gain recreation
                    pawn.needs.joy.GainJoy(100000, VariousDefOf.Gaming_Cerebral);

                    // Random temporary boost to various stats
                    if (random.Next(100) == 0) // 1 in 100
                    {
                        int boostIndex = random.Next(boostList.Length);
                        HediffDef hediff = boostList[boostIndex];
                        pawn.health.AddHediff(hediff);
                        Find.LetterStack.ReceiveLetter("BI_VRBoost".Translate(), "BI_VRBoostMessage".Translate(pawn), LetterDefOf.PositiveEvent, pawn);
                    }

                    // Random skill gain with random amount added
                    else if (random.Next(60) == 0) // 1 in 60
                    {
                        int skillIndex = random.Next(allSkillsList.Length);
                        int xpGained = random.Next(1, 501);
                        SkillDef skill = allSkillsList[skillIndex];
                        pawn.skills.Learn(skill, xpGained, true);
                        Find.LetterStack.ReceiveLetter("BI_SkillGain".Translate(), "BI_SkillGainMessage".Translate(pawn, xpGained, skill), LetterDefOf.PositiveEvent, pawn);
                    }

                    // Random chance for trait addition
                    else if (random.Next(100) == 0) // 1 in 100
                    {
                        int randomPositiveTraitListIndex = random.Next(positiveTraitList.Length);
                        int randomNegativeTraitListIndex = random.Next(negativeTraitList.Length);
                        if (random.Next(100) < 80) // Positive trait gain
                        {
                            TraitDef randomTraitDef = positiveTraitList[randomPositiveTraitListIndex];
                            if (pawn.story.traits.HasTrait(randomTraitDef))
                            {
                                Log.Message("Pawn already has trait");
                                return;
                            }
                            Trait randomTrait = new Trait(randomTraitDef); // Converts the TraitDef to a Trait
                            pawn.story.traits.GainTrait(randomTrait);
                            Find.LetterStack.ReceiveLetter("BI_TraitAdded".Translate(randomTrait.Label), "BI_TraitAddedMessage".Translate(pawn, randomTrait.Label), LetterDefOf.PositiveEvent, pawn);
                        }
                        else // Negative trait gain
                        {
                            TraitDef randomTraitDef = negativeTraitList[randomNegativeTraitListIndex];
                            if (pawn.story.traits.HasTrait(randomTraitDef))
                            {
                                Log.Message("Pawn already has trait");
                                return;
                            }
                            Trait randomTrait = new Trait(randomTraitDef); // Converts the TraitDef to a Trait
                            pawn.story.traits.GainTrait(randomTrait);
                            Find.LetterStack.ReceiveLetter("BI_TraitAdded".Translate(randomTrait.Label), "BI_TraitAddedMessage".Translate(pawn, randomTrait.Label), LetterDefOf.NegativeEvent, pawn);
                        }
                    }

                    // Random chance for trait removal
                    else if (random.Next(100) == 0) // 1 in 100
                    {
                        if (pawn.story.traits.allTraits.Count > 0) // Checks if pawn has any traits to remove at all
                        {
                            List<Trait> removalPawnTraitList = new List<Trait>();
                            foreach (Trait t in pawn.story.traits.allTraits)
                            {
                                removalPawnTraitList.Add(t);
                            }
                            int randomRemovalIndex = random.Next(removalPawnTraitList.Count);
                            Trait trait = removalPawnTraitList[randomRemovalIndex]; // Store the randomly selected trait
                            pawn.story.traits.allTraits.RemoveAt(randomRemovalIndex);
                            Find.LetterStack.ReceiveLetter("BI_TraitLost".Translate(trait.Label), "BI_TraitLostMessage".Translate(pawn, trait.Label), LetterDefOf.NeutralEvent, pawn);
                        }
                        else
                        {
                            Log.Message("Pawn has no traits to remove");
                            return;
                        }
                    }

                    // Random chance for 30 day mood bonus
                    else if (random.Next(100) == 0) // 1 in 100
                    {
                        pawn.health.AddHediff(VariousDefOf.BI_VirtualRealityTemporaryBoost_Mood);
                        Find.LetterStack.ReceiveLetter("BI_VRBoost".Translate(), "BI_VRBoostMessageMood".Translate(pawn), LetterDefOf.PositiveEvent, pawn);
                    }

                    // Random chance for heart attack hediff
                    else if (random.Next(500) == 0) // 1 in 500
                    {
                        Log.Message("Pawn is getting a heart attack");
                        pawn.health.AddHediff(VariousDefOf.HeartAttack);
                        Find.LetterStack.ReceiveLetter("BI_HeartAttack".Translate(), "BI_HeartAttackMessage".Translate(pawn), LetterDefOf.ThreatSmall, pawn);
                    }
                }
            }
            else
                return;
        }
    }
}
