using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class ErrorLog
    {
        public string Module { get; set; }
        public string Method { get; set; }
        public string Message { get; set; }
        public DateTime DateCreated { get; set; }
        public string Machine { get; set; }
        public string Username { get; set; }
    }
}
