
namespace CRUD
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EmpleadosEntities : DbContext
    {
        public EmpleadosEntities()
            : base("EmpleadosConn")
        {
        }

        public  DbSet<Personal> EmpPersCon { get; set; }
    }
}
