using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety1
	{
	class OrphanedAnimal
		{
		public OrphanedAnimal ()
			{
			}

		public Animal IntakeAnimalInfo ()
			{
			Console.Write("\nThank you for Bringing Us your Undesired Creature, \n\nWe require some information so we can take over your responsabilities and properly care for the animal.\n\nWhat is the name of animal are we taking in go by?\n");
			Console.Write("Name: ");
			string newPetName = Console.ReadLine();
			bool needShots;
			double foodUnits;
			double donorValue;
			Console.WriteLine("\nTo the best of your knowledge is this animal up to date with its shots?\n");
			Console.Write("\n[Y] or [N]");
			string haveShots = Console.ReadLine();
				if ( haveShots.ToUpper() == "N")
					{
					Console.WriteLine("\n\nLets make an appointment with the Vetrinarian right away then,"	 );
					needShots = true;
					}
				else
					{
					Console.WriteLine("Awesome, you are a great animal handler.");
					needShots = false;
					}
			Console.WriteLine("If you ever fed them, how many units of food would they eat per day?\n" );
			Console.Write("Food Units: ");
			foodUnits = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Although this animal has no value to you, how much might someone else consider to pay for this priceless life?\n\n");
			Console.WriteLine("Value: ");
			donorValue = Convert.ToDouble(Console.ReadLine());


			// make switch case for return type
			return new Dog( newPetName, donorValue, foodUnits, needShots);
			}
		}
	}
	
