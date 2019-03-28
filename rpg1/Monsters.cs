using System;

namespace rpg1
{

    public class Zombie: Monster{
        Random r = new Random();
        public Zombie(string name) : base(name)
        {
            Console.WriteLine("Created Zombie, name:{0}", name);
        }

    }
    public class Spider: Monster{
        Random r = new Random();
        public Spider(string name) : base(name)
        {
            Console.WriteLine("Created Spider, name:{0}", name);
        }

    }

}
