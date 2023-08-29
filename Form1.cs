using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryCalvetPOO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmdCrear_Click(object sender, EventArgs e)
        {
            classPersonaje objeto = new classPersonaje();
            objeto.nombre=txtNombre.Text;
            objeto.fuerza= Convert.ToInt32(txtFuerza.Text);
            objeto.destreza= int.Parse(txtDestreza.Text);
            lblDatos.Text += objeto.nombre +" "+ objeto.fuerza +" "+ objeto.destreza+"\n";
        }
    }
}
