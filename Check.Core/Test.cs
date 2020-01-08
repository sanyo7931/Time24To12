using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check.Core
{
    public class Test
    {
        public static void Main()
        {
            int inputH;
            string[] inputArray;
            IChecker regex = new RegexCheck();
            Console.WriteLine("輸入24時制時間: ");
            string militaryTime = Console.ReadLine();
            try
            {
                if (regex.MilitaryTimeToRegularTime(militaryTime))
                {
                    inputArray = militaryTime.Split(':');
                    inputH = Convert.ToInt32(inputArray[0]);
                    if (inputH > 12)
                    {
                        inputH -= 12;
                        Console.WriteLine(inputH + ":" + inputArray[1] + " PM");
                    }
                    else if (inputH == 12)
                    {
                        Console.WriteLine("12:" + inputArray[1] + " PM");
                    }
                    else if (inputH == 00)
                    {
                        Console.WriteLine("12:" + inputArray[1] + " AM");
                    }
                    else
                    {
                        Console.WriteLine(inputH + ":" + inputArray[1] + " AM");
                    }
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.ReadKey();
        }
    }
}
