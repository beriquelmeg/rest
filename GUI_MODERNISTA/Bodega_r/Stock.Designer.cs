﻿
namespace Diseno
{
    partial class Stock
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PnlFormulario = new System.Windows.Forms.Panel();
            this.DtStock = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnImagen = new System.Windows.Forms.Button();
            this.PicImagen = new System.Windows.Forms.PictureBox();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnAgregarCategoria = new System.Windows.Forms.Button();
            this.BtnCategoria = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.LytFormulario = new System.Windows.Forms.TableLayoutPanel();
            this.LblCategoria = new System.Windows.Forms.Label();
            this.CbxCategoria = new System.Windows.Forms.ComboBox();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.LblFechaV = new System.Windows.Forms.Label();
            this.LblStock = new System.Windows.Forms.Label();
            this.LblStockCritico = new System.Windows.Forms.Label();
            this.TxtStock = new System.Windows.Forms.TextBox();
            this.TxtStockCritico = new System.Windows.Forms.TextBox();
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.PnlFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtStock)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicImagen)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.LytFormulario.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlFormulario
            // 
            this.PnlFormulario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.PnlFormulario.Controls.Add(this.DtStock);
            this.PnlFormulario.Controls.Add(this.tableLayoutPanel2);
            this.PnlFormulario.Controls.Add(this.LytFormulario);
            this.PnlFormulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlFormulario.Location = new System.Drawing.Point(0, 0);
            this.PnlFormulario.Name = "PnlFormulario";
            this.PnlFormulario.Size = new System.Drawing.Size(1374, 625);
            this.PnlFormulario.TabIndex = 0;
            // 
            // DtStock
            // 
            this.DtStock.AllowUserToAddRows = false;
            this.DtStock.AllowUserToDeleteRows = false;
            this.DtStock.AllowUserToResizeRows = false;
            this.DtStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DtStock.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DtStock.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.DtStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DtStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DtStock.EnableHeadersVisualStyles = false;
            this.DtStock.GridColor = System.Drawing.Color.SteelBlue;
            this.DtStock.Location = new System.Drawing.Point(0, 314);
            this.DtStock.Name = "DtStock";
            this.DtStock.RowHeadersVisible = false;
            this.DtStock.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.DtStock.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DtStock.RowTemplate.Height = 24;
            this.DtStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtStock.Size = new System.Drawing.Size(1374, 311);
            this.DtStock.TabIndex = 4;
            this.DtStock.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtStock_CellContentDoubleClick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.48052F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.64935F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.89597F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 234F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 338F));
            this.tableLayoutPanel2.Controls.Add(this.BtnImagen, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.PicImagen, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnVolver, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnModificar, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 178);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1374, 136);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // BtnImagen
            // 
            this.BtnImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnImagen.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnImagen.ForeColor = System.Drawing.Color.White;
            this.BtnImagen.Location = new System.Drawing.Point(810, 3);
            this.BtnImagen.Name = "BtnImagen";
            this.BtnImagen.Size = new System.Drawing.Size(221, 39);
            this.BtnImagen.TabIndex = 7;
            this.BtnImagen.Text = "SELECCIONAR IMAGEN";
            this.BtnImagen.UseVisualStyleBackColor = false;
            this.BtnImagen.Click += new System.EventHandler(this.BtnImagen_Click);
            // 
            // PicImagen
            // 
            this.PicImagen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PicImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(99)))));
            this.PicImagen.Location = new System.Drawing.Point(1037, 3);
            this.PicImagen.Name = "PicImagen";
            this.PicImagen.Size = new System.Drawing.Size(272, 130);
            this.PicImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicImagen.TabIndex = 0;
            this.PicImagen.TabStop = false;
            // 
            // BtnVolver
            // 
            this.BtnVolver.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnVolver.ForeColor = System.Drawing.Color.White;
            this.BtnVolver.Location = new System.Drawing.Point(622, 3);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(141, 39);
            this.BtnVolver.TabIndex = 7;
            this.BtnVolver.Text = "VOLVER";
            this.BtnVolver.UseVisualStyleBackColor = false;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnModificar.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnModificar.ForeColor = System.Drawing.Color.White;
            this.BtnModificar.Location = new System.Drawing.Point(469, 3);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(141, 39);
            this.BtnModificar.TabIndex = 7;
            this.BtnModificar.Text = "MODIFICAR";
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.30901F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.69099F));
            this.tableLayoutPanel1.Controls.Add(this.BtnAgregarCategoria, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.BtnCategoria, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnAgregar, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.15385F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.84615F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(454, 130);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // BtnAgregarCategoria
            // 
            this.BtnAgregarCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAgregarCategoria.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnAgregarCategoria.ForeColor = System.Drawing.Color.White;
            this.BtnAgregarCategoria.Location = new System.Drawing.Point(310, 50);
            this.BtnAgregarCategoria.Name = "BtnAgregarCategoria";
            this.BtnAgregarCategoria.Size = new System.Drawing.Size(141, 41);
            this.BtnAgregarCategoria.TabIndex = 7;
            this.BtnAgregarCategoria.Text = "AGREGAR";
            this.BtnAgregarCategoria.UseVisualStyleBackColor = false;
            this.BtnAgregarCategoria.Click += new System.EventHandler(this.BtnAgregarCategoria_Click);
            // 
            // BtnCategoria
            // 
            this.BtnCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCategoria.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnCategoria.ForeColor = System.Drawing.Color.White;
            this.BtnCategoria.Location = new System.Drawing.Point(72, 3);
            this.BtnCategoria.Name = "BtnCategoria";
            this.BtnCategoria.Size = new System.Drawing.Size(226, 39);
            this.BtnCategoria.TabIndex = 7;
            this.BtnCategoria.Text = "AGREGAR CATEGORIA";
            this.BtnCategoria.UseVisualStyleBackColor = false;
            this.BtnCategoria.Click += new System.EventHandler(this.BtnCategoria_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAgregar.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnAgregar.ForeColor = System.Drawing.Color.White;
            this.BtnAgregar.Location = new System.Drawing.Point(310, 3);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(141, 39);
            this.BtnAgregar.TabIndex = 7;
            this.BtnAgregar.Text = "AGREGAR";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // LytFormulario
            // 
            this.LytFormulario.ColumnCount = 5;
            this.LytFormulario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.7931F));
            this.LytFormulario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.11885F));
            this.LytFormulario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.9369F));
            this.LytFormulario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.48863F));
            this.LytFormulario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.88261F));
            this.LytFormulario.Controls.Add(this.LblCategoria, 0, 4);
            this.LytFormulario.Controls.Add(this.CbxCategoria, 1, 4);
            this.LytFormulario.Controls.Add(this.TxtDescripcion, 1, 3);
            this.LytFormulario.Controls.Add(this.label5, 2, 0);
            this.LytFormulario.Controls.Add(this.LblDescripcion, 0, 3);
            this.LytFormulario.Controls.Add(this.LblNombre, 0, 2);
            this.LytFormulario.Controls.Add(this.TxtID, 0, 0);
            this.LytFormulario.Controls.Add(this.TxtNombre, 1, 2);
            this.LytFormulario.Controls.Add(this.LblFechaV, 2, 2);
            this.LytFormulario.Controls.Add(this.LblStock, 2, 3);
            this.LytFormulario.Controls.Add(this.LblStockCritico, 2, 4);
            this.LytFormulario.Controls.Add(this.TxtStock, 3, 3);
            this.LytFormulario.Controls.Add(this.TxtStockCritico, 3, 4);
            this.LytFormulario.Controls.Add(this.DtpFecha, 3, 2);
            this.LytFormulario.Dock = System.Windows.Forms.DockStyle.Top;
            this.LytFormulario.Location = new System.Drawing.Point(0, 0);
            this.LytFormulario.Name = "LytFormulario";
            this.LytFormulario.RowCount = 6;
            this.LytFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.31373F));
            this.LytFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.68627F));
            this.LytFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.LytFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.LytFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.LytFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.LytFormulario.Size = new System.Drawing.Size(1374, 178);
            this.LytFormulario.TabIndex = 0;
            // 
            // LblCategoria
            // 
            this.LblCategoria.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblCategoria.AutoSize = true;
            this.LblCategoria.ForeColor = System.Drawing.Color.White;
            this.LblCategoria.Location = new System.Drawing.Point(94, 132);
            this.LblCategoria.Name = "LblCategoria";
            this.LblCategoria.Size = new System.Drawing.Size(92, 17);
            this.LblCategoria.TabIndex = 1;
            this.LblCategoria.Text = "CATEGORIA:";
            // 
            // CbxCategoria
            // 
            this.CbxCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CbxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxCategoria.FormattingEnabled = true;
            this.CbxCategoria.Location = new System.Drawing.Point(192, 128);
            this.CbxCategoria.Name = "CbxCategoria";
            this.CbxCategoria.Size = new System.Drawing.Size(352, 24);
            this.CbxCategoria.TabIndex = 1;
            this.CbxCategoria.TextChanged += new System.EventHandler(this.CbxCategoria_TextChanged);
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtDescripcion.Location = new System.Drawing.Point(192, 97);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(352, 22);
            this.TxtDescripcion.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(572, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(249, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "STOCK DE PRODUCTOS";
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblDescripcion.AutoSize = true;
            this.LblDescripcion.ForeColor = System.Drawing.Color.White;
            this.LblDescripcion.Location = new System.Drawing.Point(82, 99);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(104, 17);
            this.LblDescripcion.TabIndex = 1;
            this.LblDescripcion.Text = "DESCRIPCION:";
            // 
            // LblNombre
            // 
            this.LblNombre.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblNombre.AutoSize = true;
            this.LblNombre.ForeColor = System.Drawing.Color.White;
            this.LblNombre.Location = new System.Drawing.Point(114, 68);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(72, 17);
            this.LblNombre.TabIndex = 1;
            this.LblNombre.Text = "NOMBRE:";
            // 
            // TxtID
            // 
            this.TxtID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtID.Location = new System.Drawing.Point(3, 15);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(183, 22);
            this.TxtID.TabIndex = 2;
            this.TxtID.Visible = false;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtNombre.Location = new System.Drawing.Point(192, 66);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(352, 22);
            this.TxtNombre.TabIndex = 2;
            // 
            // LblFechaV
            // 
            this.LblFechaV.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblFechaV.AutoSize = true;
            this.LblFechaV.ForeColor = System.Drawing.Color.White;
            this.LblFechaV.Location = new System.Drawing.Point(667, 68);
            this.LblFechaV.Name = "LblFechaV";
            this.LblFechaV.Size = new System.Drawing.Size(177, 17);
            this.LblFechaV.TabIndex = 1;
            this.LblFechaV.Text = "FECHA DE VENCIMIENTO:";
            // 
            // LblStock
            // 
            this.LblStock.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblStock.AutoSize = true;
            this.LblStock.ForeColor = System.Drawing.Color.White;
            this.LblStock.Location = new System.Drawing.Point(785, 99);
            this.LblStock.Name = "LblStock";
            this.LblStock.Size = new System.Drawing.Size(59, 17);
            this.LblStock.TabIndex = 1;
            this.LblStock.Text = "STOCK:";
            // 
            // LblStockCritico
            // 
            this.LblStockCritico.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblStockCritico.AutoSize = true;
            this.LblStockCritico.ForeColor = System.Drawing.Color.White;
            this.LblStockCritico.Location = new System.Drawing.Point(727, 132);
            this.LblStockCritico.Name = "LblStockCritico";
            this.LblStockCritico.Size = new System.Drawing.Size(117, 17);
            this.LblStockCritico.TabIndex = 1;
            this.LblStockCritico.Text = "STOCK CRITICO:";
            // 
            // TxtStock
            // 
            this.TxtStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtStock.Location = new System.Drawing.Point(850, 97);
            this.TxtStock.Name = "TxtStock";
            this.TxtStock.Size = new System.Drawing.Size(247, 22);
            this.TxtStock.TabIndex = 2;
            // 
            // TxtStockCritico
            // 
            this.TxtStockCritico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtStockCritico.Location = new System.Drawing.Point(850, 130);
            this.TxtStockCritico.Name = "TxtStockCritico";
            this.TxtStockCritico.Size = new System.Drawing.Size(247, 22);
            this.TxtStockCritico.TabIndex = 2;
            // 
            // DtpFecha
            // 
            this.DtpFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DtpFecha.CustomFormat = "dd/MM/yyyy";
            this.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpFecha.Location = new System.Drawing.Point(850, 66);
            this.DtpFecha.MaxDate = new System.DateTime(2040, 12, 31, 0, 0, 0, 0);
            this.DtpFecha.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(247, 22);
            this.DtpFecha.TabIndex = 4;
            this.DtpFecha.Value = new System.DateTime(2021, 10, 26, 0, 0, 0, 0);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 625);
            this.Controls.Add(this.PnlFormulario);
            this.Name = "Stock";
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.Stock_Load);
            this.PnlFormulario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtStock)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicImagen)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.LytFormulario.ResumeLayout(false);
            this.LytFormulario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlFormulario;
        private System.Windows.Forms.TableLayoutPanel LytFormulario;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label LblFechaV;
        private System.Windows.Forms.Label LblStock;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox TxtStockCritico;
        private System.Windows.Forms.PictureBox PicImagen;
        private System.Windows.Forms.Button BtnImagen;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnVolver;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Label LblCategoria;
        private System.Windows.Forms.ComboBox CbxCategoria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblStockCritico;
        private System.Windows.Forms.TextBox TxtStock;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DateTimePicker DtpFecha;
        private System.Windows.Forms.DataGridView DtStock;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button BtnCategoria;
        private System.Windows.Forms.Button BtnAgregarCategoria;
    }
}