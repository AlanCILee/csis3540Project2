namespace DataAdministrator.EF_Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int orderId { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        public int? productId { get; set; }

        public int? quantity { get; set; }

        public int? delivered { get; set; }

        [StringLength(50)]
        public string orderDate { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Product Product { get; set; }
    }
}
