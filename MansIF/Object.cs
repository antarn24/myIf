using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace MansIF
{
    public class Object
    {
        public int ObjectId { get; set; }

        public ObjectType ObjectType { get; set; }

        public string ObjectName { get; set; }
        public string ObjectDescription { get; set; }

        public decimal ObjectInsuredValue { get; set; }

        public Policy Policy { get; set; }

        public Claim Claim { get; set; }
    

    }

    public enum ObjectType
    {
        Property,
        Motor,
        Person,
        Liability,
        Marine
        
    }
}