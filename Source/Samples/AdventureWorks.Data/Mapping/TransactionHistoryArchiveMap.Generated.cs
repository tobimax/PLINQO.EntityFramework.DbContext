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
    public partial class TransactionHistoryArchiveMap
        : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<AdventureWorks.Data.Entities.TransactionHistoryArchive>
    {
        public TransactionHistoryArchiveMap()
        {
            // table
            ToTable("TransactionHistoryArchive", "Production");

            // keys
            HasKey(t => t.TransactionID);

            // Properties
            Property(t => t.TransactionID)
                .HasColumnName("TransactionID")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .IsRequired();
            Property(t => t.ProductID)
                .HasColumnName("ProductID")
                .IsRequired();
            Property(t => t.ReferenceOrderID)
                .HasColumnName("ReferenceOrderID")
                .IsRequired();
            Property(t => t.ReferenceOrderLineID)
                .HasColumnName("ReferenceOrderLineID")
                .IsRequired();
            Property(t => t.TransactionDate)
                .HasColumnName("TransactionDate")
                .IsRequired();
            Property(t => t.TransactionType)
                .HasColumnName("TransactionType")
                .HasMaxLength(1)
                .IsRequired();
            Property(t => t.Quantity)
                .HasColumnName("Quantity")
                .IsRequired();
            Property(t => t.ActualCost)
                .HasColumnName("ActualCost")
                .HasPrecision(19, 4)
                .IsRequired();
            Property(t => t.ModifiedDate)
                .HasColumnName("ModifiedDate")
                .IsRequired();

            // Relationships

            InitializeMapping();
        }
    }
}
