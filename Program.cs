using System;
namespace NumberCollectionMitArray;

class Program
{
    static void Main(string[] args)
    {
        NumberCollection collection = new NumberCollection(10, new BubbleSort());
        collection.FillRandom();
        Console.WriteLine("Original: " + collection.ToString());
        Console.WriteLine("IsSorted: " + collection.IsSorted());
        collection.Sort();
        Console.WriteLine("Sorted: " + collection.ToString());
        Console.WriteLine("IsSorted: " + collection.IsSorted());

        // Additional testing
        int searchValue = 42;
        Console.WriteLine($"Index of {searchValue}: {collection.Search(searchValue)}");
 

        int binarySearchValue = 23;
        Console.WriteLine($"Index of {binarySearchValue} (Binary Search): {collection.BinarySearch(binarySearchValue)}");
    }
}