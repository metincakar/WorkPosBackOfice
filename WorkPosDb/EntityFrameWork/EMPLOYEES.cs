namespace WorkPosDb.EntityFrameWork
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EMPLOYEES
    {
        public bool EMPLOYEE_STATUS { get; set; }

        [Key]
        public int EMPLOYEE_ID { get; set; }

        public int? EMPAPP_ID { get; set; }

        [StringLength(50)]
        public string MEMBER_CODE { get; set; }

        [StringLength(50)]
        public string EMPLOYEE_USERNAME { get; set; }

        [StringLength(50)]
        public string EMPLOYEE_PASSWORD { get; set; }

        [StringLength(50)]
        public string EMPLOYEE_NO { get; set; }

        [Required]
        [StringLength(50)]
        public string EMPLOYEE_NAME { get; set; }

        [StringLength(50)]
        public string EMPLOYEE_SURNAME { get; set; }

        [StringLength(50)]
        public string TASK { get; set; }

        [StringLength(50)]
        public string EMPLOYEE_EMAIL { get; set; }

        public int? IMCAT_ID { get; set; }

        [StringLength(50)]
        public string IM { get; set; }

        [StringLength(43)]
        public string DIRECT_TELCODE { get; set; }

        [StringLength(43)]
        public string DIRECT_TEL { get; set; }

        [StringLength(43)]
        public string EXTENSION { get; set; }

        [StringLength(43)]
        public string MOBILCODE { get; set; }

        [StringLength(43)]
        public string MOBILTEL { get; set; }

        [StringLength(43)]
        public string CORBUS_TEL { get; set; }

        [StringLength(500)]
        public string PHOTO { get; set; }

        public bool? IS_AGENDA_OPEN { get; set; }

        public int? PERIOD_ID { get; set; }

        public int? COMPANY_ID { get; set; }

        public bool? IS_IP_CONTROL { get; set; }

        [StringLength(50)]
        public string IP_ADDRESS { get; set; }

        [StringLength(50)]
        public string COMPUTER_NAME { get; set; }

        public DateTime? GROUP_STARTDATE { get; set; }

        [StringLength(200)]
        public string DYNAMIC_HIERARCHY { get; set; }

        [StringLength(50)]
        public string DYNAMIC_HIERARCHY_ADD { get; set; }

        [StringLength(50)]
        public string HIERARCHY { get; set; }

        [StringLength(50)]
        public string OZEL_KOD { get; set; }

        public DateTime? RECORD_DATE { get; set; }

        public int? RECORD_EMP { get; set; }

        [StringLength(50)]
        public string RECORD_IP { get; set; }

        public DateTime? UPDATE_DATE { get; set; }

        public int? UPDATE_EMP { get; set; }

        [StringLength(50)]
        public string UPDATE_IP { get; set; }

        [StringLength(50)]
        public string OZEL_KOD2 { get; set; }

        public DateTime? KIDEM_DATE { get; set; }

        public DateTime? IZIN_DATE { get; set; }

        public int? IN_COMPANY_REASON_ID { get; set; }

        public bool? IS_CRITICAL { get; set; }

        public int? PHOTO_SERVER_ID { get; set; }

        public DateTime? EXPIRY_DATE { get; set; }

        public int? EMPLOYEE_STAGE { get; set; }

        [StringLength(1000)]
        public string BIOGRAPHY { get; set; }

        [Column(TypeName = "ntext")]
        public string WET_SIGNATURE { get; set; }

        public int? IMCAT2_ID { get; set; }

        [StringLength(50)]
        public string IM2 { get; set; }

        public int? PER_ASSIGN_ID { get; set; }

        public bool? IS_ACC_INFO { get; set; }

        public double? IZIN_DAYS { get; set; }
    }
}
