using System;
using System.Collections.Generic;

namespace BusinessObjects
{
    /// <summary>
    /// The number of Projects and Users will be determined
    /// for Project and User reports by the presence of "All"
    /// in the project or user parameter
    /// </summary>
    /// 
    public enum ReportType
    {
        None = 0,
        ProjectSummaryByUser = 1,
        DeveloperDetail = 2,
        ApplicationUsage = 3,
        ProjectSummaryByProject = 4,
        ProjectDetail = 5
    }

    public class ReporterParms
    {
        public ReportType Type { get; set; }
        public string FileName { get; set; }
        public ReportHdr Header { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
    }
    public class ReportHdr
    {
        public string HdrRange { get; set; }
        public string Title { get; set; }
        public string TitleCell { get; set; }
        public List<ColHdr> Hdrs { get; set; }
    }

    public class ColHdr
    {
        public string Header { get; set; }
        public double Width { get; set; }
    }

}
