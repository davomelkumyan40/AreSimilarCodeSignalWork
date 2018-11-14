using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSignalJob
{

    // 4, 6, 3 
    // 3, 4, 6
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayA = { 832, 998, 148, 570, 533, 561, 894, 147, 455, 279 };
            int[] arrayB = { 832, 998, 148, 279, 533, 561, 894, 147, 455, 570 };

            Console.WriteLine(areSimilar(arrayA, arrayB).ToString());
            Console.ReadKey();
        }




       public static bool areSimilar(int[] a, int[] b)
        {
            int index1 = 0;
            int index2 = 0;
            int swapable1 = 0;
            int swapable2 = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                {
                    swapable1 = a[i];
                    index1 = i + 1;
                    break;
                }
            }
            for (int i = index1; i < a.Length; i++)
            {
                if (a[i] == b[index1 - 1])
                {
                    swapable2 = a[i];
                    index2 = i;
                }
            }
            if (AreEqual(Swap(a, index1 - 1, index2), b))
                return true;
            return false;
        }

        public static int[] Swap(int[] array, int index1, int index2)
        {
            int temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;

            return array;
        }

        public static bool AreEqual(int[] arr1, int[] arr2)
        {
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                    return false;
            }
            return true;
        }

        //
        //public static bool AreSimilar(int[] a, int[] b)
        //{
        //    int index = 0;
        //    int index2 = 0;
        //    int comparable1 = 0;
        //    int comparable2 = 0;
        //    for (int i = 0; i < a.Length; i++)
        //    {
        //        if (a[i] != b[i])
        //        {
        //            comparable1 = a[i];
        //            index = i + 1;
        //            break;
        //        }
        //    }
        //    for (int i = index; i < a.Length; i++)
        //    {
        //        if (a[i] == b[index - 1])
        //        {
        //            comparable2 = a[i];
        //            index2 = i;
        //        }
        //    }
        //    if(AreEqual(Swap(a, index - 1, index2), b))
        //    return true;
        //    return false;
        //}

        //public static int[] Swap(int[] array ,int index1, int index2)
        //{
        //    int temp = array[index1];
        //    array[index1] = array[index2];
        //    array[index2] = temp;

        //    return array;
        //}


        //public static bool AreEqual(int[] arr1, int[] arr2)
        //{
        //    for (int i = 0; i < arr1.Length; i++)
        //    {
        //        if (arr1[i] != arr2[i])
        //            return false;
        //    }
        //    return true;
        //}

        //public static bool AreSimilar(int[] a, int[] b)
        //{
        //    if (AreEqual(a, b))
        //        return true;
        //    else
        //    {
        //        for (int i = 0; i < a.Length - 1; i++)
        //        {
        //            if ((AreEqual(Swap(a, i), b)))
        //                return true;
        //        }
        //    }
        //    return false;
        //}

        //public static int[] Swap(int[] arr, int index)
        //{
        //    var copy = arr.ToList();
        //    int temp = copy[index];
        //    copy[index] = copy[index + 1];
        //    copy[index + 1] = temp;
        //    return copy.ToArray();
        //}
    }
}
