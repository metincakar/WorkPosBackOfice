namespace WorkPosDal.EntityFrameWork
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PRODUCT_PROPERTY
    {
        [Key]
        public int PROPERTY_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string PROPERTY { get; set; }

        [StringLength(150)]
        public string DETAIL { get; set; }

        public bool? PROPERTY_SIZE { get; set; }

        public bool? PROPERTY_COLOR { get; set; }

        [StringLength(50)]
        public string PRODUCT_CAT_HIER { get; set; }

        public double? ADDITIONAL_COST { get; set; }

        [StringLength(43)]
        public string ADDITIONAL_MONEY { get; set; }

        [StringLength(43)]
        public string PROPERTY_CODE { get; set; }

        public int? CAT_PROPERTY_ID { get; set; }

        public int? VARIATION_ID { get; set; }

        public double? AMOUNT { get; set; }

        public int? MIN_VALUE { get; set; }

        public int? MAX_VALUE { get; set; }

        public bool? IS_OPTIONAL { get; set; }

        public bool? IS_INTERNET { get; set; }

        public bool? IS_ACTIVE { get; set; }

        public bool? IS_VARIATION_CONTROL { get; set; }

        public int? RECORD_EMP { get; set; }

        public DateTime? RECORD_DATE { get; set; }

        [StringLength(50)]
        public string RECORD_IP { get; set; }

        public int? UPDATE_EMP { get; set; }

        public DateTime? UPDATE_DATE { get; set; }

        [StringLength(50)]
        public string UPDATE_IP { get; set; }
    }
}
