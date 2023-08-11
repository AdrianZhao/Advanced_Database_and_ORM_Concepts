using Advanced_Database_and_ORM_Concepts.Models.ViewModels;
using Advanced_Database_and_ORM_Concepts.Models;
using Microsoft.AspNetCore.Mvc;
using Advanced_Database_and_ORM_Concepts.Data;
using Microsoft.EntityFrameworkCore;

namespace Advanced_Database_and_ORM_Concepts.Controllers
{
    public class StudentsController : Controller
    {
        private readonly Advanced_Database_and_ORM_ConceptsContext _context;
        public StudentsController(Advanced_Database_and_ORM_ConceptsContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            if (_context.Student == null)
            {
                return NotFound();
            }
            else
            {
                return View(_context.Student.Include(s => s.Course).ToHashSet());
            }
        }
        public IActionResult Create()
        {
            HashSet<Course> courses = _context.Course.ToHashSet();
            CreateStudentVM vm = new CreateStudentVM(courses);
            vm.NewStudent = new Student();
            return View(vm);
        }

        [HttpPost]
        public IActionResult Create(CreateStudentVM vm)
        {
            Student student = vm.NewStudent;
            student.CourseId = vm.SelectedCourseId;
            if (ModelState.IsValid)
            {
                _context.Student.Add(student);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                return View(student);
            }
        }
        public IActionResult Edit(int? id)
        {
            if (id == null || _context.Student == null)
            {
                return NotFound();
            }
            var student =  _context.Student.Find(id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Guid id, [Bind("Id,Title")] Student student)
        {
            if (id != student.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(student);
                    _context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }

        // GET: Courses/Delete/5
        public IActionResult Delete(Guid? id)
        {
            if (id == null || _context.Student == null)
            {
                return NotFound();
            }

            var student = _context.Student
                .FirstOrDefault(m => m.Id == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // POST: Courses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(Guid id)
        {
            if (_context.Student == null)
            {
                return Problem("Entity set 'Advanced_Database_and_ORM_ConceptsContext.Student' is null.");
            }
            var student = _context.Student.Find(id);
            if (student != null)
            {
                _context.Student.Remove(student);
            }

            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        private bool CourseExists(Guid id)
        {
            return (_context.Student?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
