using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BTTH2.Models
{
    public class Publishing
    {
        [Display (Name = "ID")]
        public virtual int PublishingId { get; set; }
        [Display(Name = "Nhà xuất bản")]
        public virtual string PublishingName { get; set; }
        public virtual List<Book> Books { get; set; }
    }
}