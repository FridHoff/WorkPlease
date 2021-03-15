using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabotai
{
    class Count
    {
        string name;
        int number;
        double sum;
        Count()
        {
            this.name = "Счёт";
            this.number = 1;
            this.sum = 0;
        }
        Count(string cName, int cNumber, double cSum)
        {
            this.name = cName;
            this.number = cNumber;
            this.sum = cSum;
        }
    }
}
