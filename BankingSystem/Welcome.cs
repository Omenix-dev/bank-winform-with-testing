using System;
using Microsoft.Extensions.DependencyInjection;
using System.Windows.Forms;

namespace BankingSystem
{
    public partial class Welcome : Form
    {
        IServiceProvider serviceProvider;
        public Welcome(IServiceProvider ServiceProvider)
        {
            InitializeComponent();
            this.serviceProvider = ServiceProvider;
        }
        private void Welcome_Load(object sender, EventArgs e)
        {

        }

        private void Register_Click(object sender, EventArgs e)
        {
            var Register = serviceProvider.GetRequiredService<Register>();
            Register.Show();
            this.Hide();
            //this.Close();
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void _Logger_Click(object sender, EventArgs e)
        {
            var login = serviceProvider.GetRequiredService<Login>();
            login.Show();
            this.Hide();
        }

        private void Welcome_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

    }
}
