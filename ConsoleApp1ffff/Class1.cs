using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1ffff
{
    struct Class1
    {
        public string[] myString;
        public int[] myInt;
        public Class1(int[] myArr)
        {
            myInt = myArr;
            myString = new string[myArr.Length];
            Console.WriteLine(myString.Length + " length");
            makeStringArr();
        }
        public void makeStringArr()
        {
            for (int i=0;i<myInt.Length;i++)
            {
                Console.WriteLine(myInt[i].ToString());
                myString[i] = myInt[i].ToString();
            }
            
            for (int i=0; i<myString.Length;i++)
            {
                Console.WriteLine(myString[i]);
            }

        }
    }
}
