using System;
using System.Collections.Generic;
using System.Text;

namespace WpfApp3
{
   public class DateTimeService: IDateTimeService
    {
        public string GetDateTimeString() {
            return DateTime.Today.ToShortDateString();
        }
    }
}
