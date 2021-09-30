using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTaskAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        [HttpGet]
        public IActionResult Tasks() 
        {
            var result=new string[] { "Task 01", "Task 02", "Task 03" };
            return Ok(result);
        }

        [HttpPost]
        public IActionResult NewTasks()
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateTasks()
        {
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteTasks()
        {
            return Ok();
        }
    }
}
