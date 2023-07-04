using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verse;

namespace BipassedAddons
{
    [DefOf]
    public static class VariousDefOf
    {
        // ThingDefs
        public static ThingDef Silver;
        // JoyKindDefs
        public static JoyKindDef Gaming_Cerebral;
        // HediffDefs
        public static HediffDef HeartAttack;
        public static HediffDef BI_VirtualRealityTemporaryBoost_Talking;
        public static HediffDef BI_VirtualRealityTemporaryBoost_Manipulation;
        public static HediffDef BI_VirtualRealityTemporaryBoost_Moving;
        public static HediffDef BI_VirtualRealityTemporaryBoost_Mood;
        // Positive traits
        public static TraitDef Kind;
        public static TraitDef Transhumanist;
        public static TraitDef Nimble;
        public static TraitDef FastLearner;
        public static TraitDef Undergrounder;
        public static TraitDef Bisexual;
        // Negative traits
        public static TraitDef Jealous;
        public static TraitDef Bloodlust;
        public static TraitDef SlowLearner;
        public static TraitDef DislikesMen;
        public static TraitDef DislikesWomen;
        public static TraitDef Greedy;
        // Skills
        public static SkillDef Construction;
        public static SkillDef Plants;
        public static SkillDef Intellectual;
        public static SkillDef Mining;
        public static SkillDef Shooting;
        public static SkillDef Melee;
        public static SkillDef Social;
        public static SkillDef Animals;
        public static SkillDef Cooking;
        public static SkillDef Medicine;
        public static SkillDef Artistic;
        public static SkillDef Crafting;

        // Lewd shit
        [MayRequire("rjw.sexperience")]
        public static SkillDef Sex;
        [MayRequire("rim.job.world")]
        public static TraitDef Rapist;
        [MayRequire("rim.job.world")]
        public static TraitDef Necrophiliac;
        [MayRequire("rim.job.world")]
        public static TraitDef Zoophile;
        [MayRequire("rim.job.world")]
        public static TraitDef Nymphomaniac;
        [MayRequire("rim.job.world")]
        public static TraitDef FootSlut;
        [MayRequire("rim.job.world")]
        public static TraitDef CumSlut;
        [MayRequire("rim.job.world")]
        public static TraitDef ButtSlut;
        [MayRequire("rim.job.world")]
        public static ThingDef FilthCum;

    }
}
