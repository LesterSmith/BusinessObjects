using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class CalendarMeeting
    {
        #region public members
        public string ID { get; set; }
        public string Subject { get; set; }
        public string Organizer { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public bool Recurring { get; set; }
        public string UserName { get; set; }
        public string UserDisplayName { get; set; }
        #endregion // public members

    }
}
