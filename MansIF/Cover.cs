using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;

namespace MansIF
{
    public class Cover
    {
        public int CoverId { get; set; }

        public string CoverName { get; set; }

        public DateTime CoverValidFrom { get; set; }

        public DateTime CoverValidTill { get; set; }
    
        public List<Risk> Risks { get; set; }

        public Product Products { get; set; }
    }
}