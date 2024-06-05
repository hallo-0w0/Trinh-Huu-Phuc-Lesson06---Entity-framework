using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ThpLession06CF.Models
{
    public class ThpCategory
    {
        [Key]
        public int ThpId { get; set; }
        public string ThpCategoryName { get; set; }
        //Thuoc tinh quan he
        public virtual ICollection<ThpBook> ThpBooks { get; set; }
    }
}