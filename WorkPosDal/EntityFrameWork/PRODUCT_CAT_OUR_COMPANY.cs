namespace WorkPosDal.EntityFrameWork
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PRODUCT_CAT_OUR_COMPANY
    {
        [Key]
        public int PRODUCT_CAT_OUR_COMPANY_ID { get; set; }

        public int PRODUCT_CATID { get; set; }

        public int OUR_COMPANY_ID { get; set; }
    }
}
