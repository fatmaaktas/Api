namespace ApiMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TBLOGRENCI")]
    public partial class TBLOGRENCI
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string KULLANICIAD { get; set; }

        [StringLength(50)]
        public string SIFRE { get; set; }

        [StringLength(50)]
        public string MAIL { get; set; }

        [StringLength(50)]
        public string SEHİR { get; set; }
    }
}
