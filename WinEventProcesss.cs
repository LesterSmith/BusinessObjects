using System;
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
