using System;

class Solution
{
    public void MoveZeroes(int[] arr)
    {
        int index = 0;

        // Move non-zero elements forward
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] != 0)
            {
                arr[index++] = arr[i];
            }
        }

        // Fill remaining positions with 0
        while (index < arr.Length)
        {
            arr[index++] = 0;
        }
    }
}
