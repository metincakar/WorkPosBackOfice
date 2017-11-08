using System.ComponentModel;

namespace WorkPosDal.EntityFrameWork
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SETUP_UNIT
    {
        [Key]

        [DisplayName("Birim Id")]
        public int UNIT_ID { get; set; }

        [StringLength(43)]
        [DisplayName("Birim")]
        public string UNIT { get; set; }

        [Browsable(false)]
        public DateTime? RECORD_DATE { get; set; }

              [Browsable(false)]
        public int? RECORD_EMP { get; set; }

              [Browsable(false)]
        [StringLength(50)]
        public string RECORD_IP { get; set; }

              [Browsable(false)]
        public DateTime? UPDATE_DATE { get; set; }

              [Browsable(false)]
        public int? UPDATE_EMP { get; set; }

              [Browsable(false)]
        [StringLength(50)]
        public string UPDATE_IP { get; set; }

              [Browsable(false)]
        [StringLength(50)]
        public string UNIT_CODE { get; set; }

              [Browsable(false)]
        [StringLength(50)]
        public string UNECE_NAME { get; set; }
    }
}