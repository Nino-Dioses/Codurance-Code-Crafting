using CCLibrary.BankPrint;
using FakeItEasy;
using Xunit;

namespace CCLibrary.Tests.BankPrint
{
    public class Printer_should
    {
        [Fact]
        public void Print_bank_statement_on_reverse_order()
        {
            var printerMock = A.Fake<IPrinter>();
            var daterMock = A.Fake<IDater>();
            var repository = new RepositoryService();
            AccountService acountService = new AccountService(printerMock, daterMock, repository);

            acountService.Deposit(1000);
            acountService.WithDraw(100);
            acountService.Deposit(500);

            acountService.PrintStatement();

            A.CallTo(() => printerMock.PrintLn("DATE | AMOUNT | BALANCE ")).MustHaveHappened();
            A.CallTo(() => printerMock.PrintLn("10/04/2014 | 500.00 | 1400.00")).MustHaveHappened();
            A.CallTo(() => printerMock.PrintLn("02/04/2014 | -100.00 | 900.00")).MustHaveHappened();
            A.CallTo(() => printerMock.PrintLn("01/04/2014 | 1000.00 | 1000.00")).MustHaveHappened();

        }
    }

    public class AccountService_should
    {
        [Fact]
        public void Process_a_deposit()
        {
            var printerMock = A.Fake<IPrinter>();
            var daterMock = A.Fake<IDater>();
            var repository = new RepositoryService();
            AccountService acountService = new AccountService(printerMock, daterMock, repository);
            acountService.Deposit(1000);
            A.CallTo(() => repository.SaveData(1000, daterMock.GetDate())).MustHaveHappened();
        }

        [Fact]
        public void Process_a_withdraw()
        {
            var printerMock = A.Fake<IPrinter>();
            var daterMock = A.Fake<IDater>();
            var repository = new RepositoryService();
            AccountService acountService = new AccountService(printerMock, daterMock, repository);
            acountService.WithDraw(100);
            A.CallTo(() => repository.SaveData(-100, daterMock.GetDate())).MustHaveHappened();
        }
        
        [Fact]
        public void Print_a_line_withformat()
        {
            var printerMock = A.Fake<IPrinter>();
            var daterMock = A.Fake<IDater>();
            var repository = new RepositoryService();
            AccountService acountService = new AccountService(printerMock, daterMock, repository);
            acountService.Deposit(500);
            acountService.PrintStatement();
            A.CallTo(() => printerMock.PrintLn("07/02/2018 | 500.00")).MustHaveHappened();
        }
    }

    public class RepositoryService_should
    {
        [Fact]
        public void Save_one_data()
        {
            var daterMock = A.Fake<IDater>();
            RepositoryService repository = new RepositoryService();
            repository.SaveData(300, daterMock.GetDate());

            Assert.Equal(repository.GetData(0), new RepoItem(300, daterMock.GetDate()));
        }

        [Fact]
        public void Save_two_data()
        {
            var daterMock = A.Fake<IDater>();
            RepositoryService repository = new RepositoryService();
            repository.SaveData(300, daterMock.GetDate());
            repository.SaveData(400, daterMock.GetDate());

            Assert.Equal(repository.GetData(0), new RepoItem(300,daterMock.GetDate()));
            Assert.Equal(repository.GetData(1), new RepoItem(300, daterMock.GetDate()));
        }
    }
}
