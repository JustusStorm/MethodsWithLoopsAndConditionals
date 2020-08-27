using System;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
using System.Reflection;
using System.Dynamic;
using System.Collections.Generic;

namespace MethodsWithLoopsAndConditionals
{
    class Program
    {

        static void Main(string[] args)
        {
            
            LukeWarm1();
            ToContinue();
            Console.Clear();

            LukeWarm2();
            ToContinue();
            Console.Clear();
            
            LukeWarm3();
            ToContinue();
            Console.Clear();
            
            LukeWarm4();
            ToContinue();
            Console.Clear();
            
            LukeWarm5();
            ToContinue();
            Console.Clear();

            LukeWarm6();
            ToContinue();
            Console.Clear();

            HeatingUp1();
            ToContinue();
            Console.Clear();

            HeatingUp2();
            ToContinue();
            Console.Clear();
            

            List <int> numsList = HeatingUp3();
            ToContinue();
            Console.Clear();

            HeatingUp4(numsList);
            ToContinue();
            Console.Clear();

            
            Heatingup5();
            ToContinue();
            Console.Clear();

        }    








        
        
        public static void ToContinue()
        {
            Console.WriteLine("\n\n\nPress any key to continue...");
            Console.ReadKey();
        }

        public static void LukeWarm1()
        {
            // Write a method that will print to the console all numbers 1000 through -1000.
            var num = 1000; 
            while (num >= -1000)
            {
                Console.WriteLine(num);
                num--;
            }
        }

        public static void LukeWarm2()
        {
            // Write a method that will print to the console numbers 3 through 999 by 3 each time.
            for (var num = 3; num <= 999; num += 3)
            {
                Console.WriteLine(num);
            }

        }

        public static void LukeWarm3()
        {
            Console.WriteLine("Input 2 numbers, characters, or words and I will tell you if they are equal...");
            Console.WriteLine("\n Input the 1st number, character, or word   and press Enter.");
            Console.Write("> ");
            var num1 = Console.ReadLine();
            Console.WriteLine(" Input the 2nd number and press Enter.");
            Console.Write("> ");
            var num2 = Console.ReadLine().Trim();
            // Write a method to accept two integers as parameters and check whether they are equal or not.
            bool condition = num1 == num2;
            Console.WriteLine(condition ? $"\n{num1} and {num2} are equal \n" : $"\n{num1} and {num2} are NOT equal \n");
        }

        public static void LukeWarm4()
        {
            // Write a method to check whether a given number is even or odd.
            bool repeat = true;
            int numInteger;
            double numDouble;

            Console.WriteLine("Enter a number. I will tell you if it is even or odd.");
            
            do
            {
                Console.Write(">");
                string userInput = Console.ReadLine().Trim();
                
                if (int.TryParse(userInput, out numInteger))
                {
                    if (numInteger % 2 == 0)
                    {
                        Console.WriteLine("Your number is EVEN.");
                        repeat = false;
                    }
                    else
                    {
                        Console.WriteLine("Your number is ODD.");
                        repeat = false;
                    }
                    
                }
                else if (double.TryParse(userInput, out numDouble))
                {

                    Console.WriteLine("Your input is a decimal, which techincally can't be even or odd.");
                    Console.WriteLine("Do you want to enter a different number? yes/no");
                    Console.Write("> ");
                    string newNum = Console.ReadLine().Trim().ToLower(); 
                    if (newNum[0] == 'y')
                    {
                        Console.WriteLine("\nPlease enter another number");
                        repeat = true;
                    }
                    else
                    {
                        repeat = false;
                    }

                   
                }
                else
                {
                    Console.WriteLine("Incorrect input. Please input a whole number.");
                }
            } while (repeat == true);



            // **************** JOHNS CODE FOR REFERENCE ON HANDLING WRONG INPUTS AND INPUT TYPES **************


            //int numInteger;
            //double numDouble;
            //bool conditional = true;

            //while (conditional)
            //{
            //    Console.WriteLine("please enter a number");
            //    var userInput = Console.ReadLine();

            //    if (int.TryParse(userInput, out numInteger))
            //    {
            //        if (numInteger % 2 == 0)
            //        {
            //            Console.WriteLine("This is an even number");
            //            conditional = false;
            //        }
            //        else
            //        {
            //            Console.WriteLine("This is an odd number");
            //            conditional = false;
            //        }
            //    }
            //    else if (double.TryParse(userInput, out numDouble))
            //    {
            //        if (numDouble % 2 == 0)
            //        {
            //            Console.WriteLine("This is an even number");
            //            conditional = false;
            //        }
            //        else
            //        {
            //            Console.WriteLine("This is an even number");
            //            conditional = false;
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Please enter a valid number");
            //        Console.WriteLine();
            //    }
            //}
        }

        public static void LukeWarm5()
        {
            // Write a method to check whether a given number is positive or negative.
            /*
            Console.WriteLine("I'm going to tell you if a number is positive or negative\n");
            Console.WriteLine("Type a number and press enter.");
            Console.Write(">");
            var userInput = Convert.ToInt32(Console.ReadLine().Trim());
            Console.WriteLine((userInput > 0) ? "\nThe number you provided is POSITIVE." : "\nThe number you provided is NEGATIVE.");
            */


            bool repeat = true;
            int numInteger;
            double numDouble;

            Console.WriteLine("I'm going to tell you if a number is positive or negative\n");
            Console.WriteLine("Type any number and press Enter.");

            do
            {
                Console.Write(">");
                string userInput = Console.ReadLine().Trim();

                if (int.TryParse(userInput, out numInteger))
                {
                    if (numInteger > 0)
                    {
                        Console.WriteLine("Your number is POSITIVE.");
                        repeat = false;
                    }
                    else
                    {
                        Console.WriteLine("Your number is NEGATIVE.");
                        repeat = false;
                    }

                }
                else if (double.TryParse(userInput, out numDouble))
                {
                    if (numInteger > 0)
                    {
                        Console.WriteLine("Your number is POSITIVE.");
                        repeat = false;
                    }
                    else
                    {
                        Console.WriteLine("Your number is NEGATIVE.");
                        repeat = false;
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect input. Please input a number.");
                }
            } while (repeat == true);



        }

        public static void LukeWarm6()
        {
            Console.WriteLine("In order to vote, you must reach a certain age. Enter your age below and we will determine if you can vote:");
            Console.Write(">");
            var inputAge = Console.ReadLine();
            int parseAge;

            if (int.TryParse(inputAge, out parseAge))
            {
                if (parseAge >= 18)
                {
                    Console.WriteLine($"\nSince you are {parseAge} years old, you are over the age of 18. You can find a voting booth closest to your city online.");
                }
                else
                {
                    Console.WriteLine($"\nYou are too young to vote. I'm sorry.");
                }
            }
            else
            {
                Console.WriteLine("\nI couldn't understand your input. You will have to go to the back of the line so we can help the next customer.\n" +
                    "Maybe when I see you again, you can tell me your correct age. Now move aside. Thank you.");
            }

        }


        public static void HeatingUp1()
        {
            var repeat = true;
            Console.WriteLine("Give me a number and hit Enter, I'll tell you if it is between -10 and 10.");
            do
            {
                Console.Write(">");
                var input = Console.ReadLine();
                double parseNum;

                if (double.TryParse(input, out parseNum))
                {
                    if (parseNum < 10 && parseNum > -10)
                    {
                        Console.WriteLine("\nYour number is between -10 and 10.");
                        repeat = false;
                    }
                    else
                    {
                        Console.WriteLine("\nYour number isn't between -10 and 10.");
                        repeat = false;
                    }
                }
                else
                {
                    Console.WriteLine("\nIncorect input. Please input a number.");
                }

            } while (repeat == true);
        }


        public static void HeatingUp2()
        {
            var repeat = true;
            double parseNum;
            Console.WriteLine("Now, I know math is hard. Multiplication tables are hard to remember.\n" +
                "Give me a number and ill show you the mulitplication table of that number up to 12.");
            do
            {

                Console.Write(">");
                var input = Console.ReadLine();
                if (double.TryParse(input, out parseNum))
                {
                    for (var i = 1; i <= 12; i++)
                    {
                        if (i == 1)
                        {
                            Console.WriteLine("");
                        }
                        var multiTable = i * parseNum;
                        Console.WriteLine(multiTable);
                    }

                    repeat = false;
                }
                else
                {
                    Console.WriteLine("Incorrect input. Try again");
                }

            } while (repeat == true);
        }

        public static List<int> HeatingUp3()
        {
            var repeat = true;
            double parseNum;
            Random rand = new Random();
            List <int> numsList = new List<int>(); 

            Console.WriteLine("I know I've been asking you to give me a bunch of numbers for different things...\n" +
                "But I'm going to need more from you (lol).\n" +
                "\n" +
                "Input a number and press Enter, and I will give you a list with an amount of random numbers\n" +
                "according to your input.");
            do
            {
                Console.Write(">");
                var input = Console.ReadLine();

                if (double.TryParse(input, out parseNum))
                {
                    for(var i = 0; i < parseNum; )
                    {
                        if (i == 0) 
                        {
                            Console.WriteLine("\n");
                            Console.WriteLine("\tYour Number List:");
                        }
                        numsList.Add(rand.Next(0,1000));
                        Console.Write("Index: " + i + "\t");
                        Console.Write(numsList[i] + "\n");
                        i++;
                    }
                    repeat = false;

                    
                }
                else
                {
                    Console.WriteLine("\nIncorrect input. Try again.");
                }

            } while (repeat);
            
            return numsList;
        }

        
        public static void HeatingUp4(List<int> list)
        {
            int sum = 0;
            Console.WriteLine("Do you remember when I just asked you to give me a number,\n" +
                "and that I would create a list of random numbers as long as the number you\n" +
                "provided? Well that actually will be used on this next exercise!\n" +
                "I'm about to get the sum of all those numbers in that list for ya\n" +
                "(who else do you know is this cool? lol just kidding).\n");
           
            Console.WriteLine("\n Press Enter when your ready to calculate the sum of the\n" +
                "last exercises list...");
            Console.ReadKey();
            
            Console.WriteLine("Just to prove to you I'm right, here are the numbers in the list I'll be using:\n" +
                "(these are the same as the list recieved from the last exercise)");
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("\tYour Number List:");
            for (var i = 0; i < list.Count; i++)
            {
                Console.Write("Index: " + i + "\t");
                Console.Write(list[i] + "\n");
                sum = sum + list[i];
            }
            Console.WriteLine($"\nTotal Sum of list: {sum}");
        }

        public static void Heatingup5()
        {
            var repeat = true;
            int numParse;
            Console.WriteLine("This is the last exercise. Just enter a whole number, and I'll show you every number consecutivly, cubed,\n" +
                "up to the number you give me.");
            Console.WriteLine("Enter a whole number and press Enter.");

            do
            {
                Console.Write(">");
                var input = Console.ReadLine();

                if (int.TryParse(input, out numParse))
                {
                    for (var i = 0; i <= numParse; i++)
                    {
                        if (i == 0)
                        {
                            Console.WriteLine("\tYour cubed  list:");
                            continue;
                        }
                        var cubed = i * i * i;
                        Console.WriteLine($"Number is: {i}   and the cube of {i} is: {cubed}");
                    }

                    repeat = false;
                }
                else
                {
                    Console.WriteLine("Incorrect input. Try again.");
                }





            } while (repeat);
        
        
        
        
        
        }





    }
}
