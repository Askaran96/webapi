﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WApiVend.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class VendMgmtEntities : DbContext
    {
        public VendMgmtEntities()
            : base("name=VendMgmtEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Vendor> Vendors { get; set; }
        public virtual DbSet<LogIn> LogIns { get; set; }
        public virtual DbSet<VendorReg> VendorRegs { get; set; }
    }
}
