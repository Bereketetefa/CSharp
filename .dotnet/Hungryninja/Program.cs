using System;
using System.Collections.Generic;

namespace HungryNinja
{

    class Food
    {
        public string Name;
        public int Calories;
        public bool IsSpicy;
        public bool IsSweet;

// food constructor that takes in all four parameters: name, calories, whether or not the food is spicy or sweet
        public Food(string name, int calories, bool isspicy, bool issweet)
        {
            Name = name;
            Calories = calories;
            IsSpicy = isspicy;
            IsSweet = issweet;
        }
    }
// add a constructor and set Menu to a hard coded list of 7 or more Food objects you instantiate manually
    class Buffet
    {
        public List<Food> Menu;
        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food ("pizza", 500, true, false),
                new Food ("cheese burger", 160, false, false),
                new Food ("chicken sandwich", 500, false, false),
                new Food ("meatballs", 230, false, true),
                new Food ("chips", 57, true, false),
                new Food ("wild salmon", 420, false, false),
                new Food ("lasagna", 200, false, true),
            };
        }
// build out a Serve method that randomly selects a Food object from the Menu list and returns the Food object
        public Food Serve()
        {
            Random rand = new Random();
            rand.Next(0, Menu.Count);
            return Menu[rand.Next(0, Menu.Count)];
        }
    }

    class Ninja
        {
        private int calorieIntake;
        public List<Food> FoodHistory;

// add a constructor that sets calorieIntake to 0 and creates a new, empty list of Food objects to FoodHistory

            public Ninja()
            {
                calorieIntake = 0;
                FoodHistory = new List<Food>();
                {
                };
            }
// Add public getter to IsFull property that returns a BOOLEAN if the Ninja has eaten more than 1200 calories.
            public bool IsFull
            {
                get
                {
                    if (calorieIntake > 1200)
                    {
                        return true;
                    }
                    return false;
                }
            }
// build out the Eat method that: if the Ninja is NOT full
// adds calorie value to ninja's total calorieIntake
// adds the randomly selected Food object to ninja's FoodHistory list
// writes the Food's Name - and if it is spicy/sweet to the console
            public void Eat(Food item)
            {
                if (IsFull == false)
                {
                    calorieIntake += item.Calories;
                    FoodHistory.Add(item);
                    Console.WriteLine(item.Name);

                }
                else
                {
                    Console.WriteLine("Ninja is too full to eat more!");
                }
            }
        }
    class Program
    {
        static void Main(string[] args)
        {
// create a Ninja object below
// this is now an object
            Ninja myNinja = new Ninja();
// buffet object must be createed in order to run
            Buffet myBuffet = new Buffet();
// calls a method within Buffet
// Serve() returns a food object
            myBuffet.Serve();
// Ninja will eat and it will eat a random item that myBuffet.Serve returns (which is one random item) then when the Ninja exceeds 1200 calories, a string appears that says the Ninja is too full to eat.
            myNinja.Eat(myBuffet.Serve());
            myNinja.Eat(myBuffet.Serve());
            myNinja.Eat(myBuffet.Serve());
            myNinja.Eat(myBuffet.Serve());
            myNinja.Eat(myBuffet.Serve());
            myNinja.Eat(myBuffet.Serve());
        }
    }
}
