using System.Collections.Generic;


namespace Model
{
    public class Customer
    {
        private List<AccountDetails> _CustomerAccountDetails;
        public List<AccountDetails> CustomerAccountDetails
        {
            get { return _CustomerAccountDetails; }
            set { _CustomerAccountDetails = value; }
        }

        private PersonalDetails _PersonalDetails;
        public PersonalDetails PersonalDetails
        {
            get { return _PersonalDetails; }
            set { _PersonalDetails = value; }
        }

        private string _Password;

        public string Password
        {
            get { return _Password; }
            private set { _Password = value; }
        }

        public Customer(string fullname, string Password,string sex,string email)
        {
            this.PersonalDetails = new PersonalDetails(fullname,sex,email);
            this.Password = Password;
            this.CustomerAccountDetails = new List<AccountDetails>();
        }
    }
}
