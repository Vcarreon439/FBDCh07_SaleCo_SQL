using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FBDCh07_SaleCo_SQL
{
    public partial class formNuevoCliente : Form
    {
        public formNuevoCliente()
        {
            InitializeComponent();
        }

        private void formNuevoCliente_Load(object sender, EventArgs e)
        {
            this.cUSTOMERBindingSource.AddNew();

            // TODO: esta línea de código carga datos en la tabla 'saleCo1DataSet.CUSTOMER' Puede moverla o quitarla según sea necesario.
            // this.cUSTOMERTableAdapter.Fill(this.saleCo1DataSet.CUSTOMER);

        }

        private void cUSTOMERBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.Validate())
            {
                try
                {
                    this.cUSTOMERBindingSource.EndEdit();
                    this.cUSTOMERTableAdapter.Update(this.saleCo1DataSet.CUSTOMER);
                }
                catch (Exception exception)
                {
                    MessageBox.Show($"Error :{exception.Message}");
                }
            }
            else
            {
                MessageBox.Show(this, "Error de validacion", "Gurdar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            this.Close();
        }

        private void cUS_CODETextBox_Validating(object sender, CancelEventArgs e)
        {
            if (cUS_CODETextBox.Text.Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(cUS_CODETextBox, "Introduzca el identificador del cliente");
            }
            else
            {
                errorProvider1.SetError(cUS_CODETextBox, null);
            }
        }

        private void cUS_LNAMETextBox_Validating(object sender, CancelEventArgs e)
        {
            if (cUS_LNAMETextBox.Text.Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(cUS_LNAMETextBox, "Introduzca el nombre del cliente");
            }
            else
            {
                errorProvider1.SetError(cUS_LNAMETextBox, null);
            }
        }

        private void cUS_FNAMETextBox_Validating(object sender, CancelEventArgs e)
        {
            if (cUS_FNAMETextBox.Text.Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(cUS_FNAMETextBox, "Introduzca el nombre del cliente");
            }
            else
            {
                errorProvider1.SetError(cUS_FNAMETextBox, null);
            }
        }

        private void cUS_INITIALTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (cUS_INITIALTextBox.Text.Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(cUS_INITIALTextBox, "Introduzca el nombre del cliente");
            }
            else
            {
                errorProvider1.SetError(cUS_INITIALTextBox, null);
            }
        }

        private void cUS_AREACODETextBox_Validating(object sender, CancelEventArgs e)
        {
            if (cUS_AREACODETextBox.Text.Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(cUS_AREACODETextBox, "Introduzca el nombre del cliente");
            }
            else
            {
                errorProvider1.SetError(cUS_AREACODETextBox, null);
            }
        }

        private void cUS_PHONETextBox_Validating(object sender, CancelEventArgs e)
        {
            if (cUS_PHONETextBox.Text.Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(cUS_PHONETextBox, "Introduzca el nombre del cliente");
            }
            else
            {
                errorProvider1.SetError(cUS_PHONETextBox, null);
            }
        }

        private void cUS_BALANCETextBox_Validating(object sender, CancelEventArgs e)
        {
            if (cUS_BALANCETextBox.Text.Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(cUS_BALANCETextBox, "Introduzca el nombre del cliente");
            }
            else
            {
                errorProvider1.SetError(cUS_BALANCETextBox, null);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cUS_AREACODETextBox.Text = "";
            cUS_BALANCETextBox.Text = "";
            cUS_CODETextBox.Text = "";
            cUS_FNAMETextBox.Text = "";
            cUS_INITIALTextBox.Text = "";
            cUS_LNAMETextBox.Text = "";
            cUS_PHONETextBox.Text = "";
        }
    }
}
