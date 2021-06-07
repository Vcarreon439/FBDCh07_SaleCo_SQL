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
    public partial class formRealizarPedido : Form
    {
        public formRealizarPedido()
        {
            InitializeComponent();
        }

        private void lINEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lINEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.saleCo1DataSet);

        }

        private void formRealizarPedido_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'saleCo1DataSet.LINE' Puede moverla o quitarla según sea necesario.
            this.lINETableAdapter.Fill(this.saleCo1DataSet.LINE);

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.Validate())
            {
                try
                {
                    this.lINEBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.saleCo1DataSet);
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error:" + ex.Message);
                }
            }
            else
            {
                MessageBox.Show(this, "Error de validacion", "Guradar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            this.Close();
        }

        private void iNV_NUMBERTextBox_Validating(object sender, CancelEventArgs e)
        {

        }
    }
}
