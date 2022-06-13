using System;

namespace PILab7
{
    internal class Account: IComparable<Account>
    {
        public readonly string Id;
        public string Surname { get; private set; } = "";
        public double Balance { get; set; } = 0;
        public double InterestRate { get; set; } = 0;

        public Account(string id)
        {
            Id = id;
        }

        public Account(string id, string surname)
        {
            Id = id;
            Surname = surname;
        }

        public string GetInfo()
        {
            return $"ID: {Id}; First Name: {Surname}; Balance: {Balance}; Rate: {InterestRate}";
        }

        public double Exchange(double cost) => Balance * cost;

        public void ChangeOwner(string surname)
        {
            Surname = surname;
        }

        public void ChargeInterest()
        {
            Balance += Balance * InterestRate;
        }

        public int CompareTo(Account acc)
        {
            int bySurname = Surname.CompareTo(acc.Surname);
            int byBalance = Balance.CompareTo(acc.Balance);

            return bySurname + byBalance;
        }

        public override string ToString() => GetInfo();

        public static Account operator +(Account a, double incoming) => new Account(a.Id)
        {
            Surname = a.Surname,
            InterestRate = a.InterestRate,
            Balance = a.Balance + incoming,
        };
        public static Account operator -(Account a, double outcoming) => new Account(a.Id)
        {
            Surname = a.Surname,
            InterestRate = a.InterestRate,
            Balance = a.Balance - outcoming,
        };
    }
}
