namespace Alquizar_StudentDashboard.Models
{
    public class StudentVM
    {
        public List<Student> Students { get; set; } = new List<Student>();
        public double Average { get; private set; }
        public int PassingCount => Students.Count(s => s.Score >= 75);
        public int FailingCount => Students.Count(s => s.Score < 75);

        public void CalculateAverage()
        {
            if (Students == null || !Students.Any())
            {
                Average = 0;
                return;
            }

            Average = Students.Average(s => s.Score);
        }

        public void CalculateAllRemarks()
        {
            if (Students == null) return;
            
            foreach (var student in Students)
            {
                student.CalculateRemarks();
            }
        }
    }
}
