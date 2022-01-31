
namespace InventarioLibros
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label idLibroLabel;
            System.Windows.Forms.Label idCategoriaLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label autorLabel;
            System.Windows.Forms.Label fechaPublicacionLabel;
            this.libroBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.libroBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.libroDataGridView = new System.Windows.Forms.DataGridView();
            this.idLibroTextBox = new System.Windows.Forms.TextBox();
            this.idCategoriaTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.autorTextBox = new System.Windows.Forms.TextBox();
            this.fechaPublicacionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fillByAutorToolStrip = new System.Windows.Forms.ToolStrip();
            this.autorToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.autorToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByAutorToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.libroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotecaDataSet = new InventarioLibros.BibliotecaDataSet();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libroTableAdapter = new InventarioLibros.BibliotecaDataSetTableAdapters.LibroTableAdapter();
            this.tableAdapterManager = new InventarioLibros.BibliotecaDataSetTableAdapters.TableAdapterManager();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            idLibroLabel = new System.Windows.Forms.Label();
            idCategoriaLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            autorLabel = new System.Windows.Forms.Label();
            fechaPublicacionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.libroBindingNavigator)).BeginInit();
            this.libroBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.libroDataGridView)).BeginInit();
            this.fillByAutorToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.libroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // libroBindingNavigator
            // 
            this.libroBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.libroBindingNavigator.BindingSource = this.libroBindingSource;
            this.libroBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.libroBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.libroBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.libroBindingNavigator.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.libroBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.libroBindingNavigatorSaveItem});
            this.libroBindingNavigator.Location = new System.Drawing.Point(0, 691);
            this.libroBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.libroBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.libroBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.libroBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.libroBindingNavigator.Name = "libroBindingNavigator";
            this.libroBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.libroBindingNavigator.Size = new System.Drawing.Size(1385, 42);
            this.libroBindingNavigator.TabIndex = 0;
            this.libroBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 42);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 39);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(76, 36);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 42);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 42);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // libroBindingNavigatorSaveItem
            // 
            this.libroBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.libroBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("libroBindingNavigatorSaveItem.Image")));
            this.libroBindingNavigatorSaveItem.Name = "libroBindingNavigatorSaveItem";
            this.libroBindingNavigatorSaveItem.Size = new System.Drawing.Size(46, 36);
            this.libroBindingNavigatorSaveItem.Text = "Guardar datos";
            this.libroBindingNavigatorSaveItem.Click += new System.EventHandler(this.libroBindingNavigatorSaveItem_Click);
            // 
            // libroDataGridView
            // 
            this.libroDataGridView.AutoGenerateColumns = false;
            this.libroDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.libroDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.libroDataGridView.DataSource = this.libroBindingSource;
            this.libroDataGridView.Location = new System.Drawing.Point(77, 293);
            this.libroDataGridView.Name = "libroDataGridView";
            this.libroDataGridView.RowHeadersWidth = 82;
            this.libroDataGridView.RowTemplate.Height = 33;
            this.libroDataGridView.Size = new System.Drawing.Size(962, 378);
            this.libroDataGridView.TabIndex = 1;
            // 
            // idLibroLabel
            // 
            idLibroLabel.AutoSize = true;
            idLibroLabel.Location = new System.Drawing.Point(72, 74);
            idLibroLabel.Name = "idLibroLabel";
            idLibroLabel.Size = new System.Drawing.Size(89, 25);
            idLibroLabel.TabIndex = 2;
            idLibroLabel.Text = "Id Libro:";
            // 
            // idLibroTextBox
            // 
            this.idLibroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.libroBindingSource, "IdLibro", true));
            this.idLibroTextBox.Location = new System.Drawing.Point(273, 71);
            this.idLibroTextBox.Name = "idLibroTextBox";
            this.idLibroTextBox.Size = new System.Drawing.Size(200, 31);
            this.idLibroTextBox.TabIndex = 3;
            // 
            // idCategoriaLabel
            // 
            idCategoriaLabel.AutoSize = true;
            idCategoriaLabel.Location = new System.Drawing.Point(72, 111);
            idCategoriaLabel.Name = "idCategoriaLabel";
            idCategoriaLabel.Size = new System.Drawing.Size(134, 25);
            idCategoriaLabel.TabIndex = 4;
            idCategoriaLabel.Text = "Id Categoria:";
            // 
            // idCategoriaTextBox
            // 
            this.idCategoriaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.libroBindingSource, "IdCategoria", true));
            this.idCategoriaTextBox.Location = new System.Drawing.Point(273, 108);
            this.idCategoriaTextBox.Name = "idCategoriaTextBox";
            this.idCategoriaTextBox.Size = new System.Drawing.Size(200, 31);
            this.idCategoriaTextBox.TabIndex = 5;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(72, 148);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(93, 25);
            nombreLabel.TabIndex = 6;
            nombreLabel.Text = "Nombre:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.libroBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(273, 145);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(200, 31);
            this.nombreTextBox.TabIndex = 7;
            // 
            // autorLabel
            // 
            autorLabel.AutoSize = true;
            autorLabel.Location = new System.Drawing.Point(72, 185);
            autorLabel.Name = "autorLabel";
            autorLabel.Size = new System.Drawing.Size(69, 25);
            autorLabel.TabIndex = 8;
            autorLabel.Text = "Autor:";
            // 
            // autorTextBox
            // 
            this.autorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.libroBindingSource, "Autor", true));
            this.autorTextBox.Location = new System.Drawing.Point(273, 182);
            this.autorTextBox.Name = "autorTextBox";
            this.autorTextBox.Size = new System.Drawing.Size(200, 31);
            this.autorTextBox.TabIndex = 9;
            // 
            // fechaPublicacionLabel
            // 
            fechaPublicacionLabel.AutoSize = true;
            fechaPublicacionLabel.Location = new System.Drawing.Point(72, 223);
            fechaPublicacionLabel.Name = "fechaPublicacionLabel";
            fechaPublicacionLabel.Size = new System.Drawing.Size(195, 25);
            fechaPublicacionLabel.TabIndex = 10;
            fechaPublicacionLabel.Text = "Fecha Publicacion:";
            // 
            // fechaPublicacionDateTimePicker
            // 
            this.fechaPublicacionDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.libroBindingSource, "FechaPublicacion", true));
            this.fechaPublicacionDateTimePicker.Location = new System.Drawing.Point(273, 219);
            this.fechaPublicacionDateTimePicker.Name = "fechaPublicacionDateTimePicker";
            this.fechaPublicacionDateTimePicker.Size = new System.Drawing.Size(200, 31);
            this.fechaPublicacionDateTimePicker.TabIndex = 11;
            // 
            // fillByAutorToolStrip
            // 
            this.fillByAutorToolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.fillByAutorToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autorToolStripLabel,
            this.autorToolStripTextBox,
            this.fillByAutorToolStripButton});
            this.fillByAutorToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByAutorToolStrip.Name = "fillByAutorToolStrip";
            this.fillByAutorToolStrip.Size = new System.Drawing.Size(1385, 42);
            this.fillByAutorToolStrip.TabIndex = 12;
            this.fillByAutorToolStrip.Text = "fillByAutorToolStrip";
            // 
            // autorToolStripLabel
            // 
            this.autorToolStripLabel.Name = "autorToolStripLabel";
            this.autorToolStripLabel.Size = new System.Drawing.Size(79, 36);
            this.autorToolStripLabel.Text = "Autor:";
            // 
            // autorToolStripTextBox
            // 
            this.autorToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.autorToolStripTextBox.Name = "autorToolStripTextBox";
            this.autorToolStripTextBox.Size = new System.Drawing.Size(100, 42);
            // 
            // fillByAutorToolStripButton
            // 
            this.fillByAutorToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByAutorToolStripButton.Name = "fillByAutorToolStripButton";
            this.fillByAutorToolStripButton.Size = new System.Drawing.Size(134, 36);
            this.fillByAutorToolStripButton.Text = "FillByAutor";
            this.fillByAutorToolStripButton.Click += new System.EventHandler(this.fillByAutorToolStripButton_Click);
            // 
            // libroBindingSource
            // 
            this.libroBindingSource.DataMember = "Libro";
            this.libroBindingSource.DataSource = this.bibliotecaDataSet;
            // 
            // bibliotecaDataSet
            // 
            this.bibliotecaDataSet.DataSetName = "BibliotecaDataSet";
            this.bibliotecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdLibro";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdLibro";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IdCategoria";
            this.dataGridViewTextBoxColumn2.HeaderText = "IdCategoria";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Autor";
            this.dataGridViewTextBoxColumn4.HeaderText = "Autor";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "FechaPublicacion";
            this.dataGridViewTextBoxColumn5.HeaderText = "FechaPublicacion";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 200;
            // 
            // libroTableAdapter
            // 
            this.libroTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaTableAdapter = null;
            this.tableAdapterManager.LibroTableAdapter = this.libroTableAdapter;
            this.tableAdapterManager.LibroUnidadesTableAdapter = null;
            this.tableAdapterManager.UbicacionTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = InventarioLibros.BibliotecaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VentaTableAdapter = null;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(661, 75);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(177, 50);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(661, 157);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(177, 56);
            this.btnModify.TabIndex = 14;
            this.btnModify.Text = "Modificar";
            this.btnModify.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1385, 733);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.fillByAutorToolStrip);
            this.Controls.Add(idLibroLabel);
            this.Controls.Add(this.idLibroTextBox);
            this.Controls.Add(idCategoriaLabel);
            this.Controls.Add(this.idCategoriaTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(autorLabel);
            this.Controls.Add(this.autorTextBox);
            this.Controls.Add(fechaPublicacionLabel);
            this.Controls.Add(this.fechaPublicacionDateTimePicker);
            this.Controls.Add(this.libroDataGridView);
            this.Controls.Add(this.libroBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libroBindingNavigator)).EndInit();
            this.libroBindingNavigator.ResumeLayout(false);
            this.libroBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.libroDataGridView)).EndInit();
            this.fillByAutorToolStrip.ResumeLayout(false);
            this.fillByAutorToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.libroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BibliotecaDataSet bibliotecaDataSet;
        private System.Windows.Forms.BindingSource libroBindingSource;
        private BibliotecaDataSetTableAdapters.LibroTableAdapter libroTableAdapter;
        private BibliotecaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator libroBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton libroBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView libroDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox idLibroTextBox;
        private System.Windows.Forms.TextBox idCategoriaTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox autorTextBox;
        private System.Windows.Forms.DateTimePicker fechaPublicacionDateTimePicker;
        private System.Windows.Forms.ToolStrip fillByAutorToolStrip;
        private System.Windows.Forms.ToolStripLabel autorToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox autorToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByAutorToolStripButton;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModify;
    }
}

