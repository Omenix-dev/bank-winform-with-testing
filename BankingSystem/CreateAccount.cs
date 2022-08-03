using System;
using System.Drawing;
using System.Windows.Forms;
using Data.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using Model;
using System.Threading.Tasks;
using Utility;

namespace BankingSystem
{
    public partial class CreateAccount : Form
    {
        private int AccountType = -1;
        private decimal Amount;
        IProtocols Protocols;
        IServiceProvider service;
        IAccountRespository bankRepository;
        private Control[] dummyContainer = new Control[10];
        public CreateAccount(IServiceProvider service, IProtocols protocols, IAccountRespository bank)
        {
            InitializeComponent();
            bankRepository = bank;
            this.Protocols = protocols;
            this.service = service;
        }
        private void Logout_Click(object sender, EventArgs e)
        {
            Protocols.SESSIONS.Logout();
            var Welcome = service.GetRequiredService<Welcome>();
            this.Hide();
            Welcome.Show();
        }
      
        private async void createButt_Click(object sender, EventArgs e)
        {
            if (AccountType < 0)
            {
                CreationErr.Visible = true;
                CreationErr.Text = "Please select an Account Choice you wish to use create";
            }
            else
            {
                Amount = CreationAmount.Value;
                bool IsCreated = await bankRepository.Retrieve(AccountType, Amount,AccountGenerator.Generate());
                if (IsCreated)
                {
                    CreationErr.Visible = true;
                    CreationErr.Text = "Account was successfully created";
                    CreationErr.ForeColor = Color.Green;

                    await printAccount();

                }
                else
                {
                    CreationErr.Visible = true;
                    CreationErr.Text = "the amount deposited doesnt match the account type you selected";
                }
            }
        }

        private void Current_Account_Click_1(object sender, EventArgs e)
        {
            CreationErr.Text = "";
            CreationErr.Visible = false;
            AccountType = 1;
            if (Savings_Account.Checked) Savings_Account.Checked = false;
        }

        private void Savings_Account_Click(object sender, EventArgs e)
        {
            CreationErr.Text = "";
            CreationErr.Visible = false;
            AccountType = 0;
            if (Current_Account.Checked) Current_Account.Checked = false;
        }

        private void dashboard_butt_Paint(object sender, PaintEventArgs e)
        {

        }
        private async Task printAccount()
        {
            List<AccountDetails> value = Protocols.SESSIONS.SESSION.CustomerAccountDetails;

            // clears the panel to allow for loading the account details created
            this.dummyContainer[3] = dashBoard_panel;
            this.dashBoard_panel.Controls.Clear();

            // this section is used tom created the table for uploading the account details
            TableLayoutPanel Table = new();
            this.dummyContainer[0] = Table;
            Table.Location = new Point(50, 20);
            Table.Size = new Size(786, 29);
            Table.AutoSize = true;
            Table.Name = "AccountTable";
            Table.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            Table.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Table.GrowStyle = TableLayoutPanelGrowStyle.AddRows;

            
            // print the header page
            Table.Controls.Add(new Label { Text = "         Account Type               ", Anchor = AnchorStyles.None, AutoSize = true, ForeColor = Color.FromArgb(44, 62, 80) }, 0, 0);
            Table.Controls.Add(new Label { Text = "               Account Number               ", Anchor = AnchorStyles.None, AutoSize = true, ForeColor = Color.FromArgb(44, 62, 80) }, 1, 0);
            Table.Controls.Add(new Label { Text = "Account Balance", Anchor = AnchorStyles.None, AutoSize = true, ForeColor = Color.FromArgb(44, 62, 80) }, 2, 0);

            // prepopulate the value in the table
            List <Task<Label>> tasks = new List<Task<Label>>();
            foreach(AccountDetails account in value)
            {
                 tasks.Add(Task.Run(()=> new Label { Text = $"\t   {account.AccountType}   \t", Anchor = AnchorStyles.None, AutoSize = true, ForeColor = Color.FromArgb(44, 62, 80) }));
                 tasks.Add(Task.Run(() => new Label { Text = $"\t   {account.AccountNumber}  \t", Anchor = AnchorStyles.None, AutoSize = true, ForeColor = Color.FromArgb(44, 62, 80) }));
                 tasks.Add(Task.Run(() => new Label { Text = $"\t   {account.Balance.ToString("#.00")}   \t", Anchor = AnchorStyles.None, AutoSize = true, ForeColor = Color.FromArgb(44, 62, 80) }));
            }
            var val = await Task.WhenAll(tasks);
            int i , x;
            i = 0;
            x = 1;   
            foreach(var task in val)
            {
                Table.Controls.Add(task,i,x);
                if(i == 2)
                {
                    i = 0;
                    x++;
                    continue;
                }
                i++;
            }
            this.dashBoard_panel.Controls.Add(Table);

            //goto back to the account creation section 
            Button backbutton = new();
            this.dummyContainer[1] = backbutton;
            backbutton.Size = new Size(575, 51);
            backbutton.Location = new Point(177, 521);
            backbutton.Text = "Back to Account Creation";
            backbutton.BackColor = Color.FromArgb(44, 62, 80);
            backbutton.Name = "ReturnButton";
            backbutton.FlatStyle = FlatStyle.Flat;
            backbutton.ForeColor = Color.FromArgb(255,255,255);
            backbutton.UseVisualStyleBackColor = true;
            backbutton.Click += new System.EventHandler(backbutton_Click);
            this.dashBoard_panel.Controls.Add(backbutton);
        }
        private void backbutton_Click(object sender, EventArgs e)
        {
            dashBoard_panel.Controls.Clear();
            dashBoard_panel.Controls.Add(this.label4);
            dashBoard_panel.Controls.Add(this.CreationAmount);
            dashBoard_panel.Controls.Add(this.createButt);
            dashBoard_panel.Controls.Add(this.Savings_Account);
            dashBoard_panel.Controls.Add(this.Current_Account);
            dashBoard_panel.Controls.Add(this.groupBox1);
            dashBoard_panel.Controls.Add(this.panel8);
            dashBoard_panel.Location = new System.Drawing.Point(3, 102);
            dashBoard_panel.Name = "dashBoard_panel";
            dashBoard_panel.Size = new System.Drawing.Size(869, 592);
            dashBoard_panel.TabIndex = 21;
        }

        private void CreateAccount_FormClosed(object sender, FormClosedEventArgs e)
        {
            Protocols.SESSIONS.Logout();
            var Welcome = service.GetRequiredService<Welcome>();
            Welcome.Close();
        }

        private void CreateAccount_Load(object sender, EventArgs e) 
        {
            Username.Text = $"Welcome {Protocols.SESSIONS.SESSION.PersonalDetails.Name}";
            button1_Click(this, e);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Deposit_butt.BackColor = Color.FromArgb(44, 62, 80);
            Print_butt.BackColor = Color.FromArgb(44, 62, 80);
            Create_butt.BackColor = Color.FromArgb(44, 62, 80);
            Dash_butt.BackColor = Color.White;
            Withdraw_butt.BackColor = Color.FromArgb(44, 62, 80);
            Transfer_butt.BackColor = Color.FromArgb(44, 62, 80);

            Deposit_butt.ForeColor = Color.White;
            Print_butt.ForeColor = Color.White;
            Create_butt.ForeColor = Color.White;
            Dash_butt.ForeColor = Color.FromArgb(44, 62, 80);
            Withdraw_butt.ForeColor = Color.White;
            Transfer_butt.ForeColor = Color.White;

            this.dashboard_Parent.Controls.Clear();
            var dashboard = service.GetRequiredService<dashboard>();
            this.CreationErr.Visible = false;
            //this.dashboard_Parent.Padding = new Padding(0,-30,0,0);
            this.dashboard_Parent.Controls.Add(this.Logout);
            this.dashboard_Parent.Controls.Add(dashboard.panel2);
            this.dashboard_Parent.Controls.Add(dashboard.panel3);
            this.dashboard_Parent.Controls.Add(dashboard.panel4);
            this.dashboard_Parent.Controls.Add(dashboard.panel5);
            this.dashboard_Parent.Controls.Add(dashboard.panel6);
            this.dashboard_Parent.Controls.Add(dashboard.panel7);
            this.dashboard_Parent.Controls.Add(dashboard.panel8);
        }

        private async void Deposit_butt_Click(object sender, EventArgs e)
        {
            TableLayoutPanel Table1 = new();
            Table1.AutoSize = true;

            Deposit_butt.BackColor = Color.White;
            Print_butt.BackColor = Color.FromArgb(44, 62, 80);
            Create_butt.BackColor = Color.FromArgb(44, 62, 80);
            Dash_butt.BackColor = Color.FromArgb(44, 62, 80);
            Withdraw_butt.BackColor = Color.FromArgb(44, 62, 80);
            Transfer_butt.BackColor = Color.FromArgb(44, 62, 80);

            Deposit_butt.ForeColor = Color.FromArgb(44, 62, 80);
            Print_butt.ForeColor = Color.White;
            Create_butt.ForeColor = Color.White;
            Dash_butt.ForeColor = Color.White;
            Withdraw_butt.ForeColor = Color.White;
            Transfer_butt.ForeColor = Color.White;

            var Deposit = service.GetRequiredService<deposit>();
            await Task.Run(()=>Deposit.loadAccounts());
            Table1.Controls.AddRange(Deposit.Radio_button);

            this.dashboard_Parent.Controls.Clear();
            this.dashboard_Parent.Controls.Add(this.Logout);
            Deposit.panel1.Controls.Add(Table1);
            this.dashboard_Parent.Controls.Add(Deposit.dashboard_Parent);
        }

        private async void Withdraw_butt_Click(object sender, EventArgs e)
        {
            TableLayoutPanel Table1 = new();
            Table1.AutoSize = true;

            Deposit_butt.BackColor = Color.FromArgb(44, 62, 80);
            Print_butt.BackColor = Color.FromArgb(44, 62, 80);
            Create_butt.BackColor = Color.FromArgb(44, 62, 80);
            Dash_butt.BackColor = Color.FromArgb(44, 62, 80);
            Withdraw_butt.BackColor = Color.White;
            Transfer_butt.BackColor = Color.FromArgb(44, 62, 80);

            Deposit_butt.ForeColor = Color.White;
            Print_butt.ForeColor = Color.White;
            Create_butt.ForeColor = Color.White;
            Dash_butt.ForeColor = Color.White;
            Withdraw_butt.ForeColor = Color.FromArgb(44, 62, 80);
            Transfer_butt.ForeColor = Color.White;

            var Withdrawal = service.GetRequiredService<Withdrawal>();
            await Task.Run(() => Withdrawal.loadAccounts());
            Table1.Controls.AddRange(Withdrawal.Radio_button);

            this.dashboard_Parent.Controls.Clear();
            this.dashboard_Parent.Controls.Add(this.Logout);
            Withdrawal.panel1.Controls.Add(Table1);
            this.dashboard_Parent.Controls.Add(Withdrawal.dashboard_Parent);
        }

        private async void Transfer_butt_Click(object sender, EventArgs e)
        {
            TableLayoutPanel Table1 = new();
            Table1.AutoSize = true;

            Deposit_butt.BackColor = Color.FromArgb(44, 62, 80);
            Print_butt.BackColor = Color.FromArgb(44, 62, 80);
            Create_butt.BackColor = Color.FromArgb(44, 62, 80);
            Dash_butt.BackColor = Color.FromArgb(44, 62, 80);
            Withdraw_butt.BackColor = Color.FromArgb(44, 62, 80);
            Transfer_butt.BackColor = Color.White;

            Deposit_butt.ForeColor = Color.White;
            Print_butt.ForeColor = Color.White;
            Create_butt.ForeColor = Color.White;
            Dash_butt.ForeColor = Color.White;
            Withdraw_butt.ForeColor = Color.White;
            Transfer_butt.ForeColor = Color.FromArgb(44, 62, 80);

            var Transfer = service.GetRequiredService<Transfer>();
            await Task.Run(() => Transfer.loadAccounts());
            Table1.Controls.AddRange(Transfer.Radio_button);

            this.dashboard_Parent.Controls.Clear();
            this.dashboard_Parent.Controls.Add(this.Logout);
            Transfer.panel1.Controls.Add(Table1);
            this.dashboard_Parent.Controls.Add(Transfer.dashboard_Parent);
        }

        private async void Print_butt_Click(object sender, EventArgs e)
        {
            TableLayoutPanel Table1 = new();
            Table1.AutoSize = true;

            Deposit_butt.BackColor = Color.FromArgb(44, 62, 80);
            Print_butt.BackColor = Color.White;
            Create_butt.BackColor = Color.FromArgb(44, 62, 80);
            Dash_butt.BackColor = Color.FromArgb(44, 62, 80);
            Withdraw_butt.BackColor = Color.FromArgb(44, 62, 80);
            Transfer_butt.BackColor = Color.FromArgb(44, 62, 80);

            Deposit_butt.ForeColor = Color.White;
            Print_butt.ForeColor = Color.FromArgb(44, 62, 80);
            Create_butt.ForeColor = Color.White;
            Dash_butt.ForeColor = Color.White;
            Withdraw_butt.ForeColor = Color.White;
            Transfer_butt.ForeColor = Color.White;

            var PrintStatement = service.GetRequiredService<PrintStatement>();
            await Task.Run(() => PrintStatement.loadAccounts());
            Table1.Controls.AddRange(PrintStatement.Radio_button);

            this.dashboard_Parent.Controls.Clear();
            this.dashboard_Parent.Controls.Add(this.Logout);
            PrintStatement.panel1.Controls.Add(Table1);
            this.dashboard_Parent.Controls.Add(PrintStatement.dashboard_Parent);
        }

        private void Create_butt_Click(object sender, EventArgs e)
        {
            Deposit_butt.BackColor = Color.FromArgb(44, 62, 80);
            Print_butt.BackColor = Color.FromArgb(44, 62, 80);
            Create_butt.BackColor = Color.White;
            Dash_butt.BackColor = Color.FromArgb(44, 62, 80);
            Withdraw_butt.BackColor = Color.FromArgb(44, 62, 80);
            Transfer_butt.BackColor = Color.FromArgb(44, 62, 80);

            Deposit_butt.ForeColor = Color.White;
            Print_butt.ForeColor = Color.White;
            Create_butt.ForeColor = Color.FromArgb(44, 62, 80);
            Dash_butt.ForeColor = Color.White;
            Withdraw_butt.ForeColor = Color.White;
            Transfer_butt.ForeColor = Color.White;

            this.dashboard_Parent.Controls.Clear();
            this.dashboard_Parent.Controls.Add(this.dashBoard_panel);
            this.dashboard_Parent.Controls.Add(this.CreationErr);
            this.dashboard_Parent.Controls.Add(this.Logout);
            this.dashboard_Parent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashboard_Parent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboard_Parent.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dashboard_Parent.ForeColor = System.Drawing.Color.White;
            this.dashboard_Parent.Location = new System.Drawing.Point(227, 3);
            this.dashboard_Parent.Name = "dashboard_Parent";
            this.dashboard_Parent.Size = new System.Drawing.Size(875, 697);
            this.dashboard_Parent.TabIndex = 1;
            this.dashboard_Parent.Paint += new System.Windows.Forms.PaintEventHandler(this.dashboard_butt_Paint);
        }

    }
}

