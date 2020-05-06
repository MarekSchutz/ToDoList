using ListingTodos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListingTodos.Interfaces
{
    public interface ITodoService
    {
        List<Todo> Todos();
        Todo GetTodo(long id);
        List<Todo> CheckTodos(string isDone);
        void CreateTodo(Todo todo);
        void DeleteTodo(long id);
        void EditTodo(Todo todo);
        List<Todo> Search(string input);
        void AddAssignee(Assignee assignee);
        List<Assignee> Assignees();
    }
}
