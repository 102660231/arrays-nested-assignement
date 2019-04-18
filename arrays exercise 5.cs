using System;

namespace arrayts_5.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbInput = new int[5];

            int repeat = 0;
            int counter = 0;
            while (counter < numbInput.Length)
            {



                Console.Write("please enter 5 number{0}:    ");

                numbInput[counter] = int.Parse(Console.ReadLine());
                // numbInput[counter] = numbers;

                counter++;



                //  Storing 5 number entered by user in an array

            }


            //once reached 5 numbers , get user input another number 


            int lastNumber = 0;

            Console.Write("enter no 6 number:");
            lastNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(value: lastNumber);
            int lastNumberstore = lastNumber;

            //do check on the last number entered ,is it repeat?
            int count = 1;
            int countera = 0;
            while (countera < numbInput.Length)
            {

                Console.Write("No" + count + " number keyed in " + "and stored in array is  ");
                Console.Write(numbInput[countera]);
                Console.Write("   last number entered is :" + lastNumberstore);
                Console.Read();

                if (lastNumberstore == numbInput[countera])
                {


                    //IF NUMBER IS  REPEATED
                    Console.WriteLine(" Found Number repeated  :    " + numbInput[countera]);
                    //increase repeat counter 
                    repeat = repeat + 1;

                    Console.Write(value: numbInput[countera] + " this last keyed in number already exist : " + repeat + " times");

                    Console.Read();

                }
                countera = countera + 1;
                count++;
                Console.Read();
            }
            }
        }
}
