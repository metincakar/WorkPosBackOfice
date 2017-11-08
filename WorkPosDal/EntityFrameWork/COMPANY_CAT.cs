namespace WorkPosDal.EntityFrameWork
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class COMPANY_CAT
    {
        [Key]
        public int COMPANYCAT_ID { get; set; }

        [StringLength(43)]
        public string COMPANYCAT { get; set; }

        [StringLength(100)]
        public string DETAIL { get; set; }

        public bool? IS_ACTIVE { get; set; }

        public bool? COMPANYCAT_TYPE { get; set; }

        public bool? IS_VIEW { get; set; }

        public int? RECORD_EMP { get; set; }

        public DateTime? RECORD_DATE { get; set; }

        [StringLength(50)]
        public string RECORD_IP { get; set; }

        public DateTime? UPDATE_DATE { get; set; }

        public int? UPDATE_EMP { get; set; }

        [StringLength(50)]
        public string UPDATE_IP { get; set; }
    }
}
