using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_auto
{
    public partial class Form1 : Form
    {
        List<Auto> listautos = new List<Auto>();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs a)
        {

        }

        private void tbKilometraje_TextChanged(object sender, EventArgs i)
        {

        }

        private void btGuardar_Click(object sender, EventArgs eg)
        {
            if (cbMarca.SelectedIndex.Equals(-1)) {
                errorProvider1.SetError(cbMarca, "Debe Seleccionar una Marca");
                cbMarca.Focus();
                return;
            }
            errorProvider1.SetError(cbMarca, "");

            if (tbKilometraje.Text=="" )
            {
                errorProvider1.SetError(tbKilometraje, "Debe Ingresar una Ciudad de la Persona");
                tbKilometraje.Focus();
                return;
            }
            errorProvider1.SetError(tbKilometraje, "");

            if ( cbEstado.SelectedIndex.Equals(-1))
            {
                errorProvider1.SetError(cbEstado, "Debe Seleccionar un item");
                cbEstado.Focus();
                return;
            }
            errorProvider1.SetError(cbEstado, "");

            if (tbPrecio.Text=="")
            {
                errorProvider1.SetError(tbPrecio, "Debe Seleccionar un item");
                tbPrecio.Focus();
                return;
            }
            errorProvider1.SetError(tbPrecio, "");

            if (cbTransmision.SelectedIndex.Equals(-1))
            {
                errorProvider1.SetError(cbTransmision, "Debe Seleccionar un item");
                cbTransmision.Focus();
                return;
            }
            errorProvider1.SetError(cbTransmision, "");

            if(rbSi.Checked==false && rbNo.Checked==false)
            {
                // errorProvider1.SetError(rbSi, "Debe Ingresar un tipo");
                errorProvider1.SetError(rbNo, "Debe Ingresar un tipo");
                rbSi.Focus();
                rbNo.Focus();
                return;
            }
            errorProvider1.SetError(rbSi, "");
           errorProvider1.SetError(rbNo, "");

            
            Auto e = new Auto();//creado objeto de tipo auto
            e.marca = cbMarca.SelectedItem.ToString();
            e.kilometraje =int.Parse( tbKilometraje.Text);
            e.estado = cbEstado.SelectedItem.ToString();
            e.precio = int.Parse(tbPrecio.Text);
            e.transmision = cbTransmision.SelectedItem.ToString();
            if(rbSi.Checked==true){e.rines = true;}
            else
            if (rbNo.Checked ==true) { e.rines =false ; }

            //guardando en la lista

            listautos.Add(e);
            //mensaje de confirmacion
            MessageBox.Show("Guardado");

            //reiniciar valores
            cbMarca.SelectedIndex=-1;
            tbKilometraje.Clear();
            cbEstado.SelectedIndex=-1;
            tbPrecio.Clear();
            cbTransmision.SelectedIndex=-1;
            rbSi.Checked = false;
            rbNo.Checked = false;
        }

        private void btVer_Click(object sender, EventArgs ev)
        {
            //this.Hide();
            Form2 f2 = new Form2(listautos);
            f2.Show();

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
