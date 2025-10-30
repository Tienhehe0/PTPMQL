using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;
using System.Collections.Generic;
using System.Linq;

namespace DemoMVC.Controllers
{
    public class StudentController : Controller
    {
        // Giả lập database tạm thời
        private static List<Student> students = new List<Student>();

        // Sinh mã tự động STD001, STD002, ...
        private string GenerateStudentID()
        {
            if (students == null || students.Count == 0)
                return "STD001";

            var numbers = students
                .Where(s => !string.IsNullOrEmpty(s.StudentID) && s.StudentID.StartsWith("STD"))
                .Select(s =>
                {
                    int n = 0;
                    int.TryParse(s.StudentID.Substring(3), out n);
                    return n;
                });

            int max = numbers.Any() ? numbers.Max() : 0;
            return "STD" + (max + 1).ToString("D3");
        }

        // GET: /Student
        public IActionResult Index()
        {
            return View(students);
        }

        // GET: /Student/Create
        public IActionResult Create()
        {
            ViewBag.NewStudentID = GenerateStudentID();
            return View();
        }

        // POST: /Student/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                student.StudentID = GenerateStudentID();
                students.Add(student);
                return RedirectToAction(nameof(Index));
            }

            ViewBag.NewStudentID = GenerateStudentID();
            return View(student);
        }

        // GET: /Student/Edit/{id}
        public IActionResult Edit(string id)
        {
            if (string.IsNullOrEmpty(id)) return BadRequest();

            var student = students.FirstOrDefault(s => s.StudentID == id);
            if (student == null) return NotFound();

            return View(student);
        }

        // POST: /Student/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Student updatedStudent)
        {
            if (updatedStudent == null || string.IsNullOrEmpty(updatedStudent.StudentID))
                return BadRequest();

            var student = students.FirstOrDefault(s => s.StudentID == updatedStudent.StudentID);
            if (student == null) return NotFound();

            if (ModelState.IsValid)
            {
                student.FullName = updatedStudent.FullName;
                student.DateOfBirth = updatedStudent.DateOfBirth;
                student.Address = updatedStudent.Address;
                student.Email = updatedStudent.Email;
                return RedirectToAction(nameof(Index));
            }

            return View(updatedStudent);
        }

        // GET: /Student/Delete/{id}
        public IActionResult Delete(string id)
        {
            if (string.IsNullOrEmpty(id)) return BadRequest();

            var student = students.FirstOrDefault(s => s.StudentID == id);
            if (student == null) return NotFound();

            return View(student);
        }

        // POST: /Student/Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(string id)
        {
            var student = students.FirstOrDefault(s => s.StudentID == id);
            if (student == null) return NotFound();

            students.Remove(student);
            return RedirectToAction(nameof(Index));
        }
        
    }
}
