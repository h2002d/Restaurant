﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Restaurant.WebApplication.Data;

namespace Restaurant.WebApplication.Migrations
{
    [DbContext(typeof(TestDBContext))]
    [Migration("20200224191618_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Restaurant.WebApplication.Models.Blog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Keys")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("Blog");
                });

            modelBuilder.Entity("Restaurant.WebApplication.Models.BlogImages", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BlogId")
                        .HasColumnType("int");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("varchar(1000)")
                        .HasMaxLength(1000)
                        .IsUnicode(false);

                    b.Property<DateTime>("UploadDate")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.HasIndex("BlogId");

                    b.ToTable("BlogImages");
                });

            modelBuilder.Entity("Restaurant.WebApplication.Models.Careers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("Careers");
                });

            modelBuilder.Entity("Restaurant.WebApplication.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("ParentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("Restaurant.WebApplication.Models.Customers", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("date");

                    b.Property<string>("CompanyAddress")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("CompanyRegNumber")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.HasKey("UserId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Restaurant.WebApplication.Models.OrderProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18, 4)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("decimal(18, 4)");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderProduct");
                });

            modelBuilder.Entity("Restaurant.WebApplication.Models.OrderStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("OrderStatus");
                });

            modelBuilder.Entity("Restaurant.WebApplication.Models.Orders", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CouponId")
                        .HasColumnType("int");

                    b.Property<string>("CustomerId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasMaxLength(450);

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("ScheduleDate")
                        .HasColumnType("datetime");

                    b.Property<int>("StatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("((1))");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("StatusId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Restaurant.WebApplication.Models.ParentCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ParentCategory");
                });

            modelBuilder.Entity("Restaurant.WebApplication.Models.ProductDays", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Day")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductDays");
                });

            modelBuilder.Entity("Restaurant.WebApplication.Models.ProductImages", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("varchar(500)")
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UploadDate")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductImages");
                });

            modelBuilder.Entity("Restaurant.WebApplication.Models.Products", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)")
                        .HasMaxLength(1000);

                    b.Property<bool>("IsDeleted")
                        .HasColumnName("isDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Keys")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,4)");

                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Restaurant.WebApplication.Models.BlogImages", b =>
                {
                    b.HasOne("Restaurant.WebApplication.Models.Blog", "Blog")
                        .WithMany("BlogImages")
                        .HasForeignKey("BlogId")
                        .HasConstraintName("FK_BlogImages_Blog")
                        .IsRequired();
                });

            modelBuilder.Entity("Restaurant.WebApplication.Models.Category", b =>
                {
                    b.HasOne("Restaurant.WebApplication.Models.ParentCategory", "Parent")
                        .WithMany("Category")
                        .HasForeignKey("ParentId")
                        .HasConstraintName("FK_Category_ParentCategory")
                        .IsRequired();
                });

            modelBuilder.Entity("Restaurant.WebApplication.Models.OrderProduct", b =>
                {
                    b.HasOne("Restaurant.WebApplication.Models.Orders", "Order")
                        .WithMany("OrderProduct")
                        .HasForeignKey("OrderId")
                        .HasConstraintName("FK_OrderProduct_Orders")
                        .IsRequired();

                    b.HasOne("Restaurant.WebApplication.Models.Products", "Product")
                        .WithMany("OrderProduct")
                        .HasForeignKey("ProductId")
                        .HasConstraintName("FK_OrderProduct_Products")
                        .IsRequired();
                });

            modelBuilder.Entity("Restaurant.WebApplication.Models.Orders", b =>
                {
                    b.HasOne("Restaurant.WebApplication.Models.Customers", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .HasConstraintName("FK_Orders_Customers")
                        .IsRequired();

                    b.HasOne("Restaurant.WebApplication.Models.OrderStatus", "Status")
                        .WithMany("Orders")
                        .HasForeignKey("StatusId")
                        .HasConstraintName("FK_Orders_OrderStatus")
                        .IsRequired();
                });

            modelBuilder.Entity("Restaurant.WebApplication.Models.ProductDays", b =>
                {
                    b.HasOne("Restaurant.WebApplication.Models.Products", "Product")
                        .WithMany("ProductDays")
                        .HasForeignKey("ProductId")
                        .HasConstraintName("FK_ProductDays_Products")
                        .IsRequired();
                });

            modelBuilder.Entity("Restaurant.WebApplication.Models.ProductImages", b =>
                {
                    b.HasOne("Restaurant.WebApplication.Models.Products", "Product")
                        .WithMany("ProductImages")
                        .HasForeignKey("ProductId")
                        .HasConstraintName("FK_ProductImages_Products")
                        .IsRequired();
                });

            modelBuilder.Entity("Restaurant.WebApplication.Models.Products", b =>
                {
                    b.HasOne("Restaurant.WebApplication.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("FK_Products_Category")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
