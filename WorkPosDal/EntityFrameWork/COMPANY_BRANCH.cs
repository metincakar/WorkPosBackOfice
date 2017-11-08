namespace WorkPosDal.EntityFrameWork
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class COMPANY_BRANCH
    {
        public bool? COMPBRANCH_STATUS { get; set; }

        public int COMPANY_ID { get; set; }

        [Key]
        public int COMPBRANCH_ID { get; set; }

        public int? EMP_ID { get; set; }

        public int? POS_CODE { get; set; }

        public int? PARTNER_ID { get; set; }

        [StringLength(50)]
        public string COMPBRANCH__NAME { get; set; }

        [StringLength(100)]
        public string COMPBRANCH__NICKNAME { get; set; }

        [StringLength(100)]
        public string COMPBRANCH_EMAIL { get; set; }

        [StringLength(43)]
        public string COMPBRANCH_TELCODE { get; set; }

        [StringLength(43)]
        public string COMPBRANCH_TEL1 { get; set; }

        [StringLength(43)]
        public string COMPBRANCH_TEL2 { get; set; }

        [StringLength(43)]
        public string COMPBRANCH_TEL3 { get; set; }

        [StringLength(43)]
        public string COMPBRANCH_FAX { get; set; }

        [StringLength(50)]
        public string HOMEPAGE { get; set; }

        [StringLength(250)]
        public string COMPBRANCH_ADDRESS { get; set; }

        [StringLength(43)]
        public string COMPBRANCH_POSTCODE { get; set; }

        [StringLength(50)]
        public string SEMT { get; set; }

        public int? COUNTY_ID { get; set; }

        public int? CITY_ID { get; set; }

        public int? COUNTRY_ID { get; set; }

        public int? MEMBER_TYPE { get; set; }

        public int? BRANCH_ID { get; set; }

        public int? ZONE_ID { get; set; }

        public int? MANAGER_PARTNER_ID { get; set; }

        public int? RECORD_MEMBER { get; set; }

        public int? RECORD_PAR { get; set; }

        public DateTime? RECORD_DATE { get; set; }

        [StringLength(50)]
        public string RECORD_IP { get; set; }

        public int? UPDATE_PAR { get; set; }

        public DateTime? UPDATE_DATE { get; set; }

        [StringLength(50)]
        public string UPDATE_IP { get; set; }

        public int? UPDATE_MEMBER { get; set; }

        public bool? IS_SHIP_ADDRESS { get; set; }

        public bool? IS_INVOICE_ADDRESS { get; set; }

        [StringLength(43)]
        public string COORDINATE_1 { get; set; }

        [StringLength(43)]
        public string COORDINATE_2 { get; set; }

        [StringLength(43)]
        public string COMPBRANCH_MOBIL_CODE { get; set; }

        [StringLength(43)]
        public string COMPBRANCH_MOBILTEL { get; set; }

        public int? SZ_ID { get; set; }

        [StringLength(50)]
        public string COMPBRANCH_CODE { get; set; }

        [StringLength(100)]
        public string COMPBRANCH_ALIAS { get; set; }
    }
}
