namespace WorkPosDb.EntityFrameWork
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("COMPANY")]
    public partial class COMPANY
    {
        public bool COMPANY_STATUS { get; set; }

        public int COMPANYCAT_ID { get; set; }

        [Key]
        public int COMPANY_ID { get; set; }

        public int? OUR_COMPANY_ID { get; set; }

        [StringLength(50)]
        public string MEMBER_CODE { get; set; }

        public int? PARTNER_ID { get; set; }

        public int? DISCOUNT { get; set; }

        public int? POS_CODE { get; set; }

        public int? MANAGER_PARTNER_ID { get; set; }

        [StringLength(150)]
        public string NICKNAME { get; set; }

        [Required]
        [StringLength(250)]
        public string FULLNAME { get; set; }

        public int? SECTOR_CAT_ID { get; set; }

        public int? COMPANY_SIZE_CAT_ID { get; set; }

        public int? COMPANY_VALUE_ID { get; set; }

        [StringLength(50)]
        public string TAXOFFICE { get; set; }

        [StringLength(43)]
        public string TAXNO { get; set; }

        [StringLength(100)]
        public string COMPANY_EMAIL { get; set; }

        [StringLength(50)]
        public string HOMEPAGE { get; set; }

        [StringLength(43)]
        public string COMPANY_TELCODE { get; set; }

        [StringLength(43)]
        public string COMPANY_TEL1 { get; set; }

        [StringLength(43)]
        public string COMPANY_TEL2 { get; set; }

        [StringLength(43)]
        public string COMPANY_TEL3 { get; set; }

        [StringLength(43)]
        public string COMPANY_FAX { get; set; }

        [StringLength(43)]
        public string MOBIL_CODE { get; set; }

        [StringLength(43)]
        public string MOBILTEL { get; set; }

        [StringLength(43)]
        public string COMPANY_POSTCODE { get; set; }

        [StringLength(200)]
        public string COMPANY_ADDRESS { get; set; }

        [StringLength(50)]
        public string DUKKAN_NO { get; set; }

        [StringLength(50)]
        public string MAIN_STREET { get; set; }

        [StringLength(50)]
        public string STREET { get; set; }

        [StringLength(50)]
        public string SEMT { get; set; }

        public int? COUNTY { get; set; }

        public int? CITY { get; set; }

        public int? COUNTRY { get; set; }

        public int? RESOURCE_ID { get; set; }

        public bool? ISPOTANTIAL { get; set; }

        public int? HIERARCHY_ID { get; set; }

        public int? SALES_COUNTY { get; set; }

        public bool? IS_BUYER { get; set; }

        public bool? IS_SELLER { get; set; }

        public int? PERIOD_ID { get; set; }

        public double? COMPANY_RATE { get; set; }

        public double? RISK_LIMIT { get; set; }

        public DateTime? START_DATE { get; set; }

        public DateTime? ORG_START_DATE { get; set; }

        [StringLength(75)]
        public string OZEL_KOD { get; set; }

        [StringLength(75)]
        public string OZEL_KOD_1 { get; set; }

        [StringLength(75)]
        public string OZEL_KOD_2 { get; set; }

        public int? IMS_CODE_ID { get; set; }

        public int? COMPANY_STATE { get; set; }

        [StringLength(43)]
        public string COMPANY_FAX_CODE { get; set; }

        public DateTime? CON_CLOSE_DATE { get; set; }

        public DateTime? CON_OPEN_DATE { get; set; }

        public int? OLD_COMPANY_ID { get; set; }

        [StringLength(50)]
        public string DISTRICT { get; set; }

        public int? DUTY_PERIOD { get; set; }

        [StringLength(50)]
        public string EMAIL { get; set; }

        [StringLength(43)]
        public string ENDORSE_CURRENCY { get; set; }

        public double? ENDORSE_PAYMENT { get; set; }

        public int? ENDORSE_PERIOD { get; set; }

        public int? STOCK_AMOUNT { get; set; }

        public int? RECORD_PAR { get; set; }

        public DateTime? RECORD_DATE { get; set; }

        public int? RECORD_EMP { get; set; }

        [StringLength(50)]
        public string RECORD_IP { get; set; }

        public int? UPDATE_PAR { get; set; }

        public DateTime? UPDATE_DATE { get; set; }

        public int? UPDATE_EMP { get; set; }

        [StringLength(50)]
        public string UPDATE_IP { get; set; }

        [StringLength(50)]
        public string REF_NO { get; set; }

        [StringLength(43)]
        public string MONEY_CURRENCY { get; set; }

        public double? GRUP_RISK_LIMIT { get; set; }

        [StringLength(43)]
        public string GUESS_ENDORSEMENT_MONEY { get; set; }

        public double? GUESS_ENDORSEMENT { get; set; }

        public bool IS_RELATED_COMPANY { get; set; }

        public int? COMPANY_WORK_TYPE { get; set; }

        [StringLength(150)]
        public string ASSET_FILE_NAME1 { get; set; }

        public int? ASSET_FILE_NAME1_SERVER_ID { get; set; }

        [StringLength(150)]
        public string ASSET_FILE_NAME2 { get; set; }

        public int? ASSET_FILE_NAME2_SERVER_ID { get; set; }

        public bool? EKSTRE { get; set; }

        public int? MEMBER_ADD_OPTION_ID { get; set; }

        [StringLength(43)]
        public string WRK_ID { get; set; }

        [StringLength(43)]
        public string GLNCODE { get; set; }

        [StringLength(50)]
        public string COORDINATE_1 { get; set; }

        [StringLength(50)]
        public string COORDINATE_2 { get; set; }

        public int? DISTRICT_ID { get; set; }

        public int? CAMPAIGN_ID { get; set; }

        [Column("_MULTIPLE_SECTOR_CAT_ID")]
        [StringLength(250)]
        public string C_MULTIPLE_SECTOR_CAT_ID { get; set; }

        [StringLength(250)]
        public string FIRM_TYPE { get; set; }

        public int? DOMESTIC_VALUE_ID { get; set; }

        public int? EXPORT_VALUE_ID { get; set; }

        [StringLength(1500)]
        public string COMPANY_DETAIL { get; set; }

        public int? SORT { get; set; }

        public bool? IS_HOMEPAGE { get; set; }

        [StringLength(1500)]
        public string COMPANY_DETAIL_ENG { get; set; }

        [StringLength(1500)]
        public string COMPANY_DETAIL_SPA { get; set; }

        public bool? IS_EXPORT { get; set; }

        public int? VISIT_CAT_ID { get; set; }

        public bool? USE_EFATURA { get; set; }

        public DateTime? EFATURA_DATE { get; set; }

        public bool IS_PERSON { get; set; }

        [StringLength(50)]
        public string PROFILE_ID { get; set; }
    }
}
