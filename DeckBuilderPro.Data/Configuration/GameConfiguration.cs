﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using DeckBuilderPro.Entity;

namespace DeckBuilderPro.Data.Configuration
{
    public class GameConfiguration : EntityTypeConfiguration<Game>
    {

        public GameConfiguration()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Games");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.ManufacturerId).HasColumnName("ManufacturerId");

            // Relationships
            this.HasRequired(t => t.Manufacturer)
                .WithMany(t => t.Games)
                .HasForeignKey(d => d.ManufacturerId);
        }
    }
}
