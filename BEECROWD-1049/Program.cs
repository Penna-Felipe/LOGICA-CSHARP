using System;

namespace BEECROOWD_1049
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string entrada1, entrada2, entrada3;

            entrada1 = Console.ReadLine();
            entrada2 = Console.ReadLine();  
            entrada3 = Console.ReadLine();

            entrada1 = entrada1.Trim().ToLower();
            entrada2 = entrada2.Trim().ToLower();
            entrada3 = entrada3.Trim().ToLower();

            switch (entrada1) {
                case "vertebrado":
                    switch (entrada2) {
                        case "ave": 
                            if (entrada3 == "carnivoro") {
                                Console.WriteLine("aguia");
                            }
                            else if (entrada3 == "onivoro") {
                                Console.WriteLine("pomba");
                            }
                            else {
                                Console.WriteLine("entrada 3 invalida");
                            }
                        break;
                        case "mamifero":
                            if (entrada3 == "onivoro") {
                                Console.WriteLine("homem");
                            }
                            else if (entrada3 == "herbivoro") {
                                Console.WriteLine("vaca");
                            }
                            else {
                                Console.WriteLine("entrada 3 invalida");
                            }
                        break;
                        default:
                            Console.WriteLine("entrada 2 invalida");
                        break;
                    }
                break;
                case "invertebrado":
                    switch (entrada2) {
                        case "inseto": 
                            if (entrada3 == "hematofago") {
                                Console.WriteLine("pulga");
                            }
                            else if (entrada3 == "herbivoro") {
                                Console.WriteLine("lagarta");
                            }
                            else {
                                Console.WriteLine("entrada 3 invalida");
                            }
                        break;
                        case "anelideo":
                            if (entrada3 == "hematofago") {
                                Console.WriteLine("sanguessuga");
                            }
                            else if (entrada3 == "onivoro") {
                                Console.WriteLine("minhoca");
                            }
                            else {
                                Console.WriteLine("entrada 3 invalida");
                            }
                        break;
                        default:
                            Console.WriteLine("entrada 2 invalida");
                        break;
                    }
                break;
                
            }
            
        }
    }
}
