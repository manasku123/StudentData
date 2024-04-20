using Student.Business.Contract;
using Student.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Business.Business
{
    public class StudentBusiness : IStudentBusiness
    {

        private readonly List<Student> _student;
        private readonly List<Marksheet> _marksheet;
        public StudentBusiness()
        {
            _student = new List<Student>
            {
              new Student { StudentId = 1, Name = "Radha", StudentJoinDate = new DateTime(2024, 01, 01) },
              new Student { StudentId = 2, Name = "Radha", StudentJoinDate = new DateTime(2024, 01, 02) },
              new Student { StudentId = 3, Name = "Radha", StudentJoinDate = new DateTime(2024, 01, 03) },
              new Student { StudentId = 4, Name = "Radha", StudentJoinDate = new DateTime(2024, 01, 04) },
              new Student { StudentId = 5, Name = "Radha", StudentJoinDate = new DateTime(2024, 01, 05) },
            };
            _marksheet = new List<Marksheet>
            {
                new Marksheet{MarksheetId=1, StudentId=1, Subject="CSE", TotalMark=100, Markobtained= 60 },
                new Marksheet{MarksheetId=2, StudentId=2, Subject="CSE", TotalMark=100, Markobtained= 55 },
                new Marksheet{MarksheetId=3, StudentId=3, Subject="CSE", TotalMark=100, Markobtained= 45 },
                new Marksheet{MarksheetId=4, StudentId=4, Subject="CSE", TotalMark=100, Markobtained= 75 },
                new Marksheet{MarksheetId=5, StudentId=5, Subject="CSE", TotalMark=100, Markobtained= 50 },
               // new Marksheet{MarksheetId=6, StudentId=6, Subject="CSE", TotalMark=100, Markobtained= 60 },

            };
        }
        public int GetTotalMarkobtainedByid(int id)
        {
            return _marksheet.Where(mark => mark.StudentId == id).Sum(mark => mark.Markobtained);

        }
        public List<Marksheet> GetAllMarksByStudentId(int id)
        {
            return _marksheet.Where(mark => mark.StudentId == id).Select(selector: mark => mark.Markobtained).ToList();
        }
        public void AddMarks(Marksheet marks)
        {
            _marksheet.Add(marks);
        }
        public static bool UpdateMarks(Marksheet mark)
        {
            var i = Marksheet.FindIndex(s => s.StudentId == mark.StudentId && s.Subject == mark.Subject);
            if (i == -1) return false;
            //else case
            Marksheet[i] = mark;
            return true;
        }

        public IEnumerable<Student> GetStudent()
        {
            throw new NotImplementedException();
        }

        public int GetTotalMarkObtainedByid(int id)
        {
            throw new NotImplementedException();
        }
    }
        
         
   
}



