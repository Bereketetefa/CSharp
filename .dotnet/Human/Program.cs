using System;

namespace Human
{
// Create a Human class with four public fields: Name (string) , Strength (int), Intelligence (int), Dexterity (int)
    class Human
        {
            
        public string Name { get; set; }
// Add a constructor method that takes a string to initialize Name - and that will initialize Strength, Intelligence, and Dexterity to a default value of 3, and health to default value of 100
        public int Strength { get; set; } = 3;
        public int Intelligence { get; set; } = 3;
        public int Dexterity { get; set; } = 3;
// Add an additional private field for health (int), and a public property to access or "get" health
        private int Health { get; set; } = 100;

        public Human(string name)
        {
            Name = name;
            
        }
// Let's create an additional constructor that accepts 5 parameters, so we can set custom values for every field.
        public Human(string name, int strength, int intelligence, int dexterity, int health) :this(name)
        {
            Strength = strength;
            Intelligence = intelligence;
            Dexterity = dexterity;
            Health = health;
        }
// Now add a new method called Attack, which when invoked, should reduce the health of a Human object that is passed as a parameter. The damage done should be 5 * strength (5 points of damage to the attacked, for each 1 point of strength of the attacker). This method should return the remaining health of the target object.
        public void Attack(Object victim)
        {
            var Vic = (Human) victim;
            Vic.Health -= 5 * Strength;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"ATTACK! {Vic.Name} lost {5 * Strength} pts from his Health!");
            Console.WriteLine("Victim's Current Stats: " + Vic.ToString() );
            Console.ForegroundColor = ConsoleColor.White;
        }
        public override string ToString()
        {
            
            return 
                $"Name: {Name}, Strength: {Strength}, Intelligence: {Intelligence}, Dexterity: {Dexterity}, Health: {Health}";
        }
    }
        class Program
    {
        static void Main(string[] args)
        {
            var player1 = new Human("satan");
            var player2 = new Human("burk", 10, 50, 5, 20);
            Console.WriteLine(player1);
            Console.WriteLine(player2);
            player2.Attack(player1);
            
        }
    }
}
