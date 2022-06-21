using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeros
{
    class Program
    {
        public static void Main(string[] args)
        {
            string numero;
            int i;
            Entero num1;
            Fraccionario num2;
            Racional num3;
            Console.WriteLine("Ingrese un numero:");
            numero = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("1: Natural");
            Console.WriteLine("2: Entero");
            Console.WriteLine("3: Fraccionario");
            Console.WriteLine("4: Racional");
            i = Convert.ToInt32(Console.ReadLine());
            Console.Clear();            
            switch (i)
            {
                case 1:
                    if (numero.Contains("/") || numero.Contains("-") || numero.Contains(".") || numero.Contains("."))
                    {
                        Console.WriteLine("El numero no es natural");
                        Console.WriteLine("Presione una tecla para terminar");
                        Console.ReadKey(true);
                        Environment.Exit(0);
                    }
                    num1 = new Entero(Convert.ToInt32(numero));
                    if (num1.esNatural() == true)
                    {
                        Console.WriteLine("El numero es natural");
                        if (num1.esCompuesto() == true)
                            Console.WriteLine("El numero tambien es compuesto");
                        else if (num1.esPrimo() == true)
                            Console.WriteLine("El numero tambien es primo");
                        else if (num1.esUno() == true)
                            Console.WriteLine("El numero es 1");
                        Console.WriteLine("La suma es: " + num1.suma(2));
                        Console.WriteLine("La multiplicacion es: " + num1.multiplicacion(2));
                    }
                    else
                        Console.WriteLine("El numero no es natural");
                    break;
                case 2:
                    if (numero.Contains("/") || numero.Contains(".") || numero.Contains(","))
                    {
                        Console.WriteLine("El numero no es entero");
                        Console.WriteLine("Presione una tecla para terminar");
                        Console.ReadKey(true);
                        Environment.Exit(0);
                    }
                    num1 = new Entero(Convert.ToInt32(numero));
                    if (num1.esEntero() == true)
                    {
                        Console.WriteLine("El numero es entero");
                        if (num1.esNatural() == true && !numero.Contains("."))
                            Console.WriteLine("El numero tambien es natural");
                        if (num1.esNegativo() == true)
                            Console.WriteLine("El numero es negativo");
                        if (num1.esCero() == true)
                            Console.WriteLine("El numero es 0");
                        Console.WriteLine("La suma es: " + num1.suma(2));
                        Console.WriteLine("La multiplicacion es: " + num1.multiplicacion(2));
                        Console.WriteLine("La resta es: " + num1.resta(2));
                    }
                    else
                        Console.WriteLine("El numero no es entero");
                    break;
                case 3:
                    int numerador, denominador;
                    Entero numerador1 = new Entero();
                    Entero denominador1 = new Entero();
                    double cociente;
                    if(!numero.Contains("/"))
                    {
                        Console.WriteLine("El numero no es fraccionario");
                        Console.WriteLine("Presione una tecla para terminar");
                        Console.ReadKey(true);
                        Environment.Exit(0);
                    }
                    string[] fraccion = numero.Split('/');
                    numerador = Int32.Parse(fraccion[0]);
                    denominador = Int32.Parse(fraccion[1]);                   
                    cociente = (double)numerador / denominador;
                    numerador1.Valor = numerador;
                    denominador1.Valor = denominador;
                    num2 = new Fraccionario(numerador1,denominador1);
                    Console.WriteLine("El numero es fraccionario");
                    Console.WriteLine("El numerador es " + numerador);
                    Console.WriteLine("El denominador es " + denominador);
                    Console.WriteLine("El cociente es " + cociente);
                    Console.WriteLine("La parte entera es " + (int)cociente);
                    if (num2.esPeriodico() == true)
                        Console.WriteLine("El numero es periodico");
                    if (num2.esPeriodicoMixto() == true)
                        Console.WriteLine("El numero es periodico mixto");
                    if (num2.esPeriodicoPuro() == true)
                        Console.WriteLine("El numero es periodico puro");
                    break;
                case 4:
                    int numerador2, denominador2;
                    Entero numerador3 = new Entero();
                    Entero denominador3 = new Entero();
                    double numeradora;
                    if(numero.Contains("/"))
                    {
                        string[] fraccion1 = numero.Split('/');
                        numerador2 = Int32.Parse(fraccion1[0]);
                        denominador2 = Int32.Parse(fraccion1[1]);
                        numerador3.Valor = numerador2;
                        denominador3.Valor = denominador2;
                        num3 = new Racional(new Fraccionario(numerador3, denominador3));
                            Console.WriteLine("El numero es fraccionario");
                        if (num3.esRacional())
                            Console.WriteLine("El numero es racional");
                        if (num3.esIrracional())
                            Console.WriteLine("El numero es irracional");
                    }
                    else
                    {
                        numeradora = double.Parse(numero);
                        num3 = new Racional(numeradora);
                        if (num3.esFraccionario())
                            Console.WriteLine("El numero es fraccionario");
                        if (num3.esEntero())
                            Console.WriteLine("El numero es entero");
                        if (num3.esRacional())
                            Console.WriteLine("El numero es racional");
                        if (num3.esIrracional())
                            Console.WriteLine("El numero es irracional");
                    }
                    break;
            }
            Console.WriteLine("Presione una tecla para terminar");
            Console.ReadKey(true);
        }
    }
}
