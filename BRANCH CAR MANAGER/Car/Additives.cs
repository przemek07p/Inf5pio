using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRANCH_CAR_MANAGER
{
    class Klimatyzacja : Dekorator
    {
        Samochod car;

        public Klimatyzacja(Samochod samochod)
        {
            car = samochod;
        }

        public override String about()
        {
            return car.about() + " + klimatyzacja";
        }

        public override double cena()
        {
            if (car is Mercedes)
            {
                return car.cena() + 100000;
            }
            else if (car is Fiat)
            {
                return car.cena() + 20000;
            }
            return 0;
        }
    }

    class OponyZimowe : Dekorator
    {
        Samochod car;

        public OponyZimowe(Samochod samochod)
        {
            car = samochod;
        }

        public override String about()
        {
            return car.about() + " + opony zimowe";
        }

    
        public override double cena()
        {
            return car.cena() + 31234;
        }
    }
}
