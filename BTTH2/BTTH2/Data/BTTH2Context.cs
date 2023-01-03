using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BTTH2.Data
{
    public class BTTH2Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public BTTH2Context() : base("name=BTTH2Context")
        {
        }

        public System.Data.Entity.DbSet<BTTH2.Models.Book> Books { get; set; }

        public System.Data.Entity.DbSet<BTTH2.Models.Author> Authors { get; set; }

        public System.Data.Entity.DbSet<BTTH2.Models.Publishing> Publishings { get; set; }
    }
}
