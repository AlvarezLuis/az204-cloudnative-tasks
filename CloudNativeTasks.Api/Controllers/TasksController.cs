using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace CloudNativeTasks.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TasksController : ControllerBase
    {
        private readonly List<string> _tasks = ["tarea 1", "tarea 2"];

        [HttpGet]
        public IEnumerable<string> GetTasks()
        {
            return _tasks;
        }

        [HttpPost]
        public ActionResult CreateTask(string value)
        {
            _tasks.Add(value);
            return Ok();
        }
    }
}