using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{

    public partial class Form1 : Form
    {
        ArrayList listPorts = new ArrayList();
        public Form1()
        {
            InitializeComponent();
            comboBoxPrichal.SelectedIndexChanged += prichal_SelectedIndexChanged;
            comboBoxPort.SelectedIndexChanged+= port_SelectedIndexChanged;
        }
        void prichal_SelectedIndexChanged(object sender, EventArgs e) {
            Prichal prichal = getSelectedPrichal();
            showPrichal(prichal);
        }

        private void showPrichal(Prichal prichal)
        {
            textNumTech.Text = prichal.numTechnick.ToString();
            textNumPeople.Text = prichal.numPeople.ToString();
        }

        private void addPortBtn_Click(object sender, EventArgs e)
        {

            Port port = new Port(
                textBoxPortName.Text.ToString(),
                textBoxAddress.Text.ToString(),
                Double.Parse(textBoxTechnicCoast.Text.ToString()),
                Double.Parse(textBoxShipCost.Text.ToString()),
                Double.Parse(textBoxShipTime.Text.ToString()),
                Int32.Parse(textBoxNumPrichal.Text.ToString())
                );
            listPorts.Add(port);
            comboBoxPort.Items.Add(port.name);
            clearText();
        }
        void port_SelectedIndexChanged(object sender, EventArgs e)
        {
            Port port = getSelectedPort();
            showPort(port);
            showPrichals();
        }
        Port getSelectedPort() {
            string currentPortName = comboBoxPort.SelectedItem.ToString();
            for (int i = 0; i < listPorts.Count; i++) {
                if ((listPorts[i] as Port).name.Equals(currentPortName)) {
                    return listPorts[i] as Port;
                }
            }
            return null;
        }
        Prichal getSelectedPrichal() { 
            string currentPrichalName = comboBoxPrichal.SelectedItem.ToString();
            Port port=getSelectedPort();
            ArrayList prichals = port.arrayPrichals;
            for (int i = 0; i < prichals.Count; i++) {
                if (currentPrichalName.Equals((prichals[i] as Prichal).name)) {
                    return prichals[i] as Prichal;
                }
            }
            return null;
        }
        void showPort(Port port) {
            textBoxPortName.Text=port.name;
            textBoxAddress.Text =port.address;
            textBoxShipCost.Text = port.costShip.ToString();
            textBoxShipTime.Text = port.timeShip.ToString();
            textBoxTechnicCoast.Text = port.costTech.ToString();
            textBoxNumPrichal.Text = port.getNumPrichals().ToString();
        }
        void clearText() {
            textBoxPortName.Text        ="";
            textBoxAddress.Text         ="";
            textBoxShipCost.Text        ="";
            textBoxShipTime.Text        ="";
            textBoxTechnicCoast.Text    ="";
            textBoxNumPrichal.Text = "";
        }
        void showPrichals() {
            comboBoxPrichal.Items.Clear();
            ArrayList prichals = getSelectedPort().arrayPrichals;
            for (int i = 0; i < prichals.Count; i++) {
                comboBoxPrichal.Items.Add((prichals[i] as Prichal).name);
            }
        
        }
        private void deletePortBtn_Click(object sender, EventArgs e)
        {
            string currentPortName = comboBoxPort.SelectedItem.ToString();
            for (int i = 0; i<listPorts.Count; i++) {
                if ((listPorts[i] as Port).name.Equals(currentPortName)) {
                    listPorts.RemoveAt(i);
                    comboBoxPort.Items.RemoveAt(i);
                    clearText();
                    return;
                }
            }
            comboBoxPrichal.Items.Clear();
        }

        private void savePortBtn_Click(object sender, EventArgs e)
        {
            string currentPortName = comboBoxPort.SelectedItem.ToString();
            for (int i = 0; i < listPorts.Count; i++)
            {
                Port port = listPorts[i] as Port;
                if ((port).name.Equals(currentPortName))
                {
                    port.name      =  textBoxPortName.Text    ;
                    port.address   =  textBoxAddress.Text     ;
                    port.costShip  =  Double.Parse(textBoxShipCost.Text)    ;
                    port.costTech  = Double.Parse(textBoxShipTime.Text  )  ;
                    port.timeShip = Double.Parse(textBoxTechnicCoast.Text);
                    comboBoxPort.Items[i] = port.name;
                    clearText();

                    return;
                }
            }
        }

        private void addPrichalBtn_Click(object sender, EventArgs e)
        {
            Port port = getSelectedPort();
            port++;
            showPrichals();
        }

        private void deletePrichal_Click(object sender, EventArgs e)
        {
            string currentPrichalName = comboBoxPrichal.SelectedItem.ToString();
            Port port = getSelectedPort();
            ArrayList prichals = port.arrayPrichals;
            for (int i = 0; i < prichals.Count; i++)
            {
                if (currentPrichalName.Equals((prichals[i] as Prichal).name))
                {
                    prichals.RemoveAt(i);
                    comboBoxPrichal.Items.RemoveAt(i);
                    textNumPeople.Text = "";
                    textNumTech.Text = "";
                }
            }
        }

        private void savePrichal_Click(object sender, EventArgs e)
        {
            string currentPrichalName = comboBoxPrichal.SelectedItem.ToString();
            Port port = getSelectedPort();
            ArrayList prichals = port.arrayPrichals;
            for (int i = 0; i < prichals.Count; i++)
            {
                if (currentPrichalName.Equals((prichals[i] as Prichal).name))
                {
                    Prichal p=prichals[i] as Prichal;
                    p.numPeople = Int32.Parse(textNumPeople.Text);
                    p.numTechnick = Int32.Parse(textNumTech.Text);
                }
            }
        }
        
    }
    class Port
    {
        public string name;
        public string address;
        public double costTech;
        public double costShip;
        public double timeShip;
        private int lastPrichalID = 0;
        public ArrayList arrayPrichals = new ArrayList();
        public Port(string _name,
            string _address,
           double _costTech,
            double _costShip,

            double _timeShip,
            int _numPrichals
            )
        {
            name = _name;
            address = _address;
            costShip = _costShip;
            timeShip = _timeShip;
            costTech = _costTech;

            for (int i = 0; i < _numPrichals; i++)
            {
                addPrichal();
            }
        }
        private void addPrichal()
        {
            Prichal p = new Prichal("Prichal" + lastPrichalID.ToString(), 5, 15);
            arrayPrichals.Add(p);
            lastPrichalID++;
        }
        public int getNumPrichals()
        {
            return arrayPrichals.Count;
        }
        public int getNumPeople()
        {
            return 0;
        }
        public int getNumTechnick()
        {
            return 0;
        }
        public static Port operator ++(Port p) {
            p.addPrichal();
            return p;
        }
        public static Boolean operator >= (Port p1, Port p2)
        {
           
            return p1.arrayPrichals.Count>= p2.arrayPrichals.Count;
        }
        public static Boolean operator <=(Port p1, Port p2)
        {
            return p1.arrayPrichals.Count <= p2.arrayPrichals.Count;

        }
    }
    class Prichal
    {
        public string name;
        public int numTechnick;
        public int numPeople;
        public Prichal(string _name, int _numTechnick, int _numPeople)
        {
            name = _name;
            numTechnick = _numTechnick;
            numPeople = _numPeople;
        }
    }
}
