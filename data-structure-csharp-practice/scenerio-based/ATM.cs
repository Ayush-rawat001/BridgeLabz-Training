class ATM
{
    static void Main()
    {
        int a=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("---------------------------\n");
        combo(a);
        combo2(a);
       

    }

    public static void combo(int amt)
    { 
        int[] notes={500,200,100,50,20,10,5,2,1};
        int i=0;
          while(i<notes.Length)
          {
            int temp=amt/notes[i];
            if(temp>0)Console.WriteLine(notes[i]+"->"+temp);
            amt=amt-(temp*notes[i]);
            i++;
          }
          Console.WriteLine("---------------------------\n");
    }

    public static void combo2(int amt)
    { 
        int[] notes={500,200,100,50,20,10};
        int i=0;
          while(i<notes.Length)
          {
            int temp=amt/notes[i];
            if(temp>0)Console.WriteLine(notes[i]+"->"+temp);
            amt=amt-(temp*notes[i]);
            i++;
          }

    if(amt>0)Console.WriteLine(amt+" change is not possible");
    }


}