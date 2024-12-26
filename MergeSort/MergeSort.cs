static void DisplayArray(int[] myArray)
{
    for (int i = 0; i < myArray.Length; i++)
    {
        Console.WriteLine(myArray[i]);
    }
}
static void MergeSort(int[] A, int left, int right)
{
    if(left < right)
    {
        var mid = (left + right) / 2;
        MergeSort(A, left, mid);
        MergeSort(A, mid + 1, right);
        Merge(A, left, right, mid);
    }
}

static void Merge(int[] A, int left, int right, int mid)
{
    int i = left;
    int j = mid + 1;
    int k = left;
    int[] B = new int[right + 1];
    while(i <= mid && j <= right)
    {
        if (A[i] < A[j]) 
        { 
            B[k] = A[i];
            i++; 
        }
       else
        {
            B[k] = A[j];
            j++;
        }
        k++;
    }
    while(i <= mid)
    { 
        B[k] = A[i];
        i++;
        k++;
    }
    while(j <= right)
    { 
        B[k] = A[j]; 
        j++;  
        k++; 
    }

    for (int x = left; x < right + 1; x++)
        A[x] = B[x];

}

var myArray = new int[] { 20, 6, 18, 4 };
//var myArray = new int[] { 84, 13, 27, 56, 75, 28, 6, 4, 1, 67 };
//var myArray = new int[] { 84, 13, 27, 56, 75, 28 };
//var myArray = new int[] { 1, 2, 3, 4, 5 };
//var myArray = new int[] { 3, 5, 8, 9, 6, 2 };


Console.WriteLine("Before Sorting: ");
DisplayArray(myArray);
MergeSort(myArray, 0, myArray.Length-1);
Console.WriteLine("After Sorting: ");
DisplayArray(myArray);
