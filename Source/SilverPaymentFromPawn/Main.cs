using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Verse;

namespace BipassedAddons
{
	[StaticConstructorOnStartup]
	public class Main
	{
		static Main()
		{
			new Harmony("bipassed.addons").PatchAll(Assembly.GetExecutingAssembly());
		}
	}

}
