using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication9
{
    class Task
    {
        public int id;
        public string title;
        public string description;
        public bool is_completed;

        public Task(int id, string title, string descr, bool completed)
        {
            this.id = id;
            this.title = title;
            this.description = descr;
            this.is_completed = completed;
        }
    }
}
