using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing.Classes
{
    public abstract class GroundTransport : Transport
    {
        #region fields
        private int _iterDelay;//итерация остановки
        #endregion

        #region ctors
        protected GroundTransport(int speed)
        {
            Speed = speed;
        }
        #endregion

        #region props
        public int TimeMoveToDelay { get; set; }//Время движения до остановки
        public int TimeDelay { get => ++_iterDelay; set { _iterDelay = value; } }//Время остановки
        #endregion
    }
}
