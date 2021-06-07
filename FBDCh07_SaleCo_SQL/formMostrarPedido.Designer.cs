
namespace FBDCh07_SaleCo_SQL
{
    partial class formMostrarPedido
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
            System.Windows.Forms.Label cUS_CODELabel;
            System.Windows.Forms.Label iNV_DATELabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMostrarPedido));
            this.saleCo1DataSet = new FBDCh07_SaleCo_SQL.SaleCo1DataSet();
            this.iNVOICEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iNVOICETableAdapter = new FBDCh07_SaleCo_SQL.SaleCo1DataSetTableAdapters.INVOICETableAdapter();
            this.tableAdapterManager = new FBDCh07_SaleCo_SQL.SaleCo1DataSetTableAdapters.TableAdapterManager();
            this.iNV_NUMBERTextBox = new System.Windows.Forms.TextBox();
            this.cUS_CODETextBox = new System.Windows.Forms.TextBox();
            this.iNV_DATEDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.iNVOICEBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iNVOICEBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.btnRealizar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            iNV_NUMBERLabel = new System.Windows.Forms.Label();
            cUS_CODELabel = new System.Windows.Forms.Label();
            iNV_DATELabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.saleCo1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVOICEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVOICEBindingNavigator)).BeginInit();
            this.iNVOICEBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // iNV_NUMBERLabel
            // 
            iNV_NUMBERLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            iNV_NUMBERLabel.AutoSize = true;
            iNV_NUMBERLabel.Location = new System.Drawing.Point(13, 15);
            iNV_NUMBERLabel.Name = "iNV_NUMBERLabel";
            iNV_NUMBERLabel.Size = new System.Drawing.Size(78, 13);
            iNV_NUMBERLabel.TabIndex = 1;
            iNV_NUMBERLabel.Text = "INV NUMBER:";
            // 
            // cUS_CODELabel
            // 
            cUS_CODELabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            cUS_CODELabel.AutoSize = true;
            cUS_CODELabel.Location = new System.Drawing.Point(13, 41);
            cUS_CODELabel.Name = "cUS_CODELabel";
            cUS_CODELabel.Size = new System.Drawing.Size(65, 13);
            cUS_CODELabel.TabIndex = 3;
            cUS_CODELabel.Text = "CUS CODE:";
            // 
            // iNV_DATELabel
            // 
            iNV_DATELabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            iNV_DATELabel.AutoSize = true;
            iNV_DATELabel.Location = new System.Drawing.Point(13, 68);
            iNV_DATELabel.Name = "iNV_DATELabel";
            iNV_DATELabel.Size = new System.Drawing.Size(60, 13);
            iNV_DATELabel.TabIndex = 5;
            iNV_DATELabel.Text = "INV DATE:";
            // 
            // saleCo1DataSet
            // 
            this.saleCo1DataSet.DataSetName = "SaleCo1DataSet";
            this.saleCo1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iNVOICEBindingSource
            // 
            this.iNVOICEBindingSource.DataMember = "INVOICE";
            this.iNVOICEBindingSource.DataSource = this.saleCo1DataSet;
            // 
            // iNVOICETableAdapter
            // 
            this.iNVOICETableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CUSTOMERTableAdapter = null;
            this.tableAdapterManager.INVOICETableAdapter = this.iNVOICETableAdapter;
            this.tableAdapterManager.LINETableAdapter = null;
            this.tableAdapterManager.PRODUCTTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = FBDCh07_SaleCo_SQL.SaleCo1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VENDORTableAdapter = null;
            // 
            // iNV_NUMBERTextBox
            // 
            this.iNV_NUMBERTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iNV_NUMBERTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNVOICEBindingSource, "INV_NUMBER", true));
            this.iNV_NUMBERTextBox.Location = new System.Drawing.Point(97, 12);
            this.iNV_NUMBERTextBox.Name = "iNV_NUMBERTextBox";
            this.iNV_NUMBERTextBox.Size = new System.Drawing.Size(200, 20);
            this.iNV_NUMBERTextBox.TabIndex = 2;
            this.iNV_NUMBERTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.iNV_NUMBERTextBox_Validating);
            // 
            // cUS_CODETextBox
            // 
            this.cUS_CODETextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cUS_CODETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNVOICEBindingSource, "CUS_CODE", true));
            this.cUS_CODETextBox.Location = new System.Drawing.Point(97, 38);
            this.cUS_CODETextBox.Name = "cUS_CODETextBox";
            this.cUS_CODETextBox.Size = new System.Drawing.Size(200, 20);
            this.cUS_CODETextBox.TabIndex = 4;
            this.cUS_CODETextBox.Validating += new System.ComponentModel.CancelEventHandler(this.cUS_CODETextBox_Validating);
            // 
            // iNV_DATEDateTimePicker
            // 
            this.iNV_DATEDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iNV_DATEDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.iNVOICEBindingSource, "INV_DATE", true));
            this.iNV_DATEDateTimePicker.Location = new System.Drawing.Point(97, 64);
            this.iNV_DATEDateTimePicker.Name = "iNV_DATEDateTimePicker";
            this.iNV_DATEDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.iNV_DATEDateTimePicker.TabIndex = 6;
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
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
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
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
            // iNVOICEBindingNavigatorSaveItem
            // 
            this.iNVOICEBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.iNVOICEBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("iNVOICEBindingNavigatorSaveItem.Image")));
            this.iNVOICEBindingNavigatorSaveItem.Name = "iNVOICEBindingNavigatorSaveItem";
            this.iNVOICEBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.iNVOICEBindingNavigatorSaveItem.Text = "Guardar datos";
            // 
            // iNVOICEBindingNavigator
            // 
            this.iNVOICEBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.iNVOICEBindingNavigator.BindingSource = this.iNVOICEBindingSource;
            this.iNVOICEBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.iNVOICEBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.iNVOICEBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.iNVOICEBindingNavigatorSaveItem});
            this.iNVOICEBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.iNVOICEBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.iNVOICEBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.iNVOICEBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.iNVOICEBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.iNVOICEBindingNavigator.Name = "iNVOICEBindingNavigator";
            this.iNVOICEBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.iNVOICEBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.iNVOICEBindingNavigator.TabIndex = 0;
            this.iNVOICEBindingNavigator.Text = "bindingNavigator1";
            this.iNVOICEBindingNavigator.Visible = false;
            // 
            // btnRealizar
            // 
            this.btnRealizar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRealizar.Location = new System.Drawing.Point(106, 102);
            this.btnRealizar.Name = "btnRealizar";
            this.btnRealizar.Size = new System.Drawing.Size(110, 23);
            this.btnRealizar.TabIndex = 7;
            this.btnRealizar.Text = "Aceptar";
            this.btnRealizar.UseVisualStyleBackColor = true;
            this.btnRealizar.Click += new System.EventHandler(this.btnRealizar_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(222, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // formMostrarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 144);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnRealizar);
            this.Controls.Add(iNV_NUMBERLabel);
            this.Controls.Add(this.iNV_NUMBERTextBox);
            this.Controls.Add(cUS_CODELabel);
            this.Controls.Add(this.cUS_CODETextBox);
            this.Controls.Add(iNV_DATELabel);
            this.Controls.Add(this.iNV_DATEDateTimePicker);
            this.Controls.Add(this.iNVOICEBindingNavigator);
            this.Name = "formMostrarPedido";
            this.Text = "Mostrar Pedido";
            this.Load += new System.EventHandler(this.formMostrarPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.saleCo1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVOICEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVOICEBindingNavigator)).EndInit();
            this.iNVOICEBindingNavigator.ResumeLayout(false);
            this.iNVOICEBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SaleCo1DataSet saleCo1DataSet;
        private System.Windows.Forms.BindingSource iNVOICEBindingSource;
        private SaleCo1DataSetTableAdapters.INVOICETableAdapter iNVOICETableAdapter;
        private SaleCo1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox iNV_NUMBERTextBox;
        private System.Windows.Forms.TextBox cUS_CODETextBox;
        private System.Windows.Forms.DateTimePicker iNV_DATEDateTimePicker;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton iNVOICEBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator iNVOICEBindingNavigator;
        private System.Windows.Forms.Button btnRealizar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}