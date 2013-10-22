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

namespace Petshop.Data.Mapping
{
    public partial class ProfileMap
        : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Petshop.Data.Entities.Profile>
    {
        public ProfileMap()
        {
            // table
            ToTable("Profile", "dbo");

            // keys
            HasKey(t => t.UserId);

            // Properties
            Property(t => t.UserId)
                .HasColumnName("UserId")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasMaxLength(20)
                .IsRequired();
            Property(t => t.LangPref)
                .HasColumnName("LangPref")
                .HasMaxLength(80)
                .IsRequired();
            Property(t => t.FavCategory)
                .HasColumnName("FavCategory")
                .HasMaxLength(30)
                .IsOptional();
            Property(t => t.MyListOpt)
                .HasColumnName("MyListOpt")
                .IsOptional();
            Property(t => t.BannerOpt)
                .HasColumnName("BannerOpt")
                .IsOptional();

            // Relationships

            InitializeMapping();
        }
    }
}
