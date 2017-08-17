using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lesson1608
{
    public class User
    {
        private int[] entryAttempts;

        public Guid Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        
        public int this[int i]
        {
            get
            {
                return entryAttempts[i];
            }
            set
            {
                entryAttempts[i] = value;
            }
        }


        //    private Guid id;
        //    private string login;
        //    private string password;

        //    public Guid Id
        //    {
        //        get
        //        {
        //            return id;
        //        }
        //        set
        //        {
        //            id = value;
        //        }
        //    }

        //    public string Login
        //    {
        //        get
        //        {
        //            return login;
        //        }
        //        set
        //        {
        //            login = value;
        //        }
        //    }
        //    public string Password
        //    {
        //        get
        //        {
        //            return password;
        //        }
        //        set
        //        {
        //            password = value;
        //        }
        //    }

    }
}
