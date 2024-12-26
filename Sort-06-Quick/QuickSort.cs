static void DisplayArray(int[] myArray)
{
    for (int i = 0; i < myArray.Length; i++)
    {
        Console.WriteLine(myArray[i]);
    }
}
static void QuickSort(int[] A, int low, int high)
{
    if (low < high)
    {
        int partitionIndex = Partition(A, low, high);
        QuickSort(A, low, partitionIndex - 1);
        QuickSort(A, partitionIndex + 1, high);
    }

}

static int Partition(int[] A, int low, int high)
{
    int pivot = A[low];
    int i = low + 1;
    int j = high;
    do
    {
        while (i <= j && A[i] <= pivot)
        {
            i++;
        }
        while (j >= i && A[j] > pivot)
        {
            j--;
        }
        if(i <= j)
            Swap(A, i, j);

    } while (i < j);
    Swap(A, low, j);
    return j;
}

static void Swap(int[] A, int low, int high)
{
    int temp = A[low];
    A[low] = A[high];
    A[high] = temp;
}


var myArray = new int[] { 20, 6, 18, 4 };
//var myArray = new int[] { 84, 13, 27, 56, 75, 28, 6, 4, 1, 67 };
//var myArray = new int[] { 84, 13, 27, 56, 75, 28 };
//var myArray = new int[] { 1, 2, 3, 4, 5 };
//var myArray = new int[] { 3, 5, 8, 9, 6, 2 };


Console.WriteLine("Before Sorting: ");
DisplayArray(myArray);
QuickSort(myArray, 0, myArray.Length - 1);
Console.WriteLine("After Sorting: ");
DisplayArray(myArray);



