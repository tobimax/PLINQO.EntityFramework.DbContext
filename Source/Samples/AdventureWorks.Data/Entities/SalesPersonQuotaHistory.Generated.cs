﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a CodeSmith Template.
//
//     DO NOT MODIFY contents of this file. Changes to this
//     file will be lost if the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureWorks.Data.Entities
{
    public partial class SalesPersonQuotaHistory
    {
        public SalesPersonQuotaHistory()
        {
            ModifiedDate = DateTime.Now;
        }

        public int SalesPersonID { get; set; }
        public System.DateTime QuotaDate { get; set; }
        public decimal SalesQuota { get; set; }
        public System.Guid Rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }

        public virtual SalesPerson SalesPerson { get; set; }
    }
}