using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MansIF
{
    public class Bookkeeping
    {
        public int BkId { get; set; }

        public BkType BkType { get; set; }

        public decimal BkValue { get; set; }

        public string BkStateType { get; set; }
    }

    public enum BkType
    {
        PolicyPremium,
        ClaimPayment,
        ClaimInvoice
    }

    public enum BkStateType
    {
        Paid,
        NotPaid,
        PartlyPaid
    }
}