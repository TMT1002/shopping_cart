﻿// <auto-generated />
using System;
using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DAL.Migrations
{
    [DbContext(typeof(ShoppingCartContext))]
    [Migration("20230401161454_updateProductTable")]
    partial class updateProductTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("DAL.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("nameCategory")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("DAL.Entities.ImageProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("imgName")
                        .HasColumnType("text");

                    b.Property<string>("linkImg")
                        .HasColumnType("text");

                    b.Property<int?>("productId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("productId");

                    b.ToTable("ImageProducts");
                });

            modelBuilder.Entity("DAL.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("isPaided")
                        .HasColumnType("boolean");

                    b.Property<int?>("paymentMethodId")
                        .HasColumnType("integer");

                    b.Property<int>("status")
                        .HasColumnType("integer");

                    b.Property<float>("totalPrice")
                        .HasColumnType("real");

                    b.Property<int?>("userid")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("paymentMethodId");

                    b.HasIndex("userid");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("DAL.Entities.PaymentMethod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("PaymentMethods");
                });

            modelBuilder.Entity("DAL.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("brand")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("categoryId")
                        .HasColumnType("integer");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<float>("discountPrecent")
                        .HasColumnType("real");

                    b.Property<string>("nameProduct")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<float>("price")
                        .HasColumnType("real");

                    b.Property<float>("rateAvgReview")
                        .HasColumnType("real");

                    b.Property<long>("stockQuantity")
                        .HasColumnType("bigint");

                    b.Property<string>("thumbnailImage")
                        .HasColumnType("text");

                    b.Property<string>("thumbnailImgName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("categoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("DAL.Entities.ProductsOfCart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("price")
                        .HasColumnType("integer");

                    b.Property<int?>("productId")
                        .HasColumnType("integer");

                    b.Property<int>("quantity")
                        .HasColumnType("integer");

                    b.Property<int>("totalPrice")
                        .HasColumnType("integer");

                    b.Property<int?>("userid")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("productId");

                    b.HasIndex("userid");

                    b.ToTable("ProductsOfCarts");
                });

            modelBuilder.Entity("DAL.Entities.ProductsOfCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("categoryId")
                        .HasColumnType("integer");

                    b.Property<int?>("productId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("categoryId");

                    b.HasIndex("productId");

                    b.ToTable("ProductsOfCategories");
                });

            modelBuilder.Entity("DAL.Entities.ProductsOfOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("brandName")
                        .HasColumnType("text");

                    b.Property<string>("description")
                        .HasColumnType("text");

                    b.Property<float>("discountPercent")
                        .HasColumnType("real");

                    b.Property<string>("name")
                        .HasColumnType("text");

                    b.Property<int?>("orderId")
                        .HasColumnType("integer");

                    b.Property<float>("price")
                        .HasColumnType("real");

                    b.Property<int>("productId")
                        .HasColumnType("integer");

                    b.Property<int>("quantity")
                        .HasColumnType("integer");

                    b.Property<string>("thumbnailImage")
                        .HasColumnType("text");

                    b.Property<float>("totalPrice")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("orderId");

                    b.ToTable("ProductsOfOrders");
                });

            modelBuilder.Entity("DAL.Entities.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("productId")
                        .HasColumnType("integer");

                    b.Property<long>("rate")
                        .HasColumnType("bigint");

                    b.Property<int?>("userid")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("productId");

                    b.HasIndex("userid");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("DAL.Entities.Token", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("accessToken")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("refreshToken")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("userId")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.HasIndex("userId");

                    b.ToTable("Tokens");
                });

            modelBuilder.Entity("DAL.Entities.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("avatarLink")
                        .HasColumnType("text");

                    b.Property<string>("avatarName")
                        .HasColumnType("text");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("forgotPasswordToken")
                        .HasColumnType("text");

                    b.Property<bool>("isActive")
                        .HasColumnType("boolean");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("phoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("role")
                        .HasColumnType("integer");

                    b.Property<string>("userName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<bool>("verifyContact")
                        .HasColumnType("boolean");

                    b.Property<string>("verifyContactToken")
                        .HasColumnType("text");

                    b.Property<bool>("verifyEmail")
                        .HasColumnType("boolean");

                    b.Property<string>("verifyEmailToken")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DAL.Entities.Voucher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("content")
                        .HasColumnType("text");

                    b.Property<DateTime>("expriseTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("quantity")
                        .HasColumnType("integer");

                    b.Property<int>("used")
                        .HasColumnType("integer");

                    b.Property<float>("value")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("Vouchers");
                });

            modelBuilder.Entity("DAL.Entities.VouchersOfOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("name")
                        .HasColumnType("text");

                    b.Property<int?>("orderId")
                        .HasColumnType("integer");

                    b.Property<float>("value")
                        .HasColumnType("real");

                    b.Property<int?>("voucherId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("orderId");

                    b.HasIndex("voucherId");

                    b.ToTable("VouchersOfOrders");
                });

            modelBuilder.Entity("DAL.Entities.ImageProduct", b =>
                {
                    b.HasOne("DAL.Entities.Product", "product")
                        .WithMany("images")
                        .HasForeignKey("productId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("product");
                });

            modelBuilder.Entity("DAL.Entities.Order", b =>
                {
                    b.HasOne("DAL.Entities.PaymentMethod", "paymentMethod")
                        .WithMany("orders")
                        .HasForeignKey("paymentMethodId");

                    b.HasOne("DAL.Entities.User", "user")
                        .WithMany("orders")
                        .HasForeignKey("userid")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("paymentMethod");

                    b.Navigation("user");
                });

            modelBuilder.Entity("DAL.Entities.Product", b =>
                {
                    b.HasOne("DAL.Entities.Category", "category")
                        .WithMany("products")
                        .HasForeignKey("categoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("category");
                });

            modelBuilder.Entity("DAL.Entities.ProductsOfCart", b =>
                {
                    b.HasOne("DAL.Entities.Product", "product")
                        .WithMany("productsOfCart")
                        .HasForeignKey("productId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DAL.Entities.User", "user")
                        .WithMany("productsOfCart")
                        .HasForeignKey("userid")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("product");

                    b.Navigation("user");
                });

            modelBuilder.Entity("DAL.Entities.ProductsOfCategory", b =>
                {
                    b.HasOne("DAL.Entities.Category", "category")
                        .WithMany("productsOfCategories")
                        .HasForeignKey("categoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DAL.Entities.Product", "product")
                        .WithMany("productsOfCategories")
                        .HasForeignKey("productId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("category");

                    b.Navigation("product");
                });

            modelBuilder.Entity("DAL.Entities.ProductsOfOrder", b =>
                {
                    b.HasOne("DAL.Entities.Order", "order")
                        .WithMany("productsOfOder")
                        .HasForeignKey("orderId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("order");
                });

            modelBuilder.Entity("DAL.Entities.Review", b =>
                {
                    b.HasOne("DAL.Entities.Product", "product")
                        .WithMany("reviews")
                        .HasForeignKey("productId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DAL.Entities.User", "user")
                        .WithMany("reviews")
                        .HasForeignKey("userid")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("product");

                    b.Navigation("user");
                });

            modelBuilder.Entity("DAL.Entities.Token", b =>
                {
                    b.HasOne("DAL.Entities.User", "user")
                        .WithMany("tokens")
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("user");
                });

            modelBuilder.Entity("DAL.Entities.VouchersOfOrder", b =>
                {
                    b.HasOne("DAL.Entities.Order", "order")
                        .WithMany("vouchersOfOrder")
                        .HasForeignKey("orderId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DAL.Entities.Voucher", "voucher")
                        .WithMany("vouchersOfOrder")
                        .HasForeignKey("voucherId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("order");

                    b.Navigation("voucher");
                });

            modelBuilder.Entity("DAL.Entities.Category", b =>
                {
                    b.Navigation("products");

                    b.Navigation("productsOfCategories");
                });

            modelBuilder.Entity("DAL.Entities.Order", b =>
                {
                    b.Navigation("productsOfOder");

                    b.Navigation("vouchersOfOrder");
                });

            modelBuilder.Entity("DAL.Entities.PaymentMethod", b =>
                {
                    b.Navigation("orders");
                });

            modelBuilder.Entity("DAL.Entities.Product", b =>
                {
                    b.Navigation("images");

                    b.Navigation("productsOfCart");

                    b.Navigation("productsOfCategories");

                    b.Navigation("reviews");
                });

            modelBuilder.Entity("DAL.Entities.User", b =>
                {
                    b.Navigation("orders");

                    b.Navigation("productsOfCart");

                    b.Navigation("reviews");

                    b.Navigation("tokens");
                });

            modelBuilder.Entity("DAL.Entities.Voucher", b =>
                {
                    b.Navigation("vouchersOfOrder");
                });
#pragma warning restore 612, 618
        }
    }
}
