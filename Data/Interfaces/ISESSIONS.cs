using Model;

namespace Data.Interfaces
{
    public interface ISESSIONS
    {
        bool IsLogged { get; set; }
        Customer SESSION { get; set; }
        void Logout();
    }
}