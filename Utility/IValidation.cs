using System.Collections.Generic;
namespace Utility
{
    public interface IValidation
    {
        //decimal Amount();
        (string, bool) ValidateEmail(string Email);
        (string, bool) ValidateName(string name);
        (string, bool) ValidatePassword(string password);
    }
}