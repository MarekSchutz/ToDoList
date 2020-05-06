﻿using ListingTodos.Entities;
using Microsoft.AspNetCore.Razor.Language.CodeGeneration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListingTodos.Models
{
    public class ViewModel
    {
        public Todo Todo { get; set; }
        public List<Todo> Todos { get; set; }
        public ViewModel()
        {

        }
        public ViewModel(List<Todo> todos)
        {
            Todos = todos;
        }
        public ViewModel(Todo todo)
        {
            Todo = todo;
        }
    }
}
