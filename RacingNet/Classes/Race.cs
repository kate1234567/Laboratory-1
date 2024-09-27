using RacingNet.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Racing.Classes.Transport;

namespace Racing.Classes
{
    public class Race
    {
        #region props
        public int Distance { get; set; }
        public List<Transport>Transports { get; set; }
        public TypeTransport TypeTransport { get; set; }
        public Form MainForm { get; set; }
        #endregion

        #region ctors
        public Race(int distance, TypeTransport typeTransport, Form form)
        {
            Distance = distance;
            TypeTransport = typeTransport;
            MainForm = form;
            Transports = new List<Transport>();
        }
        #endregion

        #region methods
        public void Registry(Transport transport)
        {
            Transports.Add(transport);
        }
        #endregion
    }


}
