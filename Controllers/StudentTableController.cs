using Microsoft.AspNetCore.Mvc;
using StudentTodo.Data;
using StudentTodo.Models;


namespace StudentTodo.Controllers
{
    public class StudentTableController : Controller
    {
        private readonly ApplicationDbContext _db;

        public StudentTableController(ApplicationDbContext db)
        {
            _db = db;
        }

        // GET: StudentTodoController
        public ActionResult Index()
        {
            // var objCategoryList = _db.StudentTodos.ToList();
            IEnumerable<StudentTable> objCategoryList = _db.StudentTodos;
            return View(objCategoryList);
        }

        //get
        public ActionResult Create()
        {
            return View();
        }

        //post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(StudentTable obj)
        {
            if (ModelState.IsValid)
            {
                _db.StudentTodos.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        // get
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var DataFromDb = _db.StudentTodos.Find(id);
            if (DataFromDb == null)
            {
                return NotFound();
            }
            return View(DataFromDb);

        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(StudentTable obj)
        {
            if (ModelState.IsValid)
            {
                _db.StudentTodos.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        


    }
}









