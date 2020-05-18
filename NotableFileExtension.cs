using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class NotableFileExtension
    {
        public string ID { get; set; }
        public string Extension { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string IDEProjectExtension { get; set; }
        public bool CountLines { get; set; }
    }
}
