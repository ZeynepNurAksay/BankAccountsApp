namespace BankAccountsApp
{
    public partial class Form1 : Form
    {
        List<BankAccount> BankAccounts = new List<BankAccount>();
        public Form1()
        {
            InitializeComponent();
        }

        private void CreateAccountBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(OwnerTxt.Text))
            {
                BankAccount bankAccount = new BankAccount(OwnerTxt.Text);
                BankAccounts.Add(bankAccount);
                OwnerTxt.Text = "";
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
        }
    }
}
