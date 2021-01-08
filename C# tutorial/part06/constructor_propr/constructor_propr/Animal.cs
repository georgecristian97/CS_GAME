using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Xml.Schema;

namespace constructor_propr
{
    class Animal
    {
        protected string xt1; //acces cu metode in clasa si subclase publica in clasa curenta
        private string xt2;// poate fi schimbat cu metoda si subclasa publica in clasa curenta
        public string xt3;
        public const string xxt = "xfx";
        public string name;
        public string sound;
        public readonly int idn;

        public Animal()
            : this("No Name", "No Sunet") { }
        public Animal(string name)
            : this(name, "No sound") { }
        public Animal(string name, string sound)
        {
            SetName(name);
            Sound = sound;
            numOfAnimals = 1;
        }
        public string GEtname()
        { return name; }

        public string Sound
        {
            get { return sound; }
            set
            { if (value.Length > 10)
                {
                    sound = "No sound";
                    Console.WriteLine("Sound is too long");

                }
                sound = value; // value e default care stocheaza ce e in set
                        }

        }


        public string Owner { get; set; } = "No Ownre";
       
        public void SetName(string name)
        {
            if(!name.Any(char.IsDigit))
            {
                this.name = name;

            }
            else
            {
                this.name = "No name";
                Console.WriteLine("Name can't contain nr");

            }
        }
        public void facesunet()
        {
            Console.WriteLine("{0} say {1}",
                xt2, xt1);
        }

        public string constr(Animal x)
        {
            
            x.xt2 = x.xt2 + "_1_";
            return x.xt2;
        }
        public static void Sumat3(Animal x)
        {
            Console.WriteLine("{0}",x.xt3);
        }
        public static void Sumat2(Animal x)
        {
            Console.WriteLine("{0}", x.xt2);
        }
        public static void Sumat1(Animal x)
        {
            Console.WriteLine("{0}", x.xt1);
        }

        // You can also define static properties
        public static int numOfAnimals = 0;

        public static int NumOfAnimals
        {
            get { return numOfAnimals; }
            set { numOfAnimals += value; }
        }
    }

  
}
