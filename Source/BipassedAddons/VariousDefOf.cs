using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verse;
using Verse.AI;

namespace BipassedAddons
{
    [DefOf]
    public class VariousDefOf
    {
        public static LifeStageDef HumanlikeChild;

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

        // Anthrosonae
        [MayRequire("atk.anthrosonae")]
        public static XenotypeDef ATK_Anthrocat;
        [MayRequire("atk.anthrosonae")]
        public static XenotypeDef ATK_Anthrocow;
        [MayRequire("atk.anthrosonae")]
        public static XenotypeDef ATK_Anthrodeer;
        [MayRequire("atk.anthrosonae")]
        public static XenotypeDef ATK_Anthrodrake;
        [MayRequire("atk.anthrosonae")]
        public static XenotypeDef ATK_Anthrofox;
        [MayRequire("atk.anthrosonae")]
        public static XenotypeDef ATK_Anthrogriff;
        [MayRequire("atk.anthrosonae")]
        public static XenotypeDef ATK_Anthrohyena;
        [MayRequire("atk.anthrosonae")]
        public static XenotypeDef ATK_Anthropanda;
        [MayRequire("atk.anthrosonae")]
        public static XenotypeDef ATK_Anthrorabbit;
        [MayRequire("atk.anthrosonae")]
        public static XenotypeDef ATK_Anthrowolf;

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
        [MayRequire("rim.job.world")]
        public static ThingDef BI_PornCamera;

        // Normal sex JobDefs
        [MayRequire("rim.job.world")]
        public static JobDef JoinInBed;
        [MayRequire("rim.job.world")]
        public static JobDef GettinLoved;
        [MayRequire("rim.job.world")]
        public static JobDef GettinLicked;
        [MayRequire("rim.job.world")]
        public static JobDef GettinSucked;
        [MayRequire("rim.job.world")]
        public static JobDef Quickie;
        [MayRequire("rim.job.world")]
        public static JobDef GettingQuickie;
        // Masturbation
        [MayRequire("rim.job.world")]
        public static JobDef RJW_Masturbate;
        // Bestiality JobDefs
        [MayRequire("rim.job.world")]
        public static JobDef GettinBred;
        [MayRequire("rim.job.world")]
        public static JobDef Breed;
        [MayRequire("rim.job.world")]
        public static JobDef RJW_Mate;
        [MayRequire("rim.job.world")]
        public static JobDef Bestiality;
        [MayRequire("rim.job.world")]
        public static JobDef BestialityForFemale;
        // Rape JobDefs
        [MayRequire("rim.job.world")]
        public static JobDef GettinRaped;
        [MayRequire("rim.job.world")]
        public static JobDef RapeComfortPawn;
        [MayRequire("rim.job.world")]
        public static JobDef RandomRape;
        // Necro
        [MayRequire("rim.job.world")]
        public static JobDef ViolateCorpse;
        // Pr0n
        [MayRequire("rim.job.world")]
        public static ThingDef BI_NormalPornAwful;
        [MayRequire("rim.job.world")]
        public static ThingDef BI_NormalPornPoor;
        [MayRequire("rim.job.world")]
        public static ThingDef BI_NormalPornNormal;
        [MayRequire("rim.job.world")]
        public static ThingDef BI_NormalPornGood;
        [MayRequire("rim.job.world")]
        public static ThingDef BI_NormalPornExcellent;
        [MayRequire("rim.job.world")]
        public static ThingDef BI_NormalPornMasterwork;
        [MayRequire("rim.job.world")]
        public static ThingDef BI_NormalPornLegendary;
        [MayRequire("rim.job.world")]
        public static ThingDef BI_MasturbationPornAwful;
        [MayRequire("rim.job.world")]
        public static ThingDef BI_MasturbationPornPoor;
        [MayRequire("rim.job.world")]
        public static ThingDef BI_MasturbationPornNormal;
        [MayRequire("rim.job.world")]
        public static ThingDef BI_MasturbationPornGood;
        [MayRequire("rim.job.world")]
        public static ThingDef BI_MasturbationPornExcellent;
        [MayRequire("rim.job.world")]
        public static ThingDef BI_MasturbationPornMasterwork;
        [MayRequire("rim.job.world")]
        public static ThingDef BI_MasturbationPornLegendary;
        [MayRequire("rim.job.world")]
        public static ThingDef BI_BestialityPornAwful;
        [MayRequire("rim.job.world")]
        public static ThingDef BI_BestialityPornPoor;
        [MayRequire("rim.job.world")]
        public static ThingDef BI_BestialityPornNormal;
        [MayRequire("rim.job.world")]
        public static ThingDef BI_BestialityPornGood;
        [MayRequire("rim.job.world")]
        public static ThingDef BI_BestialityPornExcellent;
        [MayRequire("rim.job.world")]
        public static ThingDef BI_BestialityPornMasterwork;
        [MayRequire("rim.job.world")]
        public static ThingDef BI_BestialityPornLegendary;
        [MayRequire("rim.job.world")]
        public static ThingDef BI_RapePornAwful;
        [MayRequire("rim.job.world")]
        public static ThingDef BI_RapePornPoor;
        [MayRequire("rim.job.world")]
        public static ThingDef BI_RapePornNormal;
        [MayRequire("rim.job.world")]
        public static ThingDef BI_RapePornGood;
        [MayRequire("rim.job.world")]
        public static ThingDef BI_RapePornExcellent;
        [MayRequire("rim.job.world")]
        public static ThingDef BI_RapePornMasterwork;
        [MayRequire("rim.job.world")]
        public static ThingDef BI_RapePornLegendary;
        [MayRequire("rim.job.world")]
        public static ThingDef BI_BestialityRapePornAwful;
        [MayRequire("rim.job.world")]
        public static ThingDef BI_BestialityRapePornPoor;
        [MayRequire("rim.job.world")]
        public static ThingDef BI_BestialityRapePornNormal;
        [MayRequire("rim.job.world")]
        public static ThingDef BI_BestialityRapePornGood;
        [MayRequire("rim.job.world")]
        public static ThingDef BI_BestialityRapePornExcellent;
        [MayRequire("rim.job.world")]
        public static ThingDef BI_BestialityRapePornMasterwork;
        [MayRequire("rim.job.world")]
        public static ThingDef BI_BestialityRapePornLegendary;
        [MayRequire("rim.job.world")]
        public static ThingDef BI_NecroPornAwful;
        [MayRequire("rim.job.world")]
        public static ThingDef BI_NecroPornPoor;
        [MayRequire("rim.job.world")]
        public static ThingDef BI_NecroPornNormal;
        [MayRequire("rim.job.world")]
        public static ThingDef BI_NecroPornGood;
        [MayRequire("rim.job.world")]
        public static ThingDef BI_NecroPornExcellent;
        [MayRequire("rim.job.world")]
        public static ThingDef BI_NecroPornMasterwork;
        [MayRequire("rim.job.world")]
        public static ThingDef BI_NecroPornLegendary;
        [MayRequire("rim.job.world")]
        public static ThingDef BI_NecroBestialityPornAwful;
        [MayRequire("rim.job.world")]
        public static ThingDef BI_NecroBestialityPornPoor;
        [MayRequire("rim.job.world")]
        public static ThingDef BI_NecroBestialityPornNormal;
        [MayRequire("rim.job.world")]
        public static ThingDef BI_NecroBestialityPornGood;
        [MayRequire("rim.job.world")]
        public static ThingDef BI_NecroBestialityPornExcellent;
        [MayRequire("rim.job.world")]
        public static ThingDef BI_NecroBestialityPornMasterwork;
        [MayRequire("rim.job.world")]
        public static ThingDef BI_NecroBestialityPornLegendary;
    }
}
