using System;
using System.Collections.Generic;
namespace puzzles
{
    static class Program
    {
        public static Random rand = new Random();

        public static int[] RandomArray()
        {
            int[] randArr = new int[10];
            for (int i = 0; i < 10; i++)
            {
                randArr[i] = (rand.Next(5, 25));
            }
            int min = randArr[0];
            int max = randArr[0];
            int sum = 0;
            for (int i = 0; i < randArr.Length; i++)
            {
                if (randArr[i] > max)
                {
                    max = randArr[i];
                }
                if (randArr[i] < min)
                {
                    min = randArr[i];
                }
                sum += randArr[i];
            }
            Console.WriteLine($"Min: {min}  Max: {max}  Sum: {sum}");
            return randArr;
        }
        public static string CoinFlip()
        {
            Console.WriteLine("\nTossing a Coin!");
            int flip = (rand.Next(0, 2));
            string result = flip == 0 ? result = "Heads" : result = "Tails";
            Console.Write(result);
            return result;
        }
        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rand.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
        public static List<string> Names()
        {
            List<string> nameList = new List<string>();
            List<string> newNameList = new List<string>();

            nameList.Add("Todd");
            nameList.Add("Tiffany");
            nameList.Add("Charlie");
            nameList.Add("Geneva");
            nameList.Add("Sydney");
            Console.WriteLine("Current list of names:");
            foreach (var name in nameList)
            {
                Console.WriteLine(name);
            }
            Shuffle(nameList);
            Console.WriteLine("\nNames are now Shuffled \n");
            Console.WriteLine("New list of names:");
            foreach (var name in nameList)
            {
                Console.WriteLine(name);
            }

            foreach (var name in nameList)
            {
                if (name.Length > 5)
                {
                    newNameList.Add(name);

                }
            }
            Console.Write("\nReturning names that are longer than 5 characters");
            return newNameList;
        }
        static void Main(string[] args)
        {
            int[] oneRandomArr = RandomArray();
            Console.WriteLine("[{0}]", string.Join(", ", oneRandomArr));
            CoinFlip();
            Console.WriteLine("\n");

            List<string> returnedNames = Names();
            Console.WriteLine("\n[{0}]", string.Join(", ", returnedNames));

        }
    }
}
