namespace NumberCollectionMitArray;

public class NumberCollection : INumberCollection
{
    private int[] numbers;
    private ISortBehaviour _sortBehaviour;
    
    public NumberCollection(int size,ISortBehaviour sortBehaviour)
    {
        numbers = new int[size];
        this._sortBehaviour = sortBehaviour;
    }

    public void FillRandom()
    {
        Random r = new Random();
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = r.Next(1, 101);
        }
    }

    public override string ToString()
    {
        return string.Join(",", numbers);
    }

    public int Search(int value)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == value)
            {
                return i;
            }
        }
        return -1;
    }
    public bool IsSorted()
    {
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < numbers[i - 1])
            {
                return false;
            }
        }
        return true;
    }
    
    public int BinarySearch(int value)
    {
        if (!IsSorted())
        {
            throw new Exception("Array is not sorted!");
        }
        int left = 0;
        int right = numbers.Length - 1;
        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (numbers[mid] == value)
            {
                return mid;
            }

            if (numbers[mid] < value)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        return -1; // Value not found
    }

    public void Sort()
    {
        _sortBehaviour.Sort(numbers);
    }
}