using System.ComponentModel;

namespace WorkPosDal.EntityFrameWork
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PRODUCT_BRANDS_MODEL
    {
        [Key]
        [DisplayName("Model Id")]
        public int MODEL_ID { get; set; }

        [StringLength(150)]
        [DisplayName("Model")]
        public string MODEL_NAME { get; set; }

         [Browsable(false)]
        public int? RECORD_EMP { get; set; }

         [Browsable(false)]
        public DateTime? RECORD_DATE { get; set; }

         [Browsable(false)]
        [StringLength(50)]
        public string RECORD_IP { get; set; }

         [Browsable(false)]
        public int? UPDATE_EMP { get; set; }

         [Browsable(false)]
        public DateTime? UPDATE_DATE { get; set; }

         [Browsable(false)]
        [StringLength(50)]
        public string UPDATE_IP { get; set; }

         [Browsable(false)]
        [StringLength(150)]
        public string MODEL_CODE { get; set; }

         [Browsable(false)]
        public int? BRAND_ID { get; set; }
    }
}
