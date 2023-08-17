using System.Security.Cryptography.X509Certificates;

namespace CabInvoiceGenerator
{
  public  class Ride
    {
        public double distance;
        public int time;
        public Ridecategory.RideType ridecategory;
        public readonly int  MINMUM_FAIR;
        public readonly int COST_PER_MINUTE;
        public readonly int COST_PER_KM;

        public Ride(double distance,int time,Ridecategory.RideType ridecategory)
        {
            this.distance = distance;
            this.time = time;
            this.ridecategory = ridecategory;

            if (ridecategory.Equals(Ridecategory.RideType.NORMAl))
            {
                MINMUM_FAIR = 5;
                COST_PER_KM = 10;
                COST_PER_MINUTE = 1;

            }
            else
            {
                MINMUM_FAIR = 20;
                COST_PER_KM = 15;
                COST_PER_MINUTE = 2;
            }
        }
    }
}