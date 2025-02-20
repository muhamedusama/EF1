
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace EF1.Models
{
    [Table("Departments")]
    internal class Department
    {
        [Key]
        public int id { get; set; }
        [Required]
        public String Name { get; set; }
        [Required]
        [Column("Instructor_ID")]
        public int Ins_ID { get; set; }
        [Required]
        [Column(TypeName ="date")]
        public String HiringDate { get; set; }

    }
}
