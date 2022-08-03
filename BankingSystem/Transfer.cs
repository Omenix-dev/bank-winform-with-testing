using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace BankingSystem
{
    public partial class Transfer : Form
    {
        private string SendersAccount;
        IProtocols Protocols;
        IUserRespository User;
        public CheckBox[] Radio_button;
        public Transfer(IServiceProvider Services)
        {
            InitializeComponent();
            InitializeComponent();
            Protocols = Services.GetRequiredService<IProtocols>();
            User = Services.GetRequiredService<IUserRespository>();
            Radio_button = new CheckBox[Protocols.SESSIONS.SESSION.CustomerAccountDetails.Count];
        }

        private void AccountOther_TextChanged(object sender, EventArgs e)
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
            SendersAccount = name.Substring(name.Length - 11);
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
            }
        }

        private async void ExcuteTransfer_Click(object sender, EventArgs e)
        {
            decimal amount = this.getTransferAmount.Value;
            if(RecipientAcc.Text != null && SendersAccount != null)
            {
                bool IsDeposited = await User.TransferRetrieval("Deposited", SendersAccount.Trim(), RecipientAcc.Text.Trim(),amount);
                if (IsDeposited)
                {
                    CreationErr.Visible = true;
                    CreationErr.ForeColor = Color.SeaGreen;
                    CreationErr.Text = "the transaction was successful";
                    this.getTransferAmount.Value = 0.00M;
                    RecipientAcc.Text = "";
                }
                else
                {
                    getTransferAmount.Value = 0.00M;
                    RecipientAcc.Text = "";
                    CreationErr.Visible = true;
                    CreationErr.ForeColor = Color.Red;
                    CreationErr.Text = "the transaction was not successful";
                }
            }
            else
            {
                getTransferAmount.Value = 0.00M;
                RecipientAcc.Text = "";
                CreationErr.Visible = true;
                CreationErr.ForeColor = Color.Red;
                CreationErr.Text = "the please an account of your choosing";
            }
        }
    }

}
