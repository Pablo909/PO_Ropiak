using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace C07
{
    class NaszWyjatekException : SystemException
    {
        NaszWyjatekException(string message) : base(message)
        {

        }
        NaszWyjatekException(String message, Exception innerException) : base(message, innerException)
        { 
        
        }
        NaszWyjatekException(SerializationInfo info, StreamingContext context) : base(info, context)
        { 
        
        }

    }
}
