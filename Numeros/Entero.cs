using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeros
{
    public class Entero : Natural
    {
        public Entero(int num) : base(num) { }      
        public int Valor
        {
            get { return this.num; }
            set { this.num = value; }
        }
        public Entero() { }
        public bool esEntero() => num >= 0 || num < 0;
        public bool esCero() => num == 0;
        public bool esNegativo() => num < 0;
        public int resta(int num2) => num - num2;
    }
}
