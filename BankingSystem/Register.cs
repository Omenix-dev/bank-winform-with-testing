using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using Utility;
using Data.Interfaces;
using EasyEncryption;

namespace BankingSystem
{
    public partial class Register : Form
    {
        private bool firstNameBool = false;
        private bool lastnameBool = false;
        private bool Emailbool = false;
        private bool passbool = false;
        private bool Retypebool = false;
        private bool Genbool = false;

        private string firstName;
        private string lastname;
        private string Emailvalue;
        private string pass;
        private string Gender;


        //<============================ Globals Section ================================>
        IServiceProvider serviceProvider;
        IValidation Validation;
        IBankRepository BankRepository;
        public Register(IServiceProvider ServiceProvider, IValidation Validation, IBankRepository BankRepository)
        {
            this.Validation = Validation;
            InitializeComponent();
            this.serviceProvider = ServiceProvider;
            this.BankRepository = BankRepository;
        }
        private void Register_Load(object sender, EventArgs e)
        {
            
        }
        // event that is fired when the close button is fired
        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            var Welcome = serviceProvider.GetRequiredService<Welcome>();
            Welcome.Close();
        }
        private async void Sign_up_Click(object sender, EventArgs e)
        {
            if (firstNameBool && lastnameBool && Emailbool && Retypebool && passbool && Genbool)
            {
                bool Iscreated = await BankRepository.CreateCustomer($"{firstName} {lastname}", SHA.ComputeSHA256Hash(pass), Gender, Emailvalue);
                if (Iscreated)
                {
                    var _Login = serviceProvider.GetRequiredService<Login>();
                    _Login.Show();
                    this.Hide();
                }
            }
            else
            {
                fNamErr.Text = lName.Text = EmailErr.Text = PassErr.Text = GenderErr.Text = "this field is required";
                if (!firstNameBool)fNamErr.Visible = true;
                if (!lastnameBool)lName.Visible = true;
                if (!Emailbool) EmailErr.Visible = true;
                if (!passbool) PassErr.Visible = true;
                if (!Genbool) GenderErr.Visible = true;
            }
        }
        private void Fname_Leave(object sender, EventArgs e)
        {
            var value = Validation.ValidateName(Fname.Text);
            if (!value.Item2)
            {
                fNamErr.Text = value.Item1;
                fNamErr.Visible = true;
            }
            firstName = value.Item1;
            firstNameBool = value.Item2;
        }     
        private void Fname_Enter(object sender, EventArgs e)
        {
            firstName = "";
            fNamErr.Text = "";
            Fname.Text = "";
            fNamErr.Visible = false;
            firstNameBool = false;
        }
        private void _Lname_Leave(object sender, EventArgs e)
        {
            var value = Validation.ValidateName(_Lname.Text);
            if (!value.Item2)
            {
                lName.Text = value.Item1;
                lName.Visible = true;
            }
            lastname = value.Item1;
            lastnameBool = value.Item2;
        }
        private void _Lname_Enter(object sender, EventArgs e)
        {
            lastname = "";
            lName.Text = "";
            _Lname.Text = "";
            lName.Visible = false;
            lastnameBool = false;
        }
        private void Email_Enter(object sender, EventArgs e)
        {
            Emailvalue = "";
            EmailErr.Text = "";
            Email.Text = "";
            EmailErr.Visible = false;
            Emailbool = false;
        }       
        private void Email_Leave(object sender, EventArgs e)
        {
            var value = Validation.ValidateEmail(Email.Text);
            if (!value.Item2)
            {
                EmailErr.Text = value.Item1;
                EmailErr.Visible = true;
            }
            Emailvalue = value.Item1;
            Emailbool = value.Item2;
        }
        private void Password_Enter(object sender, EventArgs e)
        {
            pass = "";
            Password.Text = "";
            PassErr.Text = "";
            PassErr.Visible = false;
            passbool = false;
        }
        private void Password_Leave(object sender, EventArgs e)
        {
            var value = Validation.ValidatePassword(Password.Text);
            if (!value.Item2)
            {
                PassErr.Text = value.Item1;
                PassErr.Visible = true;
                
            }
            pass = value.Item1;
            passbool = value.Item2;
        }
        private void Re_type_Enter(object sender, EventArgs e)
        {
            RetypeErr.Text = "";
            RetypeErr.Visible = false;
            Retypebool = false;
        }
        private void Re_type_Leave(object sender, EventArgs e)
        {
            if (passbool)
            {
                if (Re_type.Text != Password.Text)
                {
                    RetypeErr.Text = "Retype the password again it doesnt match";
                    RetypeErr.Visible = true;
                }
                else
                {
                    Retypebool = true;
                    RetypeErr.Visible = false;
                }
            }
            else
            {
                RetypeErr.Text = "please fill in the password first";
                RetypeErr.Visible = true;
            }
        }
        private void Male_Click(object sender, EventArgs e)
        {
            if (Female.Checked)
            {
                Female.Checked = false;
            }
            Genbool = true;
            GenderErr.Visible = false;
            Gender = "Male";
        }
        private void Female_Click(object sender, EventArgs e)
        {
            Genbool = true;
            GenderErr.Visible = false;
            if (Male.Checked)
            {
                Male.Checked = false;
            }
            Gender = "Female";
        }
    }
}
