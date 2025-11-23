namespace Punto_De_Venta
{
    partial class frmEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpleados));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.btnNuevoEmpleado = new FontAwesome.Sharp.Material.MaterialButton();
            this.pnlContenedor = new System.Windows.Forms.FlowLayoutPanel();
            this.ctlEmpleado4 = new Punto_De_Venta.ControlesUsuario.ctlEmpleado();
            this.ctlEmpleado5 = new Punto_De_Venta.ControlesUsuario.ctlEmpleado();
            this.ctlEmpleado6 = new Punto_De_Venta.ControlesUsuario.ctlEmpleado();
            this.ctlEmpleado7 = new Punto_De_Venta.ControlesUsuario.ctlEmpleado();
            this.ctlEmpleado8 = new Punto_De_Venta.ControlesUsuario.ctlEmpleado();
            this.ctlEmpleado9 = new Punto_De_Venta.ControlesUsuario.ctlEmpleado();
            this.materialPictureBox2 = new FontAwesome.Sharp.Material.MaterialPictureBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            this.bunifuPanel1.SuspendLayout();
            this.pnlContenedor.SuspendLayout();
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
            this.bunifuPanel1.Controls.Add(this.btnNuevoEmpleado);
            this.bunifuPanel1.Controls.Add(this.pnlContenedor);
            this.bunifuPanel1.Controls.Add(this.materialPictureBox2);
            this.bunifuPanel1.Controls.Add(this.lblUsuario);
            this.bunifuPanel1.Location = new System.Drawing.Point(23, 23);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(1100, 675);
            this.bunifuPanel1.TabIndex = 3;
            // 
            // btnNuevoEmpleado
            // 
            this.btnNuevoEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(67)))), ((int)(((byte)(21)))));
            this.btnNuevoEmpleado.FlatAppearance.BorderSize = 0;
            this.btnNuevoEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoEmpleado.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoEmpleado.ForeColor = System.Drawing.Color.White;
            this.btnNuevoEmpleado.IconChar = FontAwesome.Sharp.MaterialIcons.AccountPlus;
            this.btnNuevoEmpleado.IconColor = System.Drawing.Color.White;
            this.btnNuevoEmpleado.IconSize = 40;
            this.btnNuevoEmpleado.Location = new System.Drawing.Point(840, 25);
            this.btnNuevoEmpleado.Name = "btnNuevoEmpleado";
            this.btnNuevoEmpleado.Size = new System.Drawing.Size(241, 43);
            this.btnNuevoEmpleado.TabIndex = 302;
            this.btnNuevoEmpleado.Text = "Nuevo empleado";
            this.btnNuevoEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevoEmpleado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevoEmpleado.UseVisualStyleBackColor = false;
            this.btnNuevoEmpleado.Click += new System.EventHandler(this.btnNuevoEmpleado_Click);
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.AutoScroll = true;
            this.pnlContenedor.BackColor = System.Drawing.Color.White;
            this.pnlContenedor.Controls.Add(this.ctlEmpleado4);
            this.pnlContenedor.Controls.Add(this.ctlEmpleado5);
            this.pnlContenedor.Controls.Add(this.ctlEmpleado6);
            this.pnlContenedor.Controls.Add(this.ctlEmpleado7);
            this.pnlContenedor.Controls.Add(this.ctlEmpleado8);
            this.pnlContenedor.Controls.Add(this.ctlEmpleado9);
            this.pnlContenedor.Location = new System.Drawing.Point(18, 93);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(1063, 560);
            this.pnlContenedor.TabIndex = 7;
            // 
            // ctlEmpleado4
            // 
            this.ctlEmpleado4.BackColor = System.Drawing.Color.Transparent;
            this.ctlEmpleado4.Location = new System.Drawing.Point(5, 5);
            this.ctlEmpleado4.Margin = new System.Windows.Forms.Padding(5);
            this.ctlEmpleado4.Name = "ctlEmpleado4";
            this.ctlEmpleado4.Size = new System.Drawing.Size(506, 140);
            this.ctlEmpleado4.TabIndex = 3;
            // 
            // ctlEmpleado5
            // 
            this.ctlEmpleado5.BackColor = System.Drawing.Color.Transparent;
            this.ctlEmpleado5.Location = new System.Drawing.Point(521, 5);
            this.ctlEmpleado5.Margin = new System.Windows.Forms.Padding(5);
            this.ctlEmpleado5.Name = "ctlEmpleado5";
            this.ctlEmpleado5.Size = new System.Drawing.Size(506, 140);
            this.ctlEmpleado5.TabIndex = 4;
            // 
            // ctlEmpleado6
            // 
            this.ctlEmpleado6.BackColor = System.Drawing.Color.Transparent;
            this.ctlEmpleado6.Location = new System.Drawing.Point(5, 155);
            this.ctlEmpleado6.Margin = new System.Windows.Forms.Padding(5);
            this.ctlEmpleado6.Name = "ctlEmpleado6";
            this.ctlEmpleado6.Size = new System.Drawing.Size(506, 140);
            this.ctlEmpleado6.TabIndex = 5;
            // 
            // ctlEmpleado7
            // 
            this.ctlEmpleado7.BackColor = System.Drawing.Color.Transparent;
            this.ctlEmpleado7.Location = new System.Drawing.Point(521, 155);
            this.ctlEmpleado7.Margin = new System.Windows.Forms.Padding(5);
            this.ctlEmpleado7.Name = "ctlEmpleado7";
            this.ctlEmpleado7.Size = new System.Drawing.Size(506, 140);
            this.ctlEmpleado7.TabIndex = 6;
            // 
            // ctlEmpleado8
            // 
            this.ctlEmpleado8.BackColor = System.Drawing.Color.Transparent;
            this.ctlEmpleado8.Location = new System.Drawing.Point(5, 305);
            this.ctlEmpleado8.Margin = new System.Windows.Forms.Padding(5);
            this.ctlEmpleado8.Name = "ctlEmpleado8";
            this.ctlEmpleado8.Size = new System.Drawing.Size(506, 140);
            this.ctlEmpleado8.TabIndex = 7;
            // 
            // ctlEmpleado9
            // 
            this.ctlEmpleado9.BackColor = System.Drawing.Color.Transparent;
            this.ctlEmpleado9.Location = new System.Drawing.Point(521, 305);
            this.ctlEmpleado9.Margin = new System.Windows.Forms.Padding(5);
            this.ctlEmpleado9.Name = "ctlEmpleado9";
            this.ctlEmpleado9.Size = new System.Drawing.Size(506, 140);
            this.ctlEmpleado9.TabIndex = 8;
            // 
            // materialPictureBox2
            // 
            this.materialPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.materialPictureBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.materialPictureBox2.IconChar = FontAwesome.Sharp.MaterialIcons.AccountGroup;
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
            this.lblUsuario.Size = new System.Drawing.Size(343, 41);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "Gestión de empleados";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this.btnNuevoEmpleado;
            // 
            // frmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1168, 712);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEmpleados";
            this.Text = "frmEmpleados";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            this.pnlContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.materialPictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private FontAwesome.Sharp.Material.MaterialPictureBox materialPictureBox2;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.FlowLayoutPanel pnlContenedor;
        private ControlesUsuario.ctlEmpleado ctlEmpleado4;
        private ControlesUsuario.ctlEmpleado ctlEmpleado5;
        private ControlesUsuario.ctlEmpleado ctlEmpleado6;
        private FontAwesome.Sharp.Material.MaterialButton btnNuevoEmpleado;
        private ControlesUsuario.ctlEmpleado ctlEmpleado7;
        private ControlesUsuario.ctlEmpleado ctlEmpleado8;
        private ControlesUsuario.ctlEmpleado ctlEmpleado9;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}