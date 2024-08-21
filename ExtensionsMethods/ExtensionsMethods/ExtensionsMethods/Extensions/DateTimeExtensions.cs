using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace System {
    static class DateTimeExtensions {
        public static string ElapsedTime(this DateTime thisObj) {
            TimeSpan duration = DateTime.Now.Subtract(thisObj);
            if (duration.TotalHours < 24) {
                return duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " hours";
            }
            else if (duration.TotalHours < 24 && duration.TotalHours < 240) {
                return duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " days";
            }
            else {
                double months = duration.TotalDays / 30;
                return months.ToString("F1", CultureInfo.InvariantCulture) + " months";
            }
        }
    }
}
