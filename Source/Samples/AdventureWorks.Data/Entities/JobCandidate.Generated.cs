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
    public partial class JobCandidate
    {
        public JobCandidate()
        {
        }

        public int JobCandidateID { get; set; }
        public int? EmployeeID { get; set; }
        public string Resume { get; set; }
        public System.DateTime ModifiedDate { get; set; }

        public virtual Employee Employee { get; set; }
    }
}