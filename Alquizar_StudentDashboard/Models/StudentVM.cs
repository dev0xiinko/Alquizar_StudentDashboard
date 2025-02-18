namespace Alquizar_StudentDashboard.Models
{
    public class StudentVM
    {
        public List<Student> Students { get; set; } = new List<Student>();
        public double Average { get; set; }
    }
}
