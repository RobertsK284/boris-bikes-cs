using System;

namespace borisbikescs.Models
{
    public class DockingStation
    {
        Bike borisbike;

        public Bike ReleaseBike()
        {
            return this.borisbike;
        }

        public Bike Dock(Bike bike)
        {
            this.borisbike = bike;
            return this.borisbike;
        }
    }
}