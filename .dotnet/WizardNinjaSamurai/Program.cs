using System;

namespace WizardNinjaSamurai {
    public class Human 
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        protected int health;
        public int Health 
        {
            get;set;
        }
        public Human (string name) {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;
        }
        public Human (string name, int str, int intel, int dex, int hp) {
            Name = name;
            Strength = str;
            Intelligence = intel;
            Dexterity = dex;
            health = hp;
        }
        public virtual int Attack (Human target) {
            int dmg = Strength * 3;
            target.health -= dmg;
            Console.WriteLine ($"{Name} attacked {target.Name} for {dmg} damage!");
            return target.health;
        }
    }

    public class Ninja : Human {
        // Ninja should have a default dexterity of 175
        public Ninja (string name) : base (name) {
            Name = name;
            Dexterity = 175;
        }
        // Provide an override Attack method to Ninja, which reduces the target by 5 * Dexterity and a 20% chance of dealing an additional 10 points of damage.
        public override int Attack (Human target) {
            Random rand = new Random();
            int critChance = rand.Next(0,100);
            int dmg = 0;
            if (critChance <= 20) {
                dmg = 10 + (Dexterity * 5);
            }
            else {
                dmg = Dexterity * 5;
            }
            target.Health -= dmg;
            Console.WriteLine ($"{Name} attacked {target.Name} for {dmg} damage!");
            return target.Health;
        }
        // Ninja should have a method called Steal, reduces a target Human's health by 5 and adds this amount to its own health.
        public int Steal (Human target) {
            target.Health -= 5;
            Health += 5;
            Console.WriteLine ($"{Name} has stolen 5 hp from {target.Name}!");
            return target.Health;
        }
    }
    public class Samurai : Human {
        
        //  Samurai should have a default health of 200

        public Samurai (string name) : base (name) {
            Name = name;
            health = 200;
        }
        // Provide an override Attack method to Samurai, which calls the base Attack and reduces the target to 0 if it has less than 50 remaining health points.
        public override int Attack (Human target) {
            base.Attack(target);
            if (target.Health < 50) {
                target.Health = 0;
            }
            return target.Health;
        }
        // Samurai should have a method called Meditate, which when invoked, heals the Samurai back to full health
        public int Meditate () {
            Health = 200;
            Console.WriteLine ($"{Name} has recovered 200 hp!");
            return Health;
        }
    }
        public class Wizard : Human {
        // Wizard should have a default health of 50 and Intelligence of 25

        public Wizard (string name) : base (name) {
            Name = name;
            Intelligence = 25;
            health = 50;
        }
        // Provide an override Attack method to Wizard, which reduces the target by 5 * Intelligence and heals the Wizard by the amount of damage dealt
        public override int Attack (Human target) {
            int dmg = Intelligence * 5;
            target.Health -= dmg;
            Console.WriteLine ($"{Name} attacked {target.Name} for {dmg} damage!");
            health += dmg;
            return target.Health;
        }
        // Wizard should have a method called Heal, which when invoked, heals a target Human by 10 * Intelligence
        public int Heal (Human target) {
            int cure = Intelligence * 10;
            target.Health += cure;
            Console.WriteLine ($"{Name} has healed {target.Name} and restored {cure.ToString()} hp!");
            return target.Health;
        }
    }
    namespace WizardNinjaSamurai {
        class Program {
            static void Main (string[] args) {
                Wizard Naruto = new Wizard("Naruto");
                Ninja Sauske = new Ninja("Sauske");
                Samurai Sakura = new Samurai("Sakura");
                Sakura.Attack(Naruto);
                Naruto.Attack(Sauske);
                Sauske.Attack(Sakura);
                Sauske.Steal(Naruto);
                Sakura.Meditate();
                Naruto.Heal(Naruto);
            }
        }
    }
}

