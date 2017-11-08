namespace WorkPosDb.EntityFrameWork
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SETUP_COUNTRY
    {
        [Key]
        public int COUNTRY_ID { get; set; }

        [StringLength(50)]
        public string COUNTRY_NAME { get; set; }

        public bool? IS_DEFAULT { get; set; }

        public DateTime? RECORD_DATE { get; set; }

        public int? RECORD_EMP { get; set; }

        [StringLength(50)]
        public string RECORD_IP { get; set; }

        public DateTime? UPDATE_DATE { get; set; }

        public int? UPDATE_EMP { get; set; }

        [StringLength(50)]
        public string UPDATE_IP { get; set; }

        [StringLength(43)]
        public string COUNTRY_PHONE_CODE { get; set; }

        [StringLength(43)]
        public string COUNTRY_CODE { get; set; }
    }
}
