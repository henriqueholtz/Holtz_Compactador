using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holtz_Compactador
{
    class CompactorException : Exception
    {
        public CompactorException(string msg) : base(msg)
        {
        }
    }
}
