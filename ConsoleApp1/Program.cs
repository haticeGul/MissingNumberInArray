using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {   /**
          %% Missing Number in Array %%
         there are numbers from 1 to N with one element missing, the missing number is to be found.
       - Input: 
        2
        5
        1 2 3 5
        10
        1 2 3 4 5 6 7 8 10

       - output
        4
        9
            **/
        static public void Main()
        {
            while (true)
            {
                string text = Console.ReadLine();
                if (text == null || string.IsNullOrEmpty(text))
                {
                    return;
                }

                string[] myArray = text.Split(' ');
                if (myArray.Length < 2)
                {
                    continue;
                }

                for (int i = 0; i <= myArray.Length; i++)
                {
                    if (int.Parse(myArray[i + 1]) - int.Parse(myArray[i]) != 1)
                    {
                        Console.WriteLine(int.Parse(myArray[i]) + 1);
                        break;
                    }
                }

            }
        }
    }



}

