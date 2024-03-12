namespace NumberCollectionMitArray;

public interface INumberCollection
{
    void FillRandom();
    void Sort();
    bool IsSorted();
    string ToString();
    int Search(int value);
    int BinarySearch(int value);
}