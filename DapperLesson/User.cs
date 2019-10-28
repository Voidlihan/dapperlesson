using System;
using System.Collections.Generic;
using System.Text;

namespace DapperLesson
{
    public class User
    {
        public Guid Id { get; set; }
        public DateTime CreationDate { get; set; }
        public string Login { get; set; }
        public int AttemptCount { get; set; }
    }
}
