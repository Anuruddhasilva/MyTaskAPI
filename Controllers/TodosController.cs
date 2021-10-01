using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyTaskAPI.Models;
using MyTaskAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTaskAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDosController : ControllerBase
    {
        private readonly ITodoRepository _todoservice;

        public ToDosController(ITodoRepository _repository)
        {
            _todoservice = _repository;
        }

        [HttpGet("(Id)")]
        public IActionResult GetTodos(int Id)
        {
            var getAllTodos = _todoservice.GetAllTodos().Where(t => t.Id==Id);
            return Ok(getAllTodos);
        }


    
    }
}
