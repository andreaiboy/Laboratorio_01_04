using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_01_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Andrea Iboy 1076623");

            // Ejercicio 1

            Console.WriteLine("Ejercicio 1: Operaciones Aritmeticas");

            Console.Write("Ingrese un numero: ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese otro numero: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            int suma = n1 + n2;
            int resta = n1 - n2;
            int multiplicacion = n1 * n2;

            double div1 = n1;



            double division = div1 / n2;
            int divOperacion = n1 / n2;
            int resto = n1 % n2;

            Console.WriteLine(n1 + "+" + n2 + "=" + suma);
            Console.WriteLine(n1 + "-" + n2 + "=" + resta);
            Console.WriteLine(n1 + "*" + n2 + "=" + multiplicacion);
            Console.WriteLine(n1 + "/" + n2 + "=" + division);
            Console.WriteLine(n1 + "/" + n2 + "=" + divOperacion);
            Console.WriteLine(n1 + "%" + n2 + "=" + resto);


            // Ejercicio 2
            Console.WriteLine("");
            Console.WriteLine("Ejercicio 2: Operaciones Booleanas");

            bool mayorQue = n1 > n2;
            bool menorQue = n1 < n2;
            bool igualQue = n1 == n2;
            string valorBooleano = "";
            string valorBooleano2 = "";
            string valorBooleano3 = "";

            // condicion 1
            if (mayorQue)
            {
                valorBooleano = "Verdadero";
            }
            else
            {
                valorBooleano = "Falso";
            }
            // condicion 2
            if (menorQue)
            {
                valorBooleano2 = "Verdadero";
            }
            else
            {
                valorBooleano2 = "Falso";
            }

            // condicion 3

            if (igualQue)
            {
                valorBooleano3 = "Verdadero";
            }
            else
            {
                valorBooleano3 = "Falso";
            }

            Console.WriteLine("es " + n1 + " mayor que " + n2 + " ? R// " + valorBooleano);
            Console.WriteLine("es " + n1 + " menor que " + n2 + " ? R// " + valorBooleano2);
            Console.WriteLine("es " + n1 + " igual que " + n2 + " ? R// " + valorBooleano3);

            // Ejercicio 3

            Console.WriteLine("");
            Console.WriteLine("Ejercicio 3: Jerarquia de operaciones");

            int a;
            int b;
            int c;

            Console.WriteLine("Ingrese el primer numero a operar");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero a operar");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el tercer numero a operar");
            c = int.Parse(Console.ReadLine());

            double aDouble = a;
            double bDouble = b;
            double cDouble = c;

            int primeraOperacion = (a * b) + c;
            int segundaOperacion = (b + c) * a;
            double terceraOperacion = aDouble / (bDouble * cDouble);
            double cuartaOperacion = ((3 * aDouble) + (2 * bDouble)) / Math.Pow(cDouble, 2);

            Console.WriteLine("a * b + c = " + primeraOperacion);
            Console.WriteLine("a * (b + c) = " + segundaOperacion);
            Console.WriteLine("a / b * c = " + terceraOperacion);
            Console.WriteLine("3*a + 2*b / C^2 = " + cuartaOperacion);


            // Ejercicio 3 pero con formula de bhaskara
            Console.WriteLine("");
            Console.WriteLine("El resultado de la formula de bhaskara es");
            Console.WriteLine("");

            double determinante = Math.Sqrt(Math.Pow(5, 2) - (4 * a * c));

            double x1 = (-bDouble + determinante) / (2 * a);
            //truncate para reducir decimales
            double x1TwoDecimals = (Math.Truncate(x1 * 100) / 100);

            double x2 = (-bDouble - determinante) / (2 * a);
            double x2TwoDecimals = (Math.Truncate(x2 * 100) / 100);

            Console.WriteLine(x1TwoDecimals);
            Console.WriteLine(x2TwoDecimals);

            Console.ReadLine();



        }
    }
}