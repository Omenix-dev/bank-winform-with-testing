using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Model;
using System.Linq;
 

namespace BankingSystem
{
    public partial class PrintStatement : Form
    {
        private string accountNumber;
        IProtocols Protocols;
        IUserRespository User;
        public CheckBox[] Radio_button;
        public PrintStatement(IServiceProvider Services)
        {
            InitializeComponent();
            Protocols = Services.GetRequiredService<IProtocols>();
            User = Services.GetRequiredService<IUserRespository>();
            Radio_button = new CheckBox[Protocols.SESSIONS.SESSION.CustomerAccountDetails.Count];
        }
        private void RadioClicker(object sender, EventArgs e)
        {
            foreach (var pair in Radio_button)
            {
                pair.Checked = false;
            }
            var name = sender.GetType().GetProperty("Text").GetValue(sender).ToString();
            sender.GetType().GetProperty("Checked").SetValue(sender, true);// set the click button to be checked
            accountNumber = name.Substring(name.Length - 11);
            this.CreationErr.Visible = false;
        }
        public async Task loadAccounts()
        {
            int i = 0;
            foreach (var item in Protocols.SESSIONS.SESSION.CustomerAccountDetails)
            {
                await Task.Run(() => Radio_button[i] = new CheckBox());
                Radio_button[i].AutoSize = true;
                Radio_button[i].ForeColor = System.Drawing.Color.SeaGreen;
                Radio_button[i].Location = new System.Drawing.Point(16, 12);
                Radio_button[i].Name = $"Radio_button{i}";
                Radio_button[i].Size = new System.Drawing.Size(225, 32);
                Radio_button[i].TabIndex = 0;
                Radio_button[i].TabStop = true;
                Radio_button[i].Text = $"{item.AccountType} | {item.AccountNumber} ";
                //Radio_button[i].UseVisualStyleBackColor = true;
                Radio_button[i].Click += new System.EventHandler(this.RadioClicker);
                i++;
            };
        }

        private async void CreationErr_Click(object sender, EventArgs e)
        {
            if (accountNumber == null)
            {
                this.CreationErr.Visible = true;
                this.CreationErr.Text = "please Select an account and proceed";
            }
            this.Controls.Clear();
            await PrintTable();

        }
        private async Task PrintTable()
        {
            var value = from y in Protocols.SESSIONS.SESSION.CustomerAccountDetails
                        where y.AccountNumber == accountNumber.Trim()
                        select y.ValidTransactions;

            foreach(var transactions in value) 
            {
                // this section is used tom created the table for uploading the account details
                TableLayoutPanel Table = new();
                Table.Location = new Point(50, 20);
                Table.Size = new Size(786, 29);
                Table.AutoSize = true;
                Table.Name = "AccountTable";
                Table.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
                Table.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                Table.GrowStyle = TableLayoutPanelGrowStyle.AddRows;


                // print the header page
                Table.Controls.Add(new Label { Text = "Description", Anchor = AnchorStyles.None, AutoSize = true, ForeColor = Color.FromArgb(44, 62, 80) }, 0, 0);
                Table.Controls.Add(new Label { Text = "   Account Type  ", Anchor = AnchorStyles.None, AutoSize = true, ForeColor = Color.FromArgb(44, 62, 80) }, 0, 0);
                Table.Controls.Add(new Label { Text = "     Account Number     ", Anchor = AnchorStyles.None, AutoSize = true, ForeColor = Color.FromArgb(44, 62, 80) }, 1, 0);
                Table.Controls.Add(new Label { Text = "  Amount  ", Anchor = AnchorStyles.None, AutoSize = true, ForeColor = Color.FromArgb(44, 62, 80) }, 2, 0);
                Table.Controls.Add(new Label { Text = " Balance ", Anchor = AnchorStyles.None, AutoSize = true, ForeColor = Color.FromArgb(44, 62, 80) }, 3, 0);

                // prepopulate the value in the table
                List<Task<Label>> tasks = new List<Task<Label>>();
                foreach (var item in transactions)
                {
                    tasks.Add(Task.Run(() => new Label { Text = $"\t{item.TransactionDesc}\t", Anchor = AnchorStyles.None, AutoSize = true, ForeColor = Color.FromArgb(44, 62, 80) }));
                    tasks.Add(Task.Run(() => new Label { Text = $"\t   {item.accountType}   \t", Anchor = AnchorStyles.None, AutoSize = true, ForeColor = Color.FromArgb(44, 62, 80) }));
                    tasks.Add(Task.Run(() => new Label { Text = $"\t   {item.AccountNumber}  \t", Anchor = AnchorStyles.None, AutoSize = true, ForeColor = Color.FromArgb(44, 62, 80) }));
                    tasks.Add(Task.Run(() => new Label { Text = $"\t   #{item.TransactionAmount.ToString("#.00")}  \t", Anchor = AnchorStyles.None, AutoSize = true, ForeColor = Color.FromArgb(44, 62, 80) }));
                    tasks.Add(Task.Run(() => new Label { Text = $"\t #{item.balance.ToString("#.00")} \t", Anchor = AnchorStyles.None, AutoSize = true, ForeColor = Color.FromArgb(44, 62, 80) }));
                }
                var val = await Task.WhenAll(tasks);
                int i, x;
                i = 0;
                x = 1;
                foreach (var task in val)
                {
                    Table.Controls.Add(task, i, x);
                    if (i == 4)
                    {
                        i = 0;
                        x++;
                        continue;
                    }
                    i++;
                }
                this.dashBoard_panel.Controls.Add(Table);
            }
            //goto back to the account creation section 
            Button backbutton = new();
            backbutton.Size = new Size(575, 51);
            backbutton.Location = new Point(177, 521);
            backbutton.Text = "Back to Print Statement";
            backbutton.BackColor = Color.FromArgb(44, 62, 80);
            backbutton.Name = "ReturnButton";
            backbutton.FlatStyle = FlatStyle.Flat;
            backbutton.ForeColor = Color.FromArgb(255, 255, 255);
            backbutton.UseVisualStyleBackColor = true;
            backbutton.Click += new System.EventHandler(this.reloadPage_Click);
            this.dashBoard_panel.Controls.Add(backbutton);
        }
        private async void reloadPage_Click(object sender, EventArgs e)
        {
            this.dashBoard_panel.Controls.Clear();
            await this.loadAccounts();
            TableLayoutPanel Table1 = new();
            Table1.AutoSize = true;
            Table1.Controls.AddRange(this.Radio_button);
            this.dashBoard_panel.Controls.Add(this.panel8);
            this.dashBoard_panel.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(Table1);
            this.dashBoard_panel.Controls.Add(this.panel1);
            this.dashBoard_panel.Controls.Add(this.Printer);
            //this.dashboard_Parent.Controls.Add(this.dashboard_Parent);
        }

        private async void Printer_Click(object sender, EventArgs e)
        {
            if (accountNumber == null)
            {
                this.CreationErr.Visible = true;
                this.CreationErr.Text = "please Select an account and proceed";
            }
            dashBoard_panel.Controls.Clear();
            await PrintTable();
        }
    }
}
