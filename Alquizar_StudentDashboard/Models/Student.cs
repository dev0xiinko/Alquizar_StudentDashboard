using System.ComponentModel.DataAnnotations;

namespace Alquizar_StudentDashboard.Models
{
    public class Student
    {
        // Kinahanglan gyud naay ngalan ang estudyante
        [Required(ErrorMessage = "Name is required")]
        [StringLength(100)]
        public required string Name { get; set; }

        // Ang score kay kinahanglan 0-100 ra
        [Required(ErrorMessage = "Score is required")]
        [Range(0, 100, ErrorMessage = "Score must be between 0 and 100")]
        public int Score { get; set; }

        // Diri nato ibutang kung nipasar ba or wala
        public required string Remarks { get; set; } = string.Empty;

        // Kini nga function mo compute kung passed or failed
        public void CalculateRemarks()
        {
            // Kung 75 pataas kay passed, kung ubos kay failed
            Remarks = Score >= 75 ? "Passed" : "Failed";
        }
    }
}
