using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace internetShop.Models
{
    public class Order
    {
        [BindNever] //hide from web
        public int id { get; set; }

        [Display(Name = "Enter the Name")]        
        public string name { get; set; }


        [Display(Name = "Enter the Surname")]
        public string surname { get; set; }

        [Display(Name = "Enter the Adress")]
        [DataType(DataType.EmailAddress)]
        public string address { get; set; }

        public string email { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string phone { get; set; }

        [BindNever]
        [ScaffoldColumn(false)] //to not appear in the code
        public DateTime orderTime { get; set; }

        public List<OrderDetail> orderDetails { get; set; }
    }
}
