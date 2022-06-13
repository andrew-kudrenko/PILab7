using System.ComponentModel;
using System.Linq;
using System.Collections.Generic;

namespace PILab7
{
    internal class AccountCollection
    {
        public BindingList<Account> Items { get; } = new BindingList<Account>();

        public void SetItems(BindingList<Account> accounts)
        {
            Items.Clear();
            
            foreach (var account in accounts) { 
                Items.Add(account);
            }
        }

        public BindingList<Account> OfInterestRate(double rate) {
            var items = Items.Where(a => a.InterestRate == rate).ToList();

            return new BindingList<Account>(items);
        }
        public string FindOwnerWithMaxBalance()
        {
            var owners = Items
                .GroupBy(a => a.Surname)
                .Select(g => new { Owner = g.Key, Total = g.Select(a => a.Balance).Sum() })
                .ToList();

            owners.Sort((a, b) => (int)(b.Total - a.Total));

            return owners.ElementAt(0).Owner;
        }

        public void Sort()
        {
            var ordered = Items.ToList();
            ordered.Sort();

            SetItems(new BindingList<Account>(ordered));
        }
    }
}
