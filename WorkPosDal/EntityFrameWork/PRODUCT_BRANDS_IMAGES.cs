namespace WorkPosDal.EntityFrameWork
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PRODUCT_BRANDS_IMAGES
    {
        public int BRAND_ID { get; set; }

        [Key]
        public int BRAND_IMAGEID { get; set; }

        [StringLength(100)]
        public string PATH { get; set; }

        [StringLength(250)]
        public string DETAIL { get; set; }

        public int? IMAGE_SIZE { get; set; }

        public DateTime? UPDATE_DATE { get; set; }

        public int? UPDATE_EMP { get; set; }

        [StringLength(50)]
        public string UPDATE_IP { get; set; }

        public int? PROPERTY_ID { get; set; }

        public int? UPDATE_PAR { get; set; }

        public bool? IS_INTERNET { get; set; }

        public int? PATH_SERVER_ID { get; set; }

        public bool? IS_EXTERNAL_LINK { get; set; }
    }
}
