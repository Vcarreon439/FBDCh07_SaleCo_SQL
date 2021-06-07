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
    public partial class formMostrarPedido : Form
    {
        public formMostrarPedido()
        {
            InitializeComponent();
        }

        private void formMostrarPedido_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'saleCo1DataSet.INVOICE' Puede moverla o quitarla según sea necesario.
            this.iNVOICETableAdapter.Fill(this.saleCo1DataSet.INVOICE);

        }

        private void btnRealizar_Click(object sender, EventArgs e)
        {
            if (this.Validate())
            {
                try
                {
                    this.iNVOICEBindingSource.EndEdit();
                    this.iNVOICETableAdapter.Update(this.saleCo1DataSet.INVOICE);
                }
                catch (Exception exception)
                {
                    MessageBox.Show($"Error :{exception.Message}");
                }
            }
            else
            {
                MessageBox.Show(this, "Error de validacion", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            this.Close();
        }

        private void iNV_NUMBERTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (iNV_NUMBERTextBox.Text.Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(iNV_NUMBERTextBox, "Introduzca el identificador del cliente");
            }
            else
            {
                errorProvider1.SetError(iNV_NUMBERTextBox, null);
            }
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
    }
}
