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
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdventureWorks.Data.Mapping
{
    public partial class EmployeePayHistoryMap
        : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<AdventureWorks.Data.Entities.EmployeePayHistory>
    {
        public EmployeePayHistoryMap()
        {
            // table
            ToTable("EmployeePayHistory", "HumanResources");

            // keys
            HasKey(t => new { t.EmployeeID, t.RateChangeDate });

            // Properties
            Property(t => t.EmployeeID)
                .HasColumnName("EmployeeID")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .IsRequired();
            Property(t => t.RateChangeDate)
                .HasColumnName("RateChangeDate")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .IsRequired();
            Property(t => t.Rate)
                .HasColumnName("Rate")
                .HasPrecision(19, 4)
                .IsRequired();
            Property(t => t.PayFrequency)
                .HasColumnName("PayFrequency")
                .IsRequired();
            Property(t => t.ModifiedDate)
                .HasColumnName("ModifiedDate")
                .IsRequired();

            // Relationships
            HasRequired(t => t.Employee)
                .WithMany(t => t.EmployeePayHistories)
                .HasForeignKey(d => d.EmployeeID)
                .WillCascadeOnDelete(false);

            InitializeMapping();
        }
    }
}
