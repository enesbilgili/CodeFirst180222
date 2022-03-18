using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst180222.DAL.ORM.Context
{
    [Table("Users")]
    class AppUser:BaseEntity
    {


        [Required]
        [Index("Unique",2,IsUnique =true,Order =2)]
        
        public string UserName { get; set; }
        [MaxLength(50)]
        public string LastName { get; set; }
        [NotMapped]
        public string FirstName
        {
            get
            {
                if (string.IsNullOrWhiteSpace(LastName))

                {
                    return Name;
                  
                }
                else
                {
                    return Name + " " + LastName;
                }
            }
            
        }
        [MaxLength(50)]
        public string Password { get; set; }
        public Nullable<DateTime> BirtDate { get; set; }
        [MaxLength(50)]
        public string Gender { get; set; }
    }
}
