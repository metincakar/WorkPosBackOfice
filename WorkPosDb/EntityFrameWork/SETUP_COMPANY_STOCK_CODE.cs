namespace WorkPosDb.EntityFrameWork
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SETUP_COMPANY_STOCK_CODE
    {
        [Key]
        public int COMPANY_STOCK_ID { get; set; }

        public int COMPANY_ID { get; set; }

        public int STOCK_ID { get; set; }

        [Required]
        [StringLength(150)]
        public string COMPANY_STOCK_CODE { get; set; }

        public int RECORD_EMP { get; set; }

        public DateTime RECORD_DATE { get; set; }

        [StringLength(50)]
        public string RECORD_IP { get; set; }

        [StringLength(500)]
        public string COMPANY_PRODUCT_NAME { get; set; }

        public bool? IS_ACTIVE { get; set; }

        public int? PRIORITY { get; set; }

        [StringLength(250)]
        public string DETAIL { get; set; }
    }
}
