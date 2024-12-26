static void DisplayArray(int[] myArray)
{
    for (int i = 0; i < myArray.Length; i++)
    {
        Console.WriteLine(myArray[i]);
    }
}
static void InsertionSort(int[] A, int n)
{
    for(int i = 1; i < n; i++)
    {
        var position = i;
        var currentValue = A[position];
        while (position  > 0 && A[position - 1] > currentValue)
        {
            A[position] = A[position-1];
            position--;
        }
        A[position] = currentValue;

    }
}

//var myArray = new int[] { 84, 13, 27, 56, 75 };
//var myArray = new int[] { 1, 2, 3, 4, 5 };
var myArray = new int[] { 3, 5, 8, 9, 6, 2 };


Console.WriteLine("Before Sorting: ");
DisplayArray(myArray);
InsertionSort(myArray, myArray.Length);
Console.WriteLine("After Sorting: ");
DisplayArray(myArray);
