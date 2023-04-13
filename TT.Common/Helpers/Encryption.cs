using System.Security.Cryptography;
using System.Text;

namespace TT.Common.Helpers
{
    public class Encryption
    {
        public Encryption() { }
        public string ComputeStringToSha256Hash(string text)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(text));
                StringBuilder stringBuilder= new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    stringBuilder.Append(bytes[i].ToString("x2"));
                }
                return stringBuilder.ToString();
            }
        }
    }
}
  