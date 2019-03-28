using System;

namespace rpg1
{

    public class Ninja : Human
    {
        Random r = new Random();
        public Ninja(string name) : base(name)
        {
            dexterity = 175;
            Console.WriteLine("Created Ninja named {0}", name);
        }
        public void steal(Human enemy)
        {
            int intbefore = health;
            int intheal = 10;
            health += intheal;
            Console.Write("Ninja {0} performs steal:  gained {1} health, ", name, intheal);

            if (enemy.health<=0) {
                Console.WriteLine("and beats a dead body: {0} is already dead", enemy.name);
            }
            else{
                Console.WriteLine("and gets a special attack!");
                this.attack(enemy);
            }
        }
        public void getaway()
        {
            health -= 15;
            if (health>0) {
                Console.WriteLine("Ninja {1} get_away RUNS AWAY LIKE A COWARD!!! : health:{0}", health, name);
            }
            else{
                Console.WriteLine("Ninja {1} get_away KILLED ITSELF BY RUNNING!!!! DOH! final health:{0}", health, name);
            }
        }
    }


    public class Samurai : Human
    {
        static int exists = 0;
        Random r = new Random();
        public Samurai(string name) : base(name)
        {
            health = 200;
            exists++;
            Console.WriteLine("Created Samurai, name:{0}, exists:{1}", name, exists);
        }
        public void death_blow(Human enemy)
        {

            if (enemy.health<=0) {
                Console.WriteLine("{0} beats a dead body ... {1} is already dead..", name, enemy.name);
            }
            else{
                this.attack(enemy);
                if (enemy.health<=0) {
                    Console.WriteLine("{0} tries to death_blow an alrady dead body ... {1} is already dead..", name, enemy.name);
                }
                else{

                    if (enemy.health<50){
                        enemy.health = 0; //kill it
                    }
                    Console.WriteLine("Samurai {2} death_blow ULTRA STRIKE enemy:{0} health:{1}", enemy.name, enemy.health, name);
                    if (enemy.health<=0) {
                        Console.WriteLine("{0} has DIED!", enemy.name);
                    }
                }
            }
        }
        public void meditate()
        {
            if (health>200) {
                Console.WriteLine("Samurai {0} meditate WOULD RATHER REST WHILE HEALTHY, NOPE", name);
            }
            else {
                health = 200;
                Console.WriteLine("Samurai {1} meditate MEDITATES BACK TO FULL HEALTH, health:{0}", health, name);
            }
        }
        public static int how_many(){
            Console.WriteLine(exists);
            return exists;
        }
    }



    public class Wizard : Human
    {
        Random r = new Random();
        public Wizard(string name) : base(name)
        {
            health = 50;
            intelligence = 25;
            Console.WriteLine("Created Wizard: {0}", name);
        }
        public void heal()
        {
            if (health>50) {
                Console.WriteLine("Wizard {0} heal WOULD RATHER BUFF THAN FIGHT WHILE HEALTHY, NOPE", name);
            }
            else {
                health += intelligence*2;
                Console.WriteLine("Wizard {1} heal HEALS HIMSELF LIKE A BOSS , health:{0}", health, name);
            }
        }
        public void fireball(Human enemy)
        {
            if (enemy.health<=0) {
                Console.WriteLine("{0} beats a dead body ... {1} is already dead..", name, enemy.name);
            }
            else{
                int damage = r.Next(30)+20;
                enemy.health -= damage;
                Console.WriteLine("Wizard {2} fireball: name={0} health:{1}", enemy.name, enemy.health, name);
                if (enemy.health<=0) {
                    Console.WriteLine("{0} has DIED!", enemy.name);
                }
            }
        }
    }



}