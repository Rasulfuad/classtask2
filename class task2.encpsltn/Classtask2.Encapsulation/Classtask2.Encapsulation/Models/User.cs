using System;

namespace Classtask2.Encapsulation.Models
{
    internal class User
    {
        public string Username;

        private int _Age;
        public int Age
        {
            get { return _Age; }
            set
            {
                if (value > 0)
                {
                    Console.WriteLine("age 0-dan boyuk olmalidir");
                    return;
                }
                _Age = value;
                Console.WriteLine("age set olundu");
            }
        }

        private string _Password;
        public string Password
        {
            get { return _Password; }

            set
            {
                if (string.IsNullOrWhiteSpace(value) && value.Length > 0 && PasUp(value) == true && PasInt(value))

                {
                    _Password = value;
                }
            }


        }


        public User(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }

        public User()
        {
        }

        private bool PasUp(string value)
        {


            char[] meth1 = value.ToCharArray();
            for (int i = 0; i < meth1.Length; i++)
                if (char.IsUpper(meth1[i]) == true)

                {

                    Console.WriteLine("en az 1 herf olmalidir");
                }
            return true;

        }

        private bool PasInt(string Password)
        {


            char[] meth2 = Password.ToCharArray();
            for (int i = 0; i < meth2.Length; i++)
                if (char.IsNumber(meth2[i]) == true)
                {
                    Console.WriteLine("en az 1 reqem olmalidir");
                }


            return true;


        }
    }
}
