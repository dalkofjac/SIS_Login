using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sis_login
{
    class crypto
    {
        //salt which is the same for all users, it's not stored in database
        public static string globalSalt = "xmR2$j8op14&Kl";

        //method which converts given password (string) into SHA256 hash
        //given password's format before hashing is: unique user salt + plain text password + global salt
        public static string sha256_convert(string password)
        {
            System.Security.Cryptography.SHA256Managed crypt = new System.Security.Cryptography.SHA256Managed();
            System.Text.StringBuilder hash = new System.Text.StringBuilder();
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(password), 0, Encoding.UTF8.GetByteCount(password));
            foreach (byte theByte in crypto)
            {
                hash.Append(theByte.ToString("x2"));
            }
            return hash.ToString();
        }

        //method which generates random salt (or password) of given lenght
        //lenght 15 is used for unique user salt which is stored in database, and lenght 5 is for password
        public static string createUserSalt(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }
    }
}
