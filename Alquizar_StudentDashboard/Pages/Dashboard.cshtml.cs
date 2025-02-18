using Microsoft.AspNetCore.Mvc.RazorPages;
using Alquizar_StudentDashboard.Models;

namespace Alquizar_StudentDashboard.Pages
{
    public class DashboardModel : PageModel
    {
        // Kini ang atong main view model para sa dashboard
        public StudentVM StudentVM { get; set; } = new StudentVM();

        public void OnGet()
        {
            // Mag create ta ug sample nga mga estudyante
            StudentVM.Students = new List<Student>
            {
                // Mga example nga estudyante with ilang scores
                new Student { Name = "Alice", Score = 85, Remarks = string.Empty },
                new Student { Name = "Bob", Score = 92, Remarks = string.Empty },
                new Student { Name = "Charlie", Score = 78, Remarks = string.Empty },
                new Student { Name = "Diana", Score = 88, Remarks = string.Empty }
            };

            // I-compute ang remarks sa matag estudyante
            StudentVM.CalculateRemarks();
        }
    }
}
