using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety1
	{
	class AdoptionDesk
		{
		OrphanedAnimal inboundAnimal = new OrphanedAnimal();
		public AdoptionDesk ()
			{

			}

		public void FirstMenuScreen ()
			{
			Console.WriteLine("\tHUMANE SOCIETY SOLUTION CENTER\n\n\t\tMAIN MENU\n");
			}

		public void MenuChoiceScreen ()
			{
			Console.WriteLine("Choose from the list below:\n\n[1] \tNew Animal\n[2]\tNew Adoption\n[3]\tCheck Animal Inventory\n[4]\tList Adopter History");
			string menuChoice = Console.ReadLine();
			switch (menuChoice)
				{
				case "1":
					inboundAnimal.IntakeAnimalType();
					break;
				case "2":

					break;
				case "3":

				default:
					break;

				}
			}

		}
	}
	
