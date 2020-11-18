using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_auto
{

   public class Auto
    {
        private string Marca;
        private int Kilometraje;
        private string Estado;
        private int Precio;
        private string Transmision;
        private bool Rines;


       
        public string marca {get; set;     }
        public int kilometraje { get; set; }
        public string estado { get; set; }
        public int precio { get; set; }
        public string transmision { get; set; }
        public bool rines { get; set; }
    }
}
