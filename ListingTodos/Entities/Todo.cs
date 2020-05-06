using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ListingTodos.Entities
{
    public class Todo
    {
        [Key]
        public long Id { get; set; }
        [Required]
        public string Title { get; set; }
        [DefaultValue(false)]
        public bool IsUrgent { get; set; }
        [DefaultValue(false)]
        public bool IsDone { get; set; }
        public User User { get; set; }
        public Todo()
        {
        }
        public Todo(string title)
        {
            Title = title;
        }
    }
}
