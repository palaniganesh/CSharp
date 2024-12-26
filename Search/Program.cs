
static int LinearSearchIterative(int[] A, int n, int key)
{
    int index = 0;
    while (index < n) 
        {

            if (A[index] == key) { return index; }
            index++;
        }
    return -1;
}

static int BinarySearchIterative(int[] A, int n, int key)
{
    var left = 0;
    var right = n - 1;

    while (left < right)
    {
        var m = (int) Math.Floor((left + right) / 2.0);
        if (A[m] == key) return m;
        else if (A[m] < key) right = m - 1;
        else if (A[m] > key) left = m + 1;
    }
    return 0;
}

var myArray = new int[] { 84, 13, 27, 56, 75 };

var index = LinearSearchIterative(myArray, 5, 100);

Console.WriteLine(index);

Console.ReadKey();