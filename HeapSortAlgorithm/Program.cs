using System;

namespace HeapSortAlgorithm
{
  class Program
  {

    static void Main(string[] args)
    {
      int[] array = new int[] { 16, 18, 22, 7, 1 };
      Heapsort(array);
      foreach (int i in array)
      {
        Console.WriteLine(i);
      }
    }


    public static int Left(int i)
    {
      return (2 * i) + 1;
    }

    public static int Right(int i)
    {
      return (2 * i) + 2;
    }

    public static void MaxHeapify(int[] array, int i)
    {
      int largest;
      int l = Left(i);
      int r = Right(i);
      int heapsize = array.Length;

      if (l <= heapsize - 1 && array[l] > array[i])
      {
        largest = l;
      }
      else
      {
        largest = i;
      }
      if (r <= heapsize - 1 && array[r] > array[largest])
      {
        largest = r;
      }
      if (largest != i)
      {
        int temp = array[i];
        array[i] = array[largest];
        array[largest] = temp;
        MaxHeapify(array, i);
      }
    }

    public static void BuildMaxHeap(int[] array)
    {
      int heapsize = array.Length;

      for (int i = heapsize / 2 - 1; i >= 0; i--)
      {
        MaxHeapify(array, i);
      }
    }

    public static void Heapsort(int[] array)
    {
      int heapsize = array.Length;
      BuildMaxHeap(array);
      for (int i = heapsize - 1; i >= 1; i--)
      {
        int temp = array[0];
        array[0] = array[i];
        array[i] = temp;
        heapsize = heapsize - 1;
        MaxHeapify(array, 0);
      }


    }

  }
}
