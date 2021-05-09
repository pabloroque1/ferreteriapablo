
namespace Ferreteria
{
    partial class Marca
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_cambiarDescripcionMarca = new FontAwesome.Sharp.IconButton();
            this.txt_nuevaDescMarca = new System.Windows.Forms.TextBox();
            this.lbl_nuevaDescMarca = new System.Windows.Forms.Label();
            this.dgv_Marcas = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_ModificarMarca = new FontAwesome.Sharp.IconButton();
            this.btn_BorrarMarca = new FontAwesome.Sharp.IconButton();
            this.txt_descripcionMarca = new System.Windows.Forms.TextBox();
            this.btn_GuardarMarca = new FontAwesome.Sharp.IconButton();
            this.lbl_descripcionCategoria = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Categoria = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Marcas)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.SeaShell;
            this.panel2.Controls.Add(this.btn_cambiarDescripcionMarca);
            this.panel2.Controls.Add(this.txt_nuevaDescMarca);
            this.panel2.Controls.Add(this.lbl_nuevaDescMarca);
            this.panel2.Controls.Add(this.dgv_Marcas);
            this.panel2.Controls.Add(this.btn_ModificarMarca);
            this.panel2.Controls.Add(this.btn_BorrarMarca);
            this.panel2.Controls.Add(this.txt_descripcionMarca);
            this.panel2.Controls.Add(this.btn_GuardarMarca);
            this.panel2.Controls.Add(this.lbl_descripcionCategoria);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(15, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(771, 395);
            this.panel2.TabIndex = 8;
            // 
            // btn_cambiarDescripcionMarca
            // 
            this.btn_cambiarDescripcionMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cambiarDescripcionMarca.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_cambiarDescripcionMarca.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_cambiarDescripcionMarca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_cambiarDescripcionMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cambiarDescripcionMarca.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btn_cambiarDescripcionMarca.IconColor = System.Drawing.Color.Black;
            this.btn_cambiarDescripcionMarca.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_cambiarDescripcionMarca.IconSize = 35;
            this.btn_cambiarDescripcionMarca.Location = new System.Drawing.Point(31, 336);
            this.btn_cambiarDescripcionMarca.Name = "btn_cambiarDescripcionMarca";
            this.btn_cambiarDescripcionMarca.Size = new System.Drawing.Size(124, 41);
            this.btn_cambiarDescripcionMarca.TabIndex = 35;
            this.btn_cambiarDescripcionMarca.Text = "Cambiar Descripcion";
            this.btn_cambiarDescripcionMarca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cambiarDescripcionMarca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cambiarDescripcionMarca.UseVisualStyleBackColor = true;
            this.btn_cambiarDescripcionMarca.Click += new System.EventHandler(this.btn_cambiarDescripcionMarca_Click);
            // 
            // txt_nuevaDescMarca
            // 
            this.txt_nuevaDescMarca.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_nuevaDescMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nuevaDescMarca.Location = new System.Drawing.Point(198, 135);
            this.txt_nuevaDescMarca.Name = "txt_nuevaDescMarca";
            this.txt_nuevaDescMarca.Size = new System.Drawing.Size(239, 26);
            this.txt_nuevaDescMarca.TabIndex = 34;
            // 
            // lbl_nuevaDescMarca
            // 
            this.lbl_nuevaDescMarca.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_nuevaDescMarca.AutoSize = true;
            this.lbl_nuevaDescMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nuevaDescMarca.Location = new System.Drawing.Point(27, 137);
            this.lbl_nuevaDescMarca.Name = "lbl_nuevaDescMarca";
            this.lbl_nuevaDescMarca.Size = new System.Drawing.Size(170, 24);
            this.lbl_nuevaDescMarca.TabIndex = 33;
            this.lbl_nuevaDescMarca.Text = "Nueva Descripcion";
            // 
            // dgv_Marcas
            // 
            this.dgv_Marcas.AllowUserToAddRows = false;
            this.dgv_Marcas.AllowUserToDeleteRows = false;
            this.dgv_Marcas.AllowUserToResizeColumns = false;
            this.dgv_Marcas.AllowUserToResizeRows = false;
            this.dgv_Marcas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Marcas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_Marcas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Marcas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Marcas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgv_Marcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Marcas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Descripcion});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Marcas.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgv_Marcas.Location = new System.Drawing.Point(443, 59);
            this.dgv_Marcas.Name = "dgv_Marcas";
            this.dgv_Marcas.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Marcas.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgv_Marcas.RowHeadersVisible = false;
            this.dgv_Marcas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_Marcas.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgv_Marcas.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Marcas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_Marcas.Size = new System.Drawing.Size(296, 331);
            this.dgv_Marcas.TabIndex = 32;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "idCategoria";
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
            // btn_ModificarMarca
            // 
            this.btn_ModificarMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ModificarMarca.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_ModificarMarca.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_ModificarMarca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_ModificarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ModificarMarca.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btn_ModificarMarca.IconColor = System.Drawing.Color.Black;
            this.btn_ModificarMarca.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_ModificarMarca.IconSize = 35;
            this.btn_ModificarMarca.Location = new System.Drawing.Point(161, 240);
            this.btn_ModificarMarca.Name = "btn_ModificarMarca";
            this.btn_ModificarMarca.Size = new System.Drawing.Size(104, 41);
            this.btn_ModificarMarca.TabIndex = 31;
            this.btn_ModificarMarca.Text = "Modificar";
            this.btn_ModificarMarca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ModificarMarca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ModificarMarca.UseVisualStyleBackColor = true;
            this.btn_ModificarMarca.Click += new System.EventHandler(this.btn_ModificarMarca_Click);
            // 
            // btn_BorrarMarca
            // 
            this.btn_BorrarMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_BorrarMarca.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_BorrarMarca.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_BorrarMarca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_BorrarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BorrarMarca.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btn_BorrarMarca.IconColor = System.Drawing.Color.Black;
            this.btn_BorrarMarca.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_BorrarMarca.IconSize = 35;
            this.btn_BorrarMarca.Location = new System.Drawing.Point(161, 336);
            this.btn_BorrarMarca.Name = "btn_BorrarMarca";
            this.btn_BorrarMarca.Size = new System.Drawing.Size(104, 41);
            this.btn_BorrarMarca.TabIndex = 30;
            this.btn_BorrarMarca.Text = "Borrar";
            this.btn_BorrarMarca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_BorrarMarca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_BorrarMarca.UseVisualStyleBackColor = true;
            this.btn_BorrarMarca.Click += new System.EventHandler(this.btn_BorrarMarca_Click);
            // 
            // txt_descripcionMarca
            // 
            this.txt_descripcionMarca.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_descripcionMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descripcionMarca.Location = new System.Drawing.Point(198, 66);
            this.txt_descripcionMarca.Name = "txt_descripcionMarca";
            this.txt_descripcionMarca.Size = new System.Drawing.Size(239, 26);
            this.txt_descripcionMarca.TabIndex = 20;
            // 
            // btn_GuardarMarca
            // 
            this.btn_GuardarMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_GuardarMarca.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_GuardarMarca.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_GuardarMarca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_GuardarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GuardarMarca.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btn_GuardarMarca.IconColor = System.Drawing.Color.Black;
            this.btn_GuardarMarca.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_GuardarMarca.IconSize = 35;
            this.btn_GuardarMarca.Location = new System.Drawing.Point(271, 336);
            this.btn_GuardarMarca.Name = "btn_GuardarMarca";
            this.btn_GuardarMarca.Size = new System.Drawing.Size(93, 41);
            this.btn_GuardarMarca.TabIndex = 19;
            this.btn_GuardarMarca.Text = "Guardar";
            this.btn_GuardarMarca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_GuardarMarca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_GuardarMarca.UseVisualStyleBackColor = true;
            this.btn_GuardarMarca.Click += new System.EventHandler(this.btn_GuardarMarca_Click);
            // 
            // lbl_descripcionCategoria
            // 
            this.lbl_descripcionCategoria.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_descripcionCategoria.AutoSize = true;
            this.lbl_descripcionCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descripcionCategoria.Location = new System.Drawing.Point(27, 68);
            this.lbl_descripcionCategoria.Name = "lbl_descripcionCategoria";
            this.lbl_descripcionCategoria.Size = new System.Drawing.Size(110, 24);
            this.lbl_descripcionCategoria.TabIndex = 15;
            this.lbl_descripcionCategoria.Text = "Descripcion";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.lbl_Categoria);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(771, 53);
            this.panel1.TabIndex = 0;
            // 
            // lbl_Categoria
            // 
            this.lbl_Categoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Categoria.AutoSize = true;
            this.lbl_Categoria.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Categoria.ForeColor = System.Drawing.Color.White;
            this.lbl_Categoria.Location = new System.Drawing.Point(307, 10);
            this.lbl_Categoria.Name = "lbl_Categoria";
            this.lbl_Categoria.Size = new System.Drawing.Size(94, 31);
            this.lbl_Categoria.TabIndex = 12;
            this.lbl_Categoria.Text = "Marca";
            this.lbl_Categoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Marca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ferreteria.Properties.Resources.shutterstock_710141932baja;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Marca";
            this.Text = "Marca";
            this.Load += new System.EventHandler(this.Marca_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Marcas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btn_cambiarDescripcionMarca;
        private System.Windows.Forms.TextBox txt_nuevaDescMarca;
        private System.Windows.Forms.Label lbl_nuevaDescMarca;
        private System.Windows.Forms.DataGridView dgv_Marcas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private FontAwesome.Sharp.IconButton btn_ModificarMarca;
        private FontAwesome.Sharp.IconButton btn_BorrarMarca;
        private System.Windows.Forms.TextBox txt_descripcionMarca;
        private FontAwesome.Sharp.IconButton btn_GuardarMarca;
        private System.Windows.Forms.Label lbl_descripcionCategoria;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Categoria;
    }
}