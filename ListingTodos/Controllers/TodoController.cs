using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ListingTodos.Entities;
using ListingTodos.Interfaces;
using ListingTodos.Models;
using ListingTodos.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ListingTodos.Controllers
{
    public class TodoController : Controller
    {
        private readonly ITodoService todoService;
        public TodoController(ITodoService todoService)
        {
            this.todoService = todoService;
        }
        public IActionResult Index(string isDone)
        {
            if (String.IsNullOrEmpty(isDone))
            {
                return View(new ViewModel(todoService.Todos()));
            }
            return View(new ViewModel(todoService.CheckTodos(isDone)));
        }
        [HttpGet("add")]
        public IActionResult AddTodo()
        { 
            return View(new ViewModel(todoService.Assignees()));
        }
        [HttpPost("add")]
        public IActionResult AddTodo(Todo todo, string name)
        {
            todoService.CreateTodo(todo);
            return RedirectToAction("Index");
        }
        [HttpPost("{id}/delete")]
        public IActionResult DeleteTodo([FromRoute] long id)
        {
            todoService.DeleteTodo(id);
            return RedirectToAction("Index");
        }
        [HttpGet("{id}/edit")]
        public IActionResult EditTodo([FromRoute] long id)
        {
            return View(new ViewModel(todoService.GetTodo(id)));
        }
        [HttpPost("{id}/edit")]
        public IActionResult EditTodo(Todo todo)
        {
            todoService.EditTodo(todo);
            return RedirectToAction("Index");
        }
        [HttpGet("{id}/detail")]
        public IActionResult Detail([FromRoute] long id)
        {
            return View(new ViewModel(todoService.GetTodo(id)));
        }
        [HttpGet("search")]
        public IActionResult SearchFor(string input)
        {
            return View("Index", new ViewModel(todoService.Search(input)));
        }
        [HttpGet("assignees")]
        public IActionResult ShowAssignees()
        {
            return View(new ViewModel(todoService.Assignees()));
        }
        [HttpGet("add-assignee")]
        public IActionResult AddAssignee()
        {
            return View();
        }
        [HttpPost("add-assignee")]
        public IActionResult AddAssignee(Assignee assignee)
        {
            todoService.AddAssignee(assignee);
            return RedirectToAction("ShowAssignees");
        }
    }
}