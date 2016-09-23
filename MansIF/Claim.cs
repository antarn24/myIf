using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;

namespace MansIF
{
    public class Claim
    {

        public int ClaimId { get; set; }

        public DateTime DateOfLoss { get; set; }

        public string ClaimDescription { get; set; }

        public Object DamagedObjects { get; set; }

        public Person Claimant { get; set; }

        public Person Parties { get; set; }

    }

}
