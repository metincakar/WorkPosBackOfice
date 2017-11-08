namespace WorkPosDb.EntityFrameWork
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class STOCKS
    {
        [Key]
        public int STOCK_ID { get; set; }

        [Required]
        [StringLength(150)]
        public string STOCK_CODE { get; set; }

        [StringLength(150)]
        public string STOCK_CODE_2 { get; set; }

        public int PRODUCT_ID { get; set; }

        [StringLength(500)]
        public string PROPERTY { get; set; }

        [StringLength(50)]
        public string BARCOD { get; set; }

        [Column("__SERIAL_BARCOD")]
        [StringLength(100)]
        public string C__SERIAL_BARCOD { get; set; }

        public int? PRODUCT_UNIT_ID { get; set; }

        [StringLength(100)]
        public string MANUFACT_CODE { get; set; }

        public bool? STOCK_STATUS { get; set; }

        public int? RECORD_EMP { get; set; }

        [StringLength(50)]
        public string RECORD_IP { get; set; }

        public DateTime? RECORD_DATE { get; set; }

        public int? UPDATE_EMP { get; set; }

        [StringLength(50)]
        public string UPDATE_IP { get; set; }

        public DateTime? UPDATE_DATE { get; set; }

        public double? SERIAL_BARCOD { get; set; }
    }
}
