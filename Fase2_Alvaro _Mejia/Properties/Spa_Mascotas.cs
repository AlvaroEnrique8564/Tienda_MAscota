using System.Windows.Forms;

namespace Fase2_Alvaro__Mejia.Properties
{
    public partial class Spa_Mascotas : Form
    {
        Spa spa = new Spa();

        
        public Spa_Mascotas()
        {
            InitializeComponent();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            btnguardar_Click(sender, e, spa);
        }

        private void btnguardar_Click(object sender, EventArgs e, Spa spa)
        {

            if (validar() == 1)
            {
                spa.identificacion = txtide.Text;
                spa.nomPro = txtnomP.Text;
                spa.nomMas = txtnomM.Text;
                if (opt1.Checked == true)
                {
                    spa.tipser = "45000";
                }
                if (opt2.Checked == true)
                {
                    spa.tipser = "80000";
                }
                if (opt3.Checked == true)
                {
                    spa.tipser = "100000";
                }

                try
                {
                    spa.estrato = int.Parse(estrato.Text);
                }
                catch (Exception)
                {

                }
                spa.getCosto();
                spa.getDescuento();
                txtcosS.Text = spa.getTotal().ToString();
                                
            }

        }

        public int validar()
        {
            int b = 0;
            if (txtide.Text == "")
            {
                MessageBox.Show("falta ingresar documento de identidad");
                txtide.Focus();
            }
            else if (txtnomP.Text == "")
            {
                MessageBox.Show("falta ingresar nombre propietario ");
                txtnomP.Focus();
            }
            else if (txtnomM.Text == "")
            {
                MessageBox.Show("falta ingresar nombre mascota ");
                txtnomM.Focus();
            }
            else if (estrato.Text == "")
            {
                MessageBox.Show("falta seleccionar estrato ");
                estrato.Focus();
            }
            else if (opt1.Checked == false && opt2.Checked == false && opt3.Checked == false)
            {
                MessageBox.Show("falta seleccionar tipo servicio ");
                gbxtipser.Focus();
            }
            b = 1;
            return b;

        }


        private void btnmostrar_Click(object sender, EventArgs e)
        {
            Resporte_de_Spa_Mascotas reporte = new Resporte_de_Spa_Mascotas();
            reporte.Show();
            reporte.txtNonRep.Text = spa.nomPro;
            reporte.txtIdentRep.Text = spa.identificacion;
            reporte.txtMasRep.Text = spa.nomMas;
            reporte.txtStrRep.Text = spa.estrato.ToString();
            reporte.txtTipRep.Text = spa.tipser;
            reporte.txtCosRep.Text = spa.getCosto().ToString();
            reporte.txtDecRep.Text = spa.getDescuento().ToString();
            reporte.txtfactura.Text = spa.getTotal().ToString();
           

        }

        private void txtide_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtnomP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {

                e.Handled = true;

            }
        }

        private void txtnomM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {

                e.Handled = true;

            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Esta seguro que desea salir del programa");
            Application.Exit();
        }
    }
}
