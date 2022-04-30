using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    internal class Operation : GuidID
    {
        public Guid ID { get; set; }
        public string Process_Name { get; set; } = string.Empty;
        public DateTime Time { get; set; }
        Operation()
        {
            ID = Guid.NewGuid();
            Time = DateTime.Now;
        }
    }
}
