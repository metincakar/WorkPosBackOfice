namespace WorkPosDb.EntityFrameWork
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class STOCKS_BARCODES
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int STOCK_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string BARCODE { get; set; }

        public int? UNIT_ID { get; set; }
    }
}
