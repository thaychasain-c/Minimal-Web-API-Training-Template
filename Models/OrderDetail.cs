using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web_API_Training_Template.Models
{
    [Table("orders")]
	public class Order
	{
        [Key]
        public int OrderId { get; set; }
        public string CustomerId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public DateTime ShippedDate { get; set; }
        public int? ShipVia { get; set; }
        public decimal? Freight { get; set; }
        public string? ShipName { get; set; }
        public string? ShipAddress { get; set; }
        public string? ShipCity { get; set; }
        public string? ShipRegion { get; set; }
        public string? ShipPostalCode { get; set; }
        public string? ShipCountry { get; set; }

        [ForeignKey("customer_id")]
        public ICollection<Customer>? Customer { get; set; }

        [ForeignKey("employee_id")]
        public ICollection<Employee>? Employee { get; set; }

        [ForeignKey("ship_via")]
        public ICollection<Shipper>? Shipper { get; set; }

        public Order(int OrderId_, string CustomerId_, int EmployeeId_, DateTime OrderDate_, DateTime RequiredDate_, DateTime ShippedDate_,int ShipVia_)
        {
            this.OrderId = OrderId_;
            this.CustomerId = CustomerId_;
            this.EmployeeId = EmployeeId_;
            this.ShipVia = ShipVia_;
            this.OrderDate = OrderDate_;
            this.RequiredDate = RequiredDate_;
            this.ShippedDate = ShippedDate_;
        }
    }
}
