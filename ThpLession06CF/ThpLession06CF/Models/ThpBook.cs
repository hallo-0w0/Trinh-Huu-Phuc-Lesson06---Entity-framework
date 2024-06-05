using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ThpLession06CF.Models
{
    public class ThpBook
    {
        [Key]
        public int ThpId { get; set; }
        public string ThpBookId { get; set; }
        public string ThpTitle { get; set; }
        public string ThpAuthor { get; set;}
        public int ThpYear { get; set;}
        public string ThpPulisher { get; set;}
        public string ThpPicture { get; set;}
        public string ThpCategoryId { get; set;}
        //Thuoc tinh quan he
        public virtual ThpCategory ThpCategory { get; set;}
    }
}