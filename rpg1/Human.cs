using System;

namespace rpg1
{

    public class Human
    {
        public string name;
        //The { get; set; } format creates accessor methods for the field specified
        //This is done to allow flexibility
        public int total_damage_infilcted { get; set; }
        public int total_damage_taken { get; set; }
        public int total_damage_healed { get; set; }
        public int health { get; set; }
        public int strength { get; set; }
        public int intelligence { get; set; }
        public int dexterity { get; set; }
        public Human(string person)
        {
            name = person;
            strength = 3;
            intelligence = 3;
            dexterity = 3;
            health = 100;
        }
        public Human(string person, int str, int intel, int dex, int hp)
        {
            name = person;
            strength = str;
            intelligence = intel;
            dexterity = dex;
            health = hp;
        }
        public void attack(object obj)
        {
            Human enemy = obj as Human;
            if(enemy == null)
            {
                Console.WriteLine("Failed Attack");
            }
            else
            {
                if (enemy.health<=0) {
                    Console.WriteLine("{0} beats a dead body ... {1} is already dead", name, enemy.name);
                }
                else{
                    int before = enemy.health;
                    Console.Write("{0} attacks {1} ... ", name, enemy.name);
                    int idamage = strength * 5;
                    enemy.health -= idamage;
                    if (enemy.health<=0) {
                        Console.WriteLine("{0} damage inflicted, {1} has DIED!", idamage, enemy.name);
                    }
                    else{
                        Console.WriteLine("{0} damage inflicted, {1} hp remaining", idamage, enemy.health);

                    }
                }
            }
        }
    }

}