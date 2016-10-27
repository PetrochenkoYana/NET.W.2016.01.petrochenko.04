using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.DDT
{
    public class CompareSum
    {
        static int SumElement(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
                sum += array[i];
            return sum;

        }
        static public int CompareElemSum(int[] array)
        {
            int leftsum = 0;
            int rightsum = SumElement(array) - array[0];
            int index = 1;
            while (leftsum.Equals(rightsum) == false && index < array.Length)
            {

                leftsum += array[index - 1];
                rightsum -= array[index];
                index++;

            }

            if (index == array.Length)
                return -1;
            return index - 1;

        }
    }
}
