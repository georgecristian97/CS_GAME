using System;
using System.Collections.Generic;
using System.Text;

namespace Lupta_virtuala
{
    class batalie : luptator 
    {
        public short turn;
        public void lupta(luptator  a , luptator b)
        {
            turn = 0;
            Console.WriteLine($"{a.nume} vs. {b.nume}");
            Console.WriteLine("FIGHT! {0}",turn);
            Console.WriteLine(@"
    >()       \  ()
 ,_ /||\_,     \/||\
     /\          /\");
           
            while((a.hp > 0) && (b.hp > 0 ))  
            {
               // Console.ReadLine();
                b.hp=attack(a, b,ref turn);
                if (b.hp > 0) {
                    //Console.ReadLine();
                    a.hp = attack(b, a, ref turn);
                }
                
            }

        }
        public int attack(luptator a, luptator b,  ref short turn)
        {
            turn++;
            if (b.hp - (a.dmg * (a.crit / 100)) + b.def > b.hp)
            {
               
                Console.WriteLine($"{turn} : {a.nume} miss {b.nume}");
                Console.WriteLine(@"
 >()\ ()
 /\\/\//\
/\      /\");
               
            }
            else if (b.hp - (a.dmg * (a.crit / 100)) + b.def == b.hp)
            {
                
                Console.WriteLine($"{turn} : {a.nume} block {b.nume}");
                Console.WriteLine(@"
 >()\ ()
 /\\/\//\
/\      /\");
            }
            else if (b.hp - (a.dmg * (a.crit / 100)) + b.def <= 0)
            {
                b.hp = b.hp - (a.dmg * (a.crit / 100)) + b.def;
                Console.WriteLine($"{turn} : {a.nume} killed {b.nume} {b.hp} hp ");
                if (a.nume == "ninja")
                {
                    Console.WriteLine(@"
  >()/			
,_/||				
   /\    ==>o");
                }
                else
                {
                    Console.WriteLine(@"
   /
  / 
  \()/
   ||    
   /\    ==>o");
                }
            }
            else
            {
                

                
                Console.WriteLine($"{ turn} : {a.nume} hit  {b.nume} : - {(a.dmg * (a.crit / 100)) - b.def} hp");
                b.hp = b.hp - (a.dmg * (a.crit / 100)) + b.def;
                if (a.nume == "ninja")
                {
                    Console.WriteLine(@"
 >()   / () 
 /\\_,/-||-
/\      /\");
                }
                else
                {
                    Console.WriteLine(@"
>()     ()
 -||-___//\
  /\      /\");
                }
            }
            Console.WriteLine($"{a.nume} {a.hp} hp | {b.nume} {b.hp}");
            return b.hp;

        }
            
    }
}
