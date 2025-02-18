namespace Alquizar_StudentDashboard.Models
{
    public class StudentVM
    {
        // Lista sa tanang estudyante
        public List<Student> Students { get; set; } = new List<Student>();

        // Kini mo compute sa average sa tanang scores
        // Kung walay students kay mo return ug 0
        public double Average => Students?.Any() == true ? Students.Average(s => s.Score) : 0;
        
        // Kini mo compute sa remarks sa tanang estudyante
        public void CalculateRemarks()
        {
            // I-loop ang tanang estudyante ug i-compute ilang remarks
            foreach (var student in Students)
            {
                student.CalculateRemarks();
            }
        }
    }
}
