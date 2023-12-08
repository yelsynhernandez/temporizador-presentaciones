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
            this.btnContador = new System.Windows.Forms.Button();
            this.nudSegundos = new System.Windows.Forms.NumericUpDown();
            this.nudMinutos = new System.Windows.Forms.NumericUpDown();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tlpBase = new System.Windows.Forms.TableLayoutPanel();
            this.lblSelMonitor = new System.Windows.Forms.Label();
            this.lblppHora = new System.Windows.Forms.Label();
            this.lblppMinuto = new System.Windows.Forms.Label();
            this.btnInformación = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            this.btnSalir.Location = new System.Drawing.Point(515, 537);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(5, 4, 25, 10);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(86, 32);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // cbMonitores
            // 
            this.cbMonitores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpBase.SetColumnSpan(this.cbMonitores, 3);
            this.cbMonitores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMonitores.FormattingEnabled = true;
            this.cbMonitores.Location = new System.Drawing.Point(304, 63);
            this.cbMonitores.Margin = new System.Windows.Forms.Padding(5, 8, 5, 4);
            this.cbMonitores.Name = "cbMonitores";
            this.cbMonitores.Size = new System.Drawing.Size(181, 26);
            this.cbMonitores.TabIndex = 1;
            // 
            // btnIdentificar
            // 
            this.btnIdentificar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnIdentificar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tlpBase.SetColumnSpan(this.btnIdentificar, 2);
            this.btnIdentificar.Location = new System.Drawing.Point(500, 55);
            this.btnIdentificar.Margin = new System.Windows.Forms.Padding(10, 4, 5, 4);
            this.btnIdentificar.Name = "btnIdentificar";
            this.btnIdentificar.Size = new System.Drawing.Size(110, 32);
            this.btnIdentificar.TabIndex = 3;
            this.btnIdentificar.Text = "Identificar";
            this.btnIdentificar.UseVisualStyleBackColor = false;
            this.btnIdentificar.Click += new System.EventHandler(this.btnIdentificar_Click);
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.tlpBase.SetColumnSpan(this.lblHoras, 2);
            this.lblHoras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHoras.Location = new System.Drawing.Point(30, 182);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(156, 75);
            this.lblHoras.TabIndex = 4;
            this.lblHoras.Text = "Horas";
            this.lblHoras.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMinutos
            // 
            this.lblMinutos.AutoSize = true;
            this.tlpBase.SetColumnSpan(this.lblMinutos, 2);
            this.lblMinutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMinutos.Location = new System.Drawing.Point(221, 182);
            this.lblMinutos.Name = "lblMinutos";
            this.lblMinutos.Size = new System.Drawing.Size(156, 75);
            this.lblMinutos.TabIndex = 5;
            this.lblMinutos.Text = "Minutos";
            this.lblMinutos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSegundos
            // 
            this.lblSegundos.AutoSize = true;
            this.tlpBase.SetColumnSpan(this.lblSegundos, 2);
            this.lblSegundos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSegundos.Location = new System.Drawing.Point(412, 182);
            this.lblSegundos.Name = "lblSegundos";
            this.lblSegundos.Size = new System.Drawing.Size(156, 75);
            this.lblSegundos.TabIndex = 6;
            this.lblSegundos.Text = "Segundos";
            this.lblSegundos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudHoras
            // 
            this.nudHoras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpBase.SetColumnSpan(this.nudHoras, 2);
            this.nudHoras.Font = new System.Drawing.Font("Verdana", 14F);
            this.nudHoras.Location = new System.Drawing.Point(30, 279);
            this.nudHoras.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nudHoras.Name = "nudHoras";
            this.nudHoras.Size = new System.Drawing.Size(156, 30);
            this.nudHoras.TabIndex = 7;
            this.nudHoras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudHoras_KeyPress);
            // 
            // btnContador
            // 
            this.btnContador.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tlpBase.SetColumnSpan(this.btnContador, 3);
            this.btnContador.Location = new System.Drawing.Point(111, 335);
            this.btnContador.Name = "btnContador";
            this.btnContador.Size = new System.Drawing.Size(160, 157);
            this.btnContador.TabIndex = 12;
            this.btnContador.Text = "Iniciar contador";
            this.btnContador.UseVisualStyleBackColor = false;
            this.btnContador.Click += new System.EventHandler(this.btnContador_Click);
            // 
            // nudSegundos
            // 
            this.nudSegundos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpBase.SetColumnSpan(this.nudSegundos, 2);
            this.nudSegundos.Font = new System.Drawing.Font("Verdana", 14F);
            this.nudSegundos.Location = new System.Drawing.Point(412, 279);
            this.nudSegundos.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudSegundos.Name = "nudSegundos";
            this.nudSegundos.Size = new System.Drawing.Size(156, 30);
            this.nudSegundos.TabIndex = 11;
            this.nudSegundos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudSegundos_KeyPress);
            // 
            // nudMinutos
            // 
            this.nudMinutos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpBase.SetColumnSpan(this.nudMinutos, 2);
            this.nudMinutos.Font = new System.Drawing.Font("Verdana", 14F);
            this.nudMinutos.Location = new System.Drawing.Point(221, 279);
            this.nudMinutos.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudMinutos.Name = "nudMinutos";
            this.nudMinutos.Size = new System.Drawing.Size(156, 30);
            this.nudMinutos.TabIndex = 9;
            this.nudMinutos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudMinutos_KeyPress);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tlpBase.SetColumnSpan(this.btnCancelar, 3);
            this.btnCancelar.Location = new System.Drawing.Point(412, 335);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(157, 157);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar contador";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // tlpBase
            // 
            this.tlpBase.ColumnCount = 11;
            this.tlpBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.194674F));
            this.tlpBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.44016F));
            this.tlpBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.44016F));
            this.tlpBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.47641F));
            this.tlpBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.44016F));
            this.tlpBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.44016F));
            this.tlpBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.47641F));
            this.tlpBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.44016F));
            this.tlpBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.44016F));
            this.tlpBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.38935F));
            this.tlpBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.822187F));
            this.tlpBase.Controls.Add(this.lblSelMonitor, 1, 1);
            this.tlpBase.Controls.Add(this.lblHoras, 1, 3);
            this.tlpBase.Controls.Add(this.nudHoras, 1, 4);
            this.tlpBase.Controls.Add(this.lblppHora, 3, 4);
            this.tlpBase.Controls.Add(this.lblMinutos, 4, 3);
            this.tlpBase.Controls.Add(this.nudMinutos, 4, 4);
            this.tlpBase.Controls.Add(this.lblSegundos, 7, 3);
            this.tlpBase.Controls.Add(this.lblppMinuto, 6, 4);
            this.tlpBase.Controls.Add(this.nudSegundos, 7, 4);
            this.tlpBase.Controls.Add(this.cbMonitores, 5, 1);
            this.tlpBase.Controls.Add(this.btnIdentificar, 8, 1);
            this.tlpBase.Controls.Add(this.btnSalir, 8, 6);
            this.tlpBase.Controls.Add(this.btnCancelar, 7, 5);
            this.tlpBase.Controls.Add(this.btnContador, 2, 5);
            this.tlpBase.Controls.Add(this.btnInformación, 10, 0);
            this.tlpBase.Controls.Add(this.label1, 2, 6);
            this.tlpBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBase.Location = new System.Drawing.Point(0, 0);
            this.tlpBase.Name = "tlpBase";
            this.tlpBase.RowCount = 8;
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.40181F));
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.4807F));
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.57684F));
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.15608F));
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.15608F));
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.20176F));
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.62491F));
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.401811F));
            this.tlpBase.Size = new System.Drawing.Size(656, 623);
            this.tlpBase.TabIndex = 100;
            // 
            // lblSelMonitor
            // 
            this.lblSelMonitor.AutoSize = true;
            this.tlpBase.SetColumnSpan(this.lblSelMonitor, 4);
            this.lblSelMonitor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSelMonitor.Location = new System.Drawing.Point(32, 42);
            this.lblSelMonitor.Margin = new System.Windows.Forms.Padding(5, 3, 5, 0);
            this.lblSelMonitor.Name = "lblSelMonitor";
            this.lblSelMonitor.Size = new System.Drawing.Size(262, 62);
            this.lblSelMonitor.TabIndex = 1;
            this.lblSelMonitor.Text = "Cargar temporizador en:";
            this.lblSelMonitor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblppHora
            // 
            this.lblppHora.AutoSize = true;
            this.lblppHora.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblppHora.Location = new System.Drawing.Point(192, 257);
            this.lblppHora.Name = "lblppHora";
            this.lblppHora.Size = new System.Drawing.Size(23, 75);
            this.lblppHora.TabIndex = 8;
            this.lblppHora.Text = ":";
            this.lblppHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblppMinuto
            // 
            this.lblppMinuto.AutoSize = true;
            this.lblppMinuto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblppMinuto.Location = new System.Drawing.Point(383, 257);
            this.lblppMinuto.Name = "lblppMinuto";
            this.lblppMinuto.Size = new System.Drawing.Size(23, 75);
            this.lblppMinuto.TabIndex = 10;
            this.lblppMinuto.Text = ":";
            this.lblppMinuto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnInformación
            // 
            this.btnInformación.Location = new System.Drawing.Point(629, 3);
            this.btnInformación.Name = "btnInformación";
            this.btnInformación.Size = new System.Drawing.Size(24, 23);
            this.btnInformación.TabIndex = 19;
            this.btnInformación.Text = "Δ";
            this.btnInformación.UseVisualStyleBackColor = true;
            this.btnInformación.Click += new System.EventHandler(this.btnInformación_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.tlpBase.SetColumnSpan(this.label1, 5);
            this.label1.Font = new System.Drawing.Font("Verdana", 13F);
            this.label1.Location = new System.Drawing.Point(111, 526);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 22);
            this.label1.TabIndex = 20;
            this.label1.Text = "Tiempo en pantalla: 00:00:00";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 623);
            this.Controls.Add(this.tlpBase);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
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
        private System.Windows.Forms.Button btnContador;
        private System.Windows.Forms.NumericUpDown nudSegundos;
        private System.Windows.Forms.NumericUpDown nudMinutos;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TableLayoutPanel tlpBase;
        private System.Windows.Forms.Label lblppMinuto;
        private System.Windows.Forms.Label lblppHora;
        private System.Windows.Forms.Label lblSelMonitor;
        private System.Windows.Forms.Button btnInformación;
        private System.Windows.Forms.Label label1;
    }
}

