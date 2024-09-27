using Racing.Classes;
using RacingNet.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing.Entity
{
    public class Izbushka : GroundTransport
    {
        #region ctors
        public Izbushka():base(10)
        {
            TypeTransports = TypeTransport.Ground;
            TimeMoveToDelay = 5;
            TimeDelay = 3;
        }
        #endregion

        #region methods
        public override void RunToFinish(int distance)
        {
            var round = distance / TimeMoveToDelay;
            for(int i=0;i<round;i++)
            {
                TimeToFinish -= Speed - TimeDelay - BadConditionWeather;
            }
        }

        public override string ToString()
        {
            return "Избушка на курьих ножках";
        }
        #endregion
    }
}
