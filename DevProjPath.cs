using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class DevProjPath
    {
        public string ID { get; set; }
        public string DevProjectName { get; set; }
        public string DevProjectPath { get; set; }
        public string Machine { get; set; }
        public string UserName { get; set; }
        public string IDEAppName { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime CompletedDate { get; set; }
        public bool DatabaseProject { get; set; }
        public string SyncID { get; set; }
        public string ProjFileExt { get; set; }
        public string DevSLNPath { get; set; }
        public string GitURL { get; set; }
        public bool CountLines { get; set; }
        public bool Selected { get; set; }

    }
}
