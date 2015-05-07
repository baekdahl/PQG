using System;

namespace PCG
{
	public class GetRule : Rule
	{
		public GetRule (Item item)
		{
			Text = "Get " + item.ItemName;
			if (item.InPossession) {
				outcomes.Add (new Rule ("Already have " + item.ItemName));
			} else {
				NPC stealFrom = World.RandomNPC();
				outcomes.Add (new StealRule (stealFrom, item));
			}
		}
	}
}

