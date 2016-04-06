using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety1
	{
	class Food
		{
		BirdFood birdFood;
		//DogFood dogFood;
		CatFood catFood;
		Dog dog;
		Cat cat;
		Bird bird;

		public Food ()
			{
			//dogFood = new DogFood();
			catFood = new CatFood();
			birdFood = new BirdFood();
			dog = new Dog();
			cat = new Cat();
			bird = new Bird();
			}

		public void allFoodList (DogFood dogFoodList, CatFood catFoodList, BirdFood birdFoodList)
			{
			Console.WriteLine("Bird food needed is " +(birdFood.birdFoodList));
			}
		//public void double addToDogFoodList ()
			//{
			//double dogFoodList = dogFoodList+dog.dailyFoodRation;
			//return dogFoodList;
			//}

		}
	}
