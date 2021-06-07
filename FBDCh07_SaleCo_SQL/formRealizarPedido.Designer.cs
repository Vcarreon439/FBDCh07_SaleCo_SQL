
namespace FBDCh07_SaleCo_SQL
{
    partial class formRealizarPedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iNV_NUMBERLabel;
            System.Windows.Forms.Label lINE_NUMBERLabel;
            System.Windows.Forms.Label p_CODELabel;
            System.Windows.Forms.Label lINE_UNITSLabel;
            System.Windows.Forms.Label lINE_PRICELabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formRealizarPedido));
            this.saleCo1DataSet = new FBDCh07_SaleCo_SQL.SaleCo1DataSet();
            this.lINEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lINETableAdapter = new FBDCh07_SaleCo_SQL.SaleCo1DataSetTableAdapters.LINETableAdapter();
            this.tableAdapterManager = new FBDCh07_SaleCo_SQL.SaleCo1DataSetTableAdapters.TableAdapterManager();
            this.lINEBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lINEBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iNV_NUMBERTextBox = new System.Windows.Forms.TextBox();
            this.lINE_NUMBERTextBox = new System.Windows.Forms.TextBox();
            this.p_CODETextBox = new System.Windows.Forms.TextBox();
            this.lINE_UNITSTextBox = new System.Windows.Forms.TextBox();
            this.lINE_PRICETextBox = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            iNV_NUMBERLabel = new System.Windows.Forms.Label();
            lINE_NUMBERLabel = new System.Windows.Forms.Label();
            p_CODELabel = new System.Windows.Forms.Label();
            lINE_UNITSLabel = new System.Windows.Forms.Label();
            lINE_PRICELabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.saleCo1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lINEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lINEBindingNavigator)).BeginInit();
            this.lINEBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // iNV_NUMBERLabel
            // 
            iNV_NUMBERLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            iNV_NUMBERLabel.AutoSize = true;
            iNV_NUMBERLabel.Location = new System.Drawing.Point(16, 17);
            iNV_NUMBERLabel.Name = "iNV_NUMBERLabel";
            iNV_NUMBERLabel.Size = new System.Drawing.Size(78, 13);
            iNV_NUMBERLabel.TabIndex = 1;
            iNV_NUMBERLabel.Text = "INV NUMBER:";
            // 
            // lINE_NUMBERLabel
            // 
            lINE_NUMBERLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            lINE_NUMBERLabel.AutoSize = true;
            lINE_NUMBERLabel.Location = new System.Drawing.Point(16, 43);
            lINE_NUMBERLabel.Name = "lINE_NUMBERLabel";
            lINE_NUMBERLabel.Size = new System.Drawing.Size(84, 13);
            lINE_NUMBERLabel.TabIndex = 3;
            lINE_NUMBERLabel.Text = "LINE NUMBER:";
            // 
            // p_CODELabel
            // 
            p_CODELabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            p_CODELabel.AutoSize = true;
            p_CODELabel.Location = new System.Drawing.Point(16, 69);
            p_CODELabel.Name = "p_CODELabel";
            p_CODELabel.Size = new System.Drawing.Size(50, 13);
            p_CODELabel.TabIndex = 5;
            p_CODELabel.Text = "P CODE:";
            // 
            // lINE_UNITSLabel
            // 
            lINE_UNITSLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            lINE_UNITSLabel.AutoSize = true;
            lINE_UNITSLabel.Location = new System.Drawing.Point(16, 95);
            lINE_UNITSLabel.Name = "lINE_UNITSLabel";
            lINE_UNITSLabel.Size = new System.Drawing.Size(70, 13);
            lINE_UNITSLabel.TabIndex = 7;
            lINE_UNITSLabel.Text = "LINE UNITS:";
            // 
            // lINE_PRICELabel
            // 
            lINE_PRICELabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            lINE_PRICELabel.AutoSize = true;
            lINE_PRICELabel.Location = new System.Drawing.Point(16, 121);
            lINE_PRICELabel.Name = "lINE_PRICELabel";
            lINE_PRICELabel.Size = new System.Drawing.Size(69, 13);
            lINE_PRICELabel.TabIndex = 9;
            lINE_PRICELabel.Text = "LINE PRICE:";
            // 
            // saleCo1DataSet
            // 
            this.saleCo1DataSet.DataSetName = "SaleCo1DataSet";
            this.saleCo1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lINEBindingSource
            // 
            this.lINEBindingSource.DataMember = "LINE";
            this.lINEBindingSource.DataSource = this.saleCo1DataSet;
            // 
            // lINETableAdapter
            // 
            this.lINETableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CUSTOMERTableAdapter = null;
            this.tableAdapterManager.INVOICETableAdapter = null;
            this.tableAdapterManager.LINETableAdapter = this.lINETableAdapter;
            this.tableAdapterManager.PRODUCTTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = FBDCh07_SaleCo_SQL.SaleCo1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VENDORTableAdapter = null;
            // 
            // lINEBindingNavigator
            // 
            this.lINEBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.lINEBindingNavigator.BindingSource = this.lINEBindingSource;
            this.lINEBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.lINEBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.lINEBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.lINEBindingNavigatorSaveItem});
            this.lINEBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.lINEBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.lINEBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.lINEBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.lINEBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.lINEBindingNavigator.Name = "lINEBindingNavigator";
            this.lINEBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.lINEBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.lINEBindingNavigator.TabIndex = 0;
            this.lINEBindingNavigator.Text = "bindingNavigator1";
            this.lINEBindingNavigator.Visible = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // lINEBindingNavigatorSaveItem
            // 
            this.lINEBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lINEBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("lINEBindingNavigatorSaveItem.Image")));
            this.lINEBindingNavigatorSaveItem.Name = "lINEBindingNavigatorSaveItem";
            this.lINEBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.lINEBindingNavigatorSaveItem.Text = "Guardar datos";
            this.lINEBindingNavigatorSaveItem.Click += new System.EventHandler(this.lINEBindingNavigatorSaveItem_Click);
            // 
            // iNV_NUMBERTextBox
            // 
            this.iNV_NUMBERTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iNV_NUMBERTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lINEBindingSource, "INV_NUMBER", true));
            this.iNV_NUMBERTextBox.Location = new System.Drawing.Point(106, 14);
            this.iNV_NUMBERTextBox.Name = "iNV_NUMBERTextBox";
            this.iNV_NUMBERTextBox.Size = new System.Drawing.Size(100, 20);
            this.iNV_NUMBERTextBox.TabIndex = 2;
            this.iNV_NUMBERTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.iNV_NUMBERTextBox_Validating);
            // 
            // lINE_NUMBERTextBox
            // 
            this.lINE_NUMBERTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lINE_NUMBERTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lINEBindingSource, "LINE_NUMBER", true));
            this.lINE_NUMBERTextBox.Location = new System.Drawing.Point(106, 40);
            this.lINE_NUMBERTextBox.Name = "lINE_NUMBERTextBox";
            this.lINE_NUMBERTextBox.Size = new System.Drawing.Size(100, 20);
            this.lINE_NUMBERTextBox.TabIndex = 4;
            // 
            // p_CODETextBox
            // 
            this.p_CODETextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p_CODETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lINEBindingSource, "P_CODE", true));
            this.p_CODETextBox.Location = new System.Drawing.Point(106, 66);
            this.p_CODETextBox.Name = "p_CODETextBox";
            this.p_CODETextBox.Size = new System.Drawing.Size(100, 20);
            this.p_CODETextBox.TabIndex = 6;
            // 
            // lINE_UNITSTextBox
            // 
            this.lINE_UNITSTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lINE_UNITSTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lINEBindingSource, "LINE_UNITS", true));
            this.lINE_UNITSTextBox.Location = new System.Drawing.Point(106, 92);
            this.lINE_UNITSTextBox.Name = "lINE_UNITSTextBox";
            this.lINE_UNITSTextBox.Size = new System.Drawing.Size(100, 20);
            this.lINE_UNITSTextBox.TabIndex = 8;
            // 
            // lINE_PRICETextBox
            // 
            this.lINE_PRICETextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lINE_PRICETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lINEBindingSource, "LINE_PRICE", true));
            this.lINE_PRICETextBox.Location = new System.Drawing.Point(106, 118);
            this.lINE_PRICETextBox.Name = "lINE_PRICETextBox";
            this.lINE_PRICETextBox.Size = new System.Drawing.Size(100, 20);
            this.lINE_PRICETextBox.TabIndex = 10;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(131, 165);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(50, 165);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 13;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // formRealizarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 207);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(iNV_NUMBERLabel);
            this.Controls.Add(this.iNV_NUMBERTextBox);
            this.Controls.Add(lINE_NUMBERLabel);
            this.Controls.Add(this.lINE_NUMBERTextBox);
            this.Controls.Add(p_CODELabel);
            this.Controls.Add(this.p_CODETextBox);
            this.Controls.Add(lINE_UNITSLabel);
            this.Controls.Add(this.lINE_UNITSTextBox);
            this.Controls.Add(lINE_PRICELabel);
            this.Controls.Add(this.lINE_PRICETextBox);
            this.Controls.Add(this.lINEBindingNavigator);
            this.Name = "formRealizarPedido";
            this.Text = "Realizar Pedido";
            this.Load += new System.EventHandler(this.formRealizarPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.saleCo1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lINEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lINEBindingNavigator)).EndInit();
            this.lINEBindingNavigator.ResumeLayout(false);
            this.lINEBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SaleCo1DataSet saleCo1DataSet;
        private System.Windows.Forms.BindingSource lINEBindingSource;
        private SaleCo1DataSetTableAdapters.LINETableAdapter lINETableAdapter;
        private SaleCo1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator lINEBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton lINEBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iNV_NUMBERTextBox;
        private System.Windows.Forms.TextBox lINE_NUMBERTextBox;
        private System.Windows.Forms.TextBox p_CODETextBox;
        private System.Windows.Forms.TextBox lINE_UNITSTextBox;
        private System.Windows.Forms.TextBox lINE_PRICETextBox;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}