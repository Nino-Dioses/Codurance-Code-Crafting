using System;

namespace CCLibrary.PaymentGateway
{
    public class User
    {
        private string name;
        private string account;

        public User(string name, string account)
        {
            this.name = name;
            this.account = account;
        }

        internal string GetAccount()
        {
            return this.account;
        }
    }
}