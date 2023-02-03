using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vizsgafeladat2
{
    public partial class Form1 : Form
    {
        BindingList<Entities.Termek> Termekek = new BindingList<Entities.Termek>();
        public Form1()
        {
            InitializeComponent();
            label1.Text = Resource1.Termeknev;
            label2.Text = Resource1.Ar;
            button1.Text = Resource1.Add;

            listBox1.DataSource = Termekek;
            listBox1.ValueMember = "Ar";
            listBox1.DisplayMember = "Termeknev";
                      
        }
    }
}
