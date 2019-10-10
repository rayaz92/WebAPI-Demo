using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Web_API_Demo.Models
{
    [Table("Items")]
    public class Items
    {
        public int ID { get; set; }
        public string ItemName { get; set; }
        public int CategoryID { get; set; }
        public Decimal ItemPrice { get; set; }
        public string ItemImage { get; set; }
    }
}