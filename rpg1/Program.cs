using System;

namespace rpg1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Random r = new Random();
            Random r = new Random(Guid.NewGuid().GetHashCode());

            bool bcontinue = true;

            while (bcontinue) {

                Ninja n1 = new Ninja("Nancy");
                Samurai s1 = new Samurai("Steve");
                Wizard w1 = new Wizard("William");

                Spider m1 = new Spider("stanley");
                Spider m2 = new Spider("smarcy");
                Zombie m3 = new Zombie("zed");

                int iturns=0;

                while( (m1.health>0||m2.health>0||m3.health>0) && (n1.health>0||s1.health>0||w1.health>0) ) {

                    Console.WriteLine("==============================\nTurn #{0} --------------\nHeroes:", ++iturns);

                    int move = r.Next(2); //0=heal, 1=attack
                    int type = r.Next(5);  //4=special
                    int enemy = r.Next(3);  //0=m1, 1=m2, 2=m3
                    // Console.WriteLine("{0} {1} {2} ", move, type, enemy);


                    if (n1.health<=0) {
                        Console.WriteLine("{0} is DEAD ... skipping", n1.name);
                    }
                    else {

                        if (move==0) {
                            if (type<4) {
                                if (enemy==0) {
                                    n1.attack(m1);
                                }
                                else if (enemy==1) {
                                    n1.attack(m2);
                                }
                                else if (enemy==2) {
                                    n1.attack(m3);
                                }
                            }
                            else{
                                if (enemy==0) {
                                    n1.steal(m1);
                                }
                                else if (enemy==1) {
                                    n1.steal(m2);
                                }
                                else if (enemy==2) {
                                    n1.steal(m3);
                                }
                            }
                        }
                        else{
                            n1.getaway();
                        }
                    }

                    move = r.Next(2); //1=heal, 2=attack
                    type = r.Next(5);  //4=special
                    enemy = r.Next(3);  //1=m1, 2=m2, 3=m3
                    // Console.WriteLine("{0} {1} {2} ", move, type, enemy);
                    
                    if (s1.health<=0) {
                        Console.WriteLine("{0} is DEAD ... skipping", s1.name);
                    }
                    else {

                        if (move==0) {
                            if (type<4) {
                                if (enemy==0) {
                                    s1.attack(m1);
                                }
                                else if (enemy==1) {
                                    s1.attack(m2);
                                }
                                else if (enemy==2) {
                                    s1.attack(m3);
                                }
                            }
                            else{
                                if (enemy==0) {
                                    s1.death_blow(m1);
                                }
                                else if (enemy==1) {
                                    s1.death_blow(m2);
                                }
                                else if (enemy==2) {
                                    s1.death_blow(m3);
                                }
                            }
                        }
                        else{
                            if (s1.health<200) {
                                s1.meditate();
                            }
                            else { Console.WriteLine("{0} IS TOO HEALTHY ===", s1.name); }
                        }
                    }


                    move = r.Next(2); //1=heal, 2=attack
                    type = r.Next(5);  //4=special
                    enemy = r.Next(3);  //1=m1, 2=m2, 3=m3
                    // Console.WriteLine("{0} {1} {2} ", move, type, enemy);
                    
                    if (w1.health<=0) {
                        Console.WriteLine("{0} is DEAD ... skipping", w1.name);
                    }
                    else {

                        if (move==0) {
                            if (type<4) {
                                if (enemy==0) {
                                    w1.attack(m1);
                                }
                                else if (enemy==1) {
                                    w1.attack(m2);
                                }
                                else if (enemy==2) {
                                    w1.attack(m3);
                                }
                            }
                            else{
                                if (enemy==0) {
                                    w1.fireball(m1);
                                }
                                else if (enemy==1) {
                                    w1.fireball(m2);
                                }
                                else if (enemy==2) {
                                    w1.fireball(m3);
                                }
                            }
                        }
                        else{
                            if (w1.health<200) {
                                w1.heal();
                            }
                            else { Console.WriteLine("{0} IS TOO HEALTHY >>", w1.name); }
                        }
                    }

                    Console.WriteLine("_________________\nMonsters:");


                    move = r.Next(2); //1=heal, 2=attack
                    type = r.Next(2);  //1=normal, 2=special
                    enemy = r.Next(3);  //1=m1, 2=m2, 3=m3
                    // Console.WriteLine("{0} {1} {2} ", move, type, enemy);
                    
                    if (m1.health<=0) {
                        Console.WriteLine("{0} is DEAD ... skipping", m1.name);
                    }
                    else {
                        if (n1.health>0)
                        {
                            m1.attack(n1);
                        }
                        else if (s1.health>0)
                        {
                            m1.attack(s1);
                        }
                        else if (w1.health>0)
                        {
                            m1.attack(w1);
                        }
                        else {
                            Console.WriteLine("They are all DEAD! {0} has nobody to attack", m1.name);
                        }
                    }



                    move = r.Next(2); //1=heal, 2=attack
                    type = r.Next(2);  //1=normal, 2=special
                    enemy = r.Next(3);  //1=m1, 2=m2, 3=m3
                    // Console.WriteLine("{0} {1} {2} ", move, type, enemy);
                    
                    if (m2.health<=0) {
                        Console.WriteLine("{0} is DEAD ... skipping", m2.name);
                    }
                    else {
                        if (n1.health>0)
                        {
                            m2.attack(n1);
                        }
                        else if (s1.health>0)
                        {
                            m2.attack(s1);
                        }
                        else if (w1.health>0)
                        {
                            m2.attack(w1);
                        }
                        else {
                            Console.WriteLine("They are all DEAD! {0} has nobody to attack", m2.name);
                        }
                    }



                    move = r.Next(2); //1=heal, 2=attack
                    type = r.Next(2);  //1=normal, 2=special
                    enemy = r.Next(3);  //1=m1, 2=m2, 3=m3
                    // Console.WriteLine("{0} {1} {2} ", move, type, enemy);
                    
                    if (m3.health<=0) {
                        Console.WriteLine("{0} is DEAD ... skipping", m3.name);
                    }
                    else {

                        if (n1.health>0)
                        {
                            m3.attack(n1);
                        }
                        else if (s1.health>0)
                        {
                            m3.attack(s1);
                        }
                        else if (w1.health>0)
                        {
                            m3.attack(w1);
                        }
                        else {
                            Console.WriteLine("They are all DEAD! {0} has nobody to attack", m3.name);
                        }
                    }

                    Console.WriteLine(" --- end of turn ---");




                }

                if (m1.health>0||m2.health>0||m3.health>0) {
                    Console.WriteLine("Monsters WIN");
                }
                else if (n1.health>0||s1.health>0||w1.health>0) {
                    Console.WriteLine("Heroes WIN");
                }
                else {
                    Console.WriteLine("A P O C A L Y P S E");
                }


                Console.Write("Play again? Y/n ");
                if (Console.ReadLine() == "n"){
                    bcontinue = false;
                }
                else {
                    Console.WriteLine("\n\n\n\n\n\n\n\n\n");
                }

            } //end- while bcontinue

        }// end- main



        public void DoAttacks(Human[] heros, Monster[] monsters, Random r){
            foreach (Human h in heros) {
                if (h.health>0) {
                    bool attacked=false;
                    while(!attacked) {
                        int i = r.Next(monsters.Length);
                        if (monsters[i].health>0) {
                            h.attack(monsters[i]);                            
                            attacked = true;
                        }
                    }
                }
            } // all healthy humans have attacked, each only attacking a living monster

            foreach (Monster m in monsters) {
                if (m.health>0) {
                    bool attacked=false;
                    while(!attacked) {
                        int i = r.Next(heros.Length);
                        if (heros[i].health>0) {
                            m.attack(heros[i]);                            
                            attacked = true;
                        }
                    }
                }
            } // all healthy monsters have attacked, each only attacking a living hero


        }

    }// end- program


}
