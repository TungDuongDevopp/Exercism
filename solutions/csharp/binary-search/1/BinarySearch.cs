public static class BinarySearch
{
    public static int Find(int[] input, int value)
    {
        Array.Sort(input);

        int startIndex = 0;
        int endIndex = input.Length - 1;

        while (startIndex <= endIndex)
        {
            int mid = (startIndex + endIndex) / 2;

            if (input[mid] == value)
                return mid;

            if (input[mid] < value)
                startIndex = mid + 1;
            else
                endIndex = mid - 1;
        }

        return -1;
    }
}
