public static class BinarySearch
{
    public static int Find(int[] arr, int value)
    {
       Array.Sort(arr); 
      int left = 0;
      int right = arr.Length - 1;

    while (left <= right)
    {
        int mid = left + (right - left) / 2; 

        if (arr[mid] == value)
            return mid; 
        else if (arr[mid] < value)
            left = mid + 1; 
        else
            right = mid - 1; 
    }
    return -1; 
    }
}