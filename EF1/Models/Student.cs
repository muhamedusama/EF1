
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace EF1.Models
{
    [Table("Students")]

    internal class Student
    {
        [Key]
        public int id { get; set; }
        [Required]
        public String FName { get; set; }
        [Required]
        public String LName { get; set; }
        [Required]
        public String Address { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public int Dep_ID { get; set; }

    }
}
