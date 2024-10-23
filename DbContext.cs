using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace baibuoi8
{
    public partial class SchoolContext : DbContext
    {
        public SchoolContext()
            : base("name=DbContext")
        {
        }

        public virtual DbSet<Students> Students { get; set; }

       
    }
}
