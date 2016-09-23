using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;

namespace MansIF
{
    public class Client:Person
    {
        public  Sex Sex
        {
            get;
            set;
        }
        public string Address { get; set; }

        public string EMail { get; set; }

        public string Phone { get; set; }

        public string BankAccount { get; set; }

        public List<Policy> Policies { get; set; }

        public List<Claim> Claims { get; set; } 
             

    }
}



 public enum Sex
{
    Male,
    Female
}