namespace ApiMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TBLOGRETMEN
    {
        public int id { get; set; }

        [StringLength(50)]
        public string ogr_adi { get; set; }

        [StringLength(50)]
        public string ogr_soyadi { get; set; }

        [StringLength(50)]
        public string ogr_mail { get; set; }

        [StringLength(50)]
        public string ogr_tel { get; set; }

        [StringLength(50)]
        public string ogr_password { get; set; }
    }
}
