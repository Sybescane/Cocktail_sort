namespace Shake_sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            ShakeSort(array);
        }

        static void ShakeSort(int[] array)
        {
            int right = array.Length - 1; // n - размер массива
            int left = 1;
            bool isSort = true;
            do
            {
                isSort = true;
                for (int i = left; i <= right; i++)
                {
                    if (array[i - 1] > array[i])
                    {
                        Swap(ref array[i - 1],ref array[i]);
                        isSort = false;
                    }
                }
                right--;
                for (int i = right; i >= left; i--)
                {
                    if (array[i] < array[i - 1])
                    {
                        Swap(ref array[i],ref array[i - 1]);
                        isSort = false;
                    }
                }
                left++;
            } while (isSort == false);


            foreach (int i in array)
            {
                Console.Write(i + " ");
            }

        }
        static void Swap ( ref int foo, ref int bar )
        {
            int temp = foo;
            foo = bar;
            bar = temp;
        }
    }
}