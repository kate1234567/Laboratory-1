using Racing.Classes;
using RacingNet.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing.Entity
{
    public class Sapogi : GroundTransport
    {
        #region ctors
        public Sapogi():base(13)
        {
            TypeTransports = TypeTransport.Ground;
            TimeMoveToDelay = 9;
            TimeDelay = 3;
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
            return "Сапоги-скороходы";
        }
        #endregion
    }
}
