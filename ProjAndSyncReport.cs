using System.Collections.Generic;
namespace BusinessObjects
{
    public class ProjAndSyncReport
    {
        public List<ReportProjects> Projects { get; set; }
        public List<ReportUserNames> Names { get; set; }
    }

    public class ReportProjects
    {
        public string DevProjectName { get; set; }
        public string DevProjectPath { get; set; }
        public string SyncID { get; set; }
        public string UserName { get; set; }
        public int DevProjectCount { get; set; }
        public string DevSLNPath { get; set; }
        public string GitURL { get; set; }
        public bool Selected { get; set; }
        public bool DatabaseProject { get; set; }
    }

    public class ReportUserNames
    {
        public string UserName { get; set; }
        public string DisplayName { get; set; }
    }
}
