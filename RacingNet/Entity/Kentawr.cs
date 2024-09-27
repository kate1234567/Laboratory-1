using Racing.Classes;
using RacingNet.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing.Entity
{
    public class Kentawr : GroundTransport
    {
        #region ctors
        public Kentawr():base(8)
        {
            TypeTransports = TypeTransport.Ground;
            TimeMoveToDelay = 30;
            TimeDelay = 1;
        }
        #endregion

        #region methods
        public override void RunToFinish(int distance)
        {
            var round = distance / TimeMoveToDelay;
            for (int i = 0; i < round; i++)
            {
                TimeToFinish -= Speed - TimeDelay - BadConditionWeather;
            }
        }

        public override string ToString()
        {
            return "Кентавр";
        }
        #endregion
    }
}
