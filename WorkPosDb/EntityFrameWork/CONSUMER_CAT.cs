namespace WorkPosDb.EntityFrameWork
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CONSUMER_CAT
    {
        [Key]
        public int CONSCAT_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string CONSCAT { get; set; }

        public int? POSITION_CODE { get; set; }

        public bool? IS_INTERNET { get; set; }

        public bool? IS_PREMIUM { get; set; }

        public int? HIERARCHY { get; set; }

        public int? MIN_CONSCAT_ID { get; set; }

        public bool? IS_DEFAULT { get; set; }

        public bool? IS_REF_ORDER { get; set; }

        public bool? IS_INTERNET_DENIED { get; set; }

        public int? RECORD_EMP { get; set; }

        public DateTime? RECORD_DATE { get; set; }

        [StringLength(50)]
        public string RECORD_IP { get; set; }

        public int? UPDATE_EMP { get; set; }

        public DateTime? UPDATE_DATE { get; set; }

        [StringLength(50)]
        public string UPDATE_IP { get; set; }

        public double? RISK_LIMIT { get; set; }

        public bool? IS_ACTIVE { get; set; }

        [StringLength(43)]
        public string SHORT_NAME { get; set; }

        public bool? IS_REF_RECORD { get; set; }

        public int? MAX_CONSCAT_ID { get; set; }
    }
}
