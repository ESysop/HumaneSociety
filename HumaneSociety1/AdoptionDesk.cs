using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety1
	{
	class AdoptionDesk
		{
		public List<Animal> animalInfoList;

		OrphanedAnimal inboundAnimal;
		Adopter adopter;
		public AdoptionDesk ()
			{
			
			}

		public void FirstMenuScreen ()
			{
			Console.WriteLine("\tHUMANE SOCIETY SOLUTION CENTER\n\n\t\tMAIN MENU\n");
			}

		public void MenuChoiceScreen ()
			{
			Console.WriteLine("Choose from the list below:\n\n[1] \tNew Animal Intake\n[2]\tNew Adoption\n[3]\tCheck Current Animal Inventory\n[4]\tList Adopter History\n[5]\tList of Food Needed per Day\n");
			string menuChoice = Console.ReadLine();
			switch (menuChoice)
				{
				case "1":
					inboundAnimal = new OrphanedAnimal();
					inboundAnimal.IntakeAnimalType();
					break;
				case "2":
					adopter.adoptionMenu();
					adopter = new Adopter();

					break;
				case "3":
					//check animal inventory
					break;
				case "4":
					//adopter history
					break;
				case "5":
					//List of food needs

				default:
					MenuChoiceScreen();
					break;

				}
			}

		}
	}
	
