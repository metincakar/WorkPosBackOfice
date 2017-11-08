using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace WorkPosDb.EntityFrameWork
{
    using System;
    using System.Collections.Generic;
     using System.ComponentModel;
 
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PRODUCT_BRANDS
    {
        [Key]
        [Display(Name = "Marka Id")]
        public int BRAND_ID { get; set; }

        [StringLength(50)]
        [DisplayName("Marka")]
        public string BRAND_NAME { get; set; }

        [StringLength(50)]
        [Browsable(false)]
        public string BRAND_CODE { get; set; }

        [StringLength(1000)]
        [Browsable(false)]
        public string DETAIL { get; set; }

        [Browsable(false)]
        public bool? IS_ACTIVE { get; set; }
        [Browsable(false)]
        public bool? IS_INTERNET { get; set; }

        [StringLength(250)]
        [Browsable(false)]
        public string BRAND_LOGO { get; set; }
        [Browsable(false)]
        public int? BRAND_LOGO_SERVER_ID { get; set; }
        [Browsable(false)]
        public int? RECORD_EMP { get; set; }
        [Browsable(false)]
        public DateTime? RECORD_DATE { get; set; }

        [StringLength(50)]
        [Browsable(false)]
        public string RECORD_IP { get; set; }
        [Browsable(false)]
        public int? UPDATE_EMP { get; set; }
        [Browsable(false)]
        public DateTime? UPDATE_DATE { get; set; }

        [StringLength(50)]
        [Browsable(false)]
        public string UPDATE_IP { get; set; }
    }
}
