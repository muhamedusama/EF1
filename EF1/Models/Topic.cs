using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF1.Models
{
    [Table("Topics")]
    internal class Topic
    {
        [Key]
        public int id { get; set; }
        [Required]
        public String Name { get; set; }

    }
}
