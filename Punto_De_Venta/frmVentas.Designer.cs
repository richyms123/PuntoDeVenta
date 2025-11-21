namespace Punto_De_Venta
{
    partial class frmVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentas));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlProductos = new System.Windows.Forms.Panel();
            this.bunifuPanel4 = new Bunifu.UI.WinForms.BunifuPanel();
            this.btnCancelar = new FontAwesome.Sharp.Material.MaterialButton();
            this.btnCobrar = new FontAwesome.Sharp.Material.MaterialButton();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuPanel3 = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblIdVenta = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.cboCategoria = new Bunifu.UI.WinForms.BunifuDropdown();
            this.txtBuscar = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlContenedor = new System.Windows.Forms.FlowLayoutPanel();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ctlProducto1 = new Punto_De_Venta.ControlesUsuario.ctlProducto();
            this.ctlProducto2 = new Punto_De_Venta.ControlesUsuario.ctlProducto();
            this.ctlProducto3 = new Punto_De_Venta.ControlesUsuario.ctlProducto();
            this.ctlProducto4 = new Punto_De_Venta.ControlesUsuario.ctlProducto();
            this.ctlProducto5 = new Punto_De_Venta.ControlesUsuario.ctlProducto();
            this.ctlProducto6 = new Punto_De_Venta.ControlesUsuario.ctlProducto();
            this.ctlProducto7 = new Punto_De_Venta.ControlesUsuario.ctlProducto();
            this.ctlProducto8 = new Punto_De_Venta.ControlesUsuario.ctlProducto();
            this.ctlTicketProducto3 = new Punto_De_Venta.ControlesUsuario.ctlTicketProducto();
            this.ctlTicketProducto2 = new Punto_De_Venta.ControlesUsuario.ctlTicketProducto();
            this.ctlTicketProducto1 = new Punto_De_Venta.ControlesUsuario.ctlTicketProducto();
            this.ctlTituloProductos1 = new Punto_De_Venta.ControlesUsuario.ctlTituloProductos();
            this.ctlTicketProducto4 = new Punto_De_Venta.ControlesUsuario.ctlTicketProducto();
            this.ctlTicketProducto5 = new Punto_De_Venta.ControlesUsuario.ctlTicketProducto();
            this.bunifuPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.pnlProductos.SuspendLayout();
            this.bunifuPanel4.SuspendLayout();
            this.bunifuPanel3.SuspendLayout();
            this.bunifuPanel2.SuspendLayout();
            this.pnlContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuPanel1.AutoScroll = true;
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.White;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 20;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.flowLayoutPanel2);
            this.bunifuPanel1.Controls.Add(this.bunifuPanel3);
            this.bunifuPanel1.Location = new System.Drawing.Point(786, 10);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(373, 645);
            this.bunifuPanel1.TabIndex = 314;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel2.Controls.Add(this.pnlProductos);
            this.flowLayoutPanel2.Controls.Add(this.bunifuPanel4);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(11, 106);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(341, 615);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // pnlProductos
            // 
            this.pnlProductos.AutoSize = true;
            this.pnlProductos.BackColor = System.Drawing.Color.White;
            this.pnlProductos.Controls.Add(this.ctlTicketProducto5);
            this.pnlProductos.Controls.Add(this.ctlTicketProducto4);
            this.pnlProductos.Controls.Add(this.ctlTicketProducto3);
            this.pnlProductos.Controls.Add(this.ctlTicketProducto2);
            this.pnlProductos.Controls.Add(this.ctlTicketProducto1);
            this.pnlProductos.Controls.Add(this.ctlTituloProductos1);
            this.pnlProductos.Location = new System.Drawing.Point(3, 3);
            this.pnlProductos.MinimumSize = new System.Drawing.Size(325, 200);
            this.pnlProductos.Name = "pnlProductos";
            this.pnlProductos.Size = new System.Drawing.Size(325, 300);
            this.pnlProductos.TabIndex = 1;
            // 
            // bunifuPanel4
            // 
            this.bunifuPanel4.BackgroundColor = System.Drawing.Color.White;
            this.bunifuPanel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel4.BackgroundImage")));
            this.bunifuPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel4.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel4.BorderRadius = 3;
            this.bunifuPanel4.BorderThickness = 1;
            this.bunifuPanel4.Controls.Add(this.btnCancelar);
            this.bunifuPanel4.Controls.Add(this.btnCobrar);
            this.bunifuPanel4.Controls.Add(this.lblTotal);
            this.bunifuPanel4.Controls.Add(this.label2);
            this.bunifuPanel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuPanel4.Location = new System.Drawing.Point(3, 309);
            this.bunifuPanel4.MinimumSize = new System.Drawing.Size(300, 0);
            this.bunifuPanel4.Name = "bunifuPanel4";
            this.bunifuPanel4.ShowBorders = true;
            this.bunifuPanel4.Size = new System.Drawing.Size(325, 303);
            this.bunifuPanel4.TabIndex = 2;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.IconChar = FontAwesome.Sharp.MaterialIcons.WindowClose;
            this.btnCancelar.IconColor = System.Drawing.Color.White;
            this.btnCancelar.IconSize = 40;
            this.btnCancelar.Location = new System.Drawing.Point(4, 254);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(318, 43);
            this.btnCancelar.TabIndex = 290;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnCobrar
            // 
            this.btnCobrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(67)))), ((int)(((byte)(21)))));
            this.btnCobrar.FlatAppearance.BorderSize = 0;
            this.btnCobrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCobrar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCobrar.ForeColor = System.Drawing.Color.White;
            this.btnCobrar.IconChar = FontAwesome.Sharp.MaterialIcons.CashRegister;
            this.btnCobrar.IconColor = System.Drawing.Color.White;
            this.btnCobrar.IconSize = 40;
            this.btnCobrar.Location = new System.Drawing.Point(4, 205);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(318, 43);
            this.btnCobrar.TabIndex = 8;
            this.btnCobrar.Text = "Cobrar";
            this.btnCobrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCobrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCobrar.UseVisualStyleBackColor = false;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(197)))), ((int)(((byte)(93)))));
            this.lblTotal.Location = new System.Drawing.Point(72, 162);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(249, 31);
            this.lblTotal.TabIndex = 289;
            this.lblTotal.Text = "$3500.00 MXN";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(4, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Total:";
            // 
            // bunifuPanel3
            // 
            this.bunifuPanel3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.bunifuPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel3.BackgroundImage")));
            this.bunifuPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel3.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel3.BorderRadius = 20;
            this.bunifuPanel3.BorderThickness = 1;
            this.bunifuPanel3.Controls.Add(this.lblIdVenta);
            this.bunifuPanel3.Controls.Add(this.lblUsuario);
            this.bunifuPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuPanel3.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel3.Name = "bunifuPanel3";
            this.bunifuPanel3.ShowBorders = true;
            this.bunifuPanel3.Size = new System.Drawing.Size(352, 100);
            this.bunifuPanel3.TabIndex = 0;
            // 
            // lblIdVenta
            // 
            this.lblIdVenta.BackColor = System.Drawing.Color.Transparent;
            this.lblIdVenta.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdVenta.ForeColor = System.Drawing.Color.White;
            this.lblIdVenta.Location = new System.Drawing.Point(101, 52);
            this.lblIdVenta.Name = "lblIdVenta";
            this.lblIdVenta.Size = new System.Drawing.Size(178, 31);
            this.lblIdVenta.TabIndex = 3;
            this.lblIdVenta.Text = "Folio: #0001";
            this.lblIdVenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(97, 16);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(178, 31);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Ticket de Venta";
            // 
            // bunifuPanel2
            // 
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.White;
            this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel2.BorderRadius = 20;
            this.bunifuPanel2.BorderThickness = 1;
            this.bunifuPanel2.Controls.Add(this.cboCategoria);
            this.bunifuPanel2.Controls.Add(this.txtBuscar);
            this.bunifuPanel2.Location = new System.Drawing.Point(12, 10);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(743, 100);
            this.bunifuPanel2.TabIndex = 315;
            // 
            // cboCategoria
            // 
            this.cboCategoria.BackColor = System.Drawing.Color.Transparent;
            this.cboCategoria.BackgroundColor = System.Drawing.Color.White;
            this.cboCategoria.BorderColor = System.Drawing.Color.Silver;
            this.cboCategoria.BorderRadius = 10;
            this.cboCategoria.Color = System.Drawing.Color.Silver;
            this.cboCategoria.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cboCategoria.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cboCategoria.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cboCategoria.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cboCategoria.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cboCategoria.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.cboCategoria.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboCategoria.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cboCategoria.FillDropDown = true;
            this.cboCategoria.FillIndicator = false;
            this.cboCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCategoria.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboCategoria.ForeColor = System.Drawing.Color.Black;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Icon = null;
            this.cboCategoria.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cboCategoria.IndicatorColor = System.Drawing.Color.Gray;
            this.cboCategoria.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cboCategoria.ItemBackColor = System.Drawing.Color.White;
            this.cboCategoria.ItemBorderColor = System.Drawing.Color.White;
            this.cboCategoria.ItemForeColor = System.Drawing.Color.Black;
            this.cboCategoria.ItemHeight = 37;
            this.cboCategoria.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.cboCategoria.ItemHighLightForeColor = System.Drawing.Color.White;
            this.cboCategoria.ItemTopMargin = 3;
            this.cboCategoria.Location = new System.Drawing.Point(522, 29);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(214, 43);
            this.cboCategoria.TabIndex = 5;
            this.cboCategoria.Text = null;
            this.cboCategoria.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cboCategoria.TextLeftMargin = 5;
            // 
            // txtBuscar
            // 
            this.txtBuscar.AcceptsReturn = false;
            this.txtBuscar.AcceptsTab = false;
            this.txtBuscar.AnimationSpeed = 200;
            this.txtBuscar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtBuscar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtBuscar.BackColor = System.Drawing.Color.Transparent;
            this.txtBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtBuscar.BackgroundImage")));
            this.txtBuscar.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(67)))), ((int)(((byte)(21)))));
            this.txtBuscar.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtBuscar.BorderColorHover = System.Drawing.Color.Silver;
            this.txtBuscar.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtBuscar.BorderRadius = 20;
            this.txtBuscar.BorderThickness = 1;
            this.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscar.DefaultFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.DefaultText = "";
            this.txtBuscar.FillColor = System.Drawing.Color.White;
            this.txtBuscar.HideSelection = true;
            this.txtBuscar.IconLeft = null;
            this.txtBuscar.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscar.IconPadding = 10;
            this.txtBuscar.IconRight = null;
            this.txtBuscar.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscar.Lines = new string[0];
            this.txtBuscar.Location = new System.Drawing.Point(15, 29);
            this.txtBuscar.MaxLength = 32767;
            this.txtBuscar.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtBuscar.Modified = false;
            this.txtBuscar.Multiline = false;
            this.txtBuscar.Name = "txtBuscar";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(67)))), ((int)(((byte)(21)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtBuscar.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtBuscar.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.Silver;
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtBuscar.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtBuscar.OnIdleState = stateProperties4;
            this.txtBuscar.Padding = new System.Windows.Forms.Padding(3);
            this.txtBuscar.PasswordChar = '\0';
            this.txtBuscar.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtBuscar.PlaceholderText = "Buscar producto";
            this.txtBuscar.ReadOnly = false;
            this.txtBuscar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.SelectionLength = 0;
            this.txtBuscar.SelectionStart = 0;
            this.txtBuscar.ShortcutsEnabled = true;
            this.txtBuscar.Size = new System.Drawing.Size(499, 43);
            this.txtBuscar.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtBuscar.TabIndex = 4;
            this.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBuscar.TextMarginBottom = 0;
            this.txtBuscar.TextMarginLeft = 3;
            this.txtBuscar.TextMarginTop = 0;
            this.txtBuscar.TextPlaceholder = "Buscar producto";
            this.txtBuscar.UseSystemPasswordChar = false;
            this.txtBuscar.WordWrap = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this.btnCobrar;
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Controls.Add(this.ctlProducto1);
            this.pnlContenedor.Controls.Add(this.ctlProducto2);
            this.pnlContenedor.Controls.Add(this.ctlProducto3);
            this.pnlContenedor.Controls.Add(this.ctlProducto4);
            this.pnlContenedor.Controls.Add(this.ctlProducto5);
            this.pnlContenedor.Controls.Add(this.ctlProducto6);
            this.pnlContenedor.Controls.Add(this.ctlProducto7);
            this.pnlContenedor.Controls.Add(this.ctlProducto8);
            this.pnlContenedor.Location = new System.Drawing.Point(12, 119);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(743, 540);
            this.pnlContenedor.TabIndex = 316;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 20;
            this.bunifuElipse2.TargetControl = this.btnCancelar;
            // 
            // ctlProducto1
            // 
            this.ctlProducto1.BackColor = System.Drawing.Color.Transparent;
            this.ctlProducto1.Location = new System.Drawing.Point(3, 3);
            this.ctlProducto1.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.ctlProducto1.Name = "ctlProducto1";
            this.ctlProducto1.Size = new System.Drawing.Size(165, 165);
            this.ctlProducto1.TabIndex = 0;
            // 
            // ctlProducto2
            // 
            this.ctlProducto2.BackColor = System.Drawing.Color.Transparent;
            this.ctlProducto2.Location = new System.Drawing.Point(176, 3);
            this.ctlProducto2.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.ctlProducto2.Name = "ctlProducto2";
            this.ctlProducto2.Size = new System.Drawing.Size(165, 165);
            this.ctlProducto2.TabIndex = 1;
            // 
            // ctlProducto3
            // 
            this.ctlProducto3.BackColor = System.Drawing.Color.Transparent;
            this.ctlProducto3.Location = new System.Drawing.Point(349, 3);
            this.ctlProducto3.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.ctlProducto3.Name = "ctlProducto3";
            this.ctlProducto3.Size = new System.Drawing.Size(165, 165);
            this.ctlProducto3.TabIndex = 2;
            // 
            // ctlProducto4
            // 
            this.ctlProducto4.BackColor = System.Drawing.Color.Transparent;
            this.ctlProducto4.Location = new System.Drawing.Point(522, 3);
            this.ctlProducto4.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.ctlProducto4.Name = "ctlProducto4";
            this.ctlProducto4.Size = new System.Drawing.Size(165, 165);
            this.ctlProducto4.TabIndex = 3;
            // 
            // ctlProducto5
            // 
            this.ctlProducto5.BackColor = System.Drawing.Color.Transparent;
            this.ctlProducto5.Location = new System.Drawing.Point(3, 174);
            this.ctlProducto5.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.ctlProducto5.Name = "ctlProducto5";
            this.ctlProducto5.Size = new System.Drawing.Size(165, 165);
            this.ctlProducto5.TabIndex = 4;
            // 
            // ctlProducto6
            // 
            this.ctlProducto6.BackColor = System.Drawing.Color.Transparent;
            this.ctlProducto6.Location = new System.Drawing.Point(176, 174);
            this.ctlProducto6.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.ctlProducto6.Name = "ctlProducto6";
            this.ctlProducto6.Size = new System.Drawing.Size(165, 165);
            this.ctlProducto6.TabIndex = 5;
            // 
            // ctlProducto7
            // 
            this.ctlProducto7.BackColor = System.Drawing.Color.Transparent;
            this.ctlProducto7.Location = new System.Drawing.Point(349, 174);
            this.ctlProducto7.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.ctlProducto7.Name = "ctlProducto7";
            this.ctlProducto7.Size = new System.Drawing.Size(165, 165);
            this.ctlProducto7.TabIndex = 6;
            // 
            // ctlProducto8
            // 
            this.ctlProducto8.BackColor = System.Drawing.Color.Transparent;
            this.ctlProducto8.Location = new System.Drawing.Point(522, 174);
            this.ctlProducto8.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.ctlProducto8.Name = "ctlProducto8";
            this.ctlProducto8.Size = new System.Drawing.Size(165, 165);
            this.ctlProducto8.TabIndex = 7;
            // 
            // ctlTicketProducto3
            // 
            this.ctlTicketProducto3.BackColor = System.Drawing.Color.White;
            this.ctlTicketProducto3.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctlTicketProducto3.Location = new System.Drawing.Point(0, 150);
            this.ctlTicketProducto3.Name = "ctlTicketProducto3";
            this.ctlTicketProducto3.Size = new System.Drawing.Size(325, 50);
            this.ctlTicketProducto3.TabIndex = 3;
            // 
            // ctlTicketProducto2
            // 
            this.ctlTicketProducto2.BackColor = System.Drawing.Color.White;
            this.ctlTicketProducto2.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctlTicketProducto2.Location = new System.Drawing.Point(0, 100);
            this.ctlTicketProducto2.Name = "ctlTicketProducto2";
            this.ctlTicketProducto2.Size = new System.Drawing.Size(325, 50);
            this.ctlTicketProducto2.TabIndex = 2;
            // 
            // ctlTicketProducto1
            // 
            this.ctlTicketProducto1.BackColor = System.Drawing.Color.White;
            this.ctlTicketProducto1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctlTicketProducto1.Location = new System.Drawing.Point(0, 50);
            this.ctlTicketProducto1.Name = "ctlTicketProducto1";
            this.ctlTicketProducto1.Size = new System.Drawing.Size(325, 50);
            this.ctlTicketProducto1.TabIndex = 1;
            // 
            // ctlTituloProductos1
            // 
            this.ctlTituloProductos1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ctlTituloProductos1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctlTituloProductos1.Location = new System.Drawing.Point(0, 0);
            this.ctlTituloProductos1.Name = "ctlTituloProductos1";
            this.ctlTituloProductos1.Size = new System.Drawing.Size(325, 50);
            this.ctlTituloProductos1.TabIndex = 0;
            // 
            // ctlTicketProducto4
            // 
            this.ctlTicketProducto4.BackColor = System.Drawing.Color.White;
            this.ctlTicketProducto4.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctlTicketProducto4.Location = new System.Drawing.Point(0, 200);
            this.ctlTicketProducto4.Name = "ctlTicketProducto4";
            this.ctlTicketProducto4.Size = new System.Drawing.Size(325, 50);
            this.ctlTicketProducto4.TabIndex = 4;
            // 
            // ctlTicketProducto5
            // 
            this.ctlTicketProducto5.BackColor = System.Drawing.Color.White;
            this.ctlTicketProducto5.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctlTicketProducto5.Location = new System.Drawing.Point(0, 250);
            this.ctlTicketProducto5.Name = "ctlTicketProducto5";
            this.ctlTicketProducto5.Size = new System.Drawing.Size(325, 50);
            this.ctlTicketProducto5.TabIndex = 5;
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1168, 712);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.bunifuPanel2);
            this.Controls.Add(this.bunifuPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVentas";
            this.Text = "frmVentas";
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.pnlProductos.ResumeLayout(false);
            this.bunifuPanel4.ResumeLayout(false);
            this.bunifuPanel4.PerformLayout();
            this.bunifuPanel3.ResumeLayout(false);
            this.bunifuPanel3.PerformLayout();
            this.bunifuPanel2.ResumeLayout(false);
            this.pnlContenedor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel3;
        private System.Windows.Forms.Panel pnlProductos;
        private System.Windows.Forms.Label lblIdVenta;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotal;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private Bunifu.UI.WinForms.BunifuDropdown cboCategoria;
        private Bunifu.UI.WinForms.BunifuTextBox txtBuscar;
        private FontAwesome.Sharp.Material.MaterialButton btnCobrar;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.FlowLayoutPanel pnlContenedor;
        private FontAwesome.Sharp.Material.MaterialButton btnCancelar;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private ControlesUsuario.ctlProducto ctlProducto1;
        private ControlesUsuario.ctlProducto ctlProducto2;
        private ControlesUsuario.ctlProducto ctlProducto3;
        private ControlesUsuario.ctlProducto ctlProducto4;
        private ControlesUsuario.ctlProducto ctlProducto5;
        private ControlesUsuario.ctlProducto ctlProducto6;
        private ControlesUsuario.ctlProducto ctlProducto7;
        private ControlesUsuario.ctlProducto ctlProducto8;
        private ControlesUsuario.ctlTituloProductos ctlTituloProductos1;
        private ControlesUsuario.ctlTicketProducto ctlTicketProducto3;
        private ControlesUsuario.ctlTicketProducto ctlTicketProducto2;
        private ControlesUsuario.ctlTicketProducto ctlTicketProducto1;
        private ControlesUsuario.ctlTicketProducto ctlTicketProducto5;
        private ControlesUsuario.ctlTicketProducto ctlTicketProducto4;
    }
}