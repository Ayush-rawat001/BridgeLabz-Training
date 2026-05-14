using System;
class ArrayError {
    static void Main() {
        int[] arr = {1,2,3};
        try {
        Console.WriteLine(arr[10]);
        } catch (IndexOutOfRangeException) {
            Console.WriteLine("IndexOutOfRangeException ");
        }
    }
}
