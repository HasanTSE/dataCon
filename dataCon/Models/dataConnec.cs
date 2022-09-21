using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dataCon.Models
{
    [Table("dbStudent")]
    public class dataConnec
    {
        [Key]

        public int Id { get; set; }

        [Display(Name = "Student Name")]
        [StringLength(100)]
        public string Name { get; set; }
       
        [StringLength(200)]
        public string? Address { get; set; }

        public int? Age { get; set; }


        [Display(Name = "Phone Number")]
        [StringLength(20)]
        public string? Number { get; set; }


        [DataType(DataType.Date)]
        public DateTime? DateOfBirth { get; set; }

        public int? SemesterId { get; set; }
        
        [ForeignKey("SemesterId")]
        
        public Semester Semester { get; set; }



    }
}
