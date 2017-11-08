using System.ComponentModel;

namespace WorkPosDal.EntityFrameWork
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PRODUCT_CAT{

        [Key]
          [Browsable(false)]
        public int PRODUCT_CATID { get; set; }

        [StringLength(50)]
        [DisplayName("Kategori Kodu")]
        public string HIERARCHY { get; set; }


        [DisplayName("Kategori ")]
        [Column("PRODUCT_CAT")]
        [Required]
        [StringLength(150)]
        public string PRODUCT_CAT1 { get; set; }

        [StringLength(150)]
        [Browsable(false)]
        public string DETAIL { get; set; }

        [Browsable(false)]
        public int? POSITION_CODE { get; set; }

        [Browsable(false)]
        public int? POSITION_CODE2 { get; set; }

              [Browsable(false)]
        public bool? DSP { get; set; }

              [Browsable(false)]
        public bool? IS_PUBLIC { get; set; }

              [Browsable(false)]
        public double? PROFIT_MARGIN { get; set; }

              [Browsable(false)]
        public double? PROFIT_MARGIN_MAX { get; set; }

              [Browsable(false)]
        public bool? IS_SUB_PRODUCT_CAT { get; set; }
             
        [Browsable(false)]
        public bool? IS_CUSTOMIZABLE { get; set; }

              [Browsable(false)]
        public DateTime? RECORD_DATE { get; set; }

              [Browsable(false)]
        public int? RECORD_EMP { get; set; }

              [Browsable(false)]
        [StringLength(50)]
        public string RECORD_EMP_IP { get; set; }

              [Browsable(false)]
        public DateTime? UPDATE_DATE { get; set; }

              [Browsable(false)]
        public int? UPDATE_EMP { get; set; }

        [StringLength(50)]
        [Browsable(false)]
        public string UPDATE_EMP_IP { get; set; }

              [Browsable(false)]
        public int? LIST_ORDER_NO { get; set; }

        [StringLength(200)]
        [Browsable(false)]
        public string IMAGE_CAT { get; set; }

              [Browsable(false)]
        public int? IMAGE_CAT_SERVER_ID { get; set; }

              [Browsable(false)]
        public bool? SHOW_IPAD { get; set; }

              [Browsable(false)]
        public bool? YENISEZON { get; set; }

              [Browsable(false)]
        [StringLength(250)]
        public string USER_FRIENDLY_URL { get; set; }
    }
}
