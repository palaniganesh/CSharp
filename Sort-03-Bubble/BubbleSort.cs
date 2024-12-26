static void DisplayArray(int[] myArray)
{
    for (int i = 0; i < myArray.Length; i++)
    {
        Console.WriteLine(myArray[i]);
    }
}
static void BubbleSort(int[] A, int n)
{
    for (int i = n - 1; i >= 0; i--)
    {
        for (int j = 0; j < i; j++)
        {
            if (A[j] > A[i])
            {
                int temp = A[j];
                A[j] = A[i];
                A[i] = temp;
            }
        }
    }
}

var myArray = new int[] { 84, 13, 27, 56, 75 };
//var myArray = new int[] { 1, 2, 3, 4, 5 };
//var myArray = new int[] { 3, 5, 8, 9, 6, 2 };


Console.WriteLine("Before Sorting: ");
DisplayArray(myArray);
BubbleSort(myArray, myArray.Length);
Console.WriteLine("After Sorting: ");
DisplayArray(myArray);
