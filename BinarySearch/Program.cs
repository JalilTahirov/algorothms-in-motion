using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = binary_search(new int[] {3,5,6,7}, 1);
            Console.WriteLine(result);
            Console.ReadKey();
        }

        private static int binary_search(int[] list, int itemToFind)
        {
            /*
               check if the item is equal to the mid element
             
               if it is more update low
               if it is less update high 
           */

            int high = list.Length - 1;
            int low = 0;
            

            while (low <= high)
            {
                int mid = (high + low) / 2;
                int guess = list[mid];
                if (itemToFind == guess)
                {
                    return mid;
                }

                if (guess > itemToFind)
                {
                    high = mid - 1;
                }

                if (guess < itemToFind)
                {
                    low = mid + 1; 
                }
            }



            return -888;


        }
    }
}
