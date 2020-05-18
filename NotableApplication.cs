using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class NotableApplication
    {
        #region public members
        public string ID { get; set; }
        public string AppName { get; set; }
        public string AppFriendlyName { get; set; }
        /// <summary>
        /// explorer is Windows, except when the WindowTitle is
        /// File Explorer, then it is the file explorer, we
        /// would only want to record in db explorer when it is the File Explorer
        /// and maybe not even then
        /// </summary>
        public string InterestingTitle { get; set; }
        public bool Selected { get; set; }
        #endregion // public members

    }
}
