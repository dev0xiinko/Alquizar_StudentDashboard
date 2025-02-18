using Microsoft.AspNetCore.Mvc.RazorPages;
using Alquizar_StudentDashboard.Models;

namespace Alquizar_StudentDashboard.Pages
{
    public class DashboardModel : PageModel
    {
        public StudentVM StudentVM { get; set; } = new StudentVM();

        public void OnGet()
        {
            // Initialize student list
            StudentVM.Students = new List<Student>
            {
                new Student { Name = "Alice", Score = 85 },
                new Student { Name = "Bob", Score = 92 },
                new Student { Name = "Charlie", Score = 78 },
                new Student { Name = "Diana", Score = 88 }
            };

            // Calculate average
            StudentVM.Average = StudentVM.Students.Average(s => s.Score);

            // Set remarks for each student
            foreach (var student in StudentVM.Students)
            {
                student.Remarks = student.Score switch
                {
                    >= 90 => "Excellent",
                    >= 80 => "Good",
                    _ => "Needs Improvement"
                };
            }
        }
    }
}
