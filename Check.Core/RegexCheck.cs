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
        public String MilitaryTimeToRegularTime(string militaryTime)
        {
            int inputH;
            string[] inputArray;
            Regex regex = new Regex(@"^([0-1][0-9]|20|21|22|23)\:[0-5][0-9]$");

            bool result = false;
            try
            {
                result = regex.IsMatch(militaryTime);
                if (result)
                {
                    inputArray = militaryTime.Split(':');
                    inputH = Convert.ToInt32(inputArray[0]);
                    if (inputH > 12)
                    {
                        inputH -= 12;
                        return (inputH + ":" + inputArray[1] + " PM");
                    }
                    else if (inputH == 12)
                    {
                        return (inputH + ":" + inputArray[1] + " PM");
                    }
                    else if (inputH == 00)
                    {
                        return ("12:" + inputArray[1] + " AM");
                    }
                    else
                    {
                        return (inputH + ":" + inputArray[1] + " AM");
                    }
                }
                else
                {
                    return ("Error");
                }
            }
            catch (Exception ex)
            {
                return (ex.ToString());
            }
        }
    }

}
