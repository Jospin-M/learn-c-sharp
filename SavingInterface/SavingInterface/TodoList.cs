using System;
using System.Collections.Generic;
using System.Text;

namespace SavingInterface
{
    internal class TodoList : IDisplayable, IResetable
    {
        public string[] Todos { get; private set; }
        private int nextOpenIndex;

        public TodoList()
        {
            Todos = new string[5];
            nextOpenIndex = 0;
        }

        public void Add(string todo)
        {
            Todos[nextOpenIndex] = todo;
            nextOpenIndex++;
        }

        public void Display()
        {
            foreach(string todo in Todos)
            {
                Console.WriteLine(todo);
            }
        }

        public void Reset()
        {
            Todos = [];
            nextOpenIndex = 0;
        }
    }
}
