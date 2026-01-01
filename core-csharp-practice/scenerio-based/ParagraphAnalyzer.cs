using System;

class ParagraphAnalyzer
{
    // count words
    public static void TotalWords(string text){
        int count = 0;
        string word = "";

        for (int i = 0; i < text.Length; i++){
            if (text[i] != ' '){
                word = word + text[i];
            }
            else{
                if (word != "")
                {
                    count++;
                }
                word = "";
            }
        }

        if (word != ""){
            count++;
        }

        Console.WriteLine("Total words are: " + count);
    }

    // longest word
    public static void LongWord(string text){
        string big = "";
        string word = "";

        for (int i = 0; i < text.Length; i++){
            if (text[i] != ' '){
                word = word + text[i];
            }
            else{
                if (word != ""){
                    if (word.Length > big.Length){
                        big = word;
                    }
                }
                word = "";
            }
        }

        if (word != "") {
            if (word.Length > big.Length){
                big = word;
            }
        }

        Console.WriteLine("Longest word is: " + big);
    }

    // replace word
    public static void Swap(string text){
        Console.WriteLine("Which word to change?");
        string old = Console.ReadLine() ?? "";

        Console.WriteLine("New word?");
        string newW = Console.ReadLine() ?? "";

        string result = "";
        string word = "";

        for (int i = 0; i < text.Length; i++){
            if (text[i] != ' '){
                word = word + text[i];
            }
            else{
                if (word != ""){
                    if (Same(word, old)){
                        result = result + newW;
                    }
                    else{
                        result = result + word;
                    }
                }
                result = result + " ";
                word = "";
            }
        }

        if (word != ""){
            if (Same(word, old)) {
                result = result + newW;
            }
            else{
                result = result + word;
            }
        }

        Console.WriteLine("Changed text: " + result);
    }

    // compare words ignore case
    public static bool Same(string a, string b) {
        if (a.Length != b.Length){
            return false;
        }

        for (int i = 0; i < a.Length; i++){
            char c1 = a[i];
            char c2 = b[i];

            if (c1 >= 'A' && c1 <= 'Z') {
                c1 = (char)(c1 + 32);
            }

            if (c2 >= 'A' && c2 <= 'Z'){
                c2 = (char)(c2 + 32);
            }

            if (c1 != c2){
                return false;
            }
        }

        return true;
    }

    // menu
    public static void Menu(string text) {
        while (true){
            Console.WriteLine("\n1 count words");
            Console.WriteLine("2 find longest");
            Console.WriteLine("3 change word");
            Console.WriteLine("4 stop");
            Console.Write("Enter choice: ");

            int op = Convert.ToInt32(Console.ReadLine());

            if (op == 1){
                TotalWords(text);
            }
            else if (op == 2){
                LongWord(text);
            }
            else if (op == 3){
                Swap(text);
            }
            else if (op == 4){
                break;
            }
            else{
                Console.WriteLine("Wrong choice!");
            }
        }
    }

    // main start
    public static void Main() {
        Console.WriteLine("Enter paragraph:");
        string text = Console.ReadLine() ?? "";

        bool empty = true;

        for (int i = 0; i < text.Length; i++){
            if (text[i] != ' '){
                empty = false;
                break;
            }
        }

        if (empty){
            Console.WriteLine("Nothing written!");
            return;
        }

        Menu(text);
    }
}
