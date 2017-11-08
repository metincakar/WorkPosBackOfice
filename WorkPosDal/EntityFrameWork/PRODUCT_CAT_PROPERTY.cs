namespace WorkPosDal.EntityFrameWork
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PRODUCT_CAT_PROPERTY
    {
        [Key]
        public int PRODUCT_CAT_PROID { get; set; }

        public int? PRODUCT_CAT_ID { get; set; }

        public int? PROPERTY_ID { get; set; }

        public int? LINE_VALUE { get; set; }

        public bool? IS_WORTH { get; set; }

        public bool? IS_OPTIONAL { get; set; }

        public bool? IS_AMOUNT { get; set; }

        public bool? IS_INTERNET { get; set; }

        public int? RECORD_EMP { get; set; }

        public DateTime? RECORD_DATE { get; set; }

        [StringLength(50)]
        public string RECORD_IP { get; set; }

        public int? UPDATE_EMP { get; set; }

        public DateTime? UPDATE_DATE { get; set; }

        [StringLength(50)]
        public string UPDATE_IP { get; set; }

        public int? OLD_PROPERTY_ID { get; set; }

        public bool? IS_FLAG { get; set; }
    }
}
