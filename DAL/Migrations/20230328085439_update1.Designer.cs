﻿// <auto-generated />
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
    [Migration("20230328085439_update1")]
    partial class update1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("DAL.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("brand")
                        .HasColumnType("text");

                    b.Property<string>("description")
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

                    b.ToTable("Product");
                });

            modelBuilder.Entity("DAL.Entities.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("productId")
                        .HasColumnType("integer");

                    b.Property<long>("rate")
                        .HasColumnType("bigint");

                    b.Property<int>("userid")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("productId");

                    b.HasIndex("userid");

                    b.ToTable("Review");
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

                    b.Property<int>("userid")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.HasIndex("userid");

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

            modelBuilder.Entity("DAL.Entities.Review", b =>
                {
                    b.HasOne("DAL.Entities.Product", "product")
                        .WithMany("reviews")
                        .HasForeignKey("productId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Entities.User", "user")
                        .WithMany("reviews")
                        .HasForeignKey("userid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("product");

                    b.Navigation("user");
                });

            modelBuilder.Entity("DAL.Entities.Token", b =>
                {
                    b.HasOne("DAL.Entities.User", "user")
                        .WithMany("tokens")
                        .HasForeignKey("userid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("user");
                });

            modelBuilder.Entity("DAL.Entities.Product", b =>
                {
                    b.Navigation("reviews");
                });

            modelBuilder.Entity("DAL.Entities.User", b =>
                {
                    b.Navigation("reviews");

                    b.Navigation("tokens");
                });
#pragma warning restore 612, 618
        }
    }
}