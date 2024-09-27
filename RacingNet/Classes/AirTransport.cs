using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing.Classes
{
    public abstract class AirTransport:Transport
    {
        #region props
        public int Boost { get; set; }//Ускорение
        #endregion

        #region ctors
        protected AirTransport(int speed, int boost)
        {
            Speed = speed;
            Boost = boost;
        }
        #endregion
    }
}
