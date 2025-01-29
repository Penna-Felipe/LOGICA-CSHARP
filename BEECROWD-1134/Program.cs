using System;

namespace BEECROWD_1134
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int entrada, escolha, alcool, gasolina, diesel;

            alcool = 0;
            gasolina = 0;
            diesel = 0;

            do
            {
                entrada = int.Parse(Console.ReadLine());
                switch(entrada)
                {
                    case 1:
                        alcool += 1;
                    break;

                    case 2:
                        gasolina += 1;
                    break;

                    case 3:
                        diesel += 1;
                    break;

                    case 4: 
                        Console.WriteLine("MUITO OBRIGADO");
                    break;
                }


            } while (entrada != 4);

            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}