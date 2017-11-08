namespace WorkPosDb.EntityFrameWork
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CONSUMER")]
    public partial class CONSUMER
    {
        public bool CONSUMER_STATUS { get; set; }

        public int CONSUMER_CAT_ID { get; set; }

        [Key]
        public int CONSUMER_ID { get; set; }

        [StringLength(50)]
        public string MEMBER_CODE { get; set; }

        [StringLength(50)]
        public string CONSUMER_USERNAME { get; set; }

        [StringLength(60)]
        public string CONSUMER_PASSWORD { get; set; }

        public int? LEVEL_ID { get; set; }

        public int? DESIGN_ID { get; set; }

        [StringLength(43)]
        public string LANGUAGE_ID { get; set; }

        public int? TIMEOUT_LIMIT { get; set; }

        [StringLength(100)]
        public string CONSUMER_NAME { get; set; }

        [StringLength(100)]
        public string CONSUMER_SURNAME { get; set; }

        [StringLength(100)]
        public string CONSUMER_EMAIL { get; set; }

        public int? IMCAT_ID { get; set; }

        [StringLength(43)]
        public string IM { get; set; }

        [StringLength(43)]
        public string CONSUMER_WORKTELCODE { get; set; }

        [StringLength(43)]
        public string CONSUMER_WORKTEL { get; set; }

        [StringLength(43)]
        public string CONSUMER_TEL_EXT { get; set; }

        [StringLength(43)]
        public string MOBIL_CODE { get; set; }

        [StringLength(43)]
        public string MOBILTEL { get; set; }

        [StringLength(43)]
        public string MOBIL_CODE_2 { get; set; }

        [StringLength(50)]
        public string MOBILTEL_2 { get; set; }

        [StringLength(43)]
        public string CONSUMER_FAXCODE { get; set; }

        [StringLength(43)]
        public string CONSUMER_FAX { get; set; }

        [StringLength(43)]
        public string CONSUMER_HOMETELCODE { get; set; }

        [StringLength(43)]
        public string CONSUMER_HOMETEL { get; set; }

        public DateTime? BIRTHDATE { get; set; }

        [StringLength(43)]
        public string BIRTHPLACE { get; set; }

        [StringLength(100)]
        public string COMPANY { get; set; }

        public int? SECTOR_CAT_ID { get; set; }

        public int? COMPANY_SIZE_CAT_ID { get; set; }

        public int? CONSUMER_STAGE { get; set; }

        [StringLength(40)]
        public string EDUCATION { get; set; }

        public int? EDUCATION_ID { get; set; }

        public bool? SEX { get; set; }

        [StringLength(100)]
        public string PICTURE { get; set; }

        public int? PICTURE_SERVER_ID { get; set; }

        [StringLength(40)]
        public string IDENTYCARD_CAT { get; set; }

        [StringLength(40)]
        public string IDENTYCARD_NO { get; set; }

        public bool? MARRIED { get; set; }

        [StringLength(43)]
        public string CHILD { get; set; }

        [StringLength(750)]
        public string HOMEADDRESS { get; set; }

        [StringLength(43)]
        public string HOMEPOSTCODE { get; set; }

        [StringLength(43)]
        public string HOMESEMT { get; set; }

        public int? HOME_COUNTY_ID { get; set; }

        public int? HOME_CITY_ID { get; set; }

        public int? HOME_COUNTRY_ID { get; set; }

        [StringLength(250)]
        public string HOME_DISTRICT { get; set; }

        public int? HOME_DISTRICT_ID { get; set; }

        [StringLength(250)]
        public string HOME_MAIN_STREET { get; set; }

        [StringLength(250)]
        public string HOME_STREET { get; set; }

        [StringLength(250)]
        public string HOME_DOOR_NO { get; set; }

        [StringLength(750)]
        public string WORKADDRESS { get; set; }

        [StringLength(43)]
        public string WORKPOSTCODE { get; set; }

        [StringLength(43)]
        public string WORKSEMT { get; set; }

        public int? WORK_COUNTY_ID { get; set; }

        public int? WORK_CITY_ID { get; set; }

        public int? WORK_COUNTRY_ID { get; set; }

        [StringLength(250)]
        public string WORK_DISTRICT { get; set; }

        public int? WORK_DISTRICT_ID { get; set; }

        [StringLength(250)]
        public string WORK_MAIN_STREET { get; set; }

        [StringLength(250)]
        public string WORK_STREET { get; set; }

        [StringLength(250)]
        public string WORK_DOOR_NO { get; set; }

        [StringLength(250)]
        public string TAX_OFFICE { get; set; }

        [StringLength(250)]
        public string TAX_NO { get; set; }

        [StringLength(750)]
        public string TAX_ADRESS { get; set; }

        [StringLength(43)]
        public string TAX_POSTCODE { get; set; }

        [StringLength(43)]
        public string TAX_SEMT { get; set; }

        public int? TAX_COUNTY_ID { get; set; }

        public int? TAX_CITY_ID { get; set; }

        public int? TAX_COUNTRY_ID { get; set; }

        [StringLength(250)]
        public string TAX_DISTRICT { get; set; }

        public int? TAX_DISTRICT_ID { get; set; }

        [StringLength(250)]
        public string TAX_MAIN_STREET { get; set; }

        [StringLength(250)]
        public string TAX_STREET { get; set; }

        [StringLength(250)]
        public string TAX_DOOR_NO { get; set; }

        [StringLength(50)]
        public string HOMEPAGE { get; set; }

        public int? MEMBER_TYPE { get; set; }

        public bool? ISPOTANTIAL { get; set; }

        public bool? IS_CARI { get; set; }

        [Column("_CONSUMER_CARD_NO")]
        [StringLength(50)]
        public string C_CONSUMER_CARD_NO { get; set; }

        public int? SALES_COUNTY { get; set; }

        public int? REF_POS_CODE { get; set; }

        public int? HIERARCHY_ID { get; set; }

        public int? PERIOD_ID { get; set; }

        [StringLength(50)]
        public string TITLE { get; set; }

        public int? MISSION { get; set; }

        public int? DEPARTMENT { get; set; }

        [StringLength(50)]
        public string OZEL_KOD { get; set; }

        [StringLength(50)]
        public string TC_IDENTY_NO { get; set; }

        public int? SOCIAL_SOCIETY_ID { get; set; }

        [StringLength(50)]
        public string SOCIAL_SECURITY_NO { get; set; }

        [StringLength(50)]
        public string FATHER { get; set; }

        [StringLength(50)]
        public string MOTHER { get; set; }

        public int? ILGI { get; set; }

        [StringLength(100)]
        public string ILGINO { get; set; }

        public int? YAS { get; set; }

        [StringLength(100)]
        public string ARSIV_NO1 { get; set; }

        [StringLength(100)]
        public string ARSIV_NO2 { get; set; }

        public bool WANT_EMAIL { get; set; }

        public bool? MEMBER_RULES { get; set; }

        public int? IMS_CODE_ID { get; set; }

        public int? MAIL_ID { get; set; }

        public int? INCOME_LEVEL_ID { get; set; }

        public int? VOCATION_TYPE_ID { get; set; }

        public int? NATIONALITY { get; set; }

        public int? RESOURCE_ID { get; set; }

        public int? CUSTOMER_VALUE_ID { get; set; }

        public DateTime? START_DATE { get; set; }

        public bool? IS_RELATED_CONSUMER { get; set; }

        public int? BLOOD_TYPE { get; set; }

        public bool? IS_MYCUBE_MEMBER { get; set; }

        [StringLength(500)]
        public string CONSUMER_REFERENCE_CODE { get; set; }

        public DateTime? RECORD_DATE { get; set; }

        public int? RECORD_MEMBER { get; set; }

        public int? RECORD_PAR { get; set; }

        public int? RECORD_CONS { get; set; }

        [StringLength(50)]
        public string RECORD_IP { get; set; }

        public int? UPDATE_CONS { get; set; }

        public DateTime? UPDATE_DATE { get; set; }

        public int? UPDATE_EMP { get; set; }

        [StringLength(50)]
        public string UPDATE_IP { get; set; }

        public bool? ADD_FLAG { get; set; }

        public DateTime? TERMINATE_DATE { get; set; }

        public DateTime? REF_CHANGE_DATE { get; set; }

        public int? REF_CHANGE_CAMP_ID { get; set; }

        public bool? IS_TAXPAYER { get; set; }

        public int? PROPOSER_CONS_ID { get; set; }

        public int? TAX_ADDRESS_TYPE { get; set; }

        public DateTime? MARRIED_DATE { get; set; }

        public DateTime? LAST_PASSWORD_CHANGE { get; set; }

        public int? MEMBER_ADD_OPTION_ID { get; set; }

        [StringLength(43)]
        public string WRK_ID { get; set; }

        public DateTime? TRANSFER_DATE { get; set; }

        public int? TRANSFER_IMS_CODE_ID { get; set; }

        public int? CAMPAIGN_ID { get; set; }

        public bool? IS_DELETE { get; set; }

        [StringLength(50)]
        public string COORDINATE_1 { get; set; }

        [StringLength(50)]
        public string COORDINATE_2 { get; set; }

        public bool? WANT_SMS { get; set; }

        public DateTime? CONTRACT_DATE { get; set; }

        public int? CONTRACT_CONS_ID { get; set; }

        public int? CONTRACT_EMP_ID { get; set; }

        public DateTime? CONTRACT_DATE2 { get; set; }

        public int? CONTRACT_CONS_ID2 { get; set; }

        public int? CONTRACT_CONS_EMP2 { get; set; }

        public DateTime? EFATURA_DATE { get; set; }

        public bool? USE_EFATURA { get; set; }

        [StringLength(50)]
        public string PROFILE_ID { get; set; }
    }
}
