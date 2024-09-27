using RacingNet.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Racing.Classes
{
    public abstract class Transport:IWeather
    {
        #region fields
        private Form _form;
        #endregion

        #region props
        protected int Speed { get; set; }
        public TypeTransport TypeTransports { get; set; }
        public int BadConditionWeather { get; set; }
        public abstract void RunToFinish(int distance);
        public int TimeToFinish { get; set; }
        #endregion

        #region props
        public Form Form 
        {
            get => _form;
            set
            {
                _form = value;
            }
        }
        #endregion
    }
}
