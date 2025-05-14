namespace BankAccountApp_1
{
    public partial class ownerText : Form
    {
        public ownerText()
        {
            InitializeComponent();
            BankAccount bankAccount1 = new BankAccount();
            bankAccount1.Owner = "Vinay";
            bankAccount1.AccountNumber = Guid.NewGuid();
            bankAccount1.Balance = 250;

            BankAccount bankAccount2 = new BankAccount();
            bankAccount2.Owner = "Rahul";
            bankAccount2.AccountNumber = Guid.NewGuid();
            bankAccount2.Balance = 2120;

            BankAccount bankAccount3 = new BankAccount();
            bankAccount3.Owner = "Sakshi";
            bankAccount3.AccountNumber = Guid.NewGuid();
            bankAccount3.Balance = 2230;

            List<BankAccount> bankAccounts = new List<BankAccount>();   
            bankAccounts.Add(bankAccount1); 
            bankAccounts.Add(bankAccount2);
            bankAccounts.Add(bankAccount3);

            BankAccountGrid.DataSource = bankAccounts;  

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
