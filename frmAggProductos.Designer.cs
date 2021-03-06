
namespace StockIt
{
    partial class frmAggProductos
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSImagen = new System.Windows.Forms.Button();
            this.txtNomProd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDetProd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxCatProd = new System.Windows.Forms.ComboBox();
            this.nudCanProd = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.mskPorGanancia = new System.Windows.Forms.MaskedTextBox();
            this.txtGanancia = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.btnSelProveedor = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.mskPrecLote = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPrecUnitario = new System.Windows.Forms.TextBox();
            this.txtPrecVenta = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblIDCompra = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lklProductos = new System.Windows.Forms.LinkLabel();
            this.ttSelProveedor = new System.Windows.Forms.ToolTip(this.components);
            this.ttSelImagen = new System.Windows.Forms.ToolTip(this.components);
            this.ttAgregar = new System.Windows.Forms.ToolTip(this.components);
            this.ttLimpiar = new System.Windows.Forms.ToolTip(this.components);
            this.ttFinalizar = new System.Windows.Forms.ToolTip(this.components);
            this.ttCancelar = new System.Windows.Forms.ToolTip(this.components);
            this.ttProductos = new System.Windows.Forms.ToolTip(this.components);
            this.lblIdProveedor = new System.Windows.Forms.Label();
            this.pbxImgProd = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudCanProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImgProd)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label1.Size = new System.Drawing.Size(1231, 70);
            this.label1.TabIndex = 0;
            this.label1.Text = "Compra de Productos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSImagen
            // 
            this.btnSImagen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(117)))), ((int)(((byte)(169)))));
            this.btnSImagen.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSImagen.ForeColor = System.Drawing.Color.White;
            this.btnSImagen.Location = new System.Drawing.Point(385, 271);
            this.btnSImagen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSImagen.Name = "btnSImagen";
            this.btnSImagen.Size = new System.Drawing.Size(131, 39);
            this.btnSImagen.TabIndex = 1;
            this.btnSImagen.Text = "Seleccionar";
            this.btnSImagen.UseVisualStyleBackColor = false;
            this.btnSImagen.Click += new System.EventHandler(this.btnSImagen_Click);
            // 
            // txtNomProd
            // 
            this.txtNomProd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNomProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.txtNomProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomProd.Location = new System.Drawing.Point(215, 450);
            this.txtNomProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomProd.Name = "txtNomProd";
            this.txtNomProd.Size = new System.Drawing.Size(800, 30);
            this.txtNomProd.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(215, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre de Producto";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(215, 500);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(815, 500);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Precio Unitario";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(215, 660);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(245, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Detalles Adicionales (Opcional)";
            // 
            // txtDetProd
            // 
            this.txtDetProd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDetProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.txtDetProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetProd.Location = new System.Drawing.Point(215, 690);
            this.txtDetProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDetProd.Name = "txtDetProd";
            this.txtDetProd.Size = new System.Drawing.Size(800, 30);
            this.txtDetProd.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(665, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Categoría";
            // 
            // cbxCatProd
            // 
            this.cbxCatProd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxCatProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.cbxCatProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCatProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCatProd.FormattingEnabled = true;
            this.cbxCatProd.Location = new System.Drawing.Point(665, 369);
            this.cbxCatProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxCatProd.Name = "cbxCatProd";
            this.cbxCatProd.Size = new System.Drawing.Size(350, 33);
            this.cbxCatProd.TabIndex = 3;
            // 
            // nudCanProd
            // 
            this.nudCanProd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nudCanProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.nudCanProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCanProd.Location = new System.Drawing.Point(215, 530);
            this.nudCanProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudCanProd.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudCanProd.Name = "nudCanProd";
            this.nudCanProd.Size = new System.Drawing.Size(200, 30);
            this.nudCanProd.TabIndex = 5;
            this.nudCanProd.ValueChanged += new System.EventHandler(this.nudCanProd_ValueChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(215, 580);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(188, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Porcentaje de Ganancia";
            // 
            // mskPorGanancia
            // 
            this.mskPorGanancia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mskPorGanancia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.mskPorGanancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskPorGanancia.Location = new System.Drawing.Point(215, 610);
            this.mskPorGanancia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mskPorGanancia.Mask = "000";
            this.mskPorGanancia.Name = "mskPorGanancia";
            this.mskPorGanancia.Size = new System.Drawing.Size(200, 30);
            this.mskPorGanancia.TabIndex = 8;
            this.mskPorGanancia.ValidatingType = typeof(int);
            this.mskPorGanancia.TextChanged += new System.EventHandler(this.mskPorGanancia_TextChanged);
            // 
            // txtGanancia
            // 
            this.txtGanancia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGanancia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.txtGanancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGanancia.Location = new System.Drawing.Point(515, 610);
            this.txtGanancia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGanancia.Name = "txtGanancia";
            this.txtGanancia.ReadOnly = true;
            this.txtGanancia.Size = new System.Drawing.Size(200, 30);
            this.txtGanancia.TabIndex = 9;
            this.txtGanancia.Text = "$0.00";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(515, 580);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Ganancia ($)";
            // 
            // txtProveedor
            // 
            this.txtProveedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.txtProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProveedor.Location = new System.Drawing.Point(215, 370);
            this.txtProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.ReadOnly = true;
            this.txtProveedor.Size = new System.Drawing.Size(350, 30);
            this.txtProveedor.TabIndex = 17;
            // 
            // btnSelProveedor
            // 
            this.btnSelProveedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSelProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(117)))), ((int)(((byte)(169)))));
            this.btnSelProveedor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSelProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelProveedor.ForeColor = System.Drawing.Color.White;
            this.btnSelProveedor.Location = new System.Drawing.Point(575, 366);
            this.btnSelProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelProveedor.Name = "btnSelProveedor";
            this.btnSelProveedor.Size = new System.Drawing.Size(50, 39);
            this.btnSelProveedor.TabIndex = 2;
            this.btnSelProveedor.Text = "...";
            this.btnSelProveedor.UseVisualStyleBackColor = false;
            this.btnSelProveedor.Click += new System.EventHandler(this.btnSelProveedor_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(215, 340);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Proveedor";
            // 
            // mskPrecLote
            // 
            this.mskPrecLote.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mskPrecLote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.mskPrecLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskPrecLote.Location = new System.Drawing.Point(515, 530);
            this.mskPrecLote.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mskPrecLote.Mask = "$000000.00";
            this.mskPrecLote.Name = "mskPrecLote";
            this.mskPrecLote.PromptChar = '0';
            this.mskPrecLote.Size = new System.Drawing.Size(200, 30);
            this.mskPrecLote.TabIndex = 6;
            this.mskPrecLote.TextChanged += new System.EventHandler(this.mskPrecLote_TextChanged);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(515, 500);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "Precio Lote";
            // 
            // txtPrecUnitario
            // 
            this.txtPrecUnitario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrecUnitario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.txtPrecUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecUnitario.Location = new System.Drawing.Point(815, 530);
            this.txtPrecUnitario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrecUnitario.Name = "txtPrecUnitario";
            this.txtPrecUnitario.ReadOnly = true;
            this.txtPrecUnitario.Size = new System.Drawing.Size(200, 30);
            this.txtPrecUnitario.TabIndex = 7;
            this.txtPrecUnitario.Text = "$0.00";
            // 
            // txtPrecVenta
            // 
            this.txtPrecVenta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrecVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.txtPrecVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecVenta.Location = new System.Drawing.Point(815, 610);
            this.txtPrecVenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrecVenta.Name = "txtPrecVenta";
            this.txtPrecVenta.ReadOnly = true;
            this.txtPrecVenta.Size = new System.Drawing.Size(200, 30);
            this.txtPrecVenta.TabIndex = 10;
            this.txtPrecVenta.Text = "$0.00";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(815, 580);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "Precio Venta";
            // 
            // lblIDCompra
            // 
            this.lblIDCompra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIDCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDCompra.Location = new System.Drawing.Point(575, 150);
            this.lblIDCompra.Name = "lblIDCompra";
            this.lblIDCompra.Size = new System.Drawing.Size(440, 20);
            this.lblIDCompra.TabIndex = 25;
            this.lblIDCompra.Text = "ID Compra: 0";
            this.lblIDCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(184)))), ((int)(((byte)(81)))));
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(296, 750);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(131, 39);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(62)))), ((int)(((byte)(87)))));
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(803, 750);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(131, 39);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFinalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(95)))), ((int)(((byte)(134)))));
            this.btnFinalizar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.ForeColor = System.Drawing.Color.White;
            this.btnFinalizar.Location = new System.Drawing.Point(634, 750);
            this.btnFinalizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(131, 39);
            this.btnFinalizar.TabIndex = 14;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLimpiar.BackColor = System.Drawing.Color.Gray;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(465, 750);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(131, 39);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lklProductos
            // 
            this.lklProductos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lklProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklProductos.ForeColor = System.Drawing.Color.White;
            this.lklProductos.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lklProductos.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(120)))), ((int)(((byte)(217)))));
            this.lklProductos.Location = new System.Drawing.Point(575, 180);
            this.lklProductos.Name = "lklProductos";
            this.lklProductos.Size = new System.Drawing.Size(440, 23);
            this.lklProductos.TabIndex = 16;
            this.lklProductos.TabStop = true;
            this.lklProductos.Text = "Productos de esta compra: 0";
            this.lklProductos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lklProductos.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklProductos_LinkClicked);
            // 
            // lblIdProveedor
            // 
            this.lblIdProveedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIdProveedor.AutoSize = true;
            this.lblIdProveedor.Location = new System.Drawing.Point(312, 340);
            this.lblIdProveedor.Name = "lblIdProveedor";
            this.lblIdProveedor.Size = new System.Drawing.Size(99, 17);
            this.lblIdProveedor.TabIndex = 26;
            this.lblIdProveedor.Text = "lblIdProveedor";
            this.lblIdProveedor.Visible = false;
            // 
            // pbxImgProd
            // 
            this.pbxImgProd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbxImgProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxImgProd.Image = global::StockIt.Properties.Resources.noImage;
            this.pbxImgProd.Location = new System.Drawing.Point(215, 150);
            this.pbxImgProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbxImgProd.Name = "pbxImgProd";
            this.pbxImgProd.Size = new System.Drawing.Size(160, 160);
            this.pbxImgProd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImgProd.TabIndex = 1;
            this.pbxImgProd.TabStop = false;
            // 
            // frmAggProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1231, 1102);
            this.Controls.Add(this.lblIdProveedor);
            this.Controls.Add(this.lklProductos);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.lblIDCompra);
            this.Controls.Add(this.txtPrecVenta);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtPrecUnitario);
            this.Controls.Add(this.mskPrecLote);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnSelProveedor);
            this.Controls.Add(this.txtProveedor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtGanancia);
            this.Controls.Add(this.mskPorGanancia);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nudCanProd);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cbxCatProd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDetProd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomProd);
            this.Controls.Add(this.btnSImagen);
            this.Controls.Add(this.pbxImgProd);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAggProductos";
            this.Text = "frmAggProductos";
            this.Load += new System.EventHandler(this.frmAggProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCanProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImgProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbxImgProd;
        private System.Windows.Forms.Button btnSImagen;
        private System.Windows.Forms.TextBox txtNomProd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDetProd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxCatProd;
        private System.Windows.Forms.NumericUpDown nudCanProd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mskPorGanancia;
        private System.Windows.Forms.TextBox txtGanancia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox mskPrecLote;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPrecUnitario;
        private System.Windows.Forms.TextBox txtPrecVenta;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblIDCompra;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ToolTip ttSelProveedor;
        private System.Windows.Forms.ToolTip ttSelImagen;
        private System.Windows.Forms.ToolTip ttAgregar;
        private System.Windows.Forms.ToolTip ttLimpiar;
        private System.Windows.Forms.ToolTip ttFinalizar;
        private System.Windows.Forms.ToolTip ttCancelar;
        private System.Windows.Forms.ToolTip ttProductos;
        private System.Windows.Forms.Label lblIdProveedor;
        public System.Windows.Forms.LinkLabel lklProductos;
        public System.Windows.Forms.Button btnSelProveedor;
    }
}