﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Coffee_Shop_Project
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Coffee_ProjectEntities : DbContext
    {
        public Coffee_ProjectEntities()
            : base("name=Coffee_ProjectEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<TblProduct> TblProducts { get; set; }
        public DbSet<TblProductType> TblProductTypes { get; set; }
        public DbSet<TblTransaction> TblTransactions { get; set; }
        public DbSet<TblTransactionItem> TblTransactionItems { get; set; }
    }
}
