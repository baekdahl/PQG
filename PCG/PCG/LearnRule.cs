using System;

namespace PCG
{
	public class LearnRule : Rule
	{
		public Location LearnedLocation { get;}

		public LearnRule ()
		{
			// TODO: Random location, already learned

			LearnedLocation = World.RandomLocation();

			switch (RandomNumberGenerator.NumberBetween (0, 2)) {
			case 0:
				Text = "You already know that location is " + LearnedLocation.LocationName;
				break;

			case 1:
				var readOn = World.RandomItem ();
				Text = "Read location on " + readOn.ItemName;
				outcomes.Add (new GotoRule (World.RandomLocation ()));
				outcomes.Add (new GetRule (readOn));
				outcomes.Add (new Rule ("Read location"));
				break;
			}


		}
	}
}

