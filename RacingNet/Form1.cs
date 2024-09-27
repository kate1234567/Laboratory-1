using Racing.Classes;
using Racing.Entity;
using RacingNet.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RacingNet
{
    public partial class Form1 : Form
    {
        #region fields
        private int _distance;
        private Race _race;
        private List<Transport> _transports = new List<Transport>
        {
            new AirShip(),
            new BabaYaga(),
            new Izbushka(),
            new Kareta(),
            new Kentawr(),
            new Metla(),
            new Sapogi(),
        };
        private List<Transport> _participants = new List<Transport>();
        private TypeTransport _typeTransport;
        #endregion

        #region ctors
        public Form1()
        {
            InitializeComponent();
            foreach (var item in Enum.GetNames(typeof(TypeTransport)))
            {
                switch(item)
                {
                    case "Air":
                        comboBox1.Items.Add("Воздушные");
                        break;
                    case "Ground":
                        comboBox1.Items.Add("Наземные");
                        break;
                    case "All":
                    comboBox1.Items.Add("Все");
                        break;
                }
            }
            _distance = 10;
        }
        #endregion

        #region methods
        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem)
            {
                case "Наземные":
                    _race = new Race(_distance, TypeTransport.Ground, this);
                    _typeTransport = TypeTransport.Ground;
                    break;
                case "Воздушные":
                    _race = new Race(_distance, TypeTransport.Air, this);
                    _typeTransport = TypeTransport.Air;
                    break;
                case "Все":
                    _race = new Race(_distance, TypeTransport.All, this);
                    _typeTransport = TypeTransport.All;
                    break;
            }
            addTransportsToCB();
        }

        private void addTransportsToCB()
        {
            comboBox2.Items.Clear();
            foreach (var item in _transports)
            {
                if (_typeTransport == TypeTransport.All)
                {
                    comboBox2.Items.Add(item);
                }
                else
                {
                    if (item.TypeTransports == _typeTransport)
                    {
                        comboBox2.Items.Add(item);
                    }
                }
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            _distance = (int)numericUpDown1.Value;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var item = comboBox2.SelectedItem as Transport;
            item.Form = this;
            if (!_race.Transports.Contains(item))
            {
                listBox1.Items.Add(item);
                _race.Registry(item);
            }
            else
            {
                MessageBox.Show("Данный транспорт уже учавствует в гонке", "Ошибка");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            foreach (var item in _race.Transports)
            {
                item.TimeToFinish = 0;
                item.RunToFinish(_distance);
            }

            var index = 0;

            foreach (var item in _race.Transports.OrderByDescending(x => x.TimeToFinish))
            {
                listBox2.Items.Add($"{item.ToString()} - {++index} место");
            }
        }
        #endregion
    }
}
