namespace Alquizar_StudentDashboard.Models
{
    public static class StudentLogic
    {
        public static string GetClassStatus(StudentVM viewModel)
        {
            if (viewModel.Students == null || !viewModel.Students.Any())
                return "No students enrolled";

            if (viewModel.Average >= 75)
                return "Class is performing well";
            else if (viewModel.Average >= 50)
                return "Class needs improvement";
            else
                return "Class requires immediate attention";
        }

        public static List<Student> GetTopPerformers(StudentVM viewModel, int count = 3)
        {
            if (viewModel.Students == null || !viewModel.Students.Any())
                return new List<Student>();

            return viewModel.Students
                .OrderByDescending(s => s.Score)
                .Take(count)
                .ToList();
        }

        public static List<Student> GetStudentsAtRisk(StudentVM viewModel)
        {
            if (viewModel.Students == null || !viewModel.Students.Any())
                return new List<Student>();

            return viewModel.Students
                .Where(s => s.Score < 75)
                .OrderBy(s => s.Score)
                .ToList();
        }
    }
}
