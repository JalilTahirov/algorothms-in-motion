using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new List<int> { 0, 4, 5,  3, 2 ,1,17};
            //var res = FindSmallest(input);
            //Console.WriteLine(res);
            Sort(input);

            Console.ReadKey();
        }

        private static void Sort(List<int> input)
        {
            var resultArray = new List<int>();
            while (input.Any())
            {
                var minIndex = FindSmallest(input);
                resultArray.Add(input[minIndex]);
                input.Remove(input[minIndex]);
            }


            var res = string.Join(", ", resultArray);
            Console.WriteLine(res);
            
        }

        private static int FindSmallest(List<int> input)
        {
            var minimum = int.MaxValue;
            var indexMin = 0;
            for(int i = 0; i < input.Count; i++ )
            {
                var value = input[i];
                if (value < minimum)
                {
                    minimum = value;
                    indexMin = i;
                }
            }

            return indexMin;
        }
    }
}
