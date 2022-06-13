using System;
using System.Collections.Generic;using System.Windows.Forms;

namespace PILab7
{
    enum FormMode
    {
        View,
        Edit,
        Create,
    }

    public partial class AccountForm : Form
    {
        private int _activeIndex = 0;
        private FormMode _mode;
        private FormMode Mode { 
            get { return _mode; } 
            set {
                _mode = value;
                UpdateFormState();
            } 
        }
        private AccountCollection RestorableAccounts = new AccountCollection();
        private readonly AccountCollection Accounts = new AccountCollection();
        private readonly AccountCollection ByInterestRate = new AccountCollection();

        public AccountForm()
        {
            InitializeComponent();
            Mode = FormMode.View;
            AccountsData.DataSource = Accounts.Items;
            ByInterestRateData.DataSource = ByInterestRate.Items;
        }

        private void InitializeForm(object sender, EventArgs e)
        {
            Accounts.SetItems(PresetAccounts.DefaultAccounts);
            SetRestorableAcounts();
        }

        private void OnCreateItem(object sender, EventArgs e)
        {
            Mode = FormMode.Create;
            Accounts.Items.Add(new Account(DateTime.Now.ToString()));
        }

        private void OnViewItem(object sender, EventArgs e)
        {
            Mode = FormMode.View;
            SetFormFields(Accounts.Items[_activeIndex]);
        }

        private void OnEditItem(object sender, EventArgs e)
        {
            Mode = FormMode.Edit;
           SetFormFields(Accounts.Items[_activeIndex]);
        }

        private void OnSaveCollection(object sender, EventArgs e)
        {
            if (Mode == FormMode.Edit)
            {
                Accounts.Items[_activeIndex] = GetFormFields();
            }

            SetRestorableAcounts();
            Mode = FormMode.View;
        }

        private void OnLoadCollection(object sender, EventArgs e)
        {
            Accounts.SetItems(RestorableAccounts.Items);
            SetRestorableAcounts();
        }

        private void SetFormFields(Account account)
        {
            SurnameTextBox.Text = account?.Surname ?? string.Empty;
            InterestRateTextBox.Text = account?.InterestRate.ToString() ?? 0.ToString();
            BalanceTextBox.Text = account?.Balance.ToString() ?? 0.ToString();
        }

        private void SetRestorableAcounts()
        {
            RestorableAccounts.SetItems(Accounts.Items);
        }

        private Account GetFormFields()
        {
            var existing = Accounts.Items[_activeIndex];
            
            return new Account(existing.Id, SurnameTextBox.Text)
            {
                InterestRate = double.Parse(InterestRateTextBox.Text),
                Balance = double.Parse(BalanceTextBox.Text),
            };
        }

        private void UpdateFormState()
        {
            List<TextBox> controls = new List<TextBox>() { 
                SurnameTextBox,
                InterestRateTextBox, 
                BalanceTextBox, 
            };

            bool enabled = Mode != FormMode.View;
            SaveFormButton.Enabled = enabled;
            
            foreach (var control in controls) {
                control.Enabled = enabled;
            }
        }

        private void OnCellClick(object sender, DataGridViewCellEventArgs e)
        {
            _activeIndex = e.RowIndex;
        }

        private void OnFindTheRichest(object sender, EventArgs e)
        {
            ReachestOwnerTextBox.Text = Accounts.FindOwnerWithMaxBalance();
        }

        private void OnTakeByRate(object sender, EventArgs e)
        {
            double rate = double.Parse(InterestRateFilteringTextBox.Text);
            ByInterestRate.SetItems(Accounts.OfInterestRate(rate));
        }

        private void OnSort(object sender, EventArgs e)
        {
            Accounts.Sort();
        }
    }
}
