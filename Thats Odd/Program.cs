using System;
using System.Collections.Generic;

namespace Thats_Odd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreateRandomList();
        }
        static void CreateRandomList()
        {
            while (true)
            {
                Random rnd = new Random();
                int randomNumber = rnd.Next(0, 999999999);
                string strRandom = randomNumber.ToString();
                int[] rndList = new int[strRandom.Length];
                int x = 0;
                foreach (char character in strRandom)
                {
                    string strCharacter = character.ToString();
                    int intCharacter = int.Parse(strCharacter);
                    rndList[x] = intCharacter;
                    x++;
                }
                Dictionary<int, int> Dict = new Dictionary<int, int>();
                for (int y = 0; y < 10; y++)
                {
                    Dict[y] = 0;
                    for (int i = 0; i < strRandom.Length; i++)
                    {
                        if (rndList[i] == y)
                        {
                            Dict[y] += 1;
                        }
                    }
                }
                int oddFound = 0;
                int foundValue = 0;
                foreach (KeyValuePair<int, int> value in Dict)
                {
                    int isValueOdd = value.Value % 2;
                    if (isValueOdd == 1)
                    {
                        oddFound++;
                        foundValue = value.Key;
                    }
                }
                if (oddFound == 1)
                { 
                    string printList = String.Join(", ", rndList);
                    Console.WriteLine(printList);
                    Console.WriteLine(foundValue);
                    break;
                }
            }
        }
    }
}
