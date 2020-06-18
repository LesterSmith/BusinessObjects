using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class IDEMatch
    {
        public string ID { get; set; }
        public string Regex { get; set; }
        public string RegexGroupName { get; set; }
        public string UnknownValue { get; set; }
        public string AppName { get; set; }
        public string ProjNameReplaces { get; set; }
        public string ProjNameConcat { get; set; }
        public string ConcatChar { get; set; }
        public bool IsIde { get; set; }
        public bool DBUnknown { get; set; }
        public string Description { get; set; }
        public string AlternateProjName { get; set; }
        public int Sequence { get; set; }
        public bool IsDBEngine { get; set; }

    }
}
