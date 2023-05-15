using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web_API_Training_Template.Models
{
    [Table("order_details", Schema = "public")]
	public class OrderDetail
    {
        [Key]
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public float UnitPrice { get; set; }
        public int Quantity { get; set; }
        public float Discount { get; set; }

        [ForeignKey(nameof(OrderId))]
        public Order? Order { get; set; }

        [ForeignKey(nameof(ProductId))]
        public Product? Product { get; set; }
    }
}
