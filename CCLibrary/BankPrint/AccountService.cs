using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCLibrary.BankPrint
{
    public class AccountService
    {
        private IPrinter printer;
        private IDater dater;
        private RepositoryService repo;

        public AccountService(IPrinter printer, IDater dater, RepositoryService repo)
        {
            this.printer = printer;
            this.repo = repo;
        }

        public void Deposit(Decimal amount)
        {
            repo.SaveData(amount, dater.GetDate());
        }

        public void WithDraw(Decimal amount)
        {
            repo.SaveData(-amount, dater.GetDate());
        }

        public void PrintStatement()
        {
            var data = repo.GetData(0);
            Formatter formatter = new Formatter(data.Date, data.Amount);
            printer.PrintLn(formatter.ConvertToString());
        }
    }
}
