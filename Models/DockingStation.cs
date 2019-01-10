using System;

namespace borisbikescs.Models
{
    public class DockingStation
    {
        dynamic borisbike;

        public Bike ReleaseBike()
        {
            if (this.borisbike.GetType() == typeof(Bike))
            {
                Console.WriteLine("Docking station releases a bike.");
                return this.borisbike;
            } 
            else
            {
                throw (new DockingStationHasNoBikesException("No bikes available"));
            }
        }

        public Bike Dock(Bike bike)
        {
            this.borisbike = bike;
            Console.WriteLine("Bike docked at the station.");
            return this.borisbike;
        }
    }
    public class DockingStationHasNoBikesException: Exception
    {
        public DockingStationHasNoBikesException(string message): base(message) {
        }
    }
}