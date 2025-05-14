using Microsoft.AspNetCore.Mvc;

namespace LAB2.Controllers
{
    public class TodoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // GET: Todo/Add
        public IActionResult Add()
        {
            return View();
        }
        // GET: Todo/Edit/1
        public IActionResult Edit(int id)
        {
            ViewBag.TaskId = id; // Truyền ID của công việc cần sửa
            return View();
        }


    }
}
