using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety1
	{
	class Adopter
		{
		public List<string> adopterNameList = new List<string>();
		

		public Adopter ()
			{

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
