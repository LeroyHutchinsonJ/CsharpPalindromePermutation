using System;

namespace PalindromePermutationAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            //How I did the palindrome permutation check
            Boolean isIt(String x)
            {
                //Creates a grid to keep track of all the values
                bool[] hashMap = new bool[128];

                //Turn the string into a character array
                char[] charArr = x.ToCharArray();

                //itterate through each character in the string, put it in the grid after turning it into a variable
                for (int a = 0; a < x.Length; a++)
                {
                    if (charArr[a] == ' ')
                    {
                        continue;
                    }
                    //Turn each char into a int variable
                    int coordinates = charArr[a];

                    //If a coordinate was flicked to true, then turn it false
                    if (hashMap[coordinates] == true)
                    {
                        hashMap[coordinates] = false;
                    }
                    else if (hashMap[coordinates] == false)
                    {
                        hashMap[coordinates] = true;
                    }
                }

                int counter = 0;

                //Itterate through the grid
                for (int b = 0; b < 128; b++)
                {
                    if (hashMap[b] == false)
                    {
                        counter++;

                    }
                }



                if (counter == 128 || counter == 127)
                {
                    Console.WriteLine("This is a palindrome permutation");
                }
                else
                {
                    Console.WriteLine("This is not a palindrome permutation");
                }



                return false;
            }


            isIt("abb");

            Console.WriteLine("Press any key to continue");
            Console.ReadKey(true);
        }
    }
}
