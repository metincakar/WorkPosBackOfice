namespace WorkPosBackOfice.ModulProduct
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class KARMA_PRODUCTS
    {
        [Key]
        public int ENTRY_ID { get; set; }

        public int KARMA_PRODUCT_ID { get; set; }

        public int? PRODUCT_ID { get; set; }

        [StringLength(43)]
        public string MONEY { get; set; }

        [StringLength(250)]
        public string PRODUCT_NAME { get; set; }

        public double? PURCHASE_PRICE { get; set; }

        public double? SALES_PRICE { get; set; }

        public double? SALES_PRICE_KDV { get; set; }

        public double? TOTAL_PRODUCT_PRICE { get; set; }

        public double? TAX { get; set; }

        public double? TAX_PURCHASE { get; set; }

        public int? PRODUCT_UNIT_ID { get; set; }

        [StringLength(50)]
        public string UNIT { get; set; }

        public double? PRODUCT_AMOUNT { get; set; }

        public int? STOCK_ID { get; set; }

        [Column("__ROW_NETTOTAL")]
        public double? C__ROW_NETTOTAL { get; set; }

        [Column("__ROW_NETTOTAL_2")]
        public double? C__ROW_NETTOTAL_2 { get; set; }

        [Column("__ROW_TOTAL")]
        public double? C__ROW_TOTAL { get; set; }

        [StringLength(43)]
        public string KARMA_PRODUCT_MONEY { get; set; }

        public int? SPEC_MAIN_ID { get; set; }

        public double? LIST_PRICE { get; set; }

        public double? OTHER_LIST_PRICE { get; set; }
    }
}
