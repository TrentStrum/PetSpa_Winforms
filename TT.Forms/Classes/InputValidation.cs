using System.Text.RegularExpressions;

namespace TT.Forms.Classes
{
    public class InputValidation
    {
        public InputValidation() { }
        public bool EmailValidation(string email)
        {
            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (Regex.IsMatch(email, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
 