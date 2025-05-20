namespace BankAccountApp_1
{
    public partial class ownerText : Form
    {
        List<BankAccount> bankAccounts = new List<BankAccount>();
        public ownerText()
        {
            InitializeComponent();
            /*
             * this all are hard coded 
             * BankAccount bankAccount1 = new BankAccount("Vinay");
              //bankAccount1.Owner = "Vinay";
              //bankAccount1.AccountNumber = Guid.NewGuid();
              //bankAccount1.Balance = 250;

              BankAccount bankAccount2 = new BankAccount("Rahul");
              //bankAccount2.Owner = "Rahul";
              //bankAccount2.AccountNumber = Guid.NewGuid();
              //bankAccount2.Balance = 2120;

              // these are hard coded value which is going on in this class constructor and assigning value to field
              BankAccount bankAccount3 = new BankAccount("Sakshi");
              //bankAccount3.Owner = "Sakshi";
              //bankAccount3.AccountNumber = Guid.NewGuid();
              //bankAccount3.Balance = 2230;

              BankAccount bankAccount4 = new BankAccount("Kaju");

              List<BankAccount> bankAccounts = new List<BankAccount>();
              bankAccounts.Add(bankAccount1);
              bankAccounts.Add(bankAccount2);
              bankAccounts.Add(bankAccount3);
              bankAccounts.Add(bankAccount4);

           */










        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void createaccountBtn_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text.Trim();

            // Check if input is empty or an integer
            if (string.IsNullOrEmpty(input) || int.TryParse(input, out _))
            {
                MessageBox.Show("Please enter a valid non-numeric account name.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            BankAccount bankAccount1 = new BankAccount(input);
            bankAccounts.Add(bankAccount1);
            RefrishGrid();
            textBox1.Text = "";
        }


        private void RefrishGrid()
        {

            BankAccountGrid.DataSource = null;
            BankAccountGrid.DataSource = bankAccounts;


        }

        private void depositBtn_Click(object sender, EventArgs e)
        {

            if (BankAccountGrid.SelectedRows.Count == 1 && AmountNum.Value > 0)
            {
                BankAccount selectedRow = BankAccountGrid.SelectedRows[0].DataBoundItem as BankAccount;
                selectedRow.deposit(AmountNum.Value);
                RefrishGrid();
                AmountNum.Value = 0;

            }
            else
            {
                MessageBox.Show("selected one row and enter +ve amount");
            }
        }

        private void withdrawBtn_Click(object sender, EventArgs e)
        {

            if (BankAccountGrid.SelectedRows.Count == 1 && AmountNum.Value > 0)
            {
                BankAccount selectedRow = BankAccountGrid.SelectedRows[0].DataBoundItem as BankAccount;
                selectedRow.withdraw(AmountNum.Value);
                RefrishGrid();
                AmountNum.Value = 0;

            }
            else
            {
                MessageBox.Show("selected one row and withdraw few amount");
            }
        }
    }
}
