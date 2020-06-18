using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class FileActivity
    {
        public string ID { get; set; }
        public string Machine { get; set; }
        public string DevProjName { get; set; }
        public string Filename { get; set; }
        public string Username { get; set; }
        public long FileLength { get; set; }
        public string LastAction { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastUpdate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public int UpdateCount { get; set; }
        public bool Deleted { get; set; }
        public string DevProjectPath { get; set; }
        public int CodeLines { get; set; }
        public int BlankLines { get; set; }
        public int CommentLines { get; set; }
        public int DesignerLines { get; set; }
        public string SyncID { get; set; }
    }
}
