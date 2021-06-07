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
    public partial class FormPadre : Form
    {
        public FormPadre()
        {
            InitializeComponent();
        }

        private void nuevoCliente_Click(object sender, EventArgs e)
        {
            formNuevoCliente nuevoCliente;
            nuevoCliente = new formNuevoCliente();
            nuevoCliente.Text = "Form" + MdiChildren.Length.ToString();
            nuevoCliente.MdiParent = this;
            nuevoCliente.Show();
        }

        private void nuevoPedido_Click(object sender, EventArgs e)
        {
            formRealizarPedido RealizarPedido;
            RealizarPedido = new formRealizarPedido();
            RealizarPedido.Text = "Form" + MdiChildren.Length.ToString();
            RealizarPedido.MdiParent = this;
            RealizarPedido.Show();
        }

        private void mostrarPedido_Click(object sender, EventArgs e)
        {
            formMostrarPedido MostrarPedido;
            MostrarPedido = new formMostrarPedido();
            MostrarPedido.Text = "Form" + MdiChildren.Length.ToString();
            MostrarPedido.MdiParent = this;
            MostrarPedido.Show();
        }
    }
}
