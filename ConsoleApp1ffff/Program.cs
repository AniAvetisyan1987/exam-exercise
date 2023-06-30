using ConsoleApp1ffff;

internal class Program
{
   
        private static void Main(string[] args)
        {
       
        int[] arr = { 1, 2, 3, 4, 5 };
        //Class1 clss = new Class1(arr);

        int i = 1;
        
        ////////Recurcia//////////////
        Console.WriteLine(SumRec(i));
        Console.ReadKey();

        }
        static int SumRec(int i)
        {
            if (i == 100) {
            return 1;
        }
        return i + SumRec(i + 1);
    }

}