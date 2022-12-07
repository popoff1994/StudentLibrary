using System.ComponentModel.DataAnnotations;

namespace StudentLibrary
{
    public class Student
    {
        public int StudentId { get; set; }
        [MinLength(2, ErrorMessage ="Name must be atleast two characters long")]
        public string Name { get; set; }
        public int AbsenceMin { get; set; }
        public bool CheckedIn { get; set; }
        public int NFCId { get; set; }

        public Students(int studentId, string name, int absenceMin, int nFCId, bool checkedIn)
        {
            StudentId = studentId;
            Name = name;
            AbsenceMin = absenceMin;
            NFCId = nFCId;
            CheckedIn = checkedIn
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
