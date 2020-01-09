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
            IChecker time01 = new RegexCheck();
            Console.WriteLine("輸入24時制時間: ");
            string militaryTime = Console.ReadLine();
            Console.WriteLine(time01.MilitaryTimeToRegularTime(militaryTime));
            Console.ReadKey();
        }
    }
}