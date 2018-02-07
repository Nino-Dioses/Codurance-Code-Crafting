using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCLibrary.BankPrint
{
    public class RepoItem
    {
        private decimal amount;
        private DateTime date;

        public RepoItem(decimal amount, DateTime date)
        {
            this.amount = amount;
            this.date = date;
        }

        public decimal Amount
        {
            get
            {
                return amount;
            }
           
        }

        public DateTime Date
        {
            get
            {
                return date;
            }
        }
           
    }
}
