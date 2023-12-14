namespace Temporizador
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.btnSalir = new System.Windows.Forms.Button();
            this.cbMonitores = new System.Windows.Forms.ComboBox();
            this.btnIdentificar = new System.Windows.Forms.Button();
            this.lblHoras = new System.Windows.Forms.Label();
            this.lblMinutos = new System.Windows.Forms.Label();
            this.lblSegundos = new System.Windows.Forms.Label();
            this.nudHoras = new System.Windows.Forms.NumericUpDown();
            this.nudSegundos = new System.Windows.Forms.NumericUpDown();
            this.nudMinutos = new System.Windows.Forms.NumericUpDown();
            this.tlpBase = new System.Windows.Forms.TableLayoutPanel();
            this.lblSelMonitor = new System.Windows.Forms.Label();
            this.lblppHora = new System.Windows.Forms.Label();
            this.lblppMinuto = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnPausa = new System.Windows.Forms.Button();
            this.cbIniciar = new System.Windows.Forms.CheckBox();
            this.btnOcultar = new System.Windows.Forms.Button();
            this.lblTiempoDesc = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.btnRecargar = new System.Windows.Forms.Button();
            this.btnInformación = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSegundos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutos)).BeginInit();
            this.tlpBase.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackColor = System.Drawing.SystemColors.Info;
            this.tlpBase.SetColumnSpan(this.btnSalir, 2);
            this.btnSalir.Location = new System.Drawing.Point(721, 499);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(6, 6, 30, 13);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(95, 55);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // cbMonitores
            // 
            this.cbMonitores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpBase.SetColumnSpan(this.cbMonitores, 3);
            this.cbMonitores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMonitores.Font = new System.Drawing.Font("Verdana", 14F);
            this.cbMonitores.FormattingEnabled = true;
            this.cbMonitores.Location = new System.Drawing.Point(329, 61);
            this.cbMonitores.Margin = new System.Windows.Forms.Padding(6, 10, 6, 5);
            this.cbMonitores.Name = "cbMonitores";
            this.cbMonitores.Size = new System.Drawing.Size(271, 31);
            this.cbMonitores.TabIndex = 1;
            // 
            // btnIdentificar
            // 
            this.btnIdentificar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnIdentificar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnIdentificar.Location = new System.Drawing.Point(618, 46);
            this.btnIdentificar.Margin = new System.Windows.Forms.Padding(12, 5, 6, 5);
            this.btnIdentificar.Name = "btnIdentificar";
            this.btnIdentificar.Size = new System.Drawing.Size(102, 57);
            this.btnIdentificar.TabIndex = 3;
            this.btnIdentificar.UseVisualStyleBackColor = false;
            this.btnIdentificar.Click += new System.EventHandler(this.BtnIdentificar_Click);
            // 
            // lblHoras
            // 
            this.lblHoras.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblHoras.AutoSize = true;
            this.tlpBase.SetColumnSpan(this.lblHoras, 2);
            this.lblHoras.Location = new System.Drawing.Point(127, 209);
            this.lblHoras.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(65, 23);
            this.lblHoras.TabIndex = 4;
            this.lblHoras.Text = "Horas";
            this.lblHoras.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMinutos
            // 
            this.lblMinutos.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblMinutos.AutoSize = true;
            this.tlpBase.SetColumnSpan(this.lblMinutos, 2);
            this.lblMinutos.Location = new System.Drawing.Point(400, 209);
            this.lblMinutos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMinutos.Name = "lblMinutos";
            this.lblMinutos.Size = new System.Drawing.Size(85, 23);
            this.lblMinutos.TabIndex = 5;
            this.lblMinutos.Text = "Minutos";
            this.lblMinutos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSegundos
            // 
            this.lblSegundos.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblSegundos.AutoSize = true;
            this.tlpBase.SetColumnSpan(this.lblSegundos, 2);
            this.lblSegundos.Location = new System.Drawing.Point(674, 209);
            this.lblSegundos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSegundos.Name = "lblSegundos";
            this.lblSegundos.Size = new System.Drawing.Size(104, 23);
            this.lblSegundos.TabIndex = 6;
            this.lblSegundos.Text = "Segundos";
            this.lblSegundos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudHoras
            // 
            this.nudHoras.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpBase.SetColumnSpan(this.nudHoras, 2);
            this.nudHoras.Font = new System.Drawing.Font("Verdana", 16F);
            this.nudHoras.Location = new System.Drawing.Point(44, 236);
            this.nudHoras.Margin = new System.Windows.Forms.Padding(4);
            this.nudHoras.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nudHoras.Name = "nudHoras";
            this.nudHoras.Size = new System.Drawing.Size(232, 33);
            this.nudHoras.TabIndex = 7;
            this.nudHoras.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudHoras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NudHoras_KeyPress);
            // 
            // nudSegundos
            // 
            this.nudSegundos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpBase.SetColumnSpan(this.nudSegundos, 2);
            this.nudSegundos.Font = new System.Drawing.Font("Verdana", 16F);
            this.nudSegundos.Location = new System.Drawing.Point(610, 236);
            this.nudSegundos.Margin = new System.Windows.Forms.Padding(4);
            this.nudSegundos.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudSegundos.Name = "nudSegundos";
            this.nudSegundos.Size = new System.Drawing.Size(232, 33);
            this.nudSegundos.TabIndex = 11;
            this.nudSegundos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudSegundos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NudSegundos_KeyPress);
            // 
            // nudMinutos
            // 
            this.nudMinutos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpBase.SetColumnSpan(this.nudMinutos, 2);
            this.nudMinutos.Font = new System.Drawing.Font("Verdana", 16F);
            this.nudMinutos.Location = new System.Drawing.Point(327, 236);
            this.nudMinutos.Margin = new System.Windows.Forms.Padding(4);
            this.nudMinutos.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudMinutos.Name = "nudMinutos";
            this.nudMinutos.Size = new System.Drawing.Size(232, 33);
            this.nudMinutos.TabIndex = 9;
            this.nudMinutos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudMinutos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NudMinutos_KeyPress);
            // 
            // tlpBase
            // 
            this.tlpBase.ColumnCount = 10;
            this.tlpBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.578681F));
            this.tlpBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.579F));
            this.tlpBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.579F));
            this.tlpBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.886208F));
            this.tlpBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.579F));
            this.tlpBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.579F));
            this.tlpBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.886208F));
            this.tlpBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.579F));
            this.tlpBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.58181F));
            this.tlpBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.172093F));
            this.tlpBase.Controls.Add(this.lblSelMonitor, 1, 1);
            this.tlpBase.Controls.Add(this.lblHoras, 1, 3);
            this.tlpBase.Controls.Add(this.nudHoras, 1, 4);
            this.tlpBase.Controls.Add(this.lblppHora, 3, 4);
            this.tlpBase.Controls.Add(this.lblMinutos, 4, 3);
            this.tlpBase.Controls.Add(this.nudMinutos, 4, 4);
            this.tlpBase.Controls.Add(this.lblSegundos, 7, 3);
            this.tlpBase.Controls.Add(this.lblppMinuto, 6, 4);
            this.tlpBase.Controls.Add(this.nudSegundos, 7, 4);
            this.tlpBase.Controls.Add(this.btnIniciar, 4, 5);
            this.tlpBase.Controls.Add(this.btnCargar, 1, 5);
            this.tlpBase.Controls.Add(this.btnPausa, 7, 5);
            this.tlpBase.Controls.Add(this.cbIniciar, 1, 2);
            this.tlpBase.Controls.Add(this.lblTiempoDesc, 1, 6);
            this.tlpBase.Controls.Add(this.lblTiempo, 4, 6);
            this.tlpBase.Controls.Add(this.btnInformación, 0, 7);
            this.tlpBase.Controls.Add(this.cbMonitores, 4, 1);
            this.tlpBase.Controls.Add(this.btnOcultar, 7, 2);
            this.tlpBase.Controls.Add(this.btnIdentificar, 7, 1);
            this.tlpBase.Controls.Add(this.btnRecargar, 8, 1);
            this.tlpBase.Controls.Add(this.btnSalir, 7, 6);
            this.tlpBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBase.Location = new System.Drawing.Point(0, 0);
            this.tlpBase.Margin = new System.Windows.Forms.Padding(4);
            this.tlpBase.Name = "tlpBase";
            this.tlpBase.RowCount = 8;
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.771069F));
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.08523F));
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.30228F));
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.089209F));
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.85725F));
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.71309F));
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.4108F));
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.771071F));
            this.tlpBase.Size = new System.Drawing.Size(884, 611);
            this.tlpBase.TabIndex = 100;
            // 
            // lblSelMonitor
            // 
            this.lblSelMonitor.AutoSize = true;
            this.tlpBase.SetColumnSpan(this.lblSelMonitor, 3);
            this.lblSelMonitor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSelMonitor.Font = new System.Drawing.Font("Verdana", 12F);
            this.lblSelMonitor.Location = new System.Drawing.Point(46, 45);
            this.lblSelMonitor.Margin = new System.Windows.Forms.Padding(6, 4, 6, 0);
            this.lblSelMonitor.Name = "lblSelMonitor";
            this.lblSelMonitor.Size = new System.Drawing.Size(271, 63);
            this.lblSelMonitor.TabIndex = 1;
            this.lblSelMonitor.Text = "Cargar temporizador en:";
            this.lblSelMonitor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblppHora
            // 
            this.lblppHora.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblppHora.AutoSize = true;
            this.lblppHora.Location = new System.Drawing.Point(292, 238);
            this.lblppHora.Margin = new System.Windows.Forms.Padding(4, 6, 4, 0);
            this.lblppHora.Name = "lblppHora";
            this.lblppHora.Size = new System.Drawing.Size(19, 23);
            this.lblppHora.TabIndex = 8;
            this.lblppHora.Text = ":";
            this.lblppHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblppMinuto
            // 
            this.lblppMinuto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblppMinuto.AutoSize = true;
            this.lblppMinuto.Location = new System.Drawing.Point(575, 238);
            this.lblppMinuto.Margin = new System.Windows.Forms.Padding(4, 6, 4, 0);
            this.lblppMinuto.Name = "lblppMinuto";
            this.lblppMinuto.Size = new System.Drawing.Size(19, 23);
            this.lblppMinuto.TabIndex = 10;
            this.lblppMinuto.Text = ":";
            this.lblppMinuto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIniciar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.tlpBase.SetColumnSpan(this.btnIniciar, 2);
            this.btnIniciar.Location = new System.Drawing.Point(327, 325);
            this.btnIniciar.Margin = new System.Windows.Forms.Padding(4);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(232, 138);
            this.btnIniciar.TabIndex = 12;
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCargar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tlpBase.SetColumnSpan(this.btnCargar, 2);
            this.btnCargar.Location = new System.Drawing.Point(44, 325);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(232, 138);
            this.btnCargar.TabIndex = 21;
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.BtnCargar_Click);
            // 
            // btnPausa
            // 
            this.btnPausa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPausa.BackColor = System.Drawing.SystemColors.Info;
            this.tlpBase.SetColumnSpan(this.btnPausa, 2);
            this.btnPausa.Location = new System.Drawing.Point(610, 325);
            this.btnPausa.Margin = new System.Windows.Forms.Padding(4);
            this.btnPausa.Name = "btnPausa";
            this.btnPausa.Size = new System.Drawing.Size(232, 138);
            this.btnPausa.TabIndex = 22;
            this.btnPausa.UseVisualStyleBackColor = false;
            this.btnPausa.Click += new System.EventHandler(this.BtnPausar_Click);
            // 
            // cbIniciar
            // 
            this.cbIniciar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbIniciar.AutoSize = true;
            this.tlpBase.SetColumnSpan(this.cbIniciar, 4);
            this.cbIniciar.Font = new System.Drawing.Font("Verdana", 14F);
            this.cbIniciar.Location = new System.Drawing.Point(45, 159);
            this.cbIniciar.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.cbIniciar.Name = "cbIniciar";
            this.cbIniciar.Size = new System.Drawing.Size(315, 27);
            this.cbIniciar.TabIndex = 24;
            this.cbIniciar.Text = "Iniciar temporizador al cargar";
            this.cbIniciar.UseVisualStyleBackColor = true;
            // 
            // btnOcultar
            // 
            this.btnOcultar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOcultar.BackColor = System.Drawing.Color.LightCoral;
            this.tlpBase.SetColumnSpan(this.btnOcultar, 2);
            this.btnOcultar.Location = new System.Drawing.Point(618, 112);
            this.btnOcultar.Margin = new System.Windows.Forms.Padding(12, 4, 4, 4);
            this.btnOcultar.Name = "btnOcultar";
            this.btnOcultar.Size = new System.Drawing.Size(224, 41);
            this.btnOcultar.TabIndex = 23;
            this.btnOcultar.UseVisualStyleBackColor = false;
            this.btnOcultar.Click += new System.EventHandler(this.btnOcultar_Click);
            // 
            // lblTiempoDesc
            // 
            this.lblTiempoDesc.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTiempoDesc.AutoSize = true;
            this.tlpBase.SetColumnSpan(this.lblTiempoDesc, 3);
            this.lblTiempoDesc.Font = new System.Drawing.Font("Verdana", 14F);
            this.lblTiempoDesc.Location = new System.Drawing.Point(116, 511);
            this.lblTiempoDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTiempoDesc.Name = "lblTiempoDesc";
            this.lblTiempoDesc.Size = new System.Drawing.Size(203, 23);
            this.lblTiempoDesc.TabIndex = 20;
            this.lblTiempoDesc.Text = "Tiempo en pantalla:";
            // 
            // lblTiempo
            // 
            this.lblTiempo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTiempo.AutoSize = true;
            this.tlpBase.SetColumnSpan(this.lblTiempo, 3);
            this.lblTiempo.Font = new System.Drawing.Font("Verdana", 14F);
            this.lblTiempo.Location = new System.Drawing.Point(326, 511);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(100, 23);
            this.lblTiempo.TabIndex = 25;
            this.lblTiempo.Text = "00:00:00";
            // 
            // btnRecargar
            // 
            this.btnRecargar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnRecargar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRecargar.Location = new System.Drawing.Point(738, 46);
            this.btnRecargar.Margin = new System.Windows.Forms.Padding(12, 5, 6, 5);
            this.btnRecargar.Name = "btnRecargar";
            this.btnRecargar.Size = new System.Drawing.Size(102, 57);
            this.btnRecargar.TabIndex = 26;
            this.btnRecargar.UseVisualStyleBackColor = false;
            this.btnRecargar.Click += new System.EventHandler(this.btnRecargar_Click);
            // 
            // btnInformación
            // 
            this.btnInformación.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInformación.Location = new System.Drawing.Point(4, 574);
            this.btnInformación.Margin = new System.Windows.Forms.Padding(4);
            this.btnInformación.Name = "btnInformación";
            this.btnInformación.Size = new System.Drawing.Size(32, 30);
            this.btnInformación.TabIndex = 19;
            this.btnInformación.UseVisualStyleBackColor = true;
            this.btnInformación.Click += new System.EventHandler(this.BtnInformacion_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 611);
            this.Controls.Add(this.tlpBase);
            this.Font = new System.Drawing.Font("Verdana", 14F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temporizador";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudHoras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSegundos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutos)).EndInit();
            this.tlpBase.ResumeLayout(false);
            this.tlpBase.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ComboBox cbMonitores;
        private System.Windows.Forms.Button btnIdentificar;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.Label lblMinutos;
        private System.Windows.Forms.Label lblSegundos;
        private System.Windows.Forms.NumericUpDown nudHoras;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.NumericUpDown nudSegundos;
        private System.Windows.Forms.NumericUpDown nudMinutos;
        private System.Windows.Forms.TableLayoutPanel tlpBase;
        private System.Windows.Forms.Label lblppMinuto;
        private System.Windows.Forms.Label lblppHora;
        private System.Windows.Forms.Label lblSelMonitor;
        private System.Windows.Forms.Button btnInformación;
        private System.Windows.Forms.Label lblTiempoDesc;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnPausa;
        private System.Windows.Forms.Button btnOcultar;
        private System.Windows.Forms.CheckBox cbIniciar;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Button btnRecargar;
    }
}

