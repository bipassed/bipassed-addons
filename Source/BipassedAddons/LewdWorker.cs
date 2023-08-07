using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verse;
using rjw;

namespace BipassedAddons
{
    public class LewdWorker
    {
		public float GetMultiplier(Pawn creator)
		{
			/*IEnumerable<Hediff> breasts = creator.GetBreastList().Where(breastHediff => BI_Genital_Helper.is_breast(breastHediff));
			IEnumerable<Hediff> penises = creator.GetGenitalsList().Where(genitalHediff => BI_Genital_Helper.is_penis(genitalHediff));
			bool hasBreast = !breasts.EnumerableNullOrEmpty();
			bool hasPenis = !penises.EnumerableNullOrEmpty();*/
			var breastValue = 1f;
			var penisValue = 1f;
			float finalValue;
			var beautyValue = creator.GetStatValue(StatDefOf.PawnBeauty);
			if (beautyValue <= 0)
			{
				beautyValue = 1f;
			}
			/*if (hasBreast)
            {
				foreach (Hediff boob in breasts)
                {
					breastValue += boob.Severity;
                }
            }
			if (hasPenis)
            {
				foreach (Hediff penis in penises)
                {
					penisValue += penis.Severity;
                }
            }*/
			finalValue = beautyValue + breastValue + penisValue;
			Log.Message($"{beautyValue} {breastValue} {penisValue} = {finalValue}");
			return finalValue;
		}
	}
}
