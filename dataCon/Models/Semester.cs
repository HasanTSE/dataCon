using System.ComponentModel.DataAnnotations;

namespace dataCon.Models
{
    public class Semester
    {
        public int Id { get; set; }
        
        
        [StringLength(100)]
        public string SemesterName { get; set; }

        public bool IsActive { get; set; }


    }
}
