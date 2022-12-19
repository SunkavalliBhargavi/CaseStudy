using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CropMVC.Models
{
    public class CropViewModel
    {
        public int ID { get; set; }
        public Nullable<int> User_ID { get; set; }
        public string Name { get; set; }
        public byte[] Crop_IMG { get; set; }
        public string Description { get; set; }
        public Nullable<decimal> Price { get; set; }
        public string Status { get; set; }
       
    }
}