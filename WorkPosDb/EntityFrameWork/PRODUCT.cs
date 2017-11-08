namespace WorkPosDb.EntityFrameWork
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRODUCT")]
    public partial class PRODUCT
    {
        [Key]
        public int PRODUCT_ID { get; set; }

        public bool PRODUCT_STATUS { get; set; }

        [StringLength(150)]
        public string PRODUCT_CODE { get; set; }

        public int? COMPANY_ID { get; set; }

        public int PRODUCT_CATID { get; set; }

        [StringLength(50)]
        public string BARCOD { get; set; }

        [StringLength(500)]
        public string PRODUCT_NAME { get; set; }

        [StringLength(500)]
        public string PRODUCT_DETAIL { get; set; }

        [StringLength(500)]
        public string PRODUCT_DETAIL2 { get; set; }

        public double TAX { get; set; }

        public double? TAX_PURCHASE { get; set; }

        [Column("_VALID_DATE")]
        public DateTime? C_VALID_DATE { get; set; }

        [Column("_VALID_POS")]
        public int? C_VALID_POS { get; set; }

        [Column("_VALID_EMP")]
        public int? C_VALID_EMP { get; set; }

        public bool? IS_INVENTORY { get; set; }

        public int? INVENTORY_CALC_TYPE { get; set; }

        public bool? IS_PRODUCTION { get; set; }

        [StringLength(50)]
        public string SHELF_LIFE { get; set; }

        public bool? IS_SALES { get; set; }

        public bool? IS_PURCHASE { get; set; }

        [StringLength(100)]
        public string MANUFACT_CODE { get; set; }

        public bool? IS_PROTOTYPE { get; set; }

        public double? PRODUCT_TREE_AMOUNT { get; set; }

        public int? PRODUCT_MANAGER { get; set; }

        public int? SEGMENT_ID { get; set; }

        public bool? IS_INTERNET { get; set; }

        public int? PROD_COMPETITIVE { get; set; }

        public int? PRODUCT_STAGE { get; set; }

        public bool? IS_TERAZI { get; set; }

        public int? BRAND_ID { get; set; }

        public bool? IS_SERIAL_NO { get; set; }

        public bool? IS_ZERO_STOCK { get; set; }

        public double? MIN_MARGIN { get; set; }

        public double? MAX_MARGIN { get; set; }

        public double? OTV { get; set; }

        [Column("_IS_EXPORTED")]
        public bool? C_IS_EXPORTED { get; set; }

        public bool? IS_KARMA { get; set; }

        public bool? IS_WORKER { get; set; }

        public bool? IS_RETIRED { get; set; }

        [StringLength(150)]
        public string PRODUCT_CODE_2 { get; set; }

        [StringLength(150)]
        public string SHORT_CODE { get; set; }

        public bool? IS_COST { get; set; }

        public int? WORK_STOCK_ID { get; set; }

        public double? WORK_STOCK_AMOUNT { get; set; }

        public bool? IS_EXTRANET { get; set; }

        public bool? IS_KARMA_SEVK { get; set; }

        public int? RECORD_BRANCH_ID { get; set; }

        public DateTime? RECORD_DATE { get; set; }

        public int? RECORD_MEMBER { get; set; }

        [StringLength(43)]
        public string MEMBER_TYPE { get; set; }

        public DateTime? UPDATE_DATE { get; set; }

        public int? UPDATE_EMP { get; set; }

        public int? UPDATE_PAR { get; set; }

        [StringLength(50)]
        public string UPDATE_IP { get; set; }

        [StringLength(250)]
        public string USER_FRIENDLY_URL { get; set; }

        public int? PACKAGE_CONTROL_TYPE { get; set; }

        public double? OTV_AMOUNT { get; set; }

        public bool? IS_LIMITED_STOCK { get; set; }

        public int? SHORT_CODE_ID { get; set; }

        [StringLength(255)]
        public string URL_TITLE { get; set; }

        [Column("_SEGMENT_ID")]
        public int? C_SEGMENT_ID { get; set; }

        public bool? IS_COMMISSION { get; set; }

        [StringLength(50)]
        public string CUSTOMS_RECIPE_CODE { get; set; }

        public bool? IS_ADD_XML { get; set; }

        public bool? IS_GIFT_CARD { get; set; }

        public int? GIFT_VALID_DAY { get; set; }

        public int? REF_PRODUCT_CODE { get; set; }

        public bool? IS_QUALITY { get; set; }
    }
}
