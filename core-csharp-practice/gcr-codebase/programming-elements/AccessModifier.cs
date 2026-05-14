using System;
 // Default access modifier for class is internal
    class BaseClass{
        public string publicVar ="publicVar";
        private string publicVar = "publicVar";
        protected string protectedVar = "protectedVar";
        internal string internalVar = "internalVar";
        protected internal string protectedInternalVar = "protectedInternalVar";
        private protected string privateProtectedVar = "privateProtectedVar";

        public void ShowInsideBase()
        {
           Console.WriteLine(publicVar); // ✅
            Console.WriteLine(privateVar); // ✅
            Console.WriteLine(protectedVar);// ✅
            Console.WriteLine(internalVar);// ✅
            Console.WriteLine(protectedInternalVar);// ✅
            Console.WriteLine(privateProtectedVar);// ✅
        }
    }

     class NonDerivedClass{
        public void Show(){
            BaseClass  b = new BaseClass();
            Console.WriteLine(b.publicVar);            // ✅
            // Console.WriteLine(b.privateVar);        // ❌
            // Console.WriteLine(b.protectedVar);      // ❌
            Console.WriteLine(b.internalVar);          // ✅
            Console.WriteLine(b.protectedInternalVar); // ✅
            // Console.WriteLine(b.privateProtectedVar); // ❌
        }
    }


    
    class DerivedClass : BaseClass{
        public void ShowInsideDerived(){
            Console.WriteLine(publicVar);               // ✅
            // Console.WriteLine(privateVar);           // ❌ 
            Console.WriteLine(protectedVar);            // ✅
            Console.WriteLine(internalVar);             // ✅
            Console.WriteLine(protectedInternalVar);    // ✅
            Console.WriteLine(privateProtectedVar);     // ✅ 
        }
    }

    
   
    class Program{
        static void Main(){
            BaseClass baseObj = new BaseClass();
            baseObj.ShowInsideBase();
            DerivedClass derivedObj = new DerivedClass();
            derivedObj.ShowInsideDerived();
            NonDerivedClass nonDerivedObj = new NonDerivedClass();
            nonDerivedObj.Show();
            Console.ReadLine();
        }
    }

