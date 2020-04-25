using System.Collections.Generic;
using Sandbox.Definitions;
using VRage.Game.Components;

namespace EemEnableVanillaRespawnShips.Thraxus
{
	[MySessionComponentDescriptor(MyUpdateOrder.NoUpdate, priority: int.MaxValue)]
	public class Core : MySessionComponentBase
	{
		public override void LoadData()
		{
			base.LoadData();
			foreach (KeyValuePair<string, MyRespawnShipDefinition> k in MyDefinitionManager.Static.GetRespawnShipDefinitions())
			{
				if (k.Key == "RespawnPlanetPod")
				{
					k.Value.Enabled = true;
					k.Value.Prefab.AvailableInSurvival = true;
					k.Value.UseForSpace = false;
					k.Value.UseForPlanetsWithAtmosphere = true;
					k.Value.UseForPlanetsWithoutAtmosphere  = false;
					continue;
				}
				if (k.Key == "RespawnMoonPod")
				{
					k.Value.Enabled = true;
					k.Value.UseForSpace = false;
					k.Value.UseForPlanetsWithAtmosphere = false;
					k.Value.UseForPlanetsWithoutAtmosphere = true;
					continue;
				}
				if (k.Key == "RespawnSpacePod")
				{
					k.Value.Enabled = true;
					k.Value.UseForSpace = true;
					k.Value.UseForPlanetsWithAtmosphere = false;
					k.Value.UseForPlanetsWithoutAtmosphere = false;
					continue;
				}
			}
		}
	}
}
