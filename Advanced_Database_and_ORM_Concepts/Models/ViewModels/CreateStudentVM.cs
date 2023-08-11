using Advanced_Database_and_ORM_Concepts.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace Advanced_Database_and_ORM_Concepts.Models.ViewModels
{
    public class CreateStudentVM
    {
        public Student? NewStudent { get; set; }
        public int SelectedCourseId { get; set; }
        public List<SelectListItem> SelectItems = new List<SelectListItem>();
        public CreateStudentVM(ICollection<Course> courses)
        {
            foreach (Course c in courses)
            {
                SelectItems.Add(new SelectListItem { Text = c.Title, Value = c.Id.ToString() });
            }
        }
        public CreateStudentVM() { }
    }
}