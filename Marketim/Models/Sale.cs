namespace Marketim.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sale
    {
        [Key]
        public int Salesid { get; set; }

        public int ProductId { get; set; }

        public DateTime Date { get; set; }

        public virtual Product Product { get; set; }
    }
}
