using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ShoppingCartContext : DbContext
    {
        public ShoppingCartContext(DbContextOptions<ShoppingCartContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Token> Tokens { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .HasMany(u => u.tokens)
                .WithOne(t => t.user)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<User>()
                .HasMany(u => u.reviews)
                .WithOne(t => t.user)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Product>()
                .HasMany(p => p.reviews)
                .WithOne(r => r.product)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Category>()
                .HasMany(c => c.products)
                .WithOne(p => p.category)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Product>()
                .HasMany(p => p.images)
                .WithOne(i => i.product)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<User>()
                .HasMany(u => u.orders)
                .WithOne(o => o.user)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<PaymentMethod>()
                .HasMany(p => p.orders)
                .WithOne(o => o.paymentMethod);
            modelBuilder.Entity<Product>()
                .HasMany(p => p.productsOfCart)
                .WithOne(poc => poc.product)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<User>()
                .HasMany(u => u.productsOfCart)
                .WithOne(poc => poc.user)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Category>()
                .HasMany(c => c.productsOfCategories)
                .WithOne(poc => poc.category)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Product>()
                .HasMany(p => p.productsOfCategories)
                .WithOne(poc => poc.product)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Voucher>()
                .HasMany(v => v.vouchersOfOrder)
                .WithOne(poc => poc.voucher)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Order>()
                .HasMany(o => o.vouchersOfOrder)
                .WithOne(voo => voo.order)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Order>()
                .HasMany(o => o.productsOfOder)
                .WithOne(poo => poo.order)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
