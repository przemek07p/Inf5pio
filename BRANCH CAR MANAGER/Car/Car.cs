using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRANCH_CAR_MANAGER
{
 
    abstract class Samochod
    {
        protected string samochod = "Samochod podstawowy";

        virtual public String about()
        {
            return samochod;
        }

        public abstract double cena();
    }
 
    abstract class Dekorator : Samochod
    {
        public abstract override String about();
    }

  

  
   


    public class Application
    {
        public static void Main(String[] args)
        {
            Samochod s1 = new Mercedes();
            Samochod s2 = new Fiat();

            Console.WriteLine("\nBez wyposazenia");
            Console.WriteLine(s1.about() + " " + s1.cena());
            Console.WriteLine(s2.about() + " " + s2.cena());

         

            s1 = new Klimatyzacja(s1);
            s2 = new Klimatyzacja(s2);
            Console.WriteLine("\nZ Klima");
            Console.WriteLine(s1.about() + " " + s1.cena());
            Console.WriteLine(s2.about() + " " + s2.cena());

    

            s1 = new OponyZimowe(s1);
            s2 = new OponyZimowe(s2);
            Console.WriteLine("\nZ oponami");
            Console.WriteLine(s1.about() + " " + s1.cena());
            Console.WriteLine(s2.about() + " " + s2.cena());

          
            Console.WriteLine("\nPelne wyposazenie");
            Samochod s3 = new OponyZimowe(new Klimatyzacja(new Mercedes()));
            Console.WriteLine(s3.about() + " " + s3.cena());
            Console.ReadLine();
        }
    }
}