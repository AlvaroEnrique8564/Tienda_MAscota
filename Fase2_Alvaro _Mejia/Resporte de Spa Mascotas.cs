using Fase2_Alvaro__Mejia.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fase2_Alvaro__Mejia
{
    public partial class Resporte_de_Spa_Mascotas : Form
    {
        public Resporte_de_Spa_Mascotas()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            Spa_Mascotas p = new Spa_Mascotas();
            p.Show();
            this.Hide();

        }
    }
}
