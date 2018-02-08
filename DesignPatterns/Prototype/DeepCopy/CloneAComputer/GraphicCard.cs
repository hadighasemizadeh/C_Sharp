using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDP
{
    public class GraphicCard:ICloneable
    {
        public decimal  GPUFrequency { get; set; }
        public int      GPURam { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
