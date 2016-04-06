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

		public void IntakeAnimalType ()
			{
			Console.Write("Thank you for Bringing Us your Undesired Creature, \n\nWhat kind of animal are we taking in?\n\n[1]\tBird\n[2]\tCat\n[3]\tDog\n");
			string intake = Console.ReadLine();
				switch (intake)
				{
				case "1":
					//add to birdList
					break;

				case "2":
					//add to catList
					break;

					case "3":
					//add to dogList
					break;

				case "4":
					
					break;
					
				default:
				 break;
				}
			Console.WriteLine("To the best of your knowledge is this animal up to date with its innoculations?\n\n[Y] or [N]");
			string haveShots = Console.ReadLine();
			if ( haveShots.ToUpper() == "N")
				{
				Console.WriteLine("\n\nLets make an appointment with the Vetrinarian right away then,"	 );

				}
			else
				{
				Console.WriteLine("Awesome, you are a great animal handler.");
				}
			}
		}
	}
	
