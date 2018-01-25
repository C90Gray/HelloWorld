﻿




using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)

        {
            //Part One: Greetings Statement

            //string messageOne = "Hello World!";
            //string messageTwo = "I am Spartacus";

            //////Part Two: Initial Spartacus attributes

            int ageOne = 35;
            int ageTwo = 45;
            int ageThree = 80;
            double heightOne = 72.50;
            double heightTwo = 91.45;
            float weightOne = 210.0284606f;
            float weightTwo = 331.12345678f;
            bool isGodLikeOne = true;
            bool isGodLikeTwo = false;
            char genderMale = 'M';
            char genderFemale = 'F';
            //Part Three: Display variable values

            //Console.WriteLine(messageOne);
            //Console.WriteLine(messageTwo);

            ////Part Four: Mathematical operator, bool and char examples

            //Console.WriteLine(ageOne + ageTwo);//Addition example
            //Console.WriteLine(heightOne - heightTwo);//Subtraction example
            //Console.WriteLine(weightOne * weightTwo);//Multiplication example
            //Console.WriteLine(isGodLikeOne); //Bool example
            //Console.WriteLine(genderMale);//Char example

            ////Part Five: Variable assignment

            //ageTwo = 70;
            //heightTwo = 35.12345f;
            //weightTwo = -429.1234573f;

            ////Part Six: Mathematical operator examples

            //Console.WriteLine(ageOne + ageTwo);
            //Console.WriteLine(heightOne - heightTwo);
            //Console.WriteLine(weightOne * weightTwo);
            //Console.WriteLine(ageTwo / ageOne);
            //Console.WriteLine(ageTwo % ageOne);
            //Console.WriteLine(ageThree / ageOne);
            //Console.WriteLine(ageThree % ageOne);

            ////Part Seven: Increment and decrement operator examples

            //ageTwo++;
            //Console.WriteLine(ageTwo);
            //ageTwo--;
            //Console.WriteLine(ageTwo);
            //Console.WriteLine("5" == "5"); ////this is a bool
            //Console.WriteLine(40 != 40); ////! means "is not"
            //Console.WriteLine(11 < 4);

            ////Part Eight: Concatenation example

            //Console.WriteLine(messageOne + " " + messageTwo + ".");
            //Console.WriteLine("I am " + ageOne + " years old, and yes it's " + isGodLikeOne + " I am godlike.");
            //Console.WriteLine("I weigh around " + weightOne + " pounds, and I am around " + heightOne + " inches tall.");

            ////Indexing always starts with 0. Use curly brackets to lable index numbers
            //Console.WriteLine("I am {0} years old, and yes it's {1} I am godlike.", ageOne, isGodLikeOne);
            //Console.WriteLine("I weigh around {0} pounds, and I am around {1} inches tall.", weightOne, heightOne);

            ////Part Nine: String equality examples
            //Console.WriteLine(messageTwo.Equals(messageOne));//returns boolian just like x==y
            //Console.WriteLine(messageTwo.Equals("I am Spartacus"));//returns boolian just like x==y        
            ////Just In Case (haha punny)
            //string myGreeting = "Hello";
            //Console.WriteLine(myGreeting.ToUpper());
            //Console.WriteLine(myGreeting.ToLower());
            //Console.WriteLine(myGreeting);

            ////Part Ten: String length examples
            //int messOneLength = messageOne.Length;
            //int messTwoLength = messageTwo.Length;

            //Console.WriteLine("The lenghth of messageOne is " + messageOne.Length);
            //Console.WriteLine("The lenghth of messageTwo is " + messageTwo.Length);
            //Console.WriteLine("The lenghth of messageOne is " + messOneLength);
            //Console.WriteLine("The lenghth of messageTwo is " + messTwoLength);

            ////PArt Eleven: conditional examples
            //string city1 = "Vesuvius";
            //string city2 = "Nola";
            //string city3 = "Nuceria";
            //int city1Distance, city2Distance, city3Distance;

            ////Solicit user input example
            //Console.WriteLine("What is the distance to {0}", city1);
            //city1Distance = int.TryParse (Console.ReadLine());
            //Console.WriteLine("What is the distance to " + city2 + "?");
            //city2Distance = int.TryParse(Console.ReadLine());
            //Console.WriteLine("What is the distance to Nuceria?");
            //city3Distance = int.TryParse(Console.ReadLine());

            //if ((city1Distance <= 125) && ((city1Distance < city2Distance) && (city1Distance < city3Distance)))
            //{
            //    Console.WriteLine("We will march to Versuvius");
            //}
            //if ((city2Distance <= 125) && ((city2Distance < city1Distance) && (city2Distance < city3Distance)))
            //{
            //    Console.WriteLine("We will march to Nola");
            //}
            //if ((city3Distance <= 125) && ((city3Distance < city2Distance) && (city3Distance < city1Distance)))
            //{
            //    Console.WriteLine("We will march to Nuceria");
            //}

            //Part Twelve: IF Else statements
            //Console.WriteLine("What is your rank soldier?");
            //string rank = Console.ReadLine().ToLower();

            //Console.WriteLine("What is your age soldier?");
            //int age = int.Parse(Console.ReadLine());

            //Console.WriteLine("What is your job soldier?");
            //string job = Console.ReadLine().ToLower();

            //if ((rank == "officer") || (age <= 26))
            //{
            //    Console.WriteLine("Get your gear, kiss your family goodbye, put on your marching boots.");
            //}
            //else if ((job == "cook") && (age >= 26))
            //{
            //    Console.WriteLine("My army has to eat. Pack your pots and pans.");
            //}
            //else
            //{
            //    Console.WriteLine("Sorry you are staying home.");
            //}

            //switch (job)
            //{
            //    case "infantry":
            //        Console.WriteLine("You will carry a sword.");
            //        break;

            //    case "archers":
            //        Console.WriteLine("You will carry a bow and arrow.");
            //        break;

            //    case "supply":
            //        Console.WriteLine("You will carry pots and pans.");
            //        break;

            //    case "specialist":
            //        Console.WriteLine("You will operate the catapault.");
            //        break;

            //    default:
            //        Console.WriteLine("You will ride horseback.");
            //        break;
            //}

            //Part Thirteen: Array examples
            //string[] foodList = new string[5];
            //foodList[0] = "Milk";
            //foodList[1] = "Fruit";
            //foodList[2] = "Meat";
            //foodList[3] = "Wine";
            //foodList[4] = "Bread";
            //Console.WriteLine("{0}, {1}, {2}, {3}, {4},", foodList[0], foodList[1], foodList[2], foodList[3], foodList[4]);

            //int[] foodAmount = new int[5];
            //foodAmount[0] = 1000;
            //foodAmount[1] = 100;
            //foodAmount[2] = 2000;
            //foodAmount[3] = 10000;
            //foodAmount[4] = 1500;
            //Console.WriteLine("{0}, {1}, {2}, {3}, {4}", foodAmount[0], foodAmount[1], foodAmount[2], foodAmount[3], foodAmount[4]);
            //int[] foodAmount = new int[] { 1000, 100, 2000, 10000, 1500 };
            //Console.WriteLine(foodAmount[0] + ", " + foodAmount[1] + ", " + foodAmount[2] + ", " + foodAmount[3] + ", " + foodAmount[4]);

            //Console.WriteLine(foodList[0] + ": " + foodAmount[0] + " " + foodList[1] + ": " + foodAmount[1] + " " + foodList[2] + ": " + foodAmount[2] + " " + foodList[3] + ": " + foodAmount[3] + " " + foodList[4] + ": " + foodAmount[4]);

            //Console.WriteLine(foodList.Length);

            //string[] elements = messageTwo.Split(' ');
            //Console.WriteLine(elements[0]);
            //Console.WriteLine(elements[1]);
            //Console.WriteLine(elements[2]);

            //string myName = "SUE";
            //myName.ToLower();
            //Console.WriteLine(myName);
            //char[] letters = myName.ToCharArray();
            //Console.Write(letters[0]);
            //Console.Write(letters[1]);
            //Console.WriteLine(letters[2]);

            // Part Fourteen while loop example
            //string action = " ";
            //while (action != "exit")
            //{
            //    Console.WriteLine("What is your rank soldier?");
            //    string rank = Console.ReadLine();

            //    Console.WriteLine("What is your age soldier?");
            //    int age = int.Parse(Console.ReadLine());
            //    Console.WriteLine("What is your job soldier?");
            //    string job = Console.ReadLine();

            //    if ((rank == "officer") || (age <= 26))
            //    {
            //        Console.WriteLine("Get your gear, kiss your family goodbye, put on your marching boots.");
            //    }
            //    else if ((job == "cook") || (age >= 26))
            //    {
            //        Console.WriteLine("My army has to eat. Pack your pots and pans");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Sorry you are staying home.");
            //    }
            //    Console.WriteLine("Add another? Type exit to quit");
            //    action = Console.ReadLine().ToLower(); //Important to have to reassign action and either continue or break the loop
            //}

            //string action = " ";
            //do
            //{
            //    Console.WriteLine("What is your rank soldier?");
            //    string rank = Console.ReadLine();

            //    Console.WriteLine("What is your age soldier?");
            //    int age = int.Parse(Console.ReadLine());
            //    Console.WriteLine("What is your job soldier?");
            //    string job = Console.ReadLine();

            //    if ((rank == "officer") || (age <= 26))
            //    {
            //        Console.WriteLine("Get your gear, kiss your family goodbye, put on your marching boots.");
            //    }
            //    else if ((job == "cook") || (age >= 26))
            //    {
            //        Console.WriteLine("My army has to eat. Pack your pots and pans");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Sorry you are staying home.");
            //    }
            //    Console.WriteLine("Add another? Type exit to quit");
            //    action = Console.ReadLine().ToLower();
            //} while (action != "exit");

            //For Loops
            //went way overboard and created an app for a grocery list
            //Console.WriteLine("\t\t\t\tGrocery List Generator \n\n");
            //Console.WriteLine("Please enter an amout of grocery items to get.");
            //int items = int.Parse(Console.ReadLine());

            //string[] foodList = new string[items];

            //int[] foodAmount = new int[items];

            //string[] foodAmountUnit = new string[items];

            //for (int i = 0; i < foodList.Length; i++)
            //{
            //    Console.WriteLine("Please enter a grocery item");
            //    foodList[i] = Console.ReadLine().ToLower();
            //}

            //for (int i = 0; i < foodAmountUnit.Length; i++)
            //{
            //    Console.WriteLine("Please enter the unit of measurment for " + foodList[i]);
            //    foodAmountUnit[i] = Console.ReadLine().ToLower();
            //}

            //for (int i = 0; i < foodAmount.Length; i++)
            //{
            //    Console.WriteLine("Please enter the number of " + foodAmountUnit[i] + " needed of " + foodList[i]);
            //    foodAmount[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("");
            //Console.WriteLine("Grocery List:");
            //Console.WriteLine("");

            //for (int i = 0; i < foodList.Length; i++)
            //{
            //    Console.WriteLine(foodAmount[i] + " " + foodAmountUnit[i] + " of " + foodList[i]);
            //}

            //Part Fifteen Methods

            
                ageOne = 35;
               /* bool isGodLike = true;*/ // I am not showing all the code.
                isGodLikeOne = IsGodLike(ageOne);
                Console.WriteLine("To say our hero is God like is " + isGodLikeOne);
            }
            static bool IsGodLike(int age)
            {
                bool status;
                if (age % 2 == 0)
                {
                    status = false;
                }
                else
                {
                    status = true;
                }
                return status;
            }



        }

    }



