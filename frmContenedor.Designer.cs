
namespace StockIt
{
    partial class frmContenedor
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
            this.panelFormularioHijoC = new System.Windows.Forms.Panel();
            this.lklRegistrate = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.lklPasOlv = new System.Windows.Forms.LinkLabel();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkbMostrarPwd = new System.Windows.Forms.CheckBox();
            this.panelFormularioHijoC.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFormularioHijoC
            // 
            this.panelFormularioHijoC.BackColor = System.Drawing.Color.White;
            this.panelFormularioHijoC.Controls.Add(this.chkbMostrarPwd);
            this.panelFormularioHijoC.Controls.Add(this.lklRegistrate);
            this.panelFormularioHijoC.Controls.Add(this.label4);
            this.panelFormularioHijoC.Controls.Add(this.lklPasOlv);
            this.panelFormularioHijoC.Controls.Add(this.btnIniciarSesion);
            this.panelFormularioHijoC.Controls.Add(this.label3);
            this.panelFormularioHijoC.Controls.Add(this.txtPassword);
            this.panelFormularioHijoC.Controls.Add(this.label2);
            this.panelFormularioHijoC.Controls.Add(this.txtCorreo);
            this.panelFormularioHijoC.Controls.Add(this.label1);
            this.panelFormularioHijoC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormularioHijoC.Location = new System.Drawing.Point(0, 0);
            this.panelFormularioHijoC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelFormularioHijoC.Name = "panelFormularioHijoC";
            this.panelFormularioHijoC.Size = new System.Drawing.Size(1371, 750);
            this.panelFormularioHijoC.TabIndex = 0;
            // 
            // lklRegistrate
            // 
            this.lklRegistrate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lklRegistrate.AutoSize = true;
            this.lklRegistrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklRegistrate.Location = new System.Drawing.Point(756, 507);
            this.lklRegistrate.Name = "lklRegistrate";
            this.lklRegistrate.Size = new System.Drawing.Size(86, 20);
            this.lklRegistrate.TabIndex = 13;
            this.lklRegistrate.TabStop = true;
            this.lklRegistrate.Text = "Registrate";
            this.lklRegistrate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklRegistrate_LinkClicked);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(535, 507);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "¿No tienes una cuenta?";
            // 
            // lklPasOlv
            // 
            this.lklPasOlv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lklPasOlv.AutoSize = true;
            this.lklPasOlv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklPasOlv.Location = new System.Drawing.Point(555, 372);
            this.lklPasOlv.Name = "lklPasOlv";
            this.lklPasOlv.Size = new System.Drawing.Size(232, 20);
            this.lklPasOlv.TabIndex = 11;
            this.lklPasOlv.TabStop = true;
            this.lklPasOlv.Text = "¿Has olvidado tu contraseña?";
            this.lklPasOlv.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklPasOlv_LinkClicked);
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIniciarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(117)))), ((int)(((byte)(169)))));
            this.btnIniciarSesion.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesion.ForeColor = System.Drawing.Color.White;
            this.btnIniciarSesion.Location = new System.Drawing.Point(620, 430);
            this.btnIniciarSesion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(131, 39);
            this.btnIniciarSesion.TabIndex = 10;
            this.btnIniciarSesion.Text = "Iniciar";
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(435, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Contraseña";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(435, 286);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(500, 30);
            this.txtPassword.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(435, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Correo";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(435, 176);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(500, 30);
            this.txtCorreo.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-56, -153);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 150, 0, 0);
            this.label1.Size = new System.Drawing.Size(1483, 213);
            this.label1.TabIndex = 1;
            this.label1.Text = "Iniciar Sesión";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // chkbMostrarPwd
            // 
            this.chkbMostrarPwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkbMostrarPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbMostrarPwd.Location = new System.Drawing.Point(439, 330);
            this.chkbMostrarPwd.Name = "chkbMostrarPwd";
            this.chkbMostrarPwd.Size = new System.Drawing.Size(215, 24);
            this.chkbMostrarPwd.TabIndex = 17;
            this.chkbMostrarPwd.Text = "Mostrar Contraseña";
            this.chkbMostrarPwd.UseVisualStyleBackColor = true;
            this.chkbMostrarPwd.CheckedChanged += new System.EventHandler(this.chkbMostrarPwd_CheckedChanged);
            // 
            // frmContenedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 750);
            this.Controls.Add(this.panelFormularioHijoC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmContenedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock It";
            this.Load += new System.EventHandler(this.frmContenedor_Load);
            this.panelFormularioHijoC.ResumeLayout(false);
            this.panelFormularioHijoC.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFormularioHijoC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.LinkLabel lklPasOlv;
        private System.Windows.Forms.LinkLabel lklRegistrate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkbMostrarPwd;
    }
}