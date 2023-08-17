using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class CabInvoiceException: Exception
    { public ExceptionType exceptionType;
            public enum ExceptionType
        {
            INVALID_DISTANE,
            INVAID_TIME
        }
        public CabInvoiceException(string message ,ExceptionType exceptionType) : base(message) 
        { 
        this.exceptionType = exceptionType;
         }
    }
}
