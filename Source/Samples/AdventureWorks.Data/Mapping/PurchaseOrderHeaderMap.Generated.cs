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
    public partial class PurchaseOrderHeaderMap
        : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<AdventureWorks.Data.Entities.PurchaseOrderHeader>
    {
        public PurchaseOrderHeaderMap()
        {
            // table
            ToTable("PurchaseOrderHeader", "Purchasing");

            // keys
            HasKey(t => t.PurchaseOrderID);

            // Properties
            Property(t => t.PurchaseOrderID)
                .HasColumnName("PurchaseOrderID")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();
            Property(t => t.RevisionNumber)
                .HasColumnName("RevisionNumber")
                .IsRequired();
            Property(t => t.Status)
                .HasColumnName("Status")
                .IsRequired();
            Property(t => t.EmployeeID)
                .HasColumnName("EmployeeID")
                .IsRequired();
            Property(t => t.VendorID)
                .HasColumnName("VendorID")
                .IsRequired();
            Property(t => t.ShipMethodID)
                .HasColumnName("ShipMethodID")
                .IsRequired();
            Property(t => t.OrderDate)
                .HasColumnName("OrderDate")
                .IsRequired();
            Property(t => t.ShipDate)
                .HasColumnName("ShipDate")
                .IsOptional();
            Property(t => t.SubTotal)
                .HasColumnName("SubTotal")
                .HasPrecision(19, 4)
                .IsRequired();
            Property(t => t.TaxAmt)
                .HasColumnName("TaxAmt")
                .HasPrecision(19, 4)
                .IsRequired();
            Property(t => t.Freight)
                .HasColumnName("Freight")
                .HasPrecision(19, 4)
                .IsRequired();
            Property(t => t.TotalDue)
                .HasColumnName("TotalDue")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed)
                .HasPrecision(19, 4)
                .IsRequired();
            Property(t => t.ModifiedDate)
                .HasColumnName("ModifiedDate")
                .IsRequired();

            // Relationships
            HasRequired(t => t.Employee)
                .WithMany(t => t.PurchaseOrderHeaders)
                .HasForeignKey(d => d.EmployeeID)
                .WillCascadeOnDelete(false);
            HasRequired(t => t.ShipMethod)
                .WithMany(t => t.PurchaseOrderHeaders)
                .HasForeignKey(d => d.ShipMethodID)
                .WillCascadeOnDelete(false);
            HasRequired(t => t.Vendor)
                .WithMany(t => t.PurchaseOrderHeaders)
                .HasForeignKey(d => d.VendorID)
                .WillCascadeOnDelete(false);

            InitializeMapping();
        }
    }
}
