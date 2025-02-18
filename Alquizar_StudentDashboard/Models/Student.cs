using System.ComponentModel.DataAnnotations;

namespace Alquizar_StudentDashboard.Models
{
    public class Student
    {
        [Required(ErrorMessage = "Name is required")]
        [StringLength(100)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Score is required")]
        [Range(0, 100, ErrorMessage = "Score must be between 0 and 100")]
        public int Score { get; set; }

        public string Remarks { get; set; }

        public void CalculateRemarks()
        {
            Remarks = Score switch
            {
                >= 75 => "Passed",
                _ => "Failed"
            };
        }
    }
}
