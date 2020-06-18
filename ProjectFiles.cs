using System;

namespace BusinessObjects
{
    public class ProjectFiles
    {
        public string ID { get; set; }
        public string DevProjectName { get; set; }
        public string RelativeFileName { get; set; }
        public string SyncID { get; set; }
        public string GitURL { get; set; }
        public int CodeLines { get; set; }
        public int CommentLines { get; set; }
        public int BlankLines { get; set; }
        public int DesignerLines { get; set; }
        public int UpdateCount { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastUpdate { get; set; }
        public string LastUpdatedBy { get; set; }

    }
}
