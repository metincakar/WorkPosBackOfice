namespace WorkPosDal.EntityFrameWork
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class COMPANY_PARTNER
    {
        [Key]
        public int PARTNER_ID { get; set; }

        public bool? COMPANY_PARTNER_STATUS { get; set; }

        [Column("_COMPANYCAT_ID")]
        public int? C_COMPANYCAT_ID { get; set; }

        public int? COMPANY_ID { get; set; }

        [StringLength(50)]
        public string COMPANY_PARTNER_USERNAME { get; set; }

        [StringLength(50)]
        public string COMPANY_PARTNER_PASSWORD { get; set; }

        [Column("_GROUP_ID")]
        public int? C_GROUP_ID { get; set; }

        [Column("_LEVEL_ID")]
        [StringLength(200)]
        public string C_LEVEL_ID { get; set; }

        public int? TIME_ZONE { get; set; }

        [StringLength(50)]
        public string MEMBER_CODE { get; set; }

        public bool? IS_AGENDA_OPEN { get; set; }

        [StringLength(43)]
        public string LANGUAGE_ID { get; set; }

        public int? DESIGN_ID { get; set; }

        public int? COMPBRANCH_ID { get; set; }

        [StringLength(50)]
        public string COMPANY_PARTNER_NAME { get; set; }

        [StringLength(50)]
        public string COMPANY_PARTNER_SURNAME { get; set; }

        [StringLength(100)]
        public string COMPANY_PARTNER_EMAIL { get; set; }

        public int? IMCAT_ID { get; set; }

        [StringLength(50)]
        public string IM { get; set; }

        [StringLength(43)]
        public string MOBIL_CODE { get; set; }

        [StringLength(43)]
        public string MOBILTEL { get; set; }

        [StringLength(43)]
        public string COMPANY_PARTNER_TELCODE { get; set; }

        [StringLength(43)]
        public string COMPANY_PARTNER_TEL { get; set; }

        [StringLength(43)]
        public string COMPANY_PARTNER_TEL_EXT { get; set; }

        [StringLength(43)]
        public string COMPANY_PARTNER_FAX { get; set; }

        [StringLength(200)]
        public string COMPANY_PARTNER_ADDRESS { get; set; }

        [StringLength(43)]
        public string COMPANY_PARTNER_POSTCODE { get; set; }

        [StringLength(50)]
        public string HOMEPAGE { get; set; }

        [StringLength(50)]
        public string PHOTO { get; set; }

        public int? MEMBER_TYPE { get; set; }

        public int? SEX { get; set; }

        [Column("_PARTNER_CARD_NO")]
        [StringLength(20)]
        public string C_PARTNER_CARD_NO { get; set; }

        [StringLength(50)]
        public string TITLE { get; set; }

        public int? MISSION { get; set; }

        public int? DEPARTMENT { get; set; }

        public bool? WANT_EMAIL { get; set; }

        public int? ASSISTANCE_STATUS { get; set; }

        public int? DEPOT_RELATION { get; set; }

        public int? GRADUATE_YEAR { get; set; }

        public int? IS_SMS { get; set; }

        public int? IS_UNIVERSITY { get; set; }

        [StringLength(50)]
        public string MAIL { get; set; }

        [StringLength(50)]
        public string NUMBER_OF_CHILD { get; set; }

        public int? PURCHASE_AUTHORITY { get; set; }

        public int? COUNTY { get; set; }

        public int? CITY { get; set; }

        public int? COUNTRY { get; set; }

        [StringLength(50)]
        public string SEMT { get; set; }

        public bool? IS_HAMSIS { get; set; }

        public DateTime? RECORD_DATE { get; set; }

        public int? RECORD_PAR { get; set; }

        public int? RECORD_MEMBER { get; set; }

        [StringLength(50)]
        public string RECORD_IP { get; set; }

        public int? UPDATE_PAR { get; set; }

        [StringLength(50)]
        public string UPDATE_IP { get; set; }

        public DateTime? UPDATE_DATE { get; set; }

        public int? UPDATE_MEMBER { get; set; }

        public int? UPDATE_MEMBER_TYPE { get; set; }

        public int? CP_STATUS_ID { get; set; }

        public int? PHOTO_SERVER_ID { get; set; }

        [StringLength(43)]
        public string TC_IDENTITY { get; set; }

        public DateTime? LAST_PASSWORD_CHANGE { get; set; }

        public bool? IS_SEND_FINANCE_MAIL { get; set; }

        public DateTime? START_DATE { get; set; }

        public DateTime? FINISH_DATE { get; set; }

        public int? HIERARCHY_PARTNER_ID { get; set; }

        public int? IMCAT2_ID { get; set; }

        [StringLength(50)]
        public string IM2 { get; set; }

        public int? RELATED_CONSUMER_ID { get; set; }

        [StringLength(40)]
        public string WEB_USER_KEY { get; set; }

        public DateTime? BIRTHDATE { get; set; }

        public bool? WANT_SMS { get; set; }

        [StringLength(50)]
        public string PDKS_NUMBER { get; set; }

        public int? PDKS_TYPE_ID { get; set; }

        public int? DISTRICT_ID { get; set; }
    }
}
