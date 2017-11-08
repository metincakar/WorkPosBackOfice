namespace WorkPosDb.EntityFrameWork
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class COMPANY_CREDIT
    {
        [Key]
        public int COMPANY_CREDIT_ID { get; set; }

        public int? PROCESS_STAGE { get; set; }

        public int? COMPANY_ID { get; set; }

        public int? CONSUMER_ID { get; set; }

        public double? OPEN_ACCOUNT_RISK_LIMIT { get; set; }

        public double? OPEN_ACCOUNT_RISK_LIMIT_OTHER { get; set; }

        public double? FORWARD_SALE_LIMIT { get; set; }

        public double? FORWARD_SALE_LIMIT_OTHER { get; set; }

        public double? TOTAL_RISK_LIMIT { get; set; }

        public double? TOTAL_RISK_LIMIT_OTHER { get; set; }

        [StringLength(50)]
        public string MONEY { get; set; }

        public int? PAYMETHOD_ID { get; set; }

        public int? DUE_DATEX { get; set; }

        public double? FIRST_PAYMENT_INTEREST { get; set; }

        public double? LAST_PAYMENT_INTEREST { get; set; }

        public double? PAYMENT_BLOKAJ { get; set; }

        public int? OUR_COMPANY_ID { get; set; }

        public int? DOCUMENT_TYPE { get; set; }

        public int? OPTION_STATUS { get; set; }

        public int? BRANCH_ID { get; set; }

        public int? SHIP_METHOD_ID { get; set; }

        public int? PRICE_CAT { get; set; }

        public int? REVMETHOD_ID { get; set; }

        public bool? IS_INSTALMENT_INFO { get; set; }

        public DateTime? RECORD_DATE { get; set; }

        public int? RECORD_EMP { get; set; }

        [StringLength(50)]
        public string RECORD_IP { get; set; }

        public int? RECORD_PAR { get; set; }

        public DateTime? UPDATE_DATE { get; set; }

        public int? UPDATE_EMP { get; set; }

        [StringLength(50)]
        public string UPDATE_IP { get; set; }

        public int? TRANSPORT_COMP_ID { get; set; }

        public int? TRANSPORT_DELIVER_ID { get; set; }

        public bool? IS_BLACKLIST { get; set; }

        public int? BLACKLIST_INFO { get; set; }

        public DateTime? BLACKLIST_DATE { get; set; }

        public int? CARD_REVMETHOD_ID { get; set; }

        public int? CARD_PAYMETHOD_ID { get; set; }

        public int? PAYMENT_BLOKAJ_TYPE { get; set; }

        public int? PAYMENT_RATE_TYPE { get; set; }
    }
}
