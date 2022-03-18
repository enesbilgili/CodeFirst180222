using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CodeFirst180222.DAL.ORM.Context
{
    class BaseEntity
    {
        [Key]
        [Column(Order =1)]
        public int ID { get; set; }
        [MaxLength (50)]
        [Column(Order =2)]
        public virtual string Name { get; set; }
        [Column(TypeName ="datetime2")]
        public Nullable <DateTime> Added_Date { get; set; }
        public bool  IsActive { get; set; }
    }
}
