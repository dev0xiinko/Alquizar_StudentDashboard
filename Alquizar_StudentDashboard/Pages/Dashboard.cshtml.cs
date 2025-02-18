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
                new Student { Name = "Alice", Score = 85, Remarks = string.Empty },
                new Student { Name = "Bob", Score = 92, Remarks = string.Empty },
                new Student { Name = "Charlie", Score = 78, Remarks = string.Empty },
                new Student { Name = "Diana", Score = 88, Remarks = string.Empty }
            };

            // Calculate statistics
            StudentVM.CalculateAverage();
            StudentVM.CalculateAllRemarks();
        }
    }
}
