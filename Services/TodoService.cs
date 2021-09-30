using MyTaskAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTaskAPI.Services
{
    public class TodoService
    {
        public List<Todo> GetAllTodos()
        {
            var todos = new List<Todo>();

            var todos1 = new Todo
            {
                Id = 1,
                Title = "Get books for school",
                Description = "Get some text books",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodoStatus.New

            };
            todos.Add(todos1);

            var todo2 = new Todo
            {
                Id = 2,
                Title = "Get fruits",
                Description = "Get some fruits",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodoStatus.Inprogress
            };
            todos.Add(todo2);

            var todo3 = new Todo
            {
                Id = 3,
                Title = "Get fruits",
                Description = "Get some fruits",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodoStatus.Inprogress
            };
            todos.Add(todo3);

            return todos;
        }
    }
}
