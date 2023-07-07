using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verse;
using RimWorld;
using UnityEngine;

namespace BipassedAddons
{
    public class Building_SilverStash : Building_ShipComputerCore
    {
        public bool LaunchNow = true;

		public override IEnumerable<Gizmo> GetGizmos()
		{
			foreach (Gizmo gizmo in base.GetGizmos())
			{
				yield return gizmo;
			}
			foreach (Gizmo item in ShipUtility.ShipStartupGizmos(this))
			{
				yield return item;
			}
			Command_Action command_Action = new Command_Action();
			command_Action.action = TryToLaunch;
			command_Action.defaultLabel = "CommandShipLaunch".Translate();
			command_Action.defaultDesc = "CommandShipLaunchDesc".Translate();
			if (!LaunchNow)
			{
				command_Action.Disable(ShipUtility.LaunchFailReasons(this).First());
			}
			if (ShipCountdown.CountingDown)
			{
				command_Action.Disable();
			}
			command_Action.hotKey = KeyBindingDefOf.Misc1;
			command_Action.icon = ContentFinder<Texture2D>.Get("UI/Commands/LaunchShip");
			yield return command_Action;
		}

		public void TryToLaunch()
        {
            if (LaunchNow)
            {
                ForceLaunch();
            }
        }
    }
}
