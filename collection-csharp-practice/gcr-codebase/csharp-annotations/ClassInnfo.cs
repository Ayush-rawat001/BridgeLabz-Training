using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    internal class ClassInfo
    {
        public static void Main()
        {
            Console.WriteLine("Enter full class name (e.g., System.String):");
            string input = Console.ReadLine();
            Type t = Type.GetType(input);

            if (t == null) { Console.WriteLine("Type not found."); return; }

            Console.WriteLine($"\n--- Methods in {t.Name} ---");
            foreach (var m in t.GetMethods()) Console.WriteLine(m.Name); 

            Console.WriteLine($"\n--- Fields in {t.Name} ---");
            foreach (var f in t.GetFields()) Console.WriteLine(f.Name);

            Console.WriteLine($"\n--- Constructors in {t.Name} ---");
            foreach (var c in t.GetConstructors()) Console.WriteLine(c.ToString());
        }
    }
