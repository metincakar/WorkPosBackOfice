namespace WorkPosDb.EntityFrameWork
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PRICE_STANDART
    {
        [Key]
        public int PRICESTANDART_ID { get; set; }

        public bool? PRICESTANDART_STATUS { get; set; }

        public int? PRODUCT_ID { get; set; }

        public bool? PURCHASESALES { get; set; }

        public double? PRICE { get; set; }

        public double? PRICE_KDV { get; set; }

        public bool? IS_KDV { get; set; }

        public int? ROUNDING { get; set; }

        [StringLength(50)]
        public string MONEY { get; set; }

        public int? UNIT_ID { get; set; }

        public DateTime? START_DATE { get; set; }

        public DateTime? RECORD_DATE { get; set; }

        [StringLength(50)]
        public string RECORD_IP { get; set; }

        public int? RECORD_EMP { get; set; }
    }
}
