using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RimWorld;
using Verse;
using rjw;

namespace BipassedAddons
{
    public class Comp_Transfurmation : HediffComp
    {
		public static bool RJW = ModsConfig.IsActive("rim.job.world");
		public XenotypeDef[] anthrosonaeList = { VariousDefOf.ATK_Anthrocat, VariousDefOf.ATK_Anthrocow, VariousDefOf.ATK_Anthrodeer, VariousDefOf.ATK_Anthrodrake, VariousDefOf.ATK_Anthrofox, VariousDefOf.ATK_Anthrogriff, VariousDefOf.ATK_Anthrohyena, VariousDefOf.ATK_Anthropanda, VariousDefOf.ATK_Anthrorabbit, VariousDefOf.ATK_Anthrowolf};
		public override void CompPostMake()
		{
			base.CompPostMake();
			IEnumerable<Hediff> breasts = Pawn.GetBreastList().Where(breastHediff => BI_Genital_Helper.is_breast(breastHediff));
			IEnumerable<Hediff> penises = Pawn.GetGenitalsList().Where(genitalHediff => BI_Genital_Helper.is_penis(genitalHediff));
			bool hasBreast = !breasts.EnumerableNullOrEmpty();
			bool hasPenis = !penises.EnumerableNullOrEmpty();
			XenotypeDef randXeno = anthrosonaeList.RandomElement();
			XenotypeDef curXeno = Pawn.genes.Xenotype;
			// Change xenotype to random Anthrosonae
			if (!anthrosonaeList.Contains(curXeno))
            {
				Pawn.genes.SetXenotype(randXeno);
			}

			if (RJW)
            {
				// Increase size of bits
				if (Pawn.gender == Gender.Male)
				{
					if (hasPenis)
					{
						foreach (Hediff item in penises)
						{
							item.Severity += 0.5f;
							item.Severity *= 2f;
						}
					}
				}
				if (Pawn.gender == Gender.Female || Pawn.gender == Gender.None)
				{
					if (hasPenis)
					{
						foreach (Hediff item in penises)
						{
							item.Severity += 0.5f;
							item.Severity *= 2f;
						}
					}
					if (hasBreast)
					{
						foreach (Hediff item in breasts)
						{
							item.Severity += 0.5f;
							item.Severity *= 2f;
						}
					}
				}
				// Add hypersexual trait
				if (!Pawn.story.traits.HasTrait(VariousDefOf.Nymphomaniac))
                {
					Trait hypersexual = new Trait(VariousDefOf.Nymphomaniac);
					Pawn.story.traits.GainTrait(hypersexual);
				}
			}
		}
	}
}
