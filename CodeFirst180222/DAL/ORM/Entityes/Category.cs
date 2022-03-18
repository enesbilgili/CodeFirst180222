using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst180222.DAL.ORM.Context
{
    class Category:Product
    {



        [MaxLength(50)]
        [Required]
        public override string Name { get => base.Name; set => base.Name = value; }
        [MaxLength (250)]
        public string Description { get; set; }
    }
}
