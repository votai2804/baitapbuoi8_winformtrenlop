namespace baibuoi8
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Students
    {
        [Key]
        public int StudentID { get; set; }

        [StringLength(100)]
        public string FullName { get; set; }

        public int? Age { get; set; }

        [StringLength(50)]
        public string Major { get; set; }
    }
}
