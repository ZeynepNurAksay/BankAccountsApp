namespace BankAccountsApp
{
    public partial class Form1 : Form
    {
        List<BankAccount> BankAccounts = new List<BankAccount>();
        public Form1()
        {
            InitializeComponent();
            if (BankAccounts.Count == 0)
            {
                DepositBtn.Enabled = false;
                WithdrawBtn.Enabled = false;
            }
        }

        private void CreateAccountBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(OwnerTxt.Text))
            {
                if(InterestRateNum.Value == 0)
                {
                    BankAccount bankAccount = new BankAccount(OwnerTxt.Text);
                    BankAccounts.Add(bankAccount);
                }
                else
                {
                    SavingsAccount savingsAccount = new SavingsAccount($"{OwnerTxt.Text} ({InterestRateNum.Value}%)", InterestRateNum.Value);
                    BankAccounts.Add(savingsAccount);
                }

                OwnerTxt.Text = "";
                InterestRateNum.Value = 0;
                DepositBtn.Enabled = true;
                WithdrawBtn.Enabled = true;

            }
            else
            {
                MessageBox.Show("You tried to submit an empty string. Please try again by entering the name of the account owner.");
            }


            RefreshGrid();

        }

        private void RefreshGrid()
        {
            BankAccountGrid.DataSource = null;
            BankAccountGrid.DataSource = BankAccounts;
            BankAccountGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            BankAccountGrid.MultiSelect = false;
        }

        private void DepositBtn_Click(object sender, EventArgs e)
        {

            GetSelectedAccount().Deposit(AmountNum.Value);
            RefreshGrid();
        }

        private BankAccount GetSelectedAccount()
        {
            if (BankAccountGrid.CurrentRow.DataBoundItem is BankAccount account)
            {
                return account;
            }
            return null;
        }

        private void WithdrawBtn_Click(object sender, EventArgs e)
        {
            GetSelectedAccount().Withdraw(AmountNum.Value);

            RefreshGrid();
        }
    }
}
