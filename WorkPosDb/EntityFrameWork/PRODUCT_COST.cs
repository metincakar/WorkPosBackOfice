namespace WorkPosDb.EntityFrameWork
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PRODUCT_COST
    {
        [Key]
        public int PRODUCT_COST_ID { get; set; }

        public int? PROCESS_STAGE { get; set; }

        public int? PRODUCT_ID { get; set; }

        public int? UNIT_ID { get; set; }

        public bool? IS_SPEC { get; set; }

        public int? SPECT_MAIN_ID { get; set; }

        public bool? PRODUCT_COST_STATUS { get; set; }

        public int? INVENTORY_CALC_TYPE { get; set; }

        public DateTime? START_DATE { get; set; }

        public int? COST_TYPE_ID { get; set; }

        [Column("_REFERENCE_NO")]
        public int? C_REFERENCE_NO { get; set; }

        [Column("PRODUCT_COST")]
        public double? PRODUCT_COST1 { get; set; }

        [StringLength(43)]
        public string MONEY { get; set; }

        public double? STANDARD_COST { get; set; }

        [StringLength(43)]
        public string STANDARD_COST_MONEY { get; set; }

        public double? STANDARD_COST_RATE { get; set; }

        public double? PURCHASE_NET { get; set; }

        [StringLength(43)]
        public string PURCHASE_NET_MONEY { get; set; }

        public double? PURCHASE_EXTRA_COST { get; set; }

        public double? PRICE_PROTECTION { get; set; }

        [StringLength(43)]
        public string PRICE_PROTECTION_MONEY { get; set; }

        public int? PRICE_PROTECTION_TYPE { get; set; }

        public double? PURCHASE_NET_SYSTEM { get; set; }

        [StringLength(43)]
        public string PURCHASE_NET_SYSTEM_MONEY { get; set; }

        public double? PURCHASE_EXTRA_COST_SYSTEM { get; set; }

        public double? PRODUCT_COST_SYSTEM { get; set; }

        public double? PURCHASE_NET_SYSTEM_2 { get; set; }

        [StringLength(43)]
        public string PURCHASE_NET_SYSTEM_MONEY_2 { get; set; }

        public double? PURCHASE_EXTRA_COST_SYSTEM_2 { get; set; }

        public double? AVAILABLE_STOCK { get; set; }

        public double? PARTNER_STOCK { get; set; }

        public double? ACTIVE_STOCK { get; set; }

        public bool? IS_STANDARD_COST { get; set; }

        public bool? IS_ACTIVE_STOCK { get; set; }

        public bool? IS_PARTNER_STOCK { get; set; }

        [StringLength(300)]
        public string COST_DESCRIPTION { get; set; }

        public int? ACTION_PROCESS_TYPE { get; set; }

        public int? ACTION_PROCESS_CAT_ID { get; set; }

        public int? ACTION_ID { get; set; }

        public int? ACTION_ROW_ID { get; set; }

        public double? ACTION_ROW_PRICE { get; set; }

        public int? ACTION_TYPE { get; set; }

        public int? ACTION_PERIOD_ID { get; set; }

        public double? ACTION_AMOUNT { get; set; }

        public DateTime? ACTION_DATE { get; set; }

        public int? ACTION_DUE_DATE { get; set; }

        public int? DEPARTMENT_ID { get; set; }

        public int? LOCATION_ID { get; set; }

        public double? PRODUCT_COST_LOCATION { get; set; }

        [StringLength(43)]
        public string MONEY_LOCATION { get; set; }

        public double? STANDARD_COST_LOCATION { get; set; }

        [StringLength(43)]
        public string STANDARD_COST_MONEY_LOCATION { get; set; }

        public double? STANDARD_COST_RATE_LOCATION { get; set; }

        public double? PURCHASE_NET_LOCATION { get; set; }

        [StringLength(43)]
        public string PURCHASE_NET_MONEY_LOCATION { get; set; }

        public double? PURCHASE_EXTRA_COST_LOCATION { get; set; }

        public double? PRICE_PROTECTION_LOCATION { get; set; }

        [StringLength(43)]
        public string PRICE_PROTECTION_MONEY_LOCATION { get; set; }

        public double? PURCHASE_NET_SYSTEM_LOCATION { get; set; }

        [StringLength(43)]
        public string PURCHASE_NET_SYSTEM_MONEY_LOCATION { get; set; }

        public double? PURCHASE_EXTRA_COST_SYSTEM_LOCATION { get; set; }

        public double? PURCHASE_NET_SYSTEM_2_LOCATION { get; set; }

        [StringLength(43)]
        public string PURCHASE_NET_SYSTEM_MONEY_2_LOCATION { get; set; }

        public double? PURCHASE_EXTRA_COST_SYSTEM_2_LOCATION { get; set; }

        public double? AVAILABLE_STOCK_LOCATION { get; set; }

        public double? PARTNER_STOCK_LOCATION { get; set; }

        public double? ACTIVE_STOCK_LOCATION { get; set; }

        public bool? IS_SEVK { get; set; }

        public DateTime? RECORD_DATE { get; set; }

        public int? RECORD_EMP { get; set; }

        [StringLength(50)]
        public string RECORD_IP { get; set; }

        public DateTime? UPDATE_DATE { get; set; }

        public int? UPDATE_EMP { get; set; }

        [StringLength(50)]
        public string UPDATE_IP { get; set; }

        public int? IS_SUGGEST { get; set; }

        public double? PRICE_PROTECTION_TOTAL { get; set; }

        public double? PRICE_PROTECTION_AMOUNT { get; set; }

        public DateTime? DUE_DATE { get; set; }

        public DateTime? DUE_DATE_LOCATION { get; set; }

        public DateTime? PHYSICAL_DATE { get; set; }

        public DateTime? PHYSICAL_DATE_LOCATION { get; set; }

        public double? ACTION_EXTRA_COST { get; set; }

        public int? STOCK_ID { get; set; }

        public double? PURCHASE_NET_ALL { get; set; }

        public double? PURCHASE_NET_SYSTEM_ALL { get; set; }

        public double? PURCHASE_NET_SYSTEM_2_ALL { get; set; }

        public double? PURCHASE_NET_LOCATION_ALL { get; set; }

        public double? PURCHASE_NET_SYSTEM_LOCATION_ALL { get; set; }

        public double? PURCHASE_NET_SYSTEM_2_LOCATION_ALL { get; set; }
    }
}
