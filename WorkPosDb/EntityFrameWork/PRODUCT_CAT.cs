namespace WorkPosDb.EntityFrameWork
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PRODUCT_CAT
    {
        public int PRODUCT_CATID { get; set; }

        [StringLength(50)]
        public string HIERARCHY { get; set; }

        [Column("PRODUCT_CAT")]
        [Required]
        [StringLength(150)]
        public string PRODUCT_CAT1 { get; set; }

        [StringLength(150)]
        public string DETAIL { get; set; }

        public int? POSITION_CODE { get; set; }

        public int? POSITION_CODE2 { get; set; }

        public bool? DSP { get; set; }

        public bool? IS_PUBLIC { get; set; }

        public double? PROFIT_MARGIN { get; set; }

        public double? PROFIT_MARGIN_MAX { get; set; }

        public bool? IS_SUB_PRODUCT_CAT { get; set; }

        public bool? IS_CUSTOMIZABLE { get; set; }

        public DateTime? RECORD_DATE { get; set; }

        public int? RECORD_EMP { get; set; }

        [StringLength(50)]
        public string RECORD_EMP_IP { get; set; }

        public DateTime? UPDATE_DATE { get; set; }

        public int? UPDATE_EMP { get; set; }

        [StringLength(50)]
        public string UPDATE_EMP_IP { get; set; }

        public int? LIST_ORDER_NO { get; set; }

        [StringLength(200)]
        public string IMAGE_CAT { get; set; }

        public int? IMAGE_CAT_SERVER_ID { get; set; }

        public bool? SHOW_IPAD { get; set; }

        public bool? YENISEZON { get; set; }

        [StringLength(250)]
        public string USER_FRIENDLY_URL { get; set; }
    }
}
