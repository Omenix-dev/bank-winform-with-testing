using Data.Interfaces;
using Model;


namespace Data
{
    public class SESSIONS : ISESSIONS
    {
        
        private Customer _SESSION;
        public Customer SESSION
        {
            get { return _SESSION; }
            set { _SESSION = value; }
        }

        // this is the variable that is used to store the present logging state
        private bool _IsLogged = false;
        public bool IsLogged
        {
            get { return _IsLogged; }
            set { _IsLogged = value; }
        }

        
        public void Logout()
        {
            SESSION = null;// this empty the container there by ending the session
            IsLogged = false;// this add the restriction that initializes customer logout 
        }

    }
}
