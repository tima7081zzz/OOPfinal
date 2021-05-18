using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public delegate void AccountStateHandler(object sender, AccountEventArgs e);

    public class AccountEventArgs
    {
        public string message { get; private set; }
        
        public AccountEventArgs(string mesaage_)
        {
            message = mesaage_;
        }
    }
}
