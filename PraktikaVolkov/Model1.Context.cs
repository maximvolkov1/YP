﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PraktikaVolkov
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HREntities6 : DbContext
    {
        public HREntities6()
            : base("name=HREntities6")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Acceptence> Acceptence { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Dismissal> Dismissal { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Moving> Moving { get; set; }
        public virtual DbSet<Post> Post { get; set; }
        public virtual DbSet<StaffingTable> StaffingTable { get; set; }
    }
}
