using Microsoft.AspNetCore.Mvc;
using dataCon.Models;

namespace dataCon.Controllers
{
    public class StudentController1 : Controller
    {
        private readonly dbContext _db;
        public StudentController1(dbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var studentList = _db.dataConnecs.ToList();

            //List<dataConnec> studentList = new List<dataConnec>();
            //studentList = _db.dataConnecs.ToList();

            return View(studentList);

        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var student = _db.dataConnecs.FirstOrDefault(x => x.Id == id);
            // var std=_db.dataConnecs.Where(x => x.Id == id).FirstOrDefault();

            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Create(dataConnec dataPass)
        {
            if (dataPass != null && ModelState.IsValid)
            {
                _db.Add(dataPass);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(dataPass);
        }

        public IActionResult Edit(int? id)
        {
            
            if (id == null)
            {
                return NotFound();
            }
            var student = _db.dataConnecs.FirstOrDefault(x => x.Id == id);
            if(student == null)
            {
                return NotFound();
            }

            return View(student);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]


        public IActionResult Edit(dataConnec dataPass)
        {
            if (dataPass == null)
            { 
                return NotFound();
        }

            if (ModelState.IsValid)
            {
                _db.Update(dataPass);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(dataPass);
            }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var student = _db.dataConnecs.FirstOrDefault(x => x.Id == id);
            _db.dataConnecs.Remove(student);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));

        }

    }
}
