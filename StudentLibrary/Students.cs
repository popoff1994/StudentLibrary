using System.ComponentModel.DataAnnotations;

namespace StudentLibrary
{
    public class Students
    {
        public int StudentId { get; set; }
        [MinLength(2, ErrorMessage ="Name must be atleast two characters long")]
        public string Name { get; set; }
        public int AbsenceMin { get; set; }
        public int NFCId { get; set; }

        public Students(int studentId, string name, int absenceMin, int nFCId)
        {
            StudentId = studentId;
            Name = name;
            AbsenceMin = absenceMin;
            NFCId = nFCId;
        }
        public Students()
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