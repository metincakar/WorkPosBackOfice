namespace WorkPosDb.EntityFrameWork
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class COMPANY_ACCOUNTS
    {
        [Key]
        public int MAIL_ID { get; set; }

        public int? EMPLOYEE_ID { get; set; }

        [StringLength(50)]
        public string EMAIL { get; set; }

        [StringLength(50)]
        public string ACCOUNT { get; set; }

        [StringLength(50)]
        public string PASSWORD { get; set; }

        [StringLength(50)]
        public string POP { get; set; }

        [StringLength(50)]
        public string SMTP { get; set; }

        public bool? IN_SETTINGS { get; set; }
    }
}
