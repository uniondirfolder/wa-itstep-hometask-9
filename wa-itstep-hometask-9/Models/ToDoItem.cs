using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace wa_itstep_hometask_9.Models
{
    public class TodoItem
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime Deadline { get; set; }
        public bool IsComplete { get; set; }
        public string Category { get; set; }
        public string Lable { get; set; }
    }
}
