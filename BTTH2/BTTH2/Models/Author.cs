using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BTTH2.Models
{
    public class Author
    {
        [Display(Name = "ID")]
        public virtual int AuthorId { get; set; }
        [Display(Name = "Tác giả")]
        public virtual string AuthorName { get; set; }
        public virtual List<Book> Books { get; set; }
    }
}