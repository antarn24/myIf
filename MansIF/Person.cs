using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MansIF
{
    public class Person
    {
     public string Name { get; set; }
            public string Surname { get; set; }

            public ClientType ClientType

            {
                get;
                set;
            }


            public string SocialSecurityNumner { get; set; }

            public string LegalNumber { get; set; }
        }
    public enum ClientType
    {
        Private,
        Commercial
    }
}
