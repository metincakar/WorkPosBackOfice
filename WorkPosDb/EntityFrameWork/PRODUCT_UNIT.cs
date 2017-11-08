namespace WorkPosDb.EntityFrameWork
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PRODUCT_UNIT
    {
        [Key]
        public int PRODUCT_UNIT_ID { get; set; }

        public bool PRODUCT_UNIT_STATUS { get; set; }

        public int PRODUCT_ID { get; set; }

        public int? MAIN_UNIT_ID { get; set; }

        [StringLength(50)]
        public string MAIN_UNIT { get; set; }

        public int? UNIT_ID { get; set; }

        [StringLength(50)]
        public string ADD_UNIT { get; set; }

        public double? MULTIPLIER { get; set; }

        [StringLength(50)]
        public string DIMENTION { get; set; }

        public double? DESI_VALUE { get; set; }

        public double? WEIGHT { get; set; }

        public bool? IS_MAIN { get; set; }

        public bool? IS_SHIP_UNIT { get; set; }

        public double? UNIT_MULTIPLIER { get; set; }

        public int? UNIT_MULTIPLIER_STATIC { get; set; }

        public double? VOLUME { get; set; }

        public DateTime? RECORD_DATE { get; set; }

        public int? RECORD_EMP { get; set; }

        public DateTime? UPDATE_DATE { get; set; }

        public int? UPDATE_EMP { get; set; }

        public bool? IS_ADD_UNIT { get; set; }
    }
}
