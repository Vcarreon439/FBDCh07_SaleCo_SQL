
namespace FBDCh07_SaleCo_SQL
{
    partial class FormPadre
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BarraMenusFormPadre = new System.Windows.Forms.MenuStrip();
            this.nuevoCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoPedido = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarPedido = new System.Windows.Forms.ToolStripMenuItem();
            this.BarraMenusFormPadre.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarraMenusFormPadre
            // 
            this.BarraMenusFormPadre.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoCliente,
            this.mostrarPedido,
            this.nuevoPedido});
            this.BarraMenusFormPadre.Location = new System.Drawing.Point(0, 0);
            this.BarraMenusFormPadre.Name = "BarraMenusFormPadre";
            this.BarraMenusFormPadre.Size = new System.Drawing.Size(800, 24);
            this.BarraMenusFormPadre.TabIndex = 1;
            this.BarraMenusFormPadre.Text = "menuStrip1";
            // 
            // nuevoCliente
            // 
            this.nuevoCliente.Name = "nuevoCliente";
            this.nuevoCliente.Size = new System.Drawing.Size(94, 20);
            this.nuevoCliente.Text = "Nuevo Cliente";
            this.nuevoCliente.Click += new System.EventHandler(this.nuevoCliente_Click);
            // 
            // nuevoPedido
            // 
            this.nuevoPedido.Name = "nuevoPedido";
            this.nuevoPedido.Size = new System.Drawing.Size(99, 20);
            this.nuevoPedido.Text = "Realizar Pedido";
            this.nuevoPedido.Click += new System.EventHandler(this.nuevoPedido_Click);
            // 
            // mostrarPedido
            // 
            this.mostrarPedido.Name = "mostrarPedido";
            this.mostrarPedido.Size = new System.Drawing.Size(100, 20);
            this.mostrarPedido.Text = "Mostrar Pedido";
            this.mostrarPedido.Click += new System.EventHandler(this.mostrarPedido_Click);
            // 
            // FormPadre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BarraMenusFormPadre);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.BarraMenusFormPadre;
            this.Name = "FormPadre";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.BarraMenusFormPadre.ResumeLayout(false);
            this.BarraMenusFormPadre.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip BarraMenusFormPadre;
        private System.Windows.Forms.ToolStripMenuItem nuevoCliente;
        private System.Windows.Forms.ToolStripMenuItem nuevoPedido;
        private System.Windows.Forms.ToolStripMenuItem mostrarPedido;
    }
}

