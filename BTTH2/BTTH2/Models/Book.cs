using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BTTH2.Models
{
    public class Book
    {
        public virtual int BookId { get; set; }
        public virtual int AuthorId { get; set; }
        public virtual int PublishingId { get; set; }
        [Display(Name = "Tên sách")]
        public virtual string Title { get; set; }
        [Display(Name = "Giá")]
        public virtual double Price { get; set; }
        [Display(Name = "Năm")]
        public virtual int PubYear { get; set; }
        public virtual Author Author { get; set; }
        public virtual Publishing Publishing { get; set; }
    }
}