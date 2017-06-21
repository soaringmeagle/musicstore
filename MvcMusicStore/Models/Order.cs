using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;

namespace MvcMusicStore.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public string  UserName { get; set; }
        [StringLength(160,MinimumLength=3)]
        [Required]
        public string  FirstName { get; set; }
        [Required]
        public string  LastName { get; set; }
        public string  Address { get; set; }
        public string  City { get; set; }
        public string  State { get; set; }
        public string  PostalCode { get; set; }
        public string Country { get; set; }
        public string  Phone { get; set; }
        public string  Email { get; set; }
        public decimal Total { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}