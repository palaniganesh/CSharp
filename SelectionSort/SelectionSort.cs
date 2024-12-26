static void DisplayArray(int[] myArray)
{
    for (int i = 0; i < myArray.Length; i++)
    {
        Console.WriteLine(myArray[i]);
    }
}
static void SelectSort(int[] A, int n)
{
    for (int i = 0; i < n; i++)
    {
        int position = i;
        for (int j = i + 1; j < n; j++)
        {
            if (A[j] < A[position])
                position = j;
        }
        //Console.WriteLine($"I is {i} The smallest number position is {position} and number is {A[position]}");
        //Console.WriteLine($"A[i] is {A[i]} and A[position] is {A[position]}");

        //if (A[position] < A[i])
        //{
            //Console.WriteLine("inside");
            int temp = A[i];
            A[i] = A[position];
            A[position] = temp;
        //}
    }
}

var myArray = new int[] { 84, 13, 27, 56, 75 };
//var myArray = new int[] { 1, 2, 3, 4, 5 };

Console.WriteLine("Before Sorting: ");
DisplayArray(myArray);
SelectSort(myArray, myArray.Length);
Console.WriteLine("After Sorting: ");
DisplayArray(myArray);
