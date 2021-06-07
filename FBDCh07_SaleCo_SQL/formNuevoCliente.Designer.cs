
namespace FBDCh07_SaleCo_SQL
{
    partial class formNuevoCliente
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
            System.Windows.Forms.Label cUS_CODELabel;
            System.Windows.Forms.Label cUS_LNAMELabel;
            System.Windows.Forms.Label cUS_FNAMELabel;
            System.Windows.Forms.Label cUS_INITIALLabel;
            System.Windows.Forms.Label cUS_AREACODELabel;
            System.Windows.Forms.Label cUS_PHONELabel;
            System.Windows.Forms.Label cUS_BALANCELabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formNuevoCliente));
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.saleCo1DataSet = new FBDCh07_SaleCo_SQL.SaleCo1DataSet();
            this.cUSTOMERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cUSTOMERTableAdapter = new FBDCh07_SaleCo_SQL.SaleCo1DataSetTableAdapters.CUSTOMERTableAdapter();
            this.tableAdapterManager = new FBDCh07_SaleCo_SQL.SaleCo1DataSetTableAdapters.TableAdapterManager();
            this.cUS_CODETextBox = new System.Windows.Forms.TextBox();
            this.cUS_LNAMETextBox = new System.Windows.Forms.TextBox();
            this.cUS_FNAMETextBox = new System.Windows.Forms.TextBox();
            this.cUS_INITIALTextBox = new System.Windows.Forms.TextBox();
            this.cUS_AREACODETextBox = new System.Windows.Forms.TextBox();
            this.cUS_PHONETextBox = new System.Windows.Forms.TextBox();
            this.cUS_BALANCETextBox = new System.Windows.Forms.TextBox();
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
            this.cUSTOMERBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cUSTOMERBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            cUS_CODELabel = new System.Windows.Forms.Label();
            cUS_LNAMELabel = new System.Windows.Forms.Label();
            cUS_FNAMELabel = new System.Windows.Forms.Label();
            cUS_INITIALLabel = new System.Windows.Forms.Label();
            cUS_AREACODELabel = new System.Windows.Forms.Label();
            cUS_PHONELabel = new System.Windows.Forms.Label();
            cUS_BALANCELabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.saleCo1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingNavigator)).BeginInit();
            this.cUSTOMERBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cUS_CODELabel
            // 
            cUS_CODELabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            cUS_CODELabel.AutoSize = true;
            cUS_CODELabel.Location = new System.Drawing.Point(20, 22);
            cUS_CODELabel.Name = "cUS_CODELabel";
            cUS_CODELabel.Size = new System.Drawing.Size(65, 13);
            cUS_CODELabel.TabIndex = 3;
            cUS_CODELabel.Text = "CUS CODE:";
            // 
            // cUS_LNAMELabel
            // 
            cUS_LNAMELabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            cUS_LNAMELabel.AutoSize = true;
            cUS_LNAMELabel.Location = new System.Drawing.Point(20, 48);
            cUS_LNAMELabel.Name = "cUS_LNAMELabel";
            cUS_LNAMELabel.Size = new System.Drawing.Size(72, 13);
            cUS_LNAMELabel.TabIndex = 5;
            cUS_LNAMELabel.Text = "CUS LNAME:";
            // 
            // cUS_FNAMELabel
            // 
            cUS_FNAMELabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            cUS_FNAMELabel.AutoSize = true;
            cUS_FNAMELabel.Location = new System.Drawing.Point(20, 74);
            cUS_FNAMELabel.Name = "cUS_FNAMELabel";
            cUS_FNAMELabel.Size = new System.Drawing.Size(72, 13);
            cUS_FNAMELabel.TabIndex = 7;
            cUS_FNAMELabel.Text = "CUS FNAME:";
            // 
            // cUS_INITIALLabel
            // 
            cUS_INITIALLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            cUS_INITIALLabel.AutoSize = true;
            cUS_INITIALLabel.Location = new System.Drawing.Point(20, 100);
            cUS_INITIALLabel.Name = "cUS_INITIALLabel";
            cUS_INITIALLabel.Size = new System.Drawing.Size(72, 13);
            cUS_INITIALLabel.TabIndex = 9;
            cUS_INITIALLabel.Text = "CUS INITIAL:";
            // 
            // cUS_AREACODELabel
            // 
            cUS_AREACODELabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            cUS_AREACODELabel.AutoSize = true;
            cUS_AREACODELabel.Location = new System.Drawing.Point(20, 126);
            cUS_AREACODELabel.Name = "cUS_AREACODELabel";
            cUS_AREACODELabel.Size = new System.Drawing.Size(94, 13);
            cUS_AREACODELabel.TabIndex = 11;
            cUS_AREACODELabel.Text = "CUS AREACODE:";
            // 
            // cUS_PHONELabel
            // 
            cUS_PHONELabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            cUS_PHONELabel.AutoSize = true;
            cUS_PHONELabel.Location = new System.Drawing.Point(20, 152);
            cUS_PHONELabel.Name = "cUS_PHONELabel";
            cUS_PHONELabel.Size = new System.Drawing.Size(73, 13);
            cUS_PHONELabel.TabIndex = 13;
            cUS_PHONELabel.Text = "CUS PHONE:";
            // 
            // cUS_BALANCELabel
            // 
            cUS_BALANCELabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            cUS_BALANCELabel.AutoSize = true;
            cUS_BALANCELabel.Location = new System.Drawing.Point(20, 178);
            cUS_BALANCELabel.Name = "cUS_BALANCELabel";
            cUS_BALANCELabel.Size = new System.Drawing.Size(84, 13);
            cUS_BALANCELabel.TabIndex = 15;
            cUS_BALANCELabel.Text = "CUS BALANCE:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(150, 214);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(233, 214);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // saleCo1DataSet
            // 
            this.saleCo1DataSet.DataSetName = "SaleCo1DataSet";
            this.saleCo1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cUSTOMERBindingSource
            // 
            this.cUSTOMERBindingSource.DataMember = "CUSTOMER";
            this.cUSTOMERBindingSource.DataSource = this.saleCo1DataSet;
            // 
            // cUSTOMERTableAdapter
            // 
            this.cUSTOMERTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CUSTOMERTableAdapter = this.cUSTOMERTableAdapter;
            this.tableAdapterManager.INVOICETableAdapter = null;
            this.tableAdapterManager.LINETableAdapter = null;
            this.tableAdapterManager.PRODUCTTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = FBDCh07_SaleCo_SQL.SaleCo1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VENDORTableAdapter = null;
            // 
            // cUS_CODETextBox
            // 
            this.cUS_CODETextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cUS_CODETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CUS_CODE", true));
            this.cUS_CODETextBox.Location = new System.Drawing.Point(120, 19);
            this.cUS_CODETextBox.Name = "cUS_CODETextBox";
            this.cUS_CODETextBox.Size = new System.Drawing.Size(189, 20);
            this.cUS_CODETextBox.TabIndex = 4;
            this.cUS_CODETextBox.Validating += new System.ComponentModel.CancelEventHandler(this.cUS_CODETextBox_Validating);
            // 
            // cUS_LNAMETextBox
            // 
            this.cUS_LNAMETextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cUS_LNAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CUS_LNAME", true));
            this.cUS_LNAMETextBox.Location = new System.Drawing.Point(120, 45);
            this.cUS_LNAMETextBox.Name = "cUS_LNAMETextBox";
            this.cUS_LNAMETextBox.Size = new System.Drawing.Size(189, 20);
            this.cUS_LNAMETextBox.TabIndex = 6;
            this.cUS_LNAMETextBox.Validating += new System.ComponentModel.CancelEventHandler(this.cUS_LNAMETextBox_Validating);
            // 
            // cUS_FNAMETextBox
            // 
            this.cUS_FNAMETextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cUS_FNAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CUS_FNAME", true));
            this.cUS_FNAMETextBox.Location = new System.Drawing.Point(120, 71);
            this.cUS_FNAMETextBox.Name = "cUS_FNAMETextBox";
            this.cUS_FNAMETextBox.Size = new System.Drawing.Size(189, 20);
            this.cUS_FNAMETextBox.TabIndex = 8;
            this.cUS_FNAMETextBox.Validating += new System.ComponentModel.CancelEventHandler(this.cUS_FNAMETextBox_Validating);
            // 
            // cUS_INITIALTextBox
            // 
            this.cUS_INITIALTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cUS_INITIALTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CUS_INITIAL", true));
            this.cUS_INITIALTextBox.Location = new System.Drawing.Point(120, 97);
            this.cUS_INITIALTextBox.Name = "cUS_INITIALTextBox";
            this.cUS_INITIALTextBox.Size = new System.Drawing.Size(189, 20);
            this.cUS_INITIALTextBox.TabIndex = 10;
            this.cUS_INITIALTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.cUS_INITIALTextBox_Validating);
            // 
            // cUS_AREACODETextBox
            // 
            this.cUS_AREACODETextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cUS_AREACODETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CUS_AREACODE", true));
            this.cUS_AREACODETextBox.Location = new System.Drawing.Point(120, 123);
            this.cUS_AREACODETextBox.Name = "cUS_AREACODETextBox";
            this.cUS_AREACODETextBox.Size = new System.Drawing.Size(189, 20);
            this.cUS_AREACODETextBox.TabIndex = 12;
            this.cUS_AREACODETextBox.Validating += new System.ComponentModel.CancelEventHandler(this.cUS_AREACODETextBox_Validating);
            // 
            // cUS_PHONETextBox
            // 
            this.cUS_PHONETextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cUS_PHONETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CUS_PHONE", true));
            this.cUS_PHONETextBox.Location = new System.Drawing.Point(120, 149);
            this.cUS_PHONETextBox.Name = "cUS_PHONETextBox";
            this.cUS_PHONETextBox.Size = new System.Drawing.Size(189, 20);
            this.cUS_PHONETextBox.TabIndex = 14;
            this.cUS_PHONETextBox.Validating += new System.ComponentModel.CancelEventHandler(this.cUS_PHONETextBox_Validating);
            // 
            // cUS_BALANCETextBox
            // 
            this.cUS_BALANCETextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cUS_BALANCETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CUS_BALANCE", true));
            this.cUS_BALANCETextBox.Location = new System.Drawing.Point(120, 175);
            this.cUS_BALANCETextBox.Name = "cUS_BALANCETextBox";
            this.cUS_BALANCETextBox.Size = new System.Drawing.Size(189, 20);
            this.cUS_BALANCETextBox.TabIndex = 16;
            this.cUS_BALANCETextBox.Validating += new System.ComponentModel.CancelEventHandler(this.cUS_BALANCETextBox_Validating);
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
            // cUSTOMERBindingNavigatorSaveItem
            // 
            this.cUSTOMERBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cUSTOMERBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cUSTOMERBindingNavigatorSaveItem.Image")));
            this.cUSTOMERBindingNavigatorSaveItem.Name = "cUSTOMERBindingNavigatorSaveItem";
            this.cUSTOMERBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.cUSTOMERBindingNavigatorSaveItem.Text = "Guardar datos";
            // 
            // cUSTOMERBindingNavigator
            // 
            this.cUSTOMERBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cUSTOMERBindingNavigator.BindingSource = this.cUSTOMERBindingSource;
            this.cUSTOMERBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cUSTOMERBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cUSTOMERBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.cUSTOMERBindingNavigatorSaveItem});
            this.cUSTOMERBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cUSTOMERBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cUSTOMERBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cUSTOMERBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cUSTOMERBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cUSTOMERBindingNavigator.Name = "cUSTOMERBindingNavigator";
            this.cUSTOMERBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cUSTOMERBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.cUSTOMERBindingNavigator.TabIndex = 2;
            this.cUSTOMERBindingNavigator.Text = "bindingNavigator1";
            this.cUSTOMERBindingNavigator.Visible = false;
            this.cUSTOMERBindingNavigator.RefreshItems += new System.EventHandler(this.cUSTOMERBindingNavigator_RefreshItems);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // formNuevoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 263);
            this.Controls.Add(cUS_CODELabel);
            this.Controls.Add(this.cUS_CODETextBox);
            this.Controls.Add(cUS_LNAMELabel);
            this.Controls.Add(this.cUS_LNAMETextBox);
            this.Controls.Add(cUS_FNAMELabel);
            this.Controls.Add(this.cUS_FNAMETextBox);
            this.Controls.Add(cUS_INITIALLabel);
            this.Controls.Add(this.cUS_INITIALTextBox);
            this.Controls.Add(cUS_AREACODELabel);
            this.Controls.Add(this.cUS_AREACODETextBox);
            this.Controls.Add(cUS_PHONELabel);
            this.Controls.Add(this.cUS_PHONETextBox);
            this.Controls.Add(cUS_BALANCELabel);
            this.Controls.Add(this.cUS_BALANCETextBox);
            this.Controls.Add(this.cUSTOMERBindingNavigator);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Name = "formNuevoCliente";
            this.Text = "Nuevo Cliente";
            this.Load += new System.EventHandler(this.formNuevoCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.saleCo1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingNavigator)).EndInit();
            this.cUSTOMERBindingNavigator.ResumeLayout(false);
            this.cUSTOMERBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private SaleCo1DataSet saleCo1DataSet;
        private System.Windows.Forms.BindingSource cUSTOMERBindingSource;
        private SaleCo1DataSetTableAdapters.CUSTOMERTableAdapter cUSTOMERTableAdapter;
        private SaleCo1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox cUS_CODETextBox;
        private System.Windows.Forms.TextBox cUS_LNAMETextBox;
        private System.Windows.Forms.TextBox cUS_FNAMETextBox;
        private System.Windows.Forms.TextBox cUS_INITIALTextBox;
        private System.Windows.Forms.TextBox cUS_AREACODETextBox;
        private System.Windows.Forms.TextBox cUS_PHONETextBox;
        private System.Windows.Forms.TextBox cUS_BALANCETextBox;
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
        private System.Windows.Forms.ToolStripButton cUSTOMERBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator cUSTOMERBindingNavigator;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}