using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentLibrary
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Id { get; set; }
        [MinLength(2, ErrorMessage ="Name must be atleast two characters long")]
        public string Name { get; set; }
        public int AbsenceMin { get; set; }
        public bool CheckedIn { get; set; }
        public long NFCId { get; set; }

        public Student(string name, int absenceMin, long nFCId, bool checkedIn)
        {
            Name = name;
            AbsenceMin = absenceMin;
            NFCId = nFCId;
            CheckedIn = checkedIn;
        }
        public Student()
        {

        }
        public void NameValidatior()
        {
            if (Name.Length < 2)
                throw new ArgumentException("NAME MUST BE AT LEAST TWO CHARACTERS LONG");
            else
                Console.WriteLine("Name Validated");
        }
    }
}
