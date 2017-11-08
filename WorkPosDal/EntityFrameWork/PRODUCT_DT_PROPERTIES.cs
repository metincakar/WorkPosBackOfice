namespace WorkPosDal.EntityFrameWork
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PRODUCT_DT_PROPERTIES
    {
        [Key]
        public int PRODUCT_DT_PROPERTY_ID { get; set; }

        public int? PRODUCT_ID { get; set; }

        public int? PROPERTY_ID { get; set; }

        public int? ORDER_NO { get; set; }

        public int? VARIATION_ID { get; set; }

        [Column(TypeName = "ntext")]
        public string DETAIL { get; set; }

        public int? LINE_VALUE { get; set; }

        public double? AMOUNT { get; set; }

        public double? TOTAL_MIN { get; set; }

        public double? TOTAL_MAX { get; set; }

        public bool? IS_OPTIONAL { get; set; }

        public bool? IS_EXIT { get; set; }

        public bool? IS_INTERNET { get; set; }

        public int? RECORD_EMP { get; set; }

        public DateTime? RECORD_DATE { get; set; }

        [StringLength(50)]
        public string RECORD_IP { get; set; }

        public int? OLD_PROPERTY_ID { get; set; }

        public int? OLD_VARIATION_ID { get; set; }

        public int? OLD_PRODUCT_DT_PROPERTY_ID { get; set; }

        public bool? IS_FLAG { get; set; }

        public int? UPDATE_EMP { get; set; }

        public DateTime? UPDATE_DATE { get; set; }

        [StringLength(50)]
        public string UPDATE_IP { get; set; }
    }
}
