﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Z.ExtensionMethods.EF6.Examples
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class EntityFrameworkTestEntities : DbContext
    {
        public EntityFrameworkTestEntities()
            : base("name=EntityFrameworkTestEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BulkCopyTest2> BulkCopyTest2 { get; set; }
        public virtual DbSet<EntityWithAllColumn2> EntityWithAllColumn2 { get; set; }
        public virtual DbSet<TestMapping2> TestMapping2 { get; set; }
        public virtual DbSet<VW_BulkCopyTest> VW_BulkCopyTest { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
    
        public virtual ObjectResult<Nullable<int>> TestProcedure(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("TestProcedure", iDParameter);
        }
    
        public virtual int Procedure_WithReturn(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Procedure_WithReturn", iDParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> Procedure_WithSelect(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("Procedure_WithSelect", iDParameter);
        }
    
        public virtual int Procedure_WithoutParameter()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Procedure_WithoutParameter");
        }
    }
}
