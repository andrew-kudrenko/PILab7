using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PILab7
{
    internal class PresetAccounts
    {
        public static BindingList<Account> DefaultAccounts = new BindingList<Account>() {
            new Account("0", "King") { InterestRate = 5, Balance = 210 },
            new Account("1", "Dreiser") { InterestRate = 20, Balance = 843 },
            new Account("2", "Hugo") { InterestRate = 12, Balance = 17.3 },
            new Account("3", "Dreiser") { InterestRate = 15, Balance = 654.15 },
            new Account("4", "Show") { InterestRate = 22, Balance = 230 },
            new Account("5", "Hucksley") { InterestRate = 43, Balance = 1167.3 },
            new Account("6", "Hugo") { InterestRate = 2, Balance = 400 },
        };
    }
}
