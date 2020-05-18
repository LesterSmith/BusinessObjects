using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class ProjectName
    {
        public string WindowTitle { get; set; }
        public string ProjName { get; set; }
        public string ProjDescription { get; set; }
        public string AppName { get; set; }
        public List<string> Keywords { get; set; }
    }
}
