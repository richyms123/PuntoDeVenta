namespace Punto_De_Venta
{
    partial class frmReporteComparativo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteComparativo));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.chartReporteComparativo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.chkListProductos = new System.Windows.Forms.CheckedListBox();
            this.cboMes2 = new Bunifu.UI.WinForms.BunifuDropdown();
            this.cboMes1 = new Bunifu.UI.WinForms.BunifuDropdown();
            this.btnGenerar = new FontAwesome.Sharp.Material.MaterialButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.materialPictureBox2 = new FontAwesome.Sharp.Material.MaterialPictureBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartReporteComparativo)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.bunifuPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1168, 712);
            this.panel1.TabIndex = 1;
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
            this.bunifuPanel1.Controls.Add(this.chartReporteComparativo);
            this.bunifuPanel1.Controls.Add(this.panel2);
            this.bunifuPanel1.Controls.Add(this.materialPictureBox2);
            this.bunifuPanel1.Controls.Add(this.lblUsuario);
            this.bunifuPanel1.Location = new System.Drawing.Point(27, 29);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(1100, 775);
            this.bunifuPanel1.TabIndex = 4;
            // 
            // chartReporteComparativo
            // 
            this.chartReporteComparativo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chartReporteComparativo.ChartAreas.Add(chartArea1);
            this.chartReporteComparativo.Location = new System.Drawing.Point(34, 303);
            this.chartReporteComparativo.Name = "chartReporteComparativo";
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.Name = "Series1";
            this.chartReporteComparativo.Series.Add(series1);
            this.chartReporteComparativo.Size = new System.Drawing.Size(1003, 443);
            this.chartReporteComparativo.TabIndex = 317;
            this.chartReporteComparativo.Text = "chart1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.BorderRadius = 20;
            this.panel2.BorderThickness = 1;
            this.panel2.Controls.Add(this.chkListProductos);
            this.panel2.Controls.Add(this.cboMes2);
            this.panel2.Controls.Add(this.cboMes1);
            this.panel2.Controls.Add(this.btnGenerar);
            this.panel2.Controls.Add(this.label3);
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
            this.panel2.Size = new System.Drawing.Size(1055, 192);
            this.panel2.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.panel2.TabIndex = 9;
            // 
            // chkListProductos
            // 
            this.chkListProductos.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkListProductos.FormattingEnabled = true;
            this.chkListProductos.HorizontalScrollbar = true;
            this.chkListProductos.Location = new System.Drawing.Point(506, 25);
            this.chkListProductos.Name = "chkListProductos";
            this.chkListProductos.Size = new System.Drawing.Size(513, 140);
            this.chkListProductos.TabIndex = 316;
            // 
            // cboMes2
            // 
            this.cboMes2.BackColor = System.Drawing.Color.Transparent;
            this.cboMes2.BackgroundColor = System.Drawing.Color.White;
            this.cboMes2.BorderColor = System.Drawing.Color.Silver;
            this.cboMes2.BorderRadius = 10;
            this.cboMes2.Color = System.Drawing.Color.Silver;
            this.cboMes2.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cboMes2.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cboMes2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cboMes2.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cboMes2.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cboMes2.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.cboMes2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboMes2.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.cboMes2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMes2.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cboMes2.FillDropDown = true;
            this.cboMes2.FillIndicator = false;
            this.cboMes2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboMes2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboMes2.ForeColor = System.Drawing.Color.Black;
            this.cboMes2.FormattingEnabled = true;
            this.cboMes2.Icon = null;
            this.cboMes2.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cboMes2.IndicatorColor = System.Drawing.Color.Gray;
            this.cboMes2.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cboMes2.ItemBackColor = System.Drawing.Color.White;
            this.cboMes2.ItemBorderColor = System.Drawing.Color.White;
            this.cboMes2.ItemForeColor = System.Drawing.Color.Black;
            this.cboMes2.ItemHeight = 37;
            this.cboMes2.ItemHighLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(67)))), ((int)(((byte)(21)))));
            this.cboMes2.ItemHighLightForeColor = System.Drawing.Color.White;
            this.cboMes2.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.cboMes2.ItemTopMargin = 3;
            this.cboMes2.Location = new System.Drawing.Point(269, 51);
            this.cboMes2.Name = "cboMes2";
            this.cboMes2.Size = new System.Drawing.Size(217, 43);
            this.cboMes2.TabIndex = 315;
            this.cboMes2.Text = null;
            this.cboMes2.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cboMes2.TextLeftMargin = 5;
            // 
            // cboMes1
            // 
            this.cboMes1.BackColor = System.Drawing.Color.Transparent;
            this.cboMes1.BackgroundColor = System.Drawing.Color.White;
            this.cboMes1.BorderColor = System.Drawing.Color.Silver;
            this.cboMes1.BorderRadius = 10;
            this.cboMes1.Color = System.Drawing.Color.Silver;
            this.cboMes1.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cboMes1.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cboMes1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cboMes1.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cboMes1.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cboMes1.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.cboMes1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboMes1.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.cboMes1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMes1.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cboMes1.FillDropDown = true;
            this.cboMes1.FillIndicator = false;
            this.cboMes1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboMes1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboMes1.ForeColor = System.Drawing.Color.Black;
            this.cboMes1.FormattingEnabled = true;
            this.cboMes1.Icon = null;
            this.cboMes1.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cboMes1.IndicatorColor = System.Drawing.Color.Gray;
            this.cboMes1.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cboMes1.ItemBackColor = System.Drawing.Color.White;
            this.cboMes1.ItemBorderColor = System.Drawing.Color.White;
            this.cboMes1.ItemForeColor = System.Drawing.Color.Black;
            this.cboMes1.ItemHeight = 37;
            this.cboMes1.ItemHighLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(67)))), ((int)(((byte)(21)))));
            this.cboMes1.ItemHighLightForeColor = System.Drawing.Color.White;
            this.cboMes1.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.cboMes1.ItemTopMargin = 3;
            this.cboMes1.Location = new System.Drawing.Point(31, 51);
            this.cboMes1.Name = "cboMes1";
            this.cboMes1.Size = new System.Drawing.Size(217, 43);
            this.cboMes1.TabIndex = 314;
            this.cboMes1.Text = null;
            this.cboMes1.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cboMes1.TextLeftMargin = 5;
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
            this.btnGenerar.Location = new System.Drawing.Point(31, 122);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(148, 43);
            this.btnGenerar.TabIndex = 301;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenerar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.label3.Location = new System.Drawing.Point(27, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 23);
            this.label3.TabIndex = 313;
            this.label3.Text = "Mes 1";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.label2.Location = new System.Drawing.Point(265, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 23);
            this.label2.TabIndex = 300;
            this.label2.Text = "Mes 2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.lblUsuario.Size = new System.Drawing.Size(336, 41);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "Reporte Comparativo";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this.btnGenerar;
            // 
            // frmReporteComparativo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1168, 712);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReporteComparativo";
            this.Text = "frmReporteComparativo";
            this.Load += new System.EventHandler(this.frmReporteComparativo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartReporteComparativo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialPictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuShadowPanel panel2;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.Material.MaterialButton btnGenerar;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.Material.MaterialPictureBox materialPictureBox2;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.CheckedListBox chkListProductos;
        private Bunifu.UI.WinForms.BunifuDropdown cboMes2;
        private Bunifu.UI.WinForms.BunifuDropdown cboMes1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartReporteComparativo;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}