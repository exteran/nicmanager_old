using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NICManager
{
    using System;
    using System.Text;
    using System.Security.Cryptography;

    internal class Authenticator
    {
        // NICManager authenticator 9/20/2022

        // public getter to encrypt string / SHA256
        public string GetHash(string inputString) => NewHash(inputString);

        // newHash is isolated so that it can be overrided to other encryption algorithms if desired.
        virtual public string NewHash(string inputString)
        {

            using (SHA256 sha256Hash = SHA256.Create())
            {

                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(inputString));
                StringBuilder hash = new StringBuilder();

                for (int i = 0; i < bytes.Length; i++)
                {
                    hash.Append(bytes[i].ToString("x2"));
                }

                return hash.ToString();
            }
        }
    }
}
