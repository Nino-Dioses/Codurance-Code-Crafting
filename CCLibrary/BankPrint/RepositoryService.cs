using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCLibrary.BankPrint
{
    public class RepositoryService 
    {
        private List<RepoItem> amounts;

        public RepositoryService()
        {
            this.amounts = new List<RepoItem>();
        }
        public RepoItem GetData(int row)
        {
            return this.amounts[row];
        }

        public void SaveData(decimal amount, DateTime date)
        {
            this.amounts.Add(new RepoItem(amount, date));
        }
    }
}
