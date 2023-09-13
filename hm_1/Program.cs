using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Task 1:\r\n");

                string output =
                    "It's easy to win forgiveness for being wrong;\r\n" +
                    "being right is what gets you into real trouble.\r\n" +
                    "Bjarne Stroustrup";

                Console.WriteLine(output);

                Console.WriteLine("\r\n\t *** \r\n");
                Console.ReadKey();
            }

            {
                Console.WriteLine("Task 2:\r\n");

                int size = 5;
                int[] numbersArray = new int[size];

                for (int i = 0; i < size; ++i)
                {
                    Console.Write("enter " + (i + 1) + " number: ");
                    numbersArray[i] = int.Parse(Console.ReadLine());
                }

                {
                    int sumOfNumbers = 0;

                    for (int i = 0; i < size; ++i)
                    {
                        sumOfNumbers += numbersArray[i];
                    }

                    Console.WriteLine("\r\nsum of numbers is " + sumOfNumbers);
                }

                {
                    int minValue = numbersArray[0];

                    for (int i = 0; i < size; ++i)
                    {
                        if (numbersArray[i] < minValue)
                        {
                            minValue = numbersArray[i];
                        }
                    }

                    Console.WriteLine("min value of numbers is " + minValue);
                }

                {
                    int maxValue = numbersArray[0];

                    for (int i = 0; i < size; ++i)
                    {
                        if (numbersArray[i] > maxValue)
                        {
                            maxValue = numbersArray[i];
                        }
                    }

                    Console.WriteLine("max value of numbers is " + maxValue);
                }

                Console.WriteLine("\r\n\t *** \r\n");
                Console.ReadKey();
            }

            {
                Console.WriteLine("Task 3:\r\n");

                while (true)
                {
                    Console.Write("enter six-digit digit number: ");

                    int inputNumber = int.Parse(Console.ReadLine());

                    if (inputNumber >= 100000 && inputNumber <= 999999)
                    {
                        int reverseNumber = 0;

                        while (inputNumber > 0)
                        {
                            int digit = inputNumber % 10;
                            reverseNumber = reverseNumber * 10 + digit;
                            inputNumber /= 10;
                        }

                        Console.WriteLine("reversed number is " + reverseNumber);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\r\nInvalid number entered. Enter a six-digit number.\r\n");
                    }
                }

                Console.WriteLine("\r\n\t *** \r\n");
                Console.ReadKey();
            }

            {
                Console.WriteLine("Task 4:\r\n");

                while (true)
                {
                    Console.Write("enter the beginning of calculating Fibonacci numbers: ");
                    int startOfCalculating = int.Parse(Console.ReadLine());

                    Console.Write("enter the end of calculating Fibonacci numbers: ");
                    int endOfCalculating = int.Parse(Console.ReadLine());

                    if (startOfCalculating < 0 || endOfCalculating < 0 || startOfCalculating > endOfCalculating)
                    {
                        Console.WriteLine("\r\nIncorrect range limits or starting number. Enter correct start and end numbers");
                    }
                    else
                    {
                        int firstFibonacci = 0;
                        int secondFibonacci = 1;

                        Console.WriteLine("\r\nThe Fibonacci number of given range are: ");

                        while (firstFibonacci <= endOfCalculating)
                        {
                            if (firstFibonacci >= startOfCalculating)
                            {
                                Console.Write(firstFibonacci + " ");
                            }

                            int nextFibonacci = firstFibonacci + secondFibonacci;
                            firstFibonacci = secondFibonacci;
                            secondFibonacci = nextFibonacci;
                        }

                        Console.WriteLine();
                        break;
                    }
                }

                Console.WriteLine("\r\n\t *** \r\n");
                Console.ReadKey();
            }

            {
                Console.WriteLine("Task 5:\r\n");

                while (true)
                {
                    Console.Write("enter the beginning number: ");
                    int startNumber = int.Parse(Console.ReadLine());

                    Console.Write("enter the end number: ");
                    int endNumber = int.Parse(Console.ReadLine());

                    if (startNumber < 0 || endNumber < 0 || startNumber > endNumber)
                    {
                        Console.WriteLine("\r\nIncorrect range limits or starting number. Enter correct start and end numbers");
                    }
                    else
                    {
                        Console.WriteLine();

                        while (startNumber <= endNumber)
                        {
                            for (int i = 0; i < startNumber; ++i)
                            {
                                Console.Write(startNumber);
                            }

                            Console.WriteLine();
                            startNumber++;
                        }

                        Console.WriteLine();
                        break;
                    }
                }

                Console.WriteLine("\r\n\t *** \r\n");
                Console.ReadKey();
            }

            {
                Console.WriteLine("Task 1:\r\n");

                while (true)
                {
                    Console.Write("enter line length: ");
                    int lineLength = int.Parse(Console.ReadLine());

                    if (lineLength > 0)
                    {
                        Console.Write("enter line depiction symbol: ");
                        char lineDepiction = char.Parse(Console.ReadLine());

                        Console.Write("enter 1 for horizontal, 2 for vertical output of line: ");
                        string lineDirection = Console.ReadLine();

                        if (lineDirection == "1")
                        {
                            for (int i = 0; i < lineLength; ++i)
                            {
                                Console.Write(lineDepiction);
                            }
                            break;
                        }
                        else if (lineDirection == "2")
                        {
                            for (int i = 0; i < lineLength; ++i)
                            {
                                Console.WriteLine(lineDepiction);
                            }
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\r\nInvalid value. Enter '1' or '2' to select horizontal or vertical output.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\r\nInvalid input. The value must be greater then '0'");
                    }
                }

                Console.WriteLine("\r\n\t *** \r\n");
                Console.ReadKey();
            }
        }
    }
}
