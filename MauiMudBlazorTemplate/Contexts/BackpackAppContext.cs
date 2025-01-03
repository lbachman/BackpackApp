﻿using System;
using System.Collections.Generic;
using MauiMudBlazor.Entities;
using Microsoft.EntityFrameworkCore;

namespace MauiMudBlazor.Contexts;

public partial class BackpackAppContext : DbContext
{
    public BackpackAppContext()
    {
    }

    public BackpackAppContext(DbContextOptions<BackpackAppContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Backpack> Backpacks { get; set; }

    public virtual DbSet<BackpackConfiguration> BackpackConfigurations { get; set; }

    public virtual DbSet<ConfigurationItem> ConfigurationItems { get; set; }

    public virtual DbSet<Item> Items { get; set; }

    public virtual DbSet<SubBag> SubBags { get; set; }

    public virtual DbSet<User> Users { get; set; }




    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            string dbPath;

            // Check if the app is running on Windows
            if (OperatingSystem.IsWindows())
            {
                // Use a path relative to the project directory during development
                dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "BackpackSQLite.db");
            }
            else
            {
                // Use the app's data directory on other platforms
                dbPath = Path.Combine(FileSystem.AppDataDirectory, "BackpackSQLite.db");
            }

            optionsBuilder.UseSqlite($"Data Source={dbPath}");
        }
    }




    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Backpack>(entity =>
        {
            entity.Property(e => e.BackpackId).HasColumnName("backpack_id");
            entity.Property(e => e.CapacityLiters).HasColumnName("capacity_liters");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("TIMESTAMP")
                .HasColumnName("created_at");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Weight)
                .HasDefaultValue(0.0)
                .HasColumnName("weight");
        });

        modelBuilder.Entity<BackpackConfiguration>(entity =>
        {
            entity.HasKey(e => e.ConfigId);

            entity.Property(e => e.ConfigId).HasColumnName("config_id");
            entity.Property(e => e.BackpackId).HasColumnName("backpack_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("TIMESTAMP")
                .HasColumnName("created_at");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Name).HasColumnName("name");

            entity.HasOne(d => d.Backpack).WithMany(p => p.BackpackConfigurations).HasForeignKey(d => d.BackpackId);
        });

        modelBuilder.Entity<ConfigurationItem>(entity =>
        {
            entity.HasKey(e => e.ConfigItemId);

            entity.Property(e => e.ConfigItemId).HasColumnName("config_item_id");
            entity.Property(e => e.ConfigId).HasColumnName("config_id");
            entity.Property(e => e.InBag)
                .HasDefaultValue(true)
                .HasColumnType("BOOLEAN")
                .HasColumnName("in_bag");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.Quantity)
                .HasDefaultValue(1)
                .HasColumnName("quantity");

            entity.HasOne(d => d.Config).WithMany(p => p.ConfigurationItems).HasForeignKey(d => d.ConfigId);

            entity.HasOne(d => d.Item).WithMany(p => p.ConfigurationItems).HasForeignKey(d => d.ItemId);
        });

        modelBuilder.Entity<Item>(entity =>
        {
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.BackpackId).HasColumnName("backpack_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("TIMESTAMP")
                .HasColumnName("created_at");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.InBag)
                .HasDefaultValue(true)
                .HasColumnType("BOOLEAN")
                .HasColumnName("in_bag");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.PictureUrl).HasColumnName("picture_url");
            entity.Property(e => e.Quantity)
                .HasDefaultValue(1)
                .HasColumnName("quantity");
            entity.Property(e => e.SubbagId).HasColumnName("subbag_id");
            entity.Property(e => e.Weight).HasColumnName("weight");

            entity.HasOne(d => d.Backpack).WithMany(p => p.Items).HasForeignKey(d => d.BackpackId);

            entity.HasOne(d => d.Subbag).WithMany(p => p.Items)
                .HasForeignKey(d => d.SubbagId)
                .OnDelete(DeleteBehavior.SetNull);
        });

        modelBuilder.Entity<SubBag>(entity =>
        {
            entity.Property(e => e.SubbagId).HasColumnName("subbag_id");
            entity.Property(e => e.BackpackId).HasColumnName("backpack_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("TIMESTAMP")
                .HasColumnName("created_at");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Weight)
                .HasDefaultValue(0.0)
                .HasColumnName("weight");

            entity.HasOne(d => d.Backpack).WithMany(p => p.SubBags).HasForeignKey(d => d.BackpackId);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("User");

            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("TIMESTAMP")
                .HasColumnName("created_at");
            entity.Property(e => e.ExperienceLevel).HasColumnName("experience_level");
            entity.Property(e => e.Height).HasColumnName("height");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Weight).HasColumnName("weight");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
