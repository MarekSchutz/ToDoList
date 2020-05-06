using ListingTodos.Database;
using ListingTodos.Entities;
using ListingTodos.Interfaces;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace ListingTodos.Services
{
    public class TodoDBService : ITodoService
    {
        private readonly ApplicationDBContext dBContext;
        public TodoDBService(ApplicationDBContext dBContext)
        {
            this.dBContext = dBContext;
        }
        public List<Todo> Todos()
        {
            return dBContext.Todos.ToList();
        }
        public Todo GetTodo(long id)
        {
            return dBContext.Todos.FirstOrDefault(t => t.Id.Equals(id));
        }
        public List<Todo> CheckTodos(string isDone)
        {
            if (isDone == "True")
            {
                return dBContext.Todos.Where(t => t.IsDone).ToList();
            }
            else
            {
                return dBContext.Todos.Where(t => t.IsDone == false).ToList();
            }
        }
        public void CreateTodo(Todo todo)
        {
            if (String.IsNullOrEmpty(todo.Title))
            {
                todo.Title = "default";
            }
            dBContext.Todos.Add(todo);
            dBContext.SaveChanges();
        }
        public void DeleteTodo(long id)
        {
            dBContext.Remove(dBContext.Todos.FirstOrDefault(t => t.Id == id));
            dBContext.SaveChanges();
        }
        public void EditTodo(Todo todo)
        {
            dBContext.Update(todo);
            dBContext.SaveChanges();
        }
        public List<Todo> Search(string input)
        { 
            return dBContext.Todos.Where(t => t.Title == input || t.Description == input).ToList();
        }
        public void AddAssignee(Assignee assignee)
        {
            dBContext.Assignees.Add(assignee);
            dBContext.SaveChanges();
        }
        public List<Assignee> Assignees()
        {
            return dBContext.Assignees.ToList();
        }
    }
}
