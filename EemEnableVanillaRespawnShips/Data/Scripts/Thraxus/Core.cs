using System.Collections.Generic;
using Sandbox.Definitions;
using VRage.Game;
using VRage.Game.Components;
using VRage.Utils;

namespace EemEnableVanillaRespawnShips.Thraxus
{
	[MySessionComponentDescriptor(MyUpdateOrder.NoUpdate, priority: int.MaxValue)]
	public class Core : MySessionComponentBase
	{
		public override void LoadData()
		{
			base.LoadData();
		}
	}
}
