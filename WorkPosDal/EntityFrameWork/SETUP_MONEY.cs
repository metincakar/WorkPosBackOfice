namespace WorkPosDal.EntityFrameWork
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SETUP_MONEY
    {
        [Key]
        public int MONEY_ID { get; set; }

        [StringLength(43)]
        public string MONEY { get; set; }

        public double? RATE1 { get; set; }

        public double? RATE2 { get; set; }

        public bool? MONEY_STATUS { get; set; }

        public int? PERIOD_ID { get; set; }

        public int? COMPANY_ID { get; set; }

        [Column("_ACCOUNT_900")]
        [StringLength(50)]
        public string C_ACCOUNT_900 { get; set; }

        [StringLength(50)]
        public string ACCOUNT_950 { get; set; }

        [StringLength(50)]
        public string PER_ACCOUNT { get; set; }

        public int? KURUS_COUNT { get; set; }

        public double? RATE3 { get; set; }

        public DateTime? RECORD_DATE { get; set; }

        public int? RECORD_EMP { get; set; }

        [StringLength(50)]
        public string RECORD_IP { get; set; }

        public DateTime? UPDATE_DATE { get; set; }

        public int? UPDATE_EMP { get; set; }

        [StringLength(50)]
        public string UPDATE_IP { get; set; }

        public double? RATEPP2 { get; set; }

        public double? RATEPP3 { get; set; }

        public double? RATEWW2 { get; set; }

        public double? RATEWW3 { get; set; }

        [StringLength(43)]
        public string CURRENCY_CODE { get; set; }

        public double? DSP_RATE_SALE { get; set; }

        public double? DSP_RATE_PUR { get; set; }

        public DateTime? DSP_UPDATE_DATE { get; set; }

        public double? DSP_EFFECTIVE_SALE { get; set; }

        public double? DSP_EFFECTIVE_PUR { get; set; }

        public double? EFFECTIVE_SALE { get; set; }

        public double? EFFECTIVE_PUR { get; set; }

        [StringLength(43)]
        public string MONEY_NAME { get; set; }

        [StringLength(43)]
        public string MONEY_SYMBOL { get; set; }
    }
}
