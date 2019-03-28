using System;

namespace rpg1
{
    public class Monster: Human{
        Random r = new Random();
        public Monster(string name) : base(name)
        {
            // Console.WriteLine("Created Monster, name:{0}", name);
        }
        public void attack(Human enemy) {
            base.attack(enemy);
            if (health<15 && health>0) {
                //berserker, 2 more attackes
                Console.WriteLine("{0} IS BERSERKER!!", name);
                base.attack(enemy);
                base.attack(enemy);
                base.attack(enemy);
                base.attack(enemy);
                base.attack(enemy);
            }
        }



    }
}
