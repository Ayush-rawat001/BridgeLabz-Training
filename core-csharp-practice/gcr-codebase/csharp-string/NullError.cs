using System;
class NullError{
    static void Main() {
    string s = null;
        try{
            Console.WriteLine(s.Length);
        } catch (NullReferenceException) {
            Console.WriteLine("NullReferenceException");
        }
    }
}
