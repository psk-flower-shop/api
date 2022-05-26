﻿// <auto-generated />
using System;
using FlowerApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FlowerApi.Migrations
{
    [DbContext(typeof(FlowersContext))]
    partial class FlowersContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.5");

            modelBuilder.Entity("FlowerApi.Entities.Cart", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("FlowerApi.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("FlowerApi.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("Amount")
                        .HasColumnType("INTEGER");

                    b.Property<Guid?>("CartId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CartId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("FlowerApi.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ProductUser", b =>
                {
                    b.Property<Guid>("FavoriteProductsId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("UsersId")
                        .HasColumnType("TEXT");

                    b.HasKey("FavoriteProductsId", "UsersId");

                    b.HasIndex("UsersId");

                    b.ToTable("ProductUser");
                });

            modelBuilder.Entity("FlowerApi.Entities.Cart", b =>
                {
                    b.HasOne("FlowerApi.Entities.User", "User")
                        .WithOne("Cart")
                        .HasForeignKey("FlowerApi.Entities.Cart", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("FlowerApi.Entities.Product", b =>
                {
                    b.HasOne("FlowerApi.Entities.Cart", "Cart")
                        .WithMany("ProductsInCart")
                        .HasForeignKey("CartId");

                    b.HasOne("FlowerApi.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cart");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ProductUser", b =>
                {
                    b.HasOne("FlowerApi.Entities.Product", null)
                        .WithMany()
                        .HasForeignKey("FavoriteProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FlowerApi.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FlowerApi.Entities.Cart", b =>
                {
                    b.Navigation("ProductsInCart");
                });

            modelBuilder.Entity("FlowerApi.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("FlowerApi.Entities.User", b =>
                {
                    b.Navigation("Cart")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
