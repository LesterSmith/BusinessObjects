using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class MatchUnknown
    {
        /// <summary>
        /// the unknown value of the IDEMatch object is the key to populate this property
        /// </summary>
        public string UnknownValueKey { get; set; }
        /// <summary>
        /// This bool set to true if we write an unknown projectname to the Windowevent table
        /// so it can be updated after it is written
        /// </summary>
        public bool Unknown { get; set; }
    }
}
