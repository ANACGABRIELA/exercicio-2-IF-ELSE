using System;

namespace exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {

            double ladoa, ladob, ladoc; 
           

            Console.WriteLine("Informe o valor do lado a");
            ladoa = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o valor do lado b");
            ladob = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o valor do lado c");
            ladoc = Convert.ToDouble(Console.ReadLine());


            if (ladoa + ladob >= ladoc)
            {

                if ((ladoa == ladob) && (ladob == ladoc))
                {

                    Console.WriteLine("triangulo equilatero");

                }
                else if ((ladoa == ladob) || (ladob == ladoc) || (ladoa == ladoc))
                {
                    Console.WriteLine("triangulo isosceles");

                }
                else
                {

                    Console.WriteLine("triangulo escaleno");
                }
            }
            else { Console.WriteLine("nao forma um triangulo"); }
        }



    }
    }

