using ASP.NET.TODO.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET.TODO.Controllers
{
    public class TodoController : Controller
    {
        private TodoRepository book_repository = new TodoRepository();
        public IActionResult Index()
        {
            return View("Index", book_repository.GetTodos());
            
        }
    }
}
