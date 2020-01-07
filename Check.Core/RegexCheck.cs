using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Check.Core
{
    public class RegexCheck : IChecker
    {
        public bool MilitaryTimeToRegularTime(string militaryTime)
        {
            bool result = false;
            try
            {
                Regex regex = new Regex(@"^([0-1][0-9]|20|21|22|23)\:[0-5][0-9]$");

                return regex.IsMatch(militaryTime);
            }
            catch(Exception exp)
            {
                Console.WriteLine(exp.ToString());
            }
            return result;
        }
    }

}
