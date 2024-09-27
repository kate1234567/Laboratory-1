using Racing.Classes;
using RacingNet.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing.Entity
{
    public class Kareta : GroundTransport
    {
        #region ctors
        public Kareta():base(14)
        {
            TypeTransports = TypeTransport.Ground;
            TimeMoveToDelay = 8;
            TimeDelay = 4;
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
            return "Карета-тыква";
        }
        #endregion
    }
}
