using System;

namespace BusinessObjects
{
    public class FileChange
    {
        public string FullPath { get; set; }
        public string CurrentApp { get; set; }
        public string ChangeType { get; set; }
        public string ProjectName { get; set; }
        public DateTime WindowsStartTime { get; set; }
        public string CurrentWindowID { get; set; }
    }
}
