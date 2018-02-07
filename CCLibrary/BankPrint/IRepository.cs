namespace CCLibrary.BankPrint
{
    public interface IRepository
    {
        void SaveData(decimal amount);
        decimal GetData(int row);
    }
}