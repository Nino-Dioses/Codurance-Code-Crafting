using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCLibrary.BankPrint
{
    public class Formatter
    {
        private decimal amount;
        private DateTime date;
        public Formatter(DateTime date, decimal amount)
        {
            this.date = date;
            this.amount = amount;
        }

        public string ConvertToString()
        {
            return $"{date} | {String.Format(CultureInfo.CreateSpecificCulture("en-US"), "{0:0.00}", amount)}";
        }
    }
}
