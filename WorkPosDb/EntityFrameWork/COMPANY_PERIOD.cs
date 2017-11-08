namespace WorkPosDb.EntityFrameWork
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class COMPANY_PERIOD
    {
        public int ID { get; set; }

        public int? COMPANY_ID { get; set; }

        public int? PERIOD_ID { get; set; }

        [StringLength(100)]
        public string ACCOUNT_CODE { get; set; }

        public DateTime? PERIOD_DATE { get; set; }

        [StringLength(100)]
        public string KONSINYE_CODE { get; set; }

        [StringLength(100)]
        public string ADVANCE_PAYMENT_CODE { get; set; }
    }
}
