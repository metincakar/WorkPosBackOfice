namespace WorkPosDb.EntityFrameWork
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OUR_COMPANY_INFO
    {
        public int COMP_ID { get; set; }

        public bool? IS_BARCOD_REQUIRED { get; set; }

        [StringLength(43)]
        public string WORKCUBE_SECTOR { get; set; }

        [StringLength(43)]
        public string LOGO_TYPE { get; set; }

        public bool? IS_ED_PUBLISHED_ON_PP_WW { get; set; }

        public bool? IS_PRODUCT_CONFIGURATOR { get; set; }

        public bool? IS_GUARANTY_FOLLOWUP { get; set; }

        public bool? IS_PROJECT_FOLLOWUP { get; set; }

        public bool? IS_SALES_ZONE_FOLLOWUP { get; set; }

        public bool? IS_SMS { get; set; }

        public bool? IS_UNCONDITIONAL_LIST { get; set; }

        public bool? IS_DETAIL_FILTER_OPEN { get; set; }

        public bool? IS_SUBSCRIPTION_CONTRACT { get; set; }

        [Column("_IS_CAMP_PROMOTION")]
        public bool? C_IS_CAMP_PROMOTION { get; set; }

        public bool? IS_BRAND_TO_CODE { get; set; }

        [StringLength(2000)]
        public string COMP_VIZYON { get; set; }

        [StringLength(50)]
        public string EMAIL { get; set; }

        public int? SPECT_TYPE { get; set; }

        public bool? IS_COST { get; set; }

        public int? COST_CALC_TYPE { get; set; }

        public bool? IS_TIME { get; set; }

        public bool? IS_RATE { get; set; }

        public bool? IS_RATE_FROM_PRE_PAPER { get; set; }

        public int? WORK_STOCK_ID { get; set; }

        public bool? IS_SERIAL_CONTROL { get; set; }

        public bool? IS_SHIP_CONTROL { get; set; }

        public bool? IS_PAPER_CLOSER { get; set; }

        [StringLength(43)]
        public string CARGO_CUSTOMER_CODE { get; set; }

        [StringLength(50)]
        public string CARGO_CUSTOMER_PASSWORD { get; set; }

        public bool? IS_CONTENT_FOLLOW { get; set; }

        public bool? IS_ORDER_UPDATE { get; set; }

        public bool? IS_SHIP_UPDATE { get; set; }

        public bool? IS_USE_IFRS { get; set; }

        [StringLength(100)]
        public string PUBLIC_ACCOUNT_CODE { get; set; }

        public int? RATE_ROUND_NUM { get; set; }

        public int? PURCHASE_PRICE_ROUND_NUM { get; set; }

        public int? SALES_PRICE_ROUND_NUM { get; set; }

        public bool? IS_MULTI_ANALYSIS_RESULT { get; set; }

        public bool? IS_MAXROWS_CONTROL_OFF { get; set; }

        public bool? IS_STORE_FOLLOWUP { get; set; }

        public bool? IS_DELETE_BASKET { get; set; }

        public bool? IS_USE_SMS_WEBSERVICE { get; set; }

        [StringLength(50)]
        public string SMS_CUSTOMERNO { get; set; }

        [StringLength(50)]
        public string SMS_USERNAME { get; set; }

        [StringLength(50)]
        public string SMS_PASSWORD { get; set; }

        public int? SMS_SERVICECODE { get; set; }

        [StringLength(50)]
        public string SMS_ALPHANUMERIC { get; set; }

        public int? RECORD_EMP { get; set; }

        public DateTime? RECORD_DATE { get; set; }

        [StringLength(50)]
        public string RECORD_IP { get; set; }

        public int? UPDATE_EMP { get; set; }

        public DateTime? UPDATE_DATE { get; set; }

        [StringLength(50)]
        public string UPDATE_IP { get; set; }

        public int? IS_TIME_STYLE { get; set; }

        public bool? IS_ASSET_FOLLOWUP { get; set; }

        public bool? IS_ACCOUNT_CARD_UPDATE { get; set; }

        public bool? IS_DETAILED_RISK_INFO { get; set; }

        public bool? IS_SELECT_RISK_MONEY { get; set; }

        public bool? IS_LOCATION_FOLLOW { get; set; }

        public bool? IS_PROD_COST_TYPE { get; set; }

        public bool? IS_REMAINING_AMOUNT { get; set; }

        public bool? IS_STOCK_BASED_COST { get; set; }

        public bool? IS_FILE_SIZE { get; set; }

        public int? FILE_SIZE { get; set; }

        public int? SMS_COMPANY { get; set; }

        public bool? IS_PROJECT_GROUP { get; set; }

        [StringLength(100)]
        public string SPECIAL_MENU_FILE { get; set; }

        public DateTime? TIME_CONTROL_DATE { get; set; }

        public bool? IS_ADD_INFORMATIONS { get; set; }

        public bool? IS_EFATURA { get; set; }

        [Key]
        public int OUR_COMPANY_INFO_ID { get; set; }

        public int? EINVOICE_TYPE { get; set; }

        public bool? EINVOICE_TEST_SYSTEM { get; set; }

        [StringLength(50)]
        public string EINVOICE_COMPANY_CODE { get; set; }

        [StringLength(50)]
        public string EINVOICE_USER_NAME { get; set; }

        [StringLength(50)]
        public string EINVOICE_PASSWORD { get; set; }

        [StringLength(50)]
        public string EINVOICE_SENDER_ALIAS { get; set; }

        [StringLength(50)]
        public string EINVOICE_RECEIVER_ALIAS { get; set; }

        public DateTime? EFATURA_DATE { get; set; }

        [StringLength(250)]
        public string EINVOICE_SIGNATURE_URL { get; set; }

        public bool? IS_EDEFTER { get; set; }

        public bool? IS_EARSIV { get; set; }

        public bool? EINVOICE_NUMBER_BRANCH { get; set; }

        public bool? EARSIV_NUMBER_BRANCH { get; set; }

        [StringLength(50)]
        public string EARSIV_USER_NAME { get; set; }

        [StringLength(50)]
        public string EARSIV_PASSWORD { get; set; }
    }
}
