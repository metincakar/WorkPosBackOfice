namespace WorkPosDb.EntityFrameWork
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class WorkPosDbContext : DbContext
    {
        public WorkPosDbContext()
            : base("name=WorkPosDbContext")
        {
        }

        public virtual DbSet<COMPANY> COMPANY { get; set; }
        public virtual DbSet<COMPANY_ACCOUNTS> COMPANY_ACCOUNTS { get; set; }
        public virtual DbSet<COMPANY_BRANCH> COMPANY_BRANCH { get; set; }
        public virtual DbSet<COMPANY_CAT> COMPANY_CAT { get; set; }
        public virtual DbSet<COMPANY_CREDIT> COMPANY_CREDIT { get; set; }
        public virtual DbSet<COMPANY_PARTNER> COMPANY_PARTNER { get; set; }
        public virtual DbSet<COMPANY_PERIOD> COMPANY_PERIOD { get; set; }
        public virtual DbSet<CONSUMER> CONSUMER { get; set; }
        public virtual DbSet<CONSUMER_CAT> CONSUMER_CAT { get; set; }
        public virtual DbSet<EMPLOYEE_POSITIONS> EMPLOYEE_POSITIONS { get; set; }
        public virtual DbSet<EMPLOYEES> EMPLOYEES { get; set; }
        public virtual DbSet<OUR_COMPANY_INFO> OUR_COMPANY_INFO { get; set; }
        public virtual DbSet<OUR_COMPANY> OUR_COMPANY { get; set; }

        public virtual DbSet<SETUP_BRAND> SETUP_BRAND { get; set; }
        public virtual DbSet<SETUP_CITY> SETUP_CITY { get; set; }
        public virtual DbSet<SETUP_COUNTRY> SETUP_COUNTRY { get; set; }
        public virtual DbSet<SETUP_COUNTY> SETUP_COUNTY { get; set; }
        public virtual DbSet<SETUP_MONEY> SETUP_MONEY { get; set; }
        public virtual DbSet<SETUP_UNIT> SETUP_UNIT { get; set; }


        //product


        public virtual DbSet<PRICE_STANDART> PRICE_STANDART { get; set; }
        public virtual DbSet<PRODUCT> PRODUCT { get; set; }
        public virtual DbSet<PRODUCT_BRANCH> PRODUCT_BRANCH { get; set; }
        public virtual DbSet<PRODUCT_BRANDS> PRODUCT_BRANDS { get; set; }
        public virtual DbSet<PRODUCT_BRANDS_IMAGES> PRODUCT_BRANDS_IMAGES { get; set; }
        public virtual DbSet<PRODUCT_BRANDS_MODEL> PRODUCT_BRANDS_MODEL { get; set; }
        public virtual DbSet<PRODUCT_BRANDS_OUR_COMPANY> PRODUCT_BRANDS_OUR_COMPANY { get; set; }
        public virtual DbSet<PRODUCT_CAT> PRODUCT_CAT { get; set; }
        public virtual DbSet<PRODUCT_CAT_BRANDS> PRODUCT_CAT_BRANDS { get; set; }
        public virtual DbSet<PRODUCT_CAT_OUR_COMPANY> PRODUCT_CAT_OUR_COMPANY { get; set; }
        public virtual DbSet<PRODUCT_CAT_POSITIONS> PRODUCT_CAT_POSITIONS { get; set; }
        public virtual DbSet<PRODUCT_CAT_PROPERTY> PRODUCT_CAT_PROPERTY { get; set; }
        public virtual DbSet<PRODUCT_COST> PRODUCT_COST { get; set; }
        public virtual DbSet<PRODUCT_DT_PROPERTIES> PRODUCT_DT_PROPERTIES { get; set; }
        public virtual DbSet<PRODUCT_IMAGES> PRODUCT_IMAGES { get; set; }
        public virtual DbSet<PRODUCT_PROPERTY> PRODUCT_PROPERTY { get; set; }
        public virtual DbSet<PRODUCT_PROPERTY_DETAIL> PRODUCT_PROPERTY_DETAIL { get; set; }
        public virtual DbSet<PRODUCT_PROPERTY_OUR_COMPANY> PRODUCT_PROPERTY_OUR_COMPANY { get; set; }
        public virtual DbSet<PRODUCT_UNIT> PRODUCT_UNIT { get; set; }
        public virtual DbSet<PRODUCT_UNIT_HISTORY> PRODUCT_UNIT_HISTORY { get; set; }
        public virtual DbSet<RELATED_PRODUCT_CAT> RELATED_PRODUCT_CAT { get; set; }
        public virtual DbSet<SETUP_COMPANY_STOCK_CODE> SETUP_COMPANY_STOCK_CODE { get; set; }
        public virtual DbSet<STOCKS> STOCKS { get; set; }
        public virtual DbSet<STOCKS_PROPERTY> STOCKS_PROPERTY { get; set; }
        public virtual DbSet<PRODUCT_NO> PRODUCT_NO { get; set; }
        public virtual DbSet<PRODUCT_OUR_COMPANY> PRODUCT_OUR_COMPANY { get; set; }
        public virtual DbSet<STOCKS_BARCODES> STOCKS_BARCODES { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
