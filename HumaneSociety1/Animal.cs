using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety1
	{
	abstract class Animal
		{
		public string name;
		public double animalAdoptionValue;
		public double foodUnitsRequired;
		public int cageID ;
		public bool shotsRequired;

		public Animal ( string Name, double AnimalAdoptionValue, double FoodUnitsRequired, bool ShotsRequired)
			{
			name = Name;
			animalAdoptionValue = AnimalAdoptionValue;
			foodUnitsRequired = FoodUnitsRequired;
			cageID++;
			shotsRequired = ShotsRequired;
			}
		}



	}
