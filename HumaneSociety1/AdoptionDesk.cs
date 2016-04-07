using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety1
	{
	class AdoptionDesk
		{
		public List<string> adopterNameList = new List<string>();
		public List<Cage> cages;

		OrphanedAnimal inboundAnimal;
		Adopter adopter;
		public AdoptionDesk ()
			{
			cages = new List<Cage>();
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
					inboundAnimal.IntakeAnimalInfo();
					cages.Add(new Cage(inboundAnimal.IntakeAnimalInfo()));
					MenuChoiceScreen();
					break;
				case "2":
					adoptionMenu();
					adopter = new Adopter();

					break;
				case "3":
					//check animal inventory
					break;
					//adopter history list
				case "4":
					break;
				case "5":
				//List of food needs

				default:
					MenuChoiceScreen();
					break;

				}
			}
			public void adoptionMenu ()
				{
				Console.WriteLine("Thanks for giving an old friend a new home!\n\nFor our records we require your name, please enter it below.\n\n");
				string adopterName = Console.ReadLine();
				adopterNameList.Add(adopterName);
				Console.WriteLine("\nWhat kind of animal are you adopting?\n\n[1]\tBird\n[2]\tCat\n[3]\tDog");
				string animalType = Console.ReadLine();
					if (animalType == "1")
						{
						//add to birdlist
						}
					else if (animalType == "2")
						{
						//add to catlist
						}
					else if (animalType == "3")
						{
						//add to doglist
						}
				}
		}

	}
	
	
