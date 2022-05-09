using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL1StSharp
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Column("Name", TypeName = "nvarchar")]
        [MaxLength(20)]
        public string Name { get; set; }

        [Column("SurName", TypeName = "nvarchar")]
        [MaxLength(25)]
        public string SurName { get; set; }

    }
}