using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace BusinessObjects
{
    public class WinEventProcesss 
    {
        public DateTime Starttime { get; set; }
        public Process WEProcess { get; set; }
        public WindowEvent MyWindowEvent { get; set; }

    }
}
