using Racing.Classes;
using RacingNet.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Racing.Entity
{
    public class AirShip : AirTransport
    {
        #region ctors
        public AirShip():base(20,5)
        {
            TypeTransports = TypeTransport.Air;
            BadConditionWeather = 5;
        }
        #endregion

        #region methods
        public override void RunToFinish(int distance)
        {
            var rnd = new Random();
            TimeToFinish -= Speed - BadConditionWeather + Boost - (distance - rnd.Next(1,distance));
        }

        public override string ToString()
        {
            return "Воздушный корабль";
        }
        #endregion
    }
}
