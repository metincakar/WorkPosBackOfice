namespace WorkPosDb.EntityFrameWork
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PRODUCT_UNIT_HISTORY
    {
        [Key]
        public int PRODUCT_UNIT_HISTORY_ID { get; set; }

        public int PRODUCT_UNIT_ID { get; set; }

        [StringLength(50)]
        public string MAIN_UNIT { get; set; }

        public int? UPDATE_EMP { get; set; }

        public DateTime? UPDATE_DATE { get; set; }

        public int? RECORD_EMP { get; set; }

        public DateTime? RECORD_DATE { get; set; }

        public double? MULTIPLIER { get; set; }
    }
}
