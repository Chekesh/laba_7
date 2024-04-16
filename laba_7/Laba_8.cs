using laba_7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_7
{
    class LoginArray : Massiv<string>
    {
        public LoginArray(params string[] values) : base(values)
        {
        }

        public void RegisterUser(string login)
        {
            Add(login);
        }
    }

    class PasswordArray : Massiv<int>
    {
        public PasswordArray(params int[] values) : base(values)
        {
        }

        public void SetPassword(int password)
        {
            Add(password);
        }
    }

    class Lab8
    {
        static void Main()
        {
            LoginArray loginArray = new LoginArray();
            loginArray.RegisterUser("Лол");
            loginArray.RegisterUser("Лилпоп");

            PasswordArray passwordArray = new PasswordArray();
            passwordArray.SetPassword(123456789);
            passwordArray.SetPassword(987654321);
            Console.Read();
        }
    }

}
