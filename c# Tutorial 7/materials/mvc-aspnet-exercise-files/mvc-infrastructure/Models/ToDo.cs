using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvc_infrastructure.Models
{
    public class ToDo
    {
        public string Title { get; set; }
    }

    public static class ToDoList
    {
        static ToDoList()
        {
            Items = new List<ToDo>();
        }

        static public List<ToDo> Items { get; set; }
    }
}
