﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Luis.MasteringExtJs.WebApi.Repository
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SakilaEntities : DbContext
    {
        public SakilaEntities()
            : base("name=SakilaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<actor> actors { get; set; }
        public virtual DbSet<address> addresses { get; set; }
        public virtual DbSet<category> categories { get; set; }
        public virtual DbSet<city> cities { get; set; }
        public virtual DbSet<country> countries { get; set; }
        public virtual DbSet<customer> customers { get; set; }
        public virtual DbSet<film> films { get; set; }
        public virtual DbSet<film_actor> film_actor { get; set; }
        public virtual DbSet<film_category> film_category { get; set; }
        public virtual DbSet<film_text> film_text { get; set; }
        public virtual DbSet<inventory> inventories { get; set; }
        public virtual DbSet<language> languages { get; set; }
        public virtual DbSet<payment> payments { get; set; }
        public virtual DbSet<rental> rentals { get; set; }
        public virtual DbSet<staff> staffs { get; set; }
        public virtual DbSet<store> stores { get; set; }
        public virtual DbSet<customer_list> customer_list { get; set; }
        public virtual DbSet<film_list> film_list { get; set; }
        public virtual DbSet<sales_by_film_category> sales_by_film_category { get; set; }
        public virtual DbSet<sales_by_store> sales_by_store { get; set; }
        public virtual DbSet<staff_list> staff_list { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<Permission> Permissions { get; set; }
    }
}
