namespace BankAccountsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            BankAccount bankAccount = new BankAccount("Zeynep Nur Aksay");
            BankAccount bankAccount2 = new BankAccount("Elon Musk");
            BankAccount bankAccount3 = new BankAccount("Bill Gates");

            List<BankAccount> bankAccounts = new List<BankAccount>()
            {
                bankAccount,
                bankAccount2,
                bankAccount3
            };

            BankAccountGrid.DataSource = bankAccounts;
        }

        private void CreateAccountBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clicked");
        }
    }
}
