using System.ComponentModel.DataAnnotations;

namespace Alquizar_StudentDashboard.Models
{
    public class Student
    {
        public string Name { get; set; } = string.Empty;
        public int Score { get; set; }
        public string Remarks { get; set; } = "Not Graded";
    }
}
