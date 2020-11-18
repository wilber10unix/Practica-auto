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

namespace Practica_auto
{
    public partial class Form2 : Form
    {
        List<Auto> miautos;
        public Form2(List<Auto> l)
        {
            miautos = l;
            InitializeComponent();
        }

        private void CbBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
           





            //Mostrar los elementos por Grupo
            switch (this.CbBuscar.SelectedItem)
            {
                case "Todos": //si selecciona Todos, Cargar la lista completa al DataGridView
                    this.DgvBuscar.DataSource = miautos;
                    break;

                /*
                * el metodo Where para filtrar objetos con expresiones lamda
                * y tambien podemos utilizar una consulta LINQ para obtener el mismo resultado
                * Descomenta la linea que usa LINQ y comenta la que usa Where().
                */
                case "Nissan": //Si selecciona el grupo A
                    var marca1 = miautos.Where(a => a.marca == "Nissan");
                    //var marca1 = from a in miautos where a.marca == "Nissan" select a;
                    this.DgvBuscar.DataSource = marca1.ToList();
                    break;

                case "Toyota":
                    var marca2 = miautos.Where(a => a.marca == "Toyota");
                    //var marca2 = from a in miautos where a.marca == "Toyota" select a;
                    this.DgvBuscar.DataSource = marca2.ToList();
                    break;

                case "Hyundai":
                    var marca3 = miautos.Where(a => a.marca == "Hyundai");
                    //var marca3 = from a in miautos where a.marca == "Hyundai" select a;
                    this.DgvBuscar.DataSource = marca3.ToList();
                    break;

                case "Kia":
                    var marca4 = miautos.Where(a => a.marca == "Kia");
                    //var marca4 = from a in miautos where a.marca == "Kia" select a;
                    this.DgvBuscar.DataSource = marca4.ToList();
                    break;

                case "Honda":
                    var marca5 = miautos.Where(a => a.marca == "Honda");
                    //var marca5 = from a in miautos where a.marca == "Honda" select a;
                    this.DgvBuscar.DataSource = marca5.ToList();
                    break;
            }
        }
       
                

            
           

        private void BtEliminar_Click(object sender, EventArgs e)
        {
            int fila = DgvBuscar.CurrentRow.Index;
            miautos.RemoveAt(fila);
            DgvBuscar.DataSource = null;
            DgvBuscar.DataSource = miautos;
        }

        private void DgvBuscar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int pos = DgvBuscar.CurrentRow.Index;
            
        }
        private void mostrartodo() {
            DgvBuscar.DataSource = miautos;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           CbBuscar.SelectedIndex=0;
        }
    }
}
