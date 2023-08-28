using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public  static class ExtensionTime
    {
        public static string ElapsedTime(this DateTime thisObj)
        {
            TimeSpan duration =  DateTime.Now.Subtract(thisObj);    
            if(duration.TotalHours < 24)
            {
                return duration.TotalHours.ToString("F1",CultureInfo.InvariantCulture) + "hours";
            }
            else
            {
                return duration.TotalDays.ToString("F1",CultureInfo.InvariantCulture) + "days";
            }

         
        }
    }
}
