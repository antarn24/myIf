using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;

namespace MansIF
{
    public class Policy
    {
        public string Number { get; set; } //This will be generated in future

        public int Version { get; set; }

        public int RenewalVersion { get; set; }

        public List<Object> InsuredObject { get; set; }
    

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public List<Product> Products
        {
            get; set; 
            
        }

        public Client Client { get; set; }

        public List<Claim> Claims { get; set; }
    }


             

    }

