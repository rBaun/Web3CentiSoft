using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public class Developer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Task> Tasks { get; set; }
    }
}
