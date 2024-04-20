using Student.Model;

namespace Student.Business.Business
{
    public interface IStudentBusiness
    {
        void AddMarks(Marksheet mark);
        IEnumerable<Marksheet> GetAllMarksByStudentId(int studentId);
        IEnumerable<Student> GetStudent();
        int GetTotalMarkObtainedByid(int id);
    }
}