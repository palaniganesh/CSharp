static void DisplayArray(int[] myArray)
{
    for (int i = 0; i < myArray.Length; i++)
    {
        Console.WriteLine(myArray[i]);
    }
}
static void ShellSort(int[] A, int n)
{
    for(int gap = n/2; gap > 0; gap = gap/2)
    {
        for(int i = gap; i<n; i++)
        {
            int currentValue = A[i];
            int j = i - gap;
            while( j >= 0 && A[j] > currentValue) 
            {
                A[j + gap] = A[j];
                j = j - gap;
            }
            A[j + gap] = currentValue;
        }
    }
}

static void MyShellSort(int[] A, int n)
{
    for (int gap = n / 2; gap > 0; gap = gap / 2)
    {
        for (int i = 0; i < n; ++i)
        {
            //int currentValue = A[i];
            if (i - gap > 0 && A[i] < A[i - gap])
            {
                int temp = A[i];
                A[i] = A[i - gap]; 
                A[i - gap] = temp;
            }
            if(i + gap < n  && A[i] > A[i + gap])
            {
                int temp = A[i];
                A[i] = A[i + gap];
                A[i + gap] = temp;
            }
        }
    }
}

//var myArray = new int[] { 84, 13, 27, 56, 75, 32 };
//var myArray = new int[] { 1, 2, 3, 4, 5 };
var myArray = new int[] { 3, 5, 8, 9, 6, 2 };


Console.WriteLine("Before Sorting: ");
DisplayArray(myArray);
//ShellSort(myArray, myArray.Length);
MyShellSort(myArray, myArray.Length);
Console.WriteLine("After Sorting: ");
DisplayArray(myArray);
