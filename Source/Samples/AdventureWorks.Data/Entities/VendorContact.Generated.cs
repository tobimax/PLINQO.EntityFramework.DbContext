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
    public partial class VendorContact
    {
        public VendorContact()
        {
        }

        public int VendorID { get; set; }
        public int ContactID { get; set; }
        public int ContactTypeID { get; set; }
        public System.DateTime ModifiedDate { get; set; }

        public virtual Contact Contact { get; set; }
        public virtual ContactType ContactType { get; set; }
        public virtual Vendor Vendor { get; set; }
    }
}