using Enum;

namespace Model
{
    public class PersonalDetails
    {
        private string _Name;
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        private string _Sex;
        public string Sex
        {
            get { return _Sex; }
            set { _Sex = value; }
        }

        private string _Email;
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        public PersonalDetails(string fullname, string sex, string email)
        {
            this.Name = fullname;
            this.Sex = sex;
            this.Email = email;
        }
    }
}
