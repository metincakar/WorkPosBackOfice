namespace WorkPosDal.EntityFrameWork
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PRODUCT_NO
    {
        [Key]
        [Column("PRODUCT_NO", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PRODUCT_NO1 { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int STOCK_NO { get; set; }

        [StringLength(50)]
        public string BARCODE { get; set; }

        [StringLength(50)]
        public string BARCODE_EAN8 { get; set; }
    }
}
