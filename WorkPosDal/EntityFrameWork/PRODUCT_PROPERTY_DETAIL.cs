namespace WorkPosDal.EntityFrameWork
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PRODUCT_PROPERTY_DETAIL
    {
        [Key]
        public int PROPERTY_DETAIL_ID { get; set; }

        public int? PRPT_ID { get; set; }

        [StringLength(1000)]
        public string PROPERTY_DETAIL { get; set; }

        [StringLength(100)]
        public string PROP_CODE { get; set; }

        [StringLength(500)]
        public string PROPERTY_VALUES { get; set; }

        [StringLength(43)]
        public string UNIT { get; set; }

        public bool? IS_INTERVAL { get; set; }

        public double? ADDITIONAL_COST { get; set; }

        [StringLength(43)]
        public string ADDITIONAL_MONEY { get; set; }

        [StringLength(100)]
        public string PROPERTY_DETAIL_CODE { get; set; }

        public bool? IS_ACTIVE { get; set; }

        public int? OLD_PRPT_ID { get; set; }

        public int? OLD_PROPERTY_DETAIL_ID { get; set; }

        public bool? IS_FLAG { get; set; }

        public int? RECORD_EMP { get; set; }

        public DateTime? RECORD_DATE { get; set; }

        [StringLength(50)]
        public string RECORD_IP { get; set; }

        public int? UPDATE_EMP { get; set; }

        public DateTime? UPDATE_DATE { get; set; }

        [StringLength(50)]
        public string UPDATE_IP { get; set; }

        [StringLength(500)]
        public string RELATED_VARIATION_ID { get; set; }
    }
}
