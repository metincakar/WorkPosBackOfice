namespace WorkPosDb.EntityFrameWork
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PRODUCT_CAT_BRANDS
    {
        [Key]
        public int PRODUCT_CAT_BRAND_ID { get; set; }

        public int? PRODUCT_CAT_ID { get; set; }

        public int? BRAND_ID { get; set; }
    }
}
