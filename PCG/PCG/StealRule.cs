using System;

namespace PCG
{
	public class StealRule : Rule
	{
		public StealRule (NPC npc, Item item)
		{
			Text = "Steal " + item.ItemName + " from " + npc.NPCName;

			outcomes.Add (new GotoRule (npc.Location));
			outcomes.Add (new KillRule (npc));
			outcomes.Add (new Rule ("Take " + item.ItemName));
		}
	}
}

