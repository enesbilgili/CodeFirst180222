using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst180222.DAL.ORM.Context
{
    class Product: BaseEntity
    {
      

        
        [Required,MaxLength(50),Column("ProductName",Order =2)]
        public override string Name { get => base.Name; set => base.Name = value; }
        
        public Nullable <decimal> UnitPrice { get; set; }
        public short? UnitStock { get; set; }
        public string QuantityPerUnit { get; set; }
    }
}
