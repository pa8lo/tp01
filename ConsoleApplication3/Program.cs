using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //ejercicio1();
            //ejercicio2();
            //ejercicio4();
            //var ejercicio1 = new Ejercicio3();
            //Console.WriteLine( ejercicio1.calculo("1+2555+2+3+2+2"));
            ejercicio5();
            Console.ReadKey();

        }
        static public void ejercicio1()
        {
            String nombre;
            String apellido;
            Console.WriteLine("Ingresa tu nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingresa tu edad");
            apellido = Console.ReadLine();
            Console.WriteLine("tu nombre es " + nombre + " " + apellido);
            Console.ReadKey();
        }
        static public void ejercicio2()
        {
            String nombre;
            String edad;
            Console.WriteLine("Ingresa tu nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingresa tu edad");
            edad = Console.ReadLine();
            if ( int.Parse(edad)< 18)
            {
                Console.WriteLine("menor de edad");
            }
            else
            {
                Console.WriteLine("mayor de edad");
            }
            Console.ReadKey();




        }
        static public void ejercicio4()
        {
            Console.WriteLine("ingrese un numero ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese otro numero");
            int numero2 = int.Parse(Console.ReadLine());
            if (numero1  < numero2  ){
                while(numero2%numero1 != 0.0)
                {
                    numero1 = numero2 / numero1;
                    
                }
                Console.WriteLine("el minimo comun divisor es " + numero1);
            }else
            {
                while (numero1 % numero2 != 0.0)
                {
                    numero2 = numero1 / numero2;
                }
                Console.WriteLine("el minimo comun divisor es " + numero2);
            }
            Console.ReadKey();


        }

        static public void ejercicio5()
        {
            List<int> numeros = new List<int>();
            Console.Write("ingresar numeros para sacar promedio finalizar ingresando el 0");
            int numero =int.Parse(Console.ReadLine());
            while (numero != 0)
            {
                numeros.Add(numero);
                numero = int.Parse(Console.ReadLine());
            }
            double promedio =-1 ;

            foreach (int number in numeros)
            {

                promedio += numero;

            }
            promedio = promedio / numeros.Count;
            Console.Write("el promedio es :" + promedio);


            

        }
         
    }
    public class Ejercicio3
    {
       public int calculo(String numerito)
        {
            String  []signo  = numerito.Split('+');
            int numero = 0;
            for(var i = 0; i < signo.Length; i++)
            {
                numero = int.Parse( signo[i]) + numero; 
            }
            
            return numero;
        }
    }
   

}
