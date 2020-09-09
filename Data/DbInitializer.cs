using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using toDoListProj.Models;


namespace toDoListProj.Data
{
    public static class DbInitializer
    {
        public static void Initialize(TodoContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.TodoItems.Any())
            {
                return;   // DB has been seeded
            }

            var ToDoItems = new TodoItem[]
            {
            new TodoItem{ID=1,Task="do some laundry",IsComplete=true},
            new TodoItem{ID=2,Task="do the washing up",IsComplete=false},
            new TodoItem{ID=3,Task="do some chores",IsComplete=true},
            new TodoItem{ID=4,Task="just do something",IsComplete=true},
            new TodoItem{ID=5,Task="cmon get sorted",IsComplete=false},
            new TodoItem{ID=6,Task="get things going",IsComplete=false},
            new TodoItem{ID=7,Task="do this",IsComplete=true},
            new TodoItem{ID=8,Task="do that",IsComplete=true}
            };
            foreach (TodoItem s in ToDoItems)
            {
                context.TodoItems.Add(s);
            }
            context.SaveChanges();
        }
    }
}