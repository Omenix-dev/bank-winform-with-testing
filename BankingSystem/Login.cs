using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using Utility;
using Data.Interfaces;
using System.Drawing;

namespace BankingSystem
{
    public partial class Login : Form
    {
        IServiceProvider serviceProvider;
        IBankRepository bankRepository;
        IProtocols protocol;
        public Login(IServiceProvider service, IProtocols protocol,IBankRepository Bank)
        {
            this.protocol = protocol;
            bankRepository = Bank;
            this.serviceProvider = service;
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            var Welcome = serviceProvider.GetRequiredService<Welcome>();
            Welcome.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if(bankRepository._Temp.Item2 != null)
            {
                GetEmai.Text = bankRepository._Temp.Item2;
                GetPassword.Text = bankRepository._Temp.Item1;
            }
        }

        private void _Login_Click(object sender, EventArgs e)
        {
            var IsLogged = protocol.IsAuthenticated(GetEmai.Text, GetPassword.Text);   
            if (IsLogged)
            {
                var CreateAccount = serviceProvider.GetRequiredService<CreateAccount>();
                CreateAccount.Show();
                this.Hide();
            }
            else
            {
                ErrorMess.Text = "The password doesnt match any instance";
                ErrorMess.Visible = true;
                ErrorMess.ForeColor = Color.Firebrick;
            }
        }

        private void GetEmai_Enter(object sender, EventArgs e)
        {
            ErrorMess.Visible = false;
        }

        private void GetPassword_Enter(object sender, EventArgs e)
        {
            ErrorMess.Visible = false;
        }
    
    
    }
}
