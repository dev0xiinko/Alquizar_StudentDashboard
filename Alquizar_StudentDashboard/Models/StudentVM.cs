namespace Alquizar_StudentDashboard.Models
{
    public class StudentVM
    {
        public List<Student> Students { get; set; } = new List<Student>();
        public double Average => Students?.Any() == true ? Students.Average(s => s.Score) : 0;
        
        public void CalculateRemarks()
        {
            foreach (var student in Students)
            {
                student.CalculateRemarks();
            }
        }
    }
}
