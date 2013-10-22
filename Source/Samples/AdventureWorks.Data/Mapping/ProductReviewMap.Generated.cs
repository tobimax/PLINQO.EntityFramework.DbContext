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
    public partial class ProductReviewMap
        : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<AdventureWorks.Data.Entities.ProductReview>
    {
        public ProductReviewMap()
        {
            // table
            ToTable("ProductReview", "Production");

            // keys
            HasKey(t => t.ProductReviewID);

            // Properties
            Property(t => t.ProductReviewID)
                .HasColumnName("ProductReviewID")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();
            Property(t => t.ProductID)
                .HasColumnName("ProductID")
                .IsRequired();
            Property(t => t.ReviewerName)
                .HasColumnName("ReviewerName")
                .HasMaxLength(50)
                .IsRequired();
            Property(t => t.ReviewDate)
                .HasColumnName("ReviewDate")
                .IsRequired();
            Property(t => t.EmailAddress)
                .HasColumnName("EmailAddress")
                .HasMaxLength(50)
                .IsRequired();
            Property(t => t.Rating)
                .HasColumnName("Rating")
                .IsRequired();
            Property(t => t.Comments)
                .HasColumnName("Comments")
                .HasMaxLength(3850)
                .IsOptional();
            Property(t => t.ModifiedDate)
                .HasColumnName("ModifiedDate")
                .IsRequired();

            // Relationships
            HasRequired(t => t.Product)
                .WithMany(t => t.ProductReviews)
                .HasForeignKey(d => d.ProductID)
                .WillCascadeOnDelete(false);

            InitializeMapping();
        }
    }
}
