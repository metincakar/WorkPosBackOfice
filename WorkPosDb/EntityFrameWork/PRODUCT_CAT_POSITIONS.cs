namespace WorkPosDb.EntityFrameWork
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PRODUCT_CAT_POSITIONS
    {
        [Key]
        public int PRODUCT_CAT_POSITION_ID { get; set; }

        public int? PRODUCT_CAT_ID { get; set; }

        public int? POSITION_CODE { get; set; }

        public int? SEQUENCE_NO { get; set; }
    }
}
