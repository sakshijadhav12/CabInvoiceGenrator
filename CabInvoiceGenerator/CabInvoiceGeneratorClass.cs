using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class CabInvoiceGeneratorClass
    { public  double CalculateFair(Ride ride)
        {
            double totalFair = 0;
            if(ride.distance<=0)
            {
                throw new CabInvoiceException("INVALID DISTANCE",CabInvoiceException.ExceptionType.INVALID_DISTANE);
            }
            else if(ride.time<=0)
            {
                throw new CabInvoiceException("INVALID TIME", CabInvoiceException.ExceptionType.INVAID_TIME);
            }
            else
            {
                totalFair = ride.distance * ride.COST_PER_KM + ride.time * ride.COST_PER_MINUTE;
                return Math.Max(ride.MINMUM_FAIR, totalFair);
            }
     
        }
    }
}
