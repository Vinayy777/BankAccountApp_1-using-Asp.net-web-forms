namespace BankAccountApp_1
{
    partial class ownerText
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            AmountNum = new NumericUpDown();
            BankAccountGrid = new DataGridView();
            createaccountBtn = new Button();
            depositBtn = new Button();
            withdrawBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)AmountNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BankAccountGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 58);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(84, 32);
            label1.TabIndex = 0;
            label1.Text = "Owner";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 390);
            label2.Name = "label2";
            label2.Size = new Size(100, 32);
            label2.TabIndex = 1;
            label2.Text = "Amount";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(129, 58);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(283, 39);
            textBox1.TabIndex = 2;
            // 
            // AmountNum
            // 
            AmountNum.Location = new Point(145, 390);
            AmountNum.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            AmountNum.Minimum = new decimal(new int[] { 1, 0, 0, int.MinValue });
            AmountNum.Name = "AmountNum";
            AmountNum.Size = new Size(120, 39);
            AmountNum.TabIndex = 3;
            // 
            // BankAccountGrid
            // 
            BankAccountGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BankAccountGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BankAccountGrid.Location = new Point(441, 58);
            BankAccountGrid.Name = "BankAccountGrid";
            BankAccountGrid.RowHeadersWidth = 62;
            BankAccountGrid.Size = new Size(570, 371);
            BankAccountGrid.TabIndex = 4;
            // 
            // createaccountBtn
            // 
            createaccountBtn.Location = new Point(129, 137);
            createaccountBtn.Name = "createaccountBtn";
            createaccountBtn.Size = new Size(283, 66);
            createaccountBtn.TabIndex = 5;
            createaccountBtn.Text = "Create Account";
            createaccountBtn.UseVisualStyleBackColor = true;
            createaccountBtn.Click += createaccountBtn_Click;
            // 
            // depositBtn
            // 
            depositBtn.Location = new Point(441, 470);
            depositBtn.Name = "depositBtn";
            depositBtn.Size = new Size(251, 84);
            depositBtn.TabIndex = 6;
            depositBtn.Text = "Deposit";
            depositBtn.UseVisualStyleBackColor = true;
            depositBtn.Click += depositBtn_Click;
            // 
            // withdrawBtn
            // 
            withdrawBtn.Location = new Point(737, 476);
            withdrawBtn.Name = "withdrawBtn";
            withdrawBtn.Size = new Size(274, 78);
            withdrawBtn.TabIndex = 7;
            withdrawBtn.Text = "Withdraw";
            withdrawBtn.UseVisualStyleBackColor = true;
            withdrawBtn.Click += withdrawBtn_Click;
            // 
            // ownerText
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 576);
            Controls.Add(withdrawBtn);
            Controls.Add(depositBtn);
            Controls.Add(createaccountBtn);
            Controls.Add(BankAccountGrid);
            Controls.Add(AmountNum);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "ownerText";
            Text = "Owner";
            ((System.ComponentModel.ISupportInitialize)AmountNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)BankAccountGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private NumericUpDown AmountNum;
        private DataGridView BankAccountGrid;
        private Button createaccountBtn;
        private Button depositBtn;
        private Button withdrawBtn;
    }
}
