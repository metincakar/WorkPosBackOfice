namespace WorkPosDb.EntityFrameWork
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelTest : DbContext
    {
        public ModelTest()
            : base("name=ModelTest")
        {
        }

        public virtual DbSet<SETUP_BRAND> SETUP_BRAND { get; set; }
        public virtual DbSet<SETUP_CITY> SETUP_CITY { get; set; }
        public virtual DbSet<SETUP_COUNTRY> SETUP_COUNTRY { get; set; }
        public virtual DbSet<SETUP_COUNTY> SETUP_COUNTY { get; set; }
        public virtual DbSet<SETUP_MONEY> SETUP_MONEY { get; set; }
        public virtual DbSet<SETUP_UNIT> SETUP_UNIT { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
