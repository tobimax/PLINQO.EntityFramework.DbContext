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
    public partial class SpecialOfferMap
        : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<AdventureWorks.Data.Entities.SpecialOffer>
    {
        public SpecialOfferMap()
        {
            // table
            ToTable("SpecialOffer", "Sales");

            // keys
            HasKey(t => t.SpecialOfferID);

            // Properties
            Property(t => t.SpecialOfferID)
                .HasColumnName("SpecialOfferID")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();
            Property(t => t.Description)
                .HasColumnName("Description")
                .HasMaxLength(255)
                .IsRequired();
            Property(t => t.DiscountPct)
                .HasColumnName("DiscountPct")
                .HasPrecision(10, 4)
                .IsRequired();
            Property(t => t.Type)
                .HasColumnName("Type")
                .HasMaxLength(50)
                .IsRequired();
            Property(t => t.Category)
                .HasColumnName("Category")
                .HasMaxLength(50)
                .IsRequired();
            Property(t => t.StartDate)
                .HasColumnName("StartDate")
                .IsRequired();
            Property(t => t.EndDate)
                .HasColumnName("EndDate")
                .IsRequired();
            Property(t => t.MinQty)
                .HasColumnName("MinQty")
                .IsRequired();
            Property(t => t.MaxQty)
                .HasColumnName("MaxQty")
                .IsOptional();
            Property(t => t.Rowguid)
                .HasColumnName("rowguid")
                .IsRequired();
            Property(t => t.ModifiedDate)
                .HasColumnName("ModifiedDate")
                .IsRequired();

            // Relationships

            InitializeMapping();
        }
    }
}
