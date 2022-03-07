using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRANCH_CAR_MANAGER
{
    class Mercedes : Samochod
    {

        public Mercedes()
        {
            samochod = "Mercedes";
        }

        public override double cena()
        {
            return 500000;
        }
    }

    class Fiat : Samochod
    {

        public Fiat()
        {
            samochod = "Fiat";
        }

        public override double cena()
        {
            return 100000;
        }
    }
}
