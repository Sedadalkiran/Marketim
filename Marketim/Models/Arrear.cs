namespace Marketim.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Arrear")]
    public partial class Arrear
    {
        public int CustomerName { get; set; }

        public int SumArrear { get; set; }

        [Key]
        public int Arrearıd { get; set; }
    }
}
