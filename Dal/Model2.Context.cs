﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dal
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class taxisEntities : DbContext
    {
        public taxisEntities()
            : base("name=taxisEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<RequestsTable> RequestsTables { get; set; }
        public virtual DbSet<CarTable> CarTables { get; set; }
        public virtual DbSet<EmployeeTable> EmployeeTables { get; set; }
        public virtual DbSet<LocationTable> LocationTables { get; set; }
        public virtual DbSet<RouteTable> RouteTables { get; set; }
        public virtual DbSet<StationTable> StationTables { get; set; }
        public virtual DbSet<TravleTable> TravleTables { get; set; }
        public virtual DbSet<UsersTable> UsersTables { get; set; }
        public virtual DbSet<RequestsForUser> RequestsForUsers { get; set; }
    }
}
