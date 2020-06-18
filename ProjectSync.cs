using System;

namespace BusinessObjects
{
    public class ProjectSync : BusinessObjectBase
    {
        public string ID { get; set; }
        public string DevProjectName { get; set; }
        public DateTime CreatedDate { get; set; }
        public int DevProjectCount { get; set; }
        public string GitURL { get; set; }
        public bool Selected { get; set; }
    }
}
