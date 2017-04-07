using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflex.Data
{
   public enum RecordTypes
    {
        MessageHeader = 00,
        RecordAndAutoCreadit = 10,
        RecordAndRentas = 20,
        RecordAndIBG = 30,
        RecordAndCheckMegaPay=40,
        MessageFooter=99
    }
}
