﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Quickpaste.Data;
using System;

namespace Quickpaste.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("Quickpaste.Models.Paste", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BlobUrl");

                    b.Property<DateTimeOffset>("CreatedAt");

                    b.Property<bool>("IsPublic");

                    b.Property<string>("Message");

                    b.Property<string>("QuickLink");

                    b.HasKey("Id");

                    b.HasIndex("IsPublic");

                    b.HasIndex("QuickLink")
                        .IsUnique();

                    b.ToTable("Pastes");
                });

            modelBuilder.Entity("Quickpaste.Models.UploadLink", b =>
                {
                    b.Property<string>("QuickLink")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("AllowFile");

                    b.HasKey("QuickLink");

                    b.ToTable("UploadLinks");
                });

            modelBuilder.Entity("Quickpaste.Models.User", b =>
                {
                    b.Property<string>("Username")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.HasKey("Username");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}