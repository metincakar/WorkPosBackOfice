namespace WorkPosDb.EntityFrameWork
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EMPLOYEE_POSITIONS
    {
        [Key]
        public int POSITION_ID { get; set; }

        public int? POSITION_CAT_ID { get; set; }

        public int? T_ID { get; set; }

        public int? UPPER_POSITION_CODE { get; set; }

        public int? UPPER_POSITION_CODE2 { get; set; }

        public bool? IS_MASTER { get; set; }

        public int POSITION_CODE { get; set; }

        public int? EMPLOYEE_ID { get; set; }

        [StringLength(50)]
        public string EMPLOYEE_NAME { get; set; }

        [StringLength(50)]
        public string EMPLOYEE_SURNAME { get; set; }

        [StringLength(50)]
        public string EMPLOYEE_EMAIL { get; set; }

        [StringLength(100)]
        public string POSITION_NAME { get; set; }

        public bool? POSITION_STATUS { get; set; }

        [StringLength(100)]
        public string DETAIL { get; set; }

        public int? DEPARTMENT_ID { get; set; }

        [Column("_LOGIN_DEPO_ID")]
        public int? C_LOGIN_DEPO_ID { get; set; }

        [Column("_LOGIN_LOCATION_ID")]
        public int? C_LOGIN_LOCATION_ID { get; set; }

        [StringLength(500)]
        public string LEVEL_ID { get; set; }

        public int? USER_GROUP_ID { get; set; }

        public int? VALID { get; set; }

        public int? VALID_MEMBER { get; set; }

        public int? VALIDATOR_MEMBER { get; set; }

        public DateTime? VALID_DATE { get; set; }

        public double? ONGR_UCRET { get; set; }

        public int? MONEY_ID { get; set; }

        [StringLength(50)]
        public string ACIKLAMA1 { get; set; }

        [StringLength(50)]
        public string ACIKLAMA2 { get; set; }

        [StringLength(50)]
        public string ACIKLAMA3 { get; set; }

        [StringLength(50)]
        public string ACIKLAMA4 { get; set; }

        [StringLength(50)]
        public string ACIKLAMA5 { get; set; }

        public double? RAKAM1 { get; set; }

        public double? RAKAM2 { get; set; }

        public double? RAKAM3 { get; set; }

        public double? RAKAM4 { get; set; }

        public double? RAKAM5 { get; set; }

        public double? ON_MALIYET { get; set; }

        public double? ON_HOUR { get; set; }

        [StringLength(150)]
        public string POS_ENT_DETAIL { get; set; }

        public bool? ANNOUNCE_COM { get; set; }

        public bool? ANNOUNCE_PUBLIC { get; set; }

        public bool? EHESAP { get; set; }

        public bool? IS_VEKALETEN { get; set; }

        public DateTime? VEKALETEN_DATE { get; set; }

        public int? PERIOD_ID { get; set; }

        public int? TITLE_ID { get; set; }

        [StringLength(200)]
        public string HIERARCHY { get; set; }

        [Column("___AUTHORITY_CODE")]
        [StringLength(50)]
        public string C___AUTHORITY_CODE { get; set; }

        public int? UPDATE_EMP { get; set; }

        [StringLength(50)]
        public string UPDATE_IP { get; set; }

        public DateTime? UPDATE_DATE { get; set; }

        public bool? ADMIN_STATUS { get; set; }

        [StringLength(50)]
        public string OZEL_KOD { get; set; }

        public bool? IS_CRITICAL { get; set; }

        public int? ORGANIZATION_STEP_ID { get; set; }

        public double? ON_MALIYET_YIL { get; set; }

        public bool? IS_ORG_VIEW { get; set; }

        public int? COLLAR_TYPE { get; set; }

        public int? FUNC_ID { get; set; }

        public int? BRANCH_ID { get; set; }

        public int? OUR_COMPANY_ID { get; set; }

        public int? IN_COMPANY_REASON_ID { get; set; }

        public bool? POWER_USER { get; set; }

        [StringLength(500)]
        public string POWER_USER_LEVEL_ID { get; set; }

        public bool? DISCOUNT_VALID { get; set; }

        public bool? PRICE_DISPLAY_VALID { get; set; }

        public bool? COST_DISPLAY_VALID { get; set; }

        [StringLength(200)]
        public string DYNAMIC_HIERARCHY { get; set; }

        [StringLength(50)]
        public string DYNAMIC_HIERARCHY_ADD { get; set; }

        public bool? CONSUMER_PRIORITY { get; set; }

        public bool? PRICE_VALID { get; set; }

        public int? POSITION_STAGE { get; set; }

        public bool? MEMBER_VIEW_CONTROL { get; set; }

        public bool? MEMBER_DIRECT_DENIED { get; set; }

        public double? ON_HOUR_DAILY { get; set; }

        public bool? DUEDATE_VALID { get; set; }

        public bool? IS_OBSERVATION { get; set; }

        public DateTime? OBSERVATION_DATE { get; set; }

        public bool? IS_TRIAL { get; set; }

        public DateTime? TRIAL_DATE { get; set; }

        [StringLength(500)]
        public string LEVEL_EXTRA_ID { get; set; }

        public bool? RATE_VALID { get; set; }

        public bool? TIME_COST_CONTROL { get; set; }
    }
}
