    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class ProjectSync : BusinessObjectBase
    {
        #region public members
        public string ID { get; set; }
        public string DevProjectName { get; set; }
        public DateTime CreatedDate { get; set; }
        public int DevProjectCount { get; set; }
        public string GitURL { get; set; }
        #endregion // public members
    }
}
