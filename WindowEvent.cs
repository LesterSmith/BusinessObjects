using System;
namespace BusinessObjects
{
    public class WindowEvent 
    {
        public string ID { get; set; }
        public DateTime StartTime { get; set; }
        public string WindowTitle { get; set; }
        public string AppName { get; set; }
        public string ModuleName { get; set; }
        public DateTime EndTime { get; set; }
        public string DevProjectName { get; set; }
        public string ITProjectID { get; set; }
        public string UserName { get; set; }
        public string MachineName { get; set; }
        public string UserDisplayName { get; set; }
        public string SyncID { get; set; }
    }
}
