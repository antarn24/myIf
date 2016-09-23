using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;

namespace MansIF
{
    public class Product
    {
      public int ProductId { get; set; }

     public string LineOfBusiness { get; set; }

     public Policy Policy { get; set; }

    public DateTime ProductValidFrom { get; set; }

    public DateTime ProductValidTill { get; set; }

    
     public List<Cover> Covers { get; set; }
    }

    }
