namespace WorkPosDal.EntityFrameWork
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class STOCKS_PROPERTY
    {
        public int? STOCK_ID { get; set; }

        public int? PROPERTY_ID { get; set; }

        public int? PROPERTY_DETAIL_ID { get; set; }

        [StringLength(300)]
        public string PROPERTY_DETAIL { get; set; }

        public double? TOTAL_MIN { get; set; }

        public double? TOTAL_MAX { get; set; }

        public int? OLD_PROPERTY_ID { get; set; }

        [Key]
        public int STOCK_PROPERTY_ID { get; set; }
    }
}
