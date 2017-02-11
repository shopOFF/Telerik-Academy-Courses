using System.ComponentModel.DataAnnotations.Schema;

namespace StudentSystem.Models
{
    [ComplexType]
    public class StudentAdditionalInfo
    {
        [Column("Age")]
        public int Age { get; set; }

        [Column("Country")]
        public string Country { get; set; }
    }
}
