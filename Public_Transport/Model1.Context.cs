//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Public_Transport
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CursovaEntities : DbContext
    {
        public CursovaEntities()
            : base("name=CursovaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Drivers> Drivers { get; set; }
        public virtual DbSet<Routes> Routes { get; set; }
        public virtual DbSet<Stops> Stops { get; set; }
        public virtual DbSet<Stops_name> Stops_name { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Traffic_schedule> Traffic_schedule { get; set; }
        public virtual DbSet<Transports> Transports { get; set; }
    }
}
