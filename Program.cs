using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loopy_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare the planets and each gravity constent that goes with it
            double Mercury = 0.37;
            double Venus = 0.88;
            double Mars = 0.38;
            double Jupiter = 2.64;
            double Saturn = 1.15;
            double Uranus = 1.15;
            double Neptune = 1.12;
            double Pluto = 0.04;


            //Print out the list of planets
            Console.WriteLine("List of planet" + "\n" + "1.Mercury" + "  " + "2.Venus" + "  " + "3.Earth" + "  ");
            Console.WriteLine("\n" + "4.Mars" + "  " + "5.Jupiter" + "  " + "6.Saturn" + "  ");
            Console.WriteLine("\n" + "7.Uranus" + "  " + "8.Neptune" + "  " + "9.Quit" + "  ");


            int MenuChoice;
            int Weight;


            do
            {
                Console.Write("\n + Enter Your Menu Choice");

                MenuChoice = Convert.ToInt32(Console.ReadLine());


                Console.Write("\n + Enter Your Weight On Earth");

                Weight = Convert.ToInt32(Console.ReadLine());    

                switch (MenuChoice)
                 {
                    // For each case calculate the weight on another planet. ex. int 1 calculate the weight on mecury

                    case 1:
                        //declare the data types for the answer to be a double. Each planet will have a different answer variable
                        double Answer1 = (Mercury * Weight);

                        //Print end result
                        Console.WriteLine("Your weight of" + "" + Weight + "" + "pounds on Earth would be" + "" + Answer1 + "" + "pounds on Mercury");
                        break;
                    case2:
                        double Answer2 = (Venus * Weight);

                        Console.WriteLine("Your weight of" + Weight + "" + "pounds on Earth would be" + Answer2 + "pounds on Venus");
                        break;
                    case 3:
                        double Answer3 = (Mars * Weight);
                        Console.WriteLine("Your weight  of" + Weight + "pounds On Earth would be" + Answer3 + "pounds  on Mars");
                        break;
                    case 4:
                        double Answer4 = (Jupiter * Weight);
                        Console.Write("Your Weight of" + Weight + "pounds on Earth would be" + Answer4 + "pounds on Jupiter");
                        break;
                    case 5:
                        double Answer5 = (Saturn * Weight);
                        Console.WriteLine("Your Weight of" + Weight + "pounds on  Earth would be" + Answer5 + "pounds on Saturn");
                        break;
                    case 6:
                        double Answer6 = (Uranus * Weight);
                        Console.WriteLine("Your weight of" + Weight + "pounds on Earth would be" + Answer6 + "pounds on Uranus");
                        break;
                    case 7: double Answer7 = (Neptune * Weight);
                        Console.WriteLine("Your weight of" + Weight + "pounds on Earth would be" + Answer7 + "pounds on Neptune");
                        break;
                    case 8: double Answer8 = (Pluto * Weight);
                        Console.WriteLine("Your weight of " + Weight + "pounds on Earth would be" + Answer8 + "pounds on Pluto");
                          
        }

    }

        private static object ConsoleReadLine()
        {
            throw new NotImplementedException();
        }
    }
