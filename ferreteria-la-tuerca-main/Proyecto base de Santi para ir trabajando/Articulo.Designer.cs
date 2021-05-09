
namespace Ferreteria
{
    partial class Articulo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmb_categoriaArticulo = new System.Windows.Forms.ComboBox();
            this.lbl_categoriaArticulo = new System.Windows.Forms.Label();
            this.cmb_marcaArticulo = new System.Windows.Forms.ComboBox();
            this.lbl_Marca = new System.Windows.Forms.Label();
            this.txt_precioUnitario = new System.Windows.Forms.TextBox();
            this.lbl_precioUnitario = new System.Windows.Forms.Label();
            this.btn_cambDescMarca = new FontAwesome.Sharp.IconButton();
            this.txt_codUnidad = new System.Windows.Forms.TextBox();
            this.lbl_codUnidad = new System.Windows.Forms.Label();
            this.dgv_Articulo = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_ModificarArticulo = new FontAwesome.Sharp.IconButton();
            this.btn_BorrarArticulo = new FontAwesome.Sharp.IconButton();
            this.txt_descripcionArticulo = new System.Windows.Forms.TextBox();
            this.btn_GuardarArticulo = new FontAwesome.Sharp.IconButton();
            this.lbl_descripcionArticulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Categoria = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Articulo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.SeaShell;
            this.panel2.Controls.Add(this.iconButton1);
            this.panel2.Controls.Add(this.cmb_categoriaArticulo);
            this.panel2.Controls.Add(this.lbl_categoriaArticulo);
            this.panel2.Controls.Add(this.cmb_marcaArticulo);
            this.panel2.Controls.Add(this.lbl_Marca);
            this.panel2.Controls.Add(this.txt_precioUnitario);
            this.panel2.Controls.Add(this.lbl_precioUnitario);
            this.panel2.Controls.Add(this.btn_cambDescMarca);
            this.panel2.Controls.Add(this.txt_codUnidad);
            this.panel2.Controls.Add(this.lbl_codUnidad);
            this.panel2.Controls.Add(this.dgv_Articulo);
            this.panel2.Controls.Add(this.btn_ModificarArticulo);
            this.panel2.Controls.Add(this.btn_BorrarArticulo);
            this.panel2.Controls.Add(this.txt_descripcionArticulo);
            this.panel2.Controls.Add(this.btn_GuardarArticulo);
            this.panel2.Controls.Add(this.lbl_descripcionArticulo);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(15, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1203, 547);
            this.panel2.TabIndex = 9;
            // 
            // cmb_categoriaArticulo
            // 
            this.cmb_categoriaArticulo.FormattingEnabled = true;
            this.cmb_categoriaArticulo.Location = new System.Drawing.Point(185, 254);
            this.cmb_categoriaArticulo.Name = "cmb_categoriaArticulo";
            this.cmb_categoriaArticulo.Size = new System.Drawing.Size(142, 21);
            this.cmb_categoriaArticulo.TabIndex = 41;
            // 
            // lbl_categoriaArticulo
            // 
            this.lbl_categoriaArticulo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_categoriaArticulo.AutoSize = true;
            this.lbl_categoriaArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_categoriaArticulo.Location = new System.Drawing.Point(16, 251);
            this.lbl_categoriaArticulo.Name = "lbl_categoriaArticulo";
            this.lbl_categoriaArticulo.Size = new System.Drawing.Size(90, 24);
            this.lbl_categoriaArticulo.TabIndex = 40;
            this.lbl_categoriaArticulo.Text = "Categoria";
            // 
            // cmb_marcaArticulo
            // 
            this.cmb_marcaArticulo.FormattingEnabled = true;
            this.cmb_marcaArticulo.Location = new System.Drawing.Point(185, 206);
            this.cmb_marcaArticulo.Name = "cmb_marcaArticulo";
            this.cmb_marcaArticulo.Size = new System.Drawing.Size(142, 21);
            this.cmb_marcaArticulo.TabIndex = 39;
            // 
            // lbl_Marca
            // 
            this.lbl_Marca.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_Marca.AutoSize = true;
            this.lbl_Marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Marca.Location = new System.Drawing.Point(16, 206);
            this.lbl_Marca.Name = "lbl_Marca";
            this.lbl_Marca.Size = new System.Drawing.Size(62, 24);
            this.lbl_Marca.TabIndex = 38;
            this.lbl_Marca.Text = "Marca";
            // 
            // txt_precioUnitario
            // 
            this.txt_precioUnitario.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_precioUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precioUnitario.Location = new System.Drawing.Point(185, 158);
            this.txt_precioUnitario.Name = "txt_precioUnitario";
            this.txt_precioUnitario.Size = new System.Drawing.Size(74, 26);
            this.txt_precioUnitario.TabIndex = 37;
            // 
            // lbl_precioUnitario
            // 
            this.lbl_precioUnitario.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_precioUnitario.AutoSize = true;
            this.lbl_precioUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precioUnitario.Location = new System.Drawing.Point(16, 160);
            this.lbl_precioUnitario.Name = "lbl_precioUnitario";
            this.lbl_precioUnitario.Size = new System.Drawing.Size(132, 24);
            this.lbl_precioUnitario.TabIndex = 36;
            this.lbl_precioUnitario.Text = "Precio Unitario";
            // 
            // btn_cambDescMarca
            // 
            this.btn_cambDescMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cambDescMarca.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_cambDescMarca.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_cambDescMarca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_cambDescMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cambDescMarca.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btn_cambDescMarca.IconColor = System.Drawing.Color.Black;
            this.btn_cambDescMarca.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_cambDescMarca.IconSize = 35;
            this.btn_cambDescMarca.Location = new System.Drawing.Point(24, 471);
            this.btn_cambDescMarca.Name = "btn_cambDescMarca";
            this.btn_cambDescMarca.Size = new System.Drawing.Size(124, 41);
            this.btn_cambDescMarca.TabIndex = 35;
            this.btn_cambDescMarca.Text = "Cambiar Descripcion";
            this.btn_cambDescMarca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cambDescMarca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cambDescMarca.UseVisualStyleBackColor = true;
            // 
            // txt_codUnidad
            // 
            this.txt_codUnidad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_codUnidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codUnidad.Location = new System.Drawing.Point(185, 115);
            this.txt_codUnidad.Name = "txt_codUnidad";
            this.txt_codUnidad.Size = new System.Drawing.Size(239, 26);
            this.txt_codUnidad.TabIndex = 34;
            // 
            // lbl_codUnidad
            // 
            this.lbl_codUnidad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_codUnidad.AutoSize = true;
            this.lbl_codUnidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codUnidad.Location = new System.Drawing.Point(16, 117);
            this.lbl_codUnidad.Name = "lbl_codUnidad";
            this.lbl_codUnidad.Size = new System.Drawing.Size(163, 24);
            this.lbl_codUnidad.TabIndex = 33;
            this.lbl_codUnidad.Text = "Codigo de Unidad";
            // 
            // dgv_Articulo
            // 
            this.dgv_Articulo.AllowUserToAddRows = false;
            this.dgv_Articulo.AllowUserToDeleteRows = false;
            this.dgv_Articulo.AllowUserToResizeColumns = false;
            this.dgv_Articulo.AllowUserToResizeRows = false;
            this.dgv_Articulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Articulo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_Articulo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Articulo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Articulo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.dgv_Articulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Articulo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Descripcion,
            this.codigoUnidad,
            this.precio,
            this.Marca,
            this.Categoria});
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Articulo.DefaultCellStyle = dataGridViewCellStyle26;
            this.dgv_Articulo.Location = new System.Drawing.Point(443, 59);
            this.dgv_Articulo.Name = "dgv_Articulo";
            this.dgv_Articulo.ReadOnly = true;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Articulo.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.dgv_Articulo.RowHeadersVisible = false;
            this.dgv_Articulo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_Articulo.RowsDefaultCellStyle = dataGridViewCellStyle28;
            this.dgv_Articulo.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Articulo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_Articulo.Size = new System.Drawing.Size(728, 483);
            this.dgv_Articulo.TabIndex = 32;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "codProducto";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 59;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 161;
            // 
            // codigoUnidad
            // 
            this.codigoUnidad.DataPropertyName = "codUnidad";
            this.codigoUnidad.HeaderText = "Cod Unidad";
            this.codigoUnidad.Name = "codigoUnidad";
            this.codigoUnidad.ReadOnly = true;
            this.codigoUnidad.Width = 160;
            // 
            // precio
            // 
            this.precio.DataPropertyName = "precioUnitario";
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            this.precio.Width = 104;
            // 
            // Marca
            // 
            this.Marca.DataPropertyName = "idMarca";
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            this.Marca.Width = 102;
            // 
            // Categoria
            // 
            this.Categoria.DataPropertyName = "idCategoria";
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            this.Categoria.Width = 139;
            // 
            // btn_ModificarArticulo
            // 
            this.btn_ModificarArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ModificarArticulo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_ModificarArticulo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_ModificarArticulo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_ModificarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ModificarArticulo.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btn_ModificarArticulo.IconColor = System.Drawing.Color.Black;
            this.btn_ModificarArticulo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_ModificarArticulo.IconSize = 35;
            this.btn_ModificarArticulo.Location = new System.Drawing.Point(44, 393);
            this.btn_ModificarArticulo.Name = "btn_ModificarArticulo";
            this.btn_ModificarArticulo.Size = new System.Drawing.Size(104, 41);
            this.btn_ModificarArticulo.TabIndex = 31;
            this.btn_ModificarArticulo.Text = "Modificar";
            this.btn_ModificarArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ModificarArticulo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ModificarArticulo.UseVisualStyleBackColor = true;
            // 
            // btn_BorrarArticulo
            // 
            this.btn_BorrarArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_BorrarArticulo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_BorrarArticulo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_BorrarArticulo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_BorrarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BorrarArticulo.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btn_BorrarArticulo.IconColor = System.Drawing.Color.Black;
            this.btn_BorrarArticulo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_BorrarArticulo.IconSize = 35;
            this.btn_BorrarArticulo.Location = new System.Drawing.Point(154, 393);
            this.btn_BorrarArticulo.Name = "btn_BorrarArticulo";
            this.btn_BorrarArticulo.Size = new System.Drawing.Size(104, 41);
            this.btn_BorrarArticulo.TabIndex = 30;
            this.btn_BorrarArticulo.Text = "Borrar";
            this.btn_BorrarArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_BorrarArticulo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_BorrarArticulo.UseVisualStyleBackColor = true;
            this.btn_BorrarArticulo.Click += new System.EventHandler(this.btn_BorrarArticulo_Click);
            // 
            // txt_descripcionArticulo
            // 
            this.txt_descripcionArticulo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_descripcionArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descripcionArticulo.Location = new System.Drawing.Point(185, 70);
            this.txt_descripcionArticulo.Name = "txt_descripcionArticulo";
            this.txt_descripcionArticulo.Size = new System.Drawing.Size(239, 26);
            this.txt_descripcionArticulo.TabIndex = 20;
            // 
            // btn_GuardarArticulo
            // 
            this.btn_GuardarArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_GuardarArticulo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_GuardarArticulo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_GuardarArticulo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_GuardarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GuardarArticulo.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btn_GuardarArticulo.IconColor = System.Drawing.Color.Black;
            this.btn_GuardarArticulo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_GuardarArticulo.IconSize = 35;
            this.btn_GuardarArticulo.Location = new System.Drawing.Point(265, 471);
            this.btn_GuardarArticulo.Name = "btn_GuardarArticulo";
            this.btn_GuardarArticulo.Size = new System.Drawing.Size(93, 41);
            this.btn_GuardarArticulo.TabIndex = 19;
            this.btn_GuardarArticulo.Text = "Guardar";
            this.btn_GuardarArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_GuardarArticulo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_GuardarArticulo.UseVisualStyleBackColor = true;
            this.btn_GuardarArticulo.Click += new System.EventHandler(this.btn_GuardarArticulo_Click);
            // 
            // lbl_descripcionArticulo
            // 
            this.lbl_descripcionArticulo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_descripcionArticulo.AutoSize = true;
            this.lbl_descripcionArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descripcionArticulo.Location = new System.Drawing.Point(16, 72);
            this.lbl_descripcionArticulo.Name = "lbl_descripcionArticulo";
            this.lbl_descripcionArticulo.Size = new System.Drawing.Size(110, 24);
            this.lbl_descripcionArticulo.TabIndex = 15;
            this.lbl_descripcionArticulo.Text = "Descripcion";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.lbl_Categoria);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1203, 53);
            this.panel1.TabIndex = 0;
            // 
            // lbl_Categoria
            // 
            this.lbl_Categoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Categoria.AutoSize = true;
            this.lbl_Categoria.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Categoria.ForeColor = System.Drawing.Color.White;
            this.lbl_Categoria.Location = new System.Drawing.Point(401, 10);
            this.lbl_Categoria.Name = "lbl_Categoria";
            this.lbl_Categoria.Size = new System.Drawing.Size(113, 31);
            this.lbl_Categoria.TabIndex = 12;
            this.lbl_Categoria.Text = "Articulo";
            this.lbl_Categoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.iconButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.iconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 35;
            this.iconButton1.Location = new System.Drawing.Point(155, 471);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(104, 41);
            this.iconButton1.TabIndex = 42;
            this.iconButton1.Text = "Habilitar Borrado";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // Articulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ferreteria.Properties.Resources.shutterstock_710141932baja;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1249, 602);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Articulo";
            this.Text = "Articulo";
            this.Load += new System.EventHandler(this.Articulo_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Articulo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btn_cambDescMarca;
        private System.Windows.Forms.TextBox txt_codUnidad;
        private System.Windows.Forms.Label lbl_codUnidad;
        private System.Windows.Forms.DataGridView dgv_Articulo;
        private FontAwesome.Sharp.IconButton btn_ModificarArticulo;
        private FontAwesome.Sharp.IconButton btn_BorrarArticulo;
        private System.Windows.Forms.TextBox txt_descripcionArticulo;
        private FontAwesome.Sharp.IconButton btn_GuardarArticulo;
        private System.Windows.Forms.Label lbl_descripcionArticulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Categoria;
        private System.Windows.Forms.TextBox txt_precioUnitario;
        private System.Windows.Forms.Label lbl_precioUnitario;
        private System.Windows.Forms.ComboBox cmb_categoriaArticulo;
        private System.Windows.Forms.Label lbl_categoriaArticulo;
        private System.Windows.Forms.ComboBox cmb_marcaArticulo;
        private System.Windows.Forms.Label lbl_Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}