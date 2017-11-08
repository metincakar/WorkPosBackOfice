namespace WorkPosBackOfice.ModulObject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AspNetUsers
    {
        public string Id { get; set; }

        public string UserName { get; set; }

        public string PasswordHash { get; set; }

        public string SecurityStamp { get; set; }

        public string Ad { get; set; }

        public string SoyAd { get; set; }

        public DateTime? DogumTarihi { get; set; }

        [Required]
        [StringLength(128)]
        public string Discriminator { get; set; }
    }
}
