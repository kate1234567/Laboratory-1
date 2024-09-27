using Racing.Classes;
using RacingNet.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing.Entity
{
    public class Metla : AirTransport
    {
        #region ctors
        public Metla():base(11,3)
        {
            TypeTransports = TypeTransport.Air;
            BadConditionWeather = 1;
        }
        #endregion

        #region methods
        public override void RunToFinish(int distance)
        {
            var rnd = new Random();
            TimeToFinish -= Speed - BadConditionWeather + Boost - (distance - rnd.Next(1, distance));
        }

        public override string ToString()
        {
            return "Метла";
        }
        #endregion
    }
}
