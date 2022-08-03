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
    public partial class dashboard : Form
    {
        IServiceProvider service;
        IProtocols Protocols;
        public dashboard(IServiceProvider service,IProtocols protocols)
        {
            InitializeComponent();
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
        private void Create_butt_Click(object sender, EventArgs e)
        {
            var CreateAccount = service.GetRequiredService<CreateAccount>();
            CreateAccount.Show();
            this.Hide();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            // query the datebaswe fior the account details of the presently active customer

            Username.Text = $"Welcome {Protocols.SESSIONS.SESSION.PersonalDetails.Name}";
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Deposit_butt_Click(object sender, EventArgs e)
        {

        }

        private void Withdraw_butt_Click(object sender, EventArgs e)
        {

        }

        private void Transfer_butt_Click(object sender, EventArgs e)
        {

        }

        private void Print_butt_Click(object sender, EventArgs e)
        {

        }

        private void dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Protocols.SESSIONS.Logout();
            var Welcome = service.GetRequiredService<Welcome>();
            Welcome.Close();
        }

        private void dashboard_butt_Paint(object sender, PaintEventArgs e)
        {

        }

      
    }
}
