namespace WorkPosDb.EntityFrameWork
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OUR_COMPANY
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int COMP_ID { get; set; }

        [StringLength(200)]
        public string COMPANY_NAME { get; set; }

        [StringLength(50)]
        public string NICK_NAME { get; set; }

        [StringLength(50)]
        public string TAX_OFFICE { get; set; }

        [StringLength(50)]
        public string TAX_NO { get; set; }

        [StringLength(43)]
        public string TEL_CODE { get; set; }

        [StringLength(43)]
        public string TEL { get; set; }

        [StringLength(43)]
        public string FAX { get; set; }

        [StringLength(40)]
        public string MANAGER { get; set; }

        public int? MANAGER_POSITION_CODE { get; set; }

        public int? MANAGER_POSITION_CODE2 { get; set; }

        [StringLength(50)]
        public string WEB { get; set; }

        [StringLength(50)]
        public string EMAIL { get; set; }

        [Column(TypeName = "ntext")]
        public string ADDRESS { get; set; }

        [Column(TypeName = "ntext")]
        public string ADMIN_MAIL { get; set; }

        [StringLength(43)]
        public string TEL2 { get; set; }

        [StringLength(43)]
        public string TEL3 { get; set; }

        [StringLength(43)]
        public string TEL4 { get; set; }

        [StringLength(43)]
        public string FAX2 { get; set; }

        [StringLength(50)]
        public string T_NO { get; set; }

        [StringLength(43)]
        public string SERMAYE { get; set; }

        [StringLength(150)]
        public string CHAMBER { get; set; }

        [StringLength(50)]
        public string CHAMBER_NO { get; set; }

        [StringLength(150)]
        public string CHAMBER2 { get; set; }

        [StringLength(50)]
        public string CHAMBER2_NO { get; set; }

        [StringLength(100)]
        public string ASSET_FILE_NAME1 { get; set; }

        public int? ASSET_FILE_NAME1_SERVER_ID { get; set; }

        [StringLength(100)]
        public string ASSET_FILE_NAME2 { get; set; }

        public int? ASSET_FILE_NAME2_SERVER_ID { get; set; }

        [StringLength(100)]
        public string ASSET_FILE_NAME3 { get; set; }

        public int? ASSET_FILE_NAME3_SERVER_ID { get; set; }

        public int? HEADQUARTERS_ID { get; set; }

        public bool? IS_ORGANIZATION { get; set; }

        [StringLength(75)]
        public string HIERARCHY { get; set; }

        [StringLength(75)]
        public string HIERARCHY2 { get; set; }

        public bool? COMP_STATUS { get; set; }

        public int? RECORD_EMP { get; set; }

        public DateTime? RECORD_DATE { get; set; }

        [StringLength(50)]
        public string RECORD_IP { get; set; }

        public int? UPDATE_EMP { get; set; }

        public DateTime? UPDATE_DATE { get; set; }

        [StringLength(50)]
        public string UPDATE_IP { get; set; }

        [StringLength(50)]
        public string MAP_COORDINATE { get; set; }

        public DateTime? AUTHORITY_DOC_FINISH { get; set; }

        public DateTime? AUTHORITY_DOC_START { get; set; }

        [StringLength(100)]
        public string AUTHORITY_DOC_NUMBER { get; set; }

        [StringLength(50)]
        public string AUTHORITY_DOC_TYPE { get; set; }

        public int? AUTHORITY_DOC_WARNING { get; set; }

        [StringLength(50)]
        public string COORDINATE_1 { get; set; }

        [StringLength(50)]
        public string COORDINATE_2 { get; set; }

        public int? COUNTRY_ID { get; set; }

        public int? POSTAL_CODE { get; set; }

        public int? CITY_ID { get; set; }

        [StringLength(50)]
        public string CITY_SUBDIVISION_NAME { get; set; }

        [StringLength(50)]
        public string BUILDING_NUMBER { get; set; }

        [StringLength(50)]
        public string STREET_NAME { get; set; }

        [StringLength(50)]
        public string DISTRICT_NAME { get; set; }

        public int? COUNTY_ID { get; set; }

        [StringLength(50)]
        public string MERSIS_NO { get; set; }

        [StringLength(50)]
        public string NACE_CODE { get; set; }
    }
}
