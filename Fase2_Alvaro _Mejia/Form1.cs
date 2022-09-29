using Fase2_Alvaro__Mejia.Properties;
using System.Security.Permissions;

namespace Fase2_Alvaro__Mejia
{
    public partial class frmclave : Form
    {
        public frmclave()
        {
            InitializeComponent();
        }

        private void btnvalidar_Click(object sender, EventArgs e)
        {
            if(txtclave.Text != "")
            {
                if (txtclave.Text == "123")
                {
                    Spa_Mascotas s = new Spa_Mascotas();
                    s.ShowDialog();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Digite la contraseña correcta");
                    txtclave.Focus();
                }
            }
            else
            {
                MessageBox.Show("Digite la contraseña");
                txtclave.Focus();
            }

        }

        private void txtclave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                 (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}