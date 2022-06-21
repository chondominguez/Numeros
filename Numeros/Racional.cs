using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Numeros
{
    public class Racional 
    {
        private double decimall;
        private Fraccionario fraccionario = new Fraccionario();

        public Racional() { }

        public Racional(Fraccionario fraccionario)
        {
            this.decimall = (double)fraccionario.NUMERADOR / fraccionario.DENOMINADOR;
        }

        public Racional(double decimall)
        {
            this.decimall = decimall;
        }

        public double Decimall
        {
            get => this.decimall;
            set => this.decimall = value;
        }

        public bool esFraccionario() => decimall.ToString().Contains(',') ;

        public bool esEntero() => !esFraccionario();
      
        public bool esRacional() => fraccionario.esPeriodicoMixto() || fraccionario.esPeriodicoPuro() || esEntero() || esFraccionario();

        public bool esIrracional() => !esRacional();

    }
}
