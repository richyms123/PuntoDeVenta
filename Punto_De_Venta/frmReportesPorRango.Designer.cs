namespace Punto_De_Venta
{
    partial class frmReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.panel2 = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.btnGenerar = new FontAwesome.Sharp.Material.MaterialButton();
            this.materialPictureBox2 = new FontAwesome.Sharp.Material.MaterialPictureBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.dtpFechaFin = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDescargar = new FontAwesome.Sharp.Material.MaterialButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ctlReporte7 = new Punto_De_Venta.ControlesUsuario.ctlReporte();
            this.ctlReporte6 = new Punto_De_Venta.ControlesUsuario.ctlReporte();
            this.ctlReporte5 = new Punto_De_Venta.ControlesUsuario.ctlReporte();
            this.ctlReporte4 = new Punto_De_Venta.ControlesUsuario.ctlReporte();
            this.ctlReporte3 = new Punto_De_Venta.ControlesUsuario.ctlReporte();
            this.ctlReporte2 = new Punto_De_Venta.ControlesUsuario.ctlReporte();
            this.ctlReporte1 = new Punto_De_Venta.ControlesUsuario.ctlReporte();
            this.ctlTituloReporte1 = new Punto_De_Venta.ControlesUsuario.ctlTituloReporte();
            this.panel1.SuspendLayout();
            this.bunifuPanel1.SuspendLayout();
            this.pnlContenedor.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.bunifuPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1168, 712);
            this.panel1.TabIndex = 0;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.AutoSize = true;
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.White;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 20;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.pnlContenedor);
            this.bunifuPanel1.Controls.Add(this.panel2);
            this.bunifuPanel1.Controls.Add(this.materialPictureBox2);
            this.bunifuPanel1.Controls.Add(this.lblUsuario);
            this.bunifuPanel1.Location = new System.Drawing.Point(27, 29);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(1100, 652);
            this.bunifuPanel1.TabIndex = 4;
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.AutoSize = true;
            this.pnlContenedor.BackColor = System.Drawing.Color.White;
            this.pnlContenedor.Controls.Add(this.ctlReporte7);
            this.pnlContenedor.Controls.Add(this.ctlReporte6);
            this.pnlContenedor.Controls.Add(this.ctlReporte5);
            this.pnlContenedor.Controls.Add(this.ctlReporte4);
            this.pnlContenedor.Controls.Add(this.ctlReporte3);
            this.pnlContenedor.Controls.Add(this.ctlReporte2);
            this.pnlContenedor.Controls.Add(this.ctlReporte1);
            this.pnlContenedor.Controls.Add(this.ctlTituloReporte1);
            this.pnlContenedor.Location = new System.Drawing.Point(18, 229);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(1055, 420);
            this.pnlContenedor.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.BorderRadius = 20;
            this.panel2.BorderThickness = 1;
            this.panel2.Controls.Add(this.btnDescargar);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dtpFechaFin);
            this.panel2.Controls.Add(this.dtpFechaInicio);
            this.panel2.Controls.Add(this.btnGenerar);
            this.panel2.Controls.Add(this.label2);
            this.panel2.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.panel2.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.panel2.Location = new System.Drawing.Point(18, 78);
            this.panel2.Name = "panel2";
            this.panel2.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panel2.PanelColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panel2.ShadowColor = System.Drawing.Color.Silver;
            this.panel2.ShadowDept = 2;
            this.panel2.ShadowDepth = 0;
            this.panel2.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.ForwardDiagonal;
            this.panel2.ShadowTopLeftVisible = false;
            this.panel2.Size = new System.Drawing.Size(1055, 129);
            this.panel2.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.panel2.TabIndex = 9;
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(67)))), ((int)(((byte)(21)))));
            this.btnGenerar.FlatAppearance.BorderSize = 0;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.ForeColor = System.Drawing.Color.White;
            this.btnGenerar.IconChar = FontAwesome.Sharp.MaterialIcons.CogClockwise;
            this.btnGenerar.IconColor = System.Drawing.Color.White;
            this.btnGenerar.IconSize = 40;
            this.btnGenerar.Location = new System.Drawing.Point(896, 51);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(148, 43);
            this.btnGenerar.TabIndex = 301;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenerar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGenerar.UseVisualStyleBackColor = false;
            // 
            // materialPictureBox2
            // 
            this.materialPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.materialPictureBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.materialPictureBox2.IconChar = FontAwesome.Sharp.MaterialIcons.FileChart;
            this.materialPictureBox2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.materialPictureBox2.IconSize = 55;
            this.materialPictureBox2.Location = new System.Drawing.Point(18, 15);
            this.materialPictureBox2.Name = "materialPictureBox2";
            this.materialPictureBox2.Size = new System.Drawing.Size(55, 55);
            this.materialPictureBox2.TabIndex = 6;
            this.materialPictureBox2.TabStop = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.lblUsuario.Location = new System.Drawing.Point(73, 20);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(286, 41);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "Reporte de ventas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.label2.Location = new System.Drawing.Point(350, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 23);
            this.label2.TabIndex = 300;
            this.label2.Text = "Fin";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.BackColor = System.Drawing.Color.Transparent;
            this.dtpFechaInicio.BorderRadius = 15;
            this.dtpFechaInicio.Color = System.Drawing.Color.Silver;
            this.dtpFechaInicio.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.dtpFechaInicio.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.dtpFechaInicio.DisabledColor = System.Drawing.Color.Gray;
            this.dtpFechaInicio.DisplayWeekNumbers = false;
            this.dtpFechaInicio.DPHeight = 0;
            this.dtpFechaInicio.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpFechaInicio.FillDatePicker = false;
            this.dtpFechaInicio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpFechaInicio.ForeColor = System.Drawing.Color.Black;
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Icon = ((System.Drawing.Image)(resources.GetObject("dtpFechaInicio.Icon")));
            this.dtpFechaInicio.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(67)))), ((int)(((byte)(21)))));
            this.dtpFechaInicio.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.dtpFechaInicio.LeftTextMargin = 5;
            this.dtpFechaInicio.Location = new System.Drawing.Point(20, 51);
            this.dtpFechaInicio.MinimumSize = new System.Drawing.Size(4, 43);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(300, 43);
            this.dtpFechaInicio.TabIndex = 311;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.BackColor = System.Drawing.Color.Transparent;
            this.dtpFechaFin.BorderRadius = 15;
            this.dtpFechaFin.Color = System.Drawing.Color.Silver;
            this.dtpFechaFin.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.dtpFechaFin.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.dtpFechaFin.DisabledColor = System.Drawing.Color.Gray;
            this.dtpFechaFin.DisplayWeekNumbers = false;
            this.dtpFechaFin.DPHeight = 0;
            this.dtpFechaFin.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpFechaFin.FillDatePicker = false;
            this.dtpFechaFin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpFechaFin.ForeColor = System.Drawing.Color.Black;
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Icon = ((System.Drawing.Image)(resources.GetObject("dtpFechaFin.Icon")));
            this.dtpFechaFin.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(67)))), ((int)(((byte)(21)))));
            this.dtpFechaFin.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.dtpFechaFin.LeftTextMargin = 5;
            this.dtpFechaFin.Location = new System.Drawing.Point(345, 51);
            this.dtpFechaFin.MinimumSize = new System.Drawing.Size(4, 43);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(300, 43);
            this.dtpFechaFin.TabIndex = 312;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.label3.Location = new System.Drawing.Point(27, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 23);
            this.label3.TabIndex = 313;
            this.label3.Text = "Inicio";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDescargar
            // 
            this.btnDescargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.btnDescargar.FlatAppearance.BorderSize = 0;
            this.btnDescargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescargar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescargar.ForeColor = System.Drawing.Color.White;
            this.btnDescargar.IconChar = FontAwesome.Sharp.MaterialIcons.FileExcel;
            this.btnDescargar.IconColor = System.Drawing.Color.White;
            this.btnDescargar.IconSize = 40;
            this.btnDescargar.Location = new System.Drawing.Point(733, 51);
            this.btnDescargar.Name = "btnDescargar";
            this.btnDescargar.Size = new System.Drawing.Size(148, 43);
            this.btnDescargar.TabIndex = 314;
            this.btnDescargar.Text = "Descargar";
            this.btnDescargar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDescargar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDescargar.UseVisualStyleBackColor = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this.btnDescargar;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 15;
            this.bunifuElipse2.TargetControl = this.btnGenerar;
            // 
            // ctlReporte7
            // 
            this.ctlReporte7.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctlReporte7.Location = new System.Drawing.Point(0, 350);
            this.ctlReporte7.Name = "ctlReporte7";
            this.ctlReporte7.Size = new System.Drawing.Size(1055, 50);
            this.ctlReporte7.TabIndex = 7;
            // 
            // ctlReporte6
            // 
            this.ctlReporte6.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctlReporte6.Location = new System.Drawing.Point(0, 300);
            this.ctlReporte6.Name = "ctlReporte6";
            this.ctlReporte6.Size = new System.Drawing.Size(1055, 50);
            this.ctlReporte6.TabIndex = 6;
            // 
            // ctlReporte5
            // 
            this.ctlReporte5.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctlReporte5.Location = new System.Drawing.Point(0, 250);
            this.ctlReporte5.Name = "ctlReporte5";
            this.ctlReporte5.Size = new System.Drawing.Size(1055, 50);
            this.ctlReporte5.TabIndex = 5;
            // 
            // ctlReporte4
            // 
            this.ctlReporte4.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctlReporte4.Location = new System.Drawing.Point(0, 200);
            this.ctlReporte4.Name = "ctlReporte4";
            this.ctlReporte4.Size = new System.Drawing.Size(1055, 50);
            this.ctlReporte4.TabIndex = 4;
            // 
            // ctlReporte3
            // 
            this.ctlReporte3.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctlReporte3.Location = new System.Drawing.Point(0, 150);
            this.ctlReporte3.Name = "ctlReporte3";
            this.ctlReporte3.Size = new System.Drawing.Size(1055, 50);
            this.ctlReporte3.TabIndex = 3;
            // 
            // ctlReporte2
            // 
            this.ctlReporte2.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctlReporte2.Location = new System.Drawing.Point(0, 100);
            this.ctlReporte2.Name = "ctlReporte2";
            this.ctlReporte2.Size = new System.Drawing.Size(1055, 50);
            this.ctlReporte2.TabIndex = 2;
            // 
            // ctlReporte1
            // 
            this.ctlReporte1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctlReporte1.Location = new System.Drawing.Point(0, 50);
            this.ctlReporte1.Name = "ctlReporte1";
            this.ctlReporte1.Size = new System.Drawing.Size(1055, 50);
            this.ctlReporte1.TabIndex = 1;
            // 
            // ctlTituloReporte1
            // 
            this.ctlTituloReporte1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.ctlTituloReporte1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctlTituloReporte1.Location = new System.Drawing.Point(0, 0);
            this.ctlTituloReporte1.Name = "ctlTituloReporte1";
            this.ctlTituloReporte1.Size = new System.Drawing.Size(1055, 50);
            this.ctlTituloReporte1.TabIndex = 0;
            // 
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1168, 712);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReportes";
            this.Text = "frmReportes";
            this.Load += new System.EventHandler(this.frmReportes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            this.pnlContenedor.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialPictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private System.Windows.Forms.Panel pnlContenedor;
        private Bunifu.UI.WinForms.BunifuShadowPanel panel2;
        private FontAwesome.Sharp.Material.MaterialButton btnGenerar;
        private FontAwesome.Sharp.Material.MaterialPictureBox materialPictureBox2;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.UI.WinForms.BunifuDatePicker dtpFechaFin;
        private Bunifu.UI.WinForms.BunifuDatePicker dtpFechaInicio;
        private ControlesUsuario.ctlReporte ctlReporte7;
        private ControlesUsuario.ctlReporte ctlReporte6;
        private ControlesUsuario.ctlReporte ctlReporte5;
        private ControlesUsuario.ctlReporte ctlReporte4;
        private ControlesUsuario.ctlReporte ctlReporte3;
        private ControlesUsuario.ctlReporte ctlReporte2;
        private ControlesUsuario.ctlReporte ctlReporte1;
        private ControlesUsuario.ctlTituloReporte ctlTituloReporte1;
        private FontAwesome.Sharp.Material.MaterialButton btnDescargar;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
    }
}