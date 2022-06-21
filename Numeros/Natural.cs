using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeros
{
    public class Natural
    {
        public int i, a, num;
        public Natural(int num)
        {
            this.num = num;
        }
        public Natural() { }
        public int NUM
        {
            get { return this.num; }
            set { this.num = value; }
        }
        public bool esNatural() => num > 0;
        public bool esUno() => esNatural() == true && num == 1;
        public bool esPrimo()
        {
            for (i = 1; i <= num; i++)
            {
                if (num % i == 0)
                    a++;
            }
            if (a == 2)
                return esNatural() == true;
            else
                return false;
        }
        public bool esCompuesto() => esNatural() == true && num > 1 && esPrimo() == false;
        public int suma(int num2) => num + num2;
        public int multiplicacion(int num2) => num * num2;
    }
}
