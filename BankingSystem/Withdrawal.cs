using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using Data.Interfaces;

namespace BankingSystem
{
    public partial class Withdrawal : Form
    {
        private string accountNumber;
        IProtocols Protocols;
        IUserRespository User;
        public CheckBox[] Radio_button;
        public Withdrawal(IServiceProvider Services)
        {
            InitializeComponent();
            Protocols = Services.GetRequiredService<IProtocols>();
            User = Services.GetRequiredService<IUserRespository>();
            Radio_button = new CheckBox[Protocols.SESSIONS.SESSION.CustomerAccountDetails.Count];
        }

        private void label2_Click(object sender, EventArgs e)
        {

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
            CreationErr.Visible = false;
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

        private async void ExcuteDeposit_Click(object sender, EventArgs e)
        {
            decimal amount = this.getDepositAmount.Value;
            if (accountNumber != null)
            {
                bool IsDeposited = await User.RetrieveWithdrawal("Cash withdrawal", amount, accountNumber.Trim());
                if (IsDeposited)
                {
                    CreationErr.Visible = true;
                    CreationErr.ForeColor = Color.SeaGreen;
                    CreationErr.Text = "the transaction was successful";
                    getDepositAmount.Value = 0.00M;
                }
                else
                {
                    getDepositAmount.Value = 0.00M;
                    CreationErr.Visible = true;
                    CreationErr.ForeColor = Color.Red;
                    CreationErr.Text = "the transaction was not successful";
                }
            }
            else
            {
                getDepositAmount.Value = 0.00M;
                CreationErr.Visible = true;
                CreationErr.ForeColor = Color.Red;
                CreationErr.Text = "Please select an account of your choosing";
            }
        }
    }
   
}
