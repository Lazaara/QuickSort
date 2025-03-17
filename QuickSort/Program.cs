using System;
using System.Linq;

namespace QuickSort
{
    internal class Program
    {
        
        private static void QuickSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(arr, left, right);

                if (pivot > 1) {
                    QuickSort(arr, left, pivot - 1);
                }
                if (pivot + 1 < right) {
                    QuickSort(arr, pivot + 1, right);
                }
            }
        }

        private static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[left];
            while (true) 
            {
                while (arr[left] < pivot) 
                {
                    left++;
                }
                
                while (arr[right] > pivot)
                {
                    right--;
                }
                
                if (left < right)
                {
                    if (arr[left] == arr[right]) return right;

                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                }
                else 
                {
                    return right;
                }
            }
        }

        public static void Main(string[] args)
        {

            int[] arr = { 3, 6, 8, 9, 22, 13, 4, 1, 27, 36 };
            
            /*
             Sort lai array, demo chac ko can dau
            int[] arrSorted = arr;
            Array.Sort(arrSorted);
            
            int[] arrSortedReverse = arrSorted.OrderByDescending(c => c).ToArray();
            
            */

            Console.Write("Array truoc khi sort: ");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            QuickSort(arr, 0, arr.Length - 1);
            Console.Write("Array sau khi sort: ");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.ReadLine();

        }
    }
}