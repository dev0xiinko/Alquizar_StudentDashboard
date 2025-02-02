using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Alquizar_StudentDashboard.Pages
{
    public class DashboardModel : PageModel
    {
        public void OnGet()
        {
        }
    }

    public class Student
    {
        public string Name { get; set; }
        public int Score { get; set; }
    }
}