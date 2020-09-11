namespace Model.EntityFramework
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class OnlineShopDbContext : DbContext
    {
        public OnlineShopDbContext()
            : base("name=OnlineShopDbContext")
        {
        }

        public virtual DbSet<users> users { get; set; }
        public virtual DbSet<brands> brands { get; set; }
        public virtual DbSet<categories> categories { get; set; }
        public virtual DbSet<products> products { get; set; }
        public virtual DbSet<stocks> stocks { get; set; }
        public virtual DbSet<customers> customers { get; set; }
        public virtual DbSet<order_items> order_items { get; set; }
        public virtual DbSet<orders> orders { get; set; }
        public virtual DbSet<staffs> staffs { get; set; }
        public virtual DbSet<stores> stores { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<users>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<users>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<brands>()
                .Property(e => e.brand_name)
                .IsUnicode(false);

            modelBuilder.Entity<categories>()
                .Property(e => e.category_name)
                .IsUnicode(false);

            modelBuilder.Entity<products>()
                .Property(e => e.product_name)
                .IsUnicode(false);

            modelBuilder.Entity<products>()
                .Property(e => e.list_price)
                .HasPrecision(10, 2);

            modelBuilder.Entity<customers>()
                .Property(e => e.first_name)
                .IsUnicode(false);

            modelBuilder.Entity<customers>()
                .Property(e => e.last_name)
                .IsUnicode(false);

            modelBuilder.Entity<customers>()
                .Property(e => e.phone)
                .IsUnicode(false);

            modelBuilder.Entity<customers>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<customers>()
                .Property(e => e.street)
                .IsUnicode(false);

            modelBuilder.Entity<customers>()
                .Property(e => e.city)
                .IsUnicode(false);

            modelBuilder.Entity<customers>()
                .Property(e => e.state)
                .IsUnicode(false);

            modelBuilder.Entity<customers>()
                .Property(e => e.zip_code)
                .IsUnicode(false);

            modelBuilder.Entity<customers>()
                .HasMany(e => e.orders)
                .WithOptional(e => e.customers)
                .WillCascadeOnDelete();

            modelBuilder.Entity<order_items>()
                .Property(e => e.list_price)
                .HasPrecision(10, 2);

            modelBuilder.Entity<order_items>()
                .Property(e => e.discount)
                .HasPrecision(4, 2);

            modelBuilder.Entity<staffs>()
                .Property(e => e.first_name)
                .IsUnicode(false);

            modelBuilder.Entity<staffs>()
                .Property(e => e.last_name)
                .IsUnicode(false);

            modelBuilder.Entity<staffs>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<staffs>()
                .Property(e => e.phone)
                .IsUnicode(false);

            modelBuilder.Entity<staffs>()
                .HasMany(e => e.orders)
                .WithRequired(e => e.staffs)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<staffs>()
                .HasMany(e => e.staffs1)
                .WithOptional(e => e.staffs2)
                .HasForeignKey(e => e.manager_id);

            modelBuilder.Entity<stores>()
                .Property(e => e.store_name)
                .IsUnicode(false);

            modelBuilder.Entity<stores>()
                .Property(e => e.phone)
                .IsUnicode(false);

            modelBuilder.Entity<stores>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<stores>()
                .Property(e => e.street)
                .IsUnicode(false);

            modelBuilder.Entity<stores>()
                .Property(e => e.city)
                .IsUnicode(false);

            modelBuilder.Entity<stores>()
                .Property(e => e.state)
                .IsUnicode(false);

            modelBuilder.Entity<stores>()
                .Property(e => e.zip_code)
                .IsUnicode(false);
        }
    }
}