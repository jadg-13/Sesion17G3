namespace Sesion17G3.Formularios
{
    partial class ProductoFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductoFrm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            TbID = new TextBox();
            TbNombre = new TextBox();
            TbDescripcion = new TextBox();
            TbPrecio = new TextBox();
            toolStrip1 = new ToolStrip();
            BtnGuardar = new ToolStripButton();
            BtnEditar = new ToolStripButton();
            BtnEliminar = new ToolStripButton();
            gbRegistros = new GroupBox();
            DgvRegistros = new DataGridView();
            groupBox1.SuspendLayout();
            toolStrip1.SuspendLayout();
            gbRegistros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvRegistros).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TbPrecio);
            groupBox1.Controls.Add(TbDescripcion);
            groupBox1.Controls.Add(TbNombre);
            groupBox1.Controls.Add(TbID);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(51, 79);
            groupBox1.Margin = new Padding(4, 4, 4, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 4, 4, 4);
            groupBox1.Size = new Size(531, 376);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Generales";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 59);
            label1.Name = "label1";
            label1.Size = new Size(81, 28);
            label1.TabIndex = 0;
            label1.Text = "Código:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 117);
            label2.Name = "label2";
            label2.Size = new Size(89, 28);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 181);
            label3.Name = "label3";
            label3.Size = new Size(118, 28);
            label3.TabIndex = 2;
            label3.Text = "Descripción:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(69, 303);
            label4.Name = "label4";
            label4.Size = new Size(70, 28);
            label4.TabIndex = 3;
            label4.Text = "Precio:";
            // 
            // TbID
            // 
            TbID.Location = new Point(162, 59);
            TbID.Name = "TbID";
            TbID.Size = new Size(143, 34);
            TbID.TabIndex = 4;
            // 
            // TbNombre
            // 
            TbNombre.Location = new Point(162, 117);
            TbNombre.Name = "TbNombre";
            TbNombre.Size = new Size(344, 34);
            TbNombre.TabIndex = 5;
            // 
            // TbDescripcion
            // 
            TbDescripcion.Location = new Point(162, 181);
            TbDescripcion.Multiline = true;
            TbDescripcion.Name = "TbDescripcion";
            TbDescripcion.ScrollBars = ScrollBars.Vertical;
            TbDescripcion.Size = new Size(344, 96);
            TbDescripcion.TabIndex = 6;
            // 
            // TbPrecio
            // 
            TbPrecio.Location = new Point(162, 303);
            TbPrecio.Name = "TbPrecio";
            TbPrecio.Size = new Size(125, 34);
            TbPrecio.TabIndex = 7;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { BtnGuardar, BtnEditar, BtnEliminar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1100, 27);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // BtnGuardar
            // 
            BtnGuardar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            BtnGuardar.Image = (Image)resources.GetObject("BtnGuardar.Image");
            BtnGuardar.ImageTransparentColor = Color.Magenta;
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(29, 24);
            BtnGuardar.Text = "Guadar";
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // BtnEditar
            // 
            BtnEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            BtnEditar.Image = (Image)resources.GetObject("BtnEditar.Image");
            BtnEditar.ImageTransparentColor = Color.Magenta;
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(29, 24);
            BtnEditar.Text = "Editar";
            // 
            // BtnEliminar
            // 
            BtnEliminar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            BtnEliminar.Image = (Image)resources.GetObject("BtnEliminar.Image");
            BtnEliminar.ImageTransparentColor = Color.Magenta;
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(29, 24);
            BtnEliminar.Text = "Eliminar";
            // 
            // gbRegistros
            // 
            gbRegistros.Controls.Add(DgvRegistros);
            gbRegistros.Location = new Point(51, 484);
            gbRegistros.Name = "gbRegistros";
            gbRegistros.Size = new Size(979, 330);
            gbRegistros.TabIndex = 2;
            gbRegistros.TabStop = false;
            gbRegistros.Text = "Registros Guardados";
            // 
            // DgvRegistros
            // 
            DgvRegistros.AllowUserToAddRows = false;
            DgvRegistros.AllowUserToDeleteRows = false;
            DgvRegistros.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(192, 255, 192);
            dataGridViewCellStyle1.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DgvRegistros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DgvRegistros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvRegistros.Dock = DockStyle.Fill;
            DgvRegistros.Location = new Point(3, 30);
            DgvRegistros.Name = "DgvRegistros";
            DgvRegistros.ReadOnly = true;
            DgvRegistros.RowHeadersWidth = 51;
            DgvRegistros.Size = new Size(973, 297);
            DgvRegistros.TabIndex = 0;
            // 
            // ProductoFrm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 826);
            Controls.Add(gbRegistros);
            Controls.Add(toolStrip1);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4, 4, 4, 4);
            Name = "ProductoFrm";
            Text = "ProductoFrm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            gbRegistros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvRegistros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private TextBox TbPrecio;
        private TextBox TbDescripcion;
        private TextBox TbNombre;
        private TextBox TbID;
        private ToolStrip toolStrip1;
        private ToolStripButton BtnGuardar;
        private ToolStripButton BtnEditar;
        private ToolStripButton BtnEliminar;
        private GroupBox gbRegistros;
        private DataGridView DgvRegistros;
    }
}