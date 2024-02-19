namespace Bacud_Machine_Problem_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Some Variable Declaration
            int op = -1;
            Random rnd = new Random();
            int dig2 = 9; 
            int dig2sec = 9;

            // Side note: dig3 and dig4 was put just in case of any conflicts

            int dig3 = 99;
            int dig3sec = 99; 
            int dig4 = 999;
            int dig4sec = 999;

            // For answers and counting of right answers

            int answer = 0;
            int correct = 0;

            // While loop to enable fast reset when wrong input in difficulty selection

            while (true)
            {
                // Difficulty Selection
                Console.WriteLine("Welcome to the Math Quiz Bee!");

                Console.WriteLine("");
                Console.WriteLine("Please select your difficulty by inputting the corresponding number:");
                Console.WriteLine("[1] EASY (25 Questions, 2 Digits)\n[2] MEDIUM (15 Questions, 3 Digits) \n[3] HARD (10 Questions, 4 Digits");

                Console.WriteLine("");
                Console.Write("Input: ");
                int diff = int.Parse(Console.ReadLine());

                //Operations (For Easy Mode)

                if (diff == 1)
                {
                    Console.WriteLine("");
                    Console.WriteLine("You have chosen the Easy Difficulty");
                    Console.WriteLine("");

                    for (int x = 1; x <= 25; x++)
                    {

                        // Random Number Generator

                        op = rnd.Next(0, 4);
                        dig2 = rnd.Next(10, 100);
                        dig2sec = rnd.Next(10, 100);


                        // Operations
                        switch (op)
                        {
                            case 0:
                                Console.WriteLine("Problem " + x + ": ADDITION");
                                Console.WriteLine("");
                                Console.WriteLine("Question: What is " + dig2 + " + " + dig2sec + "?");
                                Console.WriteLine("");
                                Console.Write("Input your answer here: ");

                                answer = int.Parse(Console.ReadLine());

                                if (answer == dig2 + dig2sec)
                                {
                                    correct++;
                                    Console.WriteLine();
                                    Console.WriteLine("Correct! Next Question");
                                    Console.WriteLine();
                                }
                                else
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Incorrect!");
                                    Console.WriteLine();
                                }
                                break;

                            case 1:
                                Console.WriteLine("Problem " + x + ": SUBTRACTION");
                                Console.WriteLine("");
                                Console.WriteLine("Question: What is " + dig2 + " - " + dig2sec + "?");
                                Console.WriteLine("");
                                Console.Write("Input your answer here: ");

                                answer = int.Parse(Console.ReadLine());

                                if (answer == dig2 - dig2sec)
                                {
                                    correct++;
                                    Console.WriteLine();
                                    Console.WriteLine("Correct! Next Question");
                                    Console.WriteLine();
                                }
                                else
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Incorrect!");
                                    Console.WriteLine();
                                }

                                break;

                            case 2:
                                Console.WriteLine("Problem " + x + ": MULTIPLICATION");
                                Console.WriteLine("");
                                Console.WriteLine("Question: What is " + dig2 + " * " + dig2sec + "?");
                                Console.WriteLine("");
                                Console.Write("Input your answer here: ");

                                answer = int.Parse(Console.ReadLine());

                                if (answer == dig2 * dig2sec)
                                {
                                    correct++;
                                    Console.WriteLine();
                                    Console.WriteLine("Correct! Next Question");
                                    Console.WriteLine();
                                }
                                else
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Incorrect!");
                                    Console.WriteLine();
                                }

                                break;

                            case 3:
                                Console.WriteLine("Problem " + x + ": DIVISION");
                                Console.WriteLine("");
                                Console.WriteLine("Question: What is " + dig2 + " / " + dig2sec + "?");
                                Console.WriteLine("");
                                Console.Write("Input your answer here: ");

                                answer = int.Parse(Console.ReadLine());

                                if (answer == dig2 / dig2sec)
                                {
                                    correct++;
                                    Console.WriteLine();
                                    Console.WriteLine("Correct! Next Question");
                                    Console.WriteLine();
                                }
                                else
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Incorrect!");
                                    Console.WriteLine();
                                }

                                break;
                        }

                    }

                    Console.WriteLine("Game Over. You have answered " + correct + "/25 questions");
                    Console.ReadKey();

                    break;

                }

                // Operations (For Medium Mode)

                if (diff == 2)
                {
                    Console.WriteLine("");
                    Console.WriteLine("You have chosen the Medium Difficulty");
                    Console.WriteLine("");

                    for (int y = 1; y <= 15; y++)
                    {
                        // Random Number Generator

                        op = rnd.Next(0, 4);
                        dig3 = rnd.Next(100, 999);
                        dig3sec = rnd.Next(100, 999);

                        switch (op)
                        {

                            // Operations
                            
                            case 0:
                                Console.WriteLine("Problem " + y + ": ADDITION");
                                Console.WriteLine("");
                                Console.WriteLine("Question: What is " + dig3 + " + " + dig3sec + "?");
                                Console.WriteLine("");
                                Console.WriteLine("Input your answer here: ");

                                answer = int.Parse(Console.ReadLine());

                                if (answer == dig3 + dig3sec)
                                {
                                    correct++;
                                    Console.WriteLine();
                                    Console.WriteLine("Correct! Next Question");
                                    Console.WriteLine();
                                }
                                else
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Incorrect!");
                                    Console.WriteLine();
                                }
                                break;

                            case 1:
                                Console.WriteLine("Problem " + y + ": SUBTRACTION");
                                Console.WriteLine("");
                                Console.WriteLine("Question: What is " + dig3 + " - " + dig3sec + "?");
                                Console.WriteLine("");
                                Console.Write("Input your answer here: ");

                                answer = int.Parse(Console.ReadLine());

                                if (answer == dig3 - dig3sec)
                                {
                                    correct++;
                                    Console.WriteLine();
                                    Console.WriteLine("Correct! Next Question");
                                    Console.WriteLine();
                                }
                                else
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Incorrect!");
                                    Console.WriteLine();
                                }

                                break;

                            case 2:
                                Console.WriteLine("Problem " + y + ": MULTIPLICATION");
                                Console.WriteLine("");
                                Console.WriteLine("Question: What is " + dig3 + " * " + dig3sec + "?");
                                Console.WriteLine("");
                                Console.Write("Input your answer here: ");

                                answer = int.Parse(Console.ReadLine());

                                if (answer == dig3 * dig3sec)
                                {
                                    correct++;
                                    Console.WriteLine();
                                    Console.WriteLine("Correct! Next Question");
                                    Console.WriteLine();
                                }
                                else
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Incorrect!");
                                    Console.WriteLine();
                                }

                                break;

                            case 3:
                                Console.WriteLine("Problem " + y + ": DIVISION");
                                Console.WriteLine("");
                                Console.WriteLine("Question: What is " + dig3 + " / " + dig3sec + "?");
                                Console.WriteLine("");
                                Console.Write("Input your answer here: ");

                                answer = int.Parse(Console.ReadLine());

                                if (answer == dig3 / dig3sec)
                                {
                                    correct++;
                                    Console.WriteLine();
                                    Console.WriteLine("Correct! Next Question");
                                    Console.WriteLine();
                                }
                                else
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Incorrect!");
                                    Console.WriteLine();
                                }

                                break;
                        }


                    }

                    // Score Counter

                    Console.WriteLine("Game Over. You have answered " + correct + "/15 questions");
                    Console.ReadKey();

                    break;
                }



                // Operations (For Hard Mode)

                else if (diff == 3)
                {
                    Console.WriteLine("");
                    Console.WriteLine("You have chosen the Hard Difficulty");
                    Console.WriteLine("");

                    for (int z = 1; z <= 10; z++)
                    {

                        // Random Number Generator

                        op = rnd.Next(0, 4);
                        dig3 = rnd.Next(1000, 9999);
                        dig3sec = rnd.Next(1000, 9999);

                        switch (op)
                        {

                            // Operations

                            case 0:
                                Console.WriteLine("Problem " + z + ": ADDITION");
                                Console.WriteLine("");
                                Console.WriteLine("Question: What is " + dig4 + " + " + dig4sec + "?");
                                Console.WriteLine("");
                                Console.WriteLine("Input your answer here: ");

                                answer = int.Parse(Console.ReadLine());

                                if (answer == dig4 + dig4sec)
                                {
                                    correct++;
                                    Console.WriteLine();
                                    Console.WriteLine("Correct! Next Question");
                                    Console.WriteLine();
                                }
                                else
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Incorrect!");
                                    Console.WriteLine();
                                }
                                break;

                            case 1:
                                Console.WriteLine("Problem " + z + ": SUBTRACTION");
                                Console.WriteLine("");
                                Console.WriteLine("Question: What is " + dig4 + " - " + dig4sec + "?");
                                Console.WriteLine("");
                                Console.Write("Input your answer here: ");

                                answer = int.Parse(Console.ReadLine());

                                if (answer == dig4 - dig4sec)
                                {
                                    correct++;
                                    Console.WriteLine();
                                    Console.WriteLine("Correct! Next Question");
                                    Console.WriteLine();
                                }
                                else
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Incorrect!");
                                    Console.WriteLine();
                                }

                                break;

                            case 2:
                                Console.WriteLine("Problem " + z + ": MULTIPLICATION");
                                Console.WriteLine("");
                                Console.WriteLine("Question: What is " + dig4 + " * " + dig4sec + "?");
                                Console.WriteLine("");
                                Console.Write("Input your answer here: ");

                                answer = int.Parse(Console.ReadLine());

                                if (answer == dig4 * dig4sec)
                                {
                                    correct++;
                                    Console.WriteLine();
                                    Console.WriteLine("Correct! Next Question");
                                    Console.WriteLine();
                                }
                                else
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Incorrect!");
                                    Console.WriteLine();
                                }

                                break;

                            case 3:
                                Console.WriteLine("Problem " + z + ": DIVISION");
                                Console.WriteLine("");
                                Console.WriteLine("Question: What is " + dig4 + " / " + dig4sec + "?");
                                Console.WriteLine("");
                                Console.Write("Input your answer here: ");

                                answer = int.Parse(Console.ReadLine());

                                if (answer == dig4 / dig4sec)
                                {
                                    correct++;
                                    Console.WriteLine();
                                    Console.WriteLine("Correct! Next Question");
                                    Console.WriteLine();
                                }
                                else
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Incorrect!");
                                    Console.WriteLine();
                                }

                                break;
                        }

                    }

                    Console.WriteLine("Game Over. You have answered " + correct + "/10 questions");
                    Console.ReadKey();

                    break;
                }
                
                // If ever user is dumb enough to input anything that is not from the choices

                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("You have inputted a non-existing option. Please try again.");
                    Console.WriteLine("");

                    // Resets prompt back to the very start

                }
            } 
        }
    }
}