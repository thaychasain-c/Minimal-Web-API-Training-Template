using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web_API_Training_Template.Models
{
    [Table("shippers", Schema = "public")]
    public class Shipper
	{
        [Key]
        public int ShipperId { get; set; }
        public string CompanyName { get; set; }
        public string? Phone { get; set; }
    }
}

