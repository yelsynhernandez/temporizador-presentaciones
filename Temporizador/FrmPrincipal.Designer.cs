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
            this.lblSelMonitor = new System.Windows.Forms.Label();
            this.btnIdentificar = new System.Windows.Forms.Button();
            this.lblpp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHoras = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudHoras = new System.Windows.Forms.NumericUpDown();
            this.btnContador = new System.Windows.Forms.Button();
            this.nudSegundos = new System.Windows.Forms.NumericUpDown();
            this.nudMinutos = new System.Windows.Forms.NumericUpDown();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSegundos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(529, 541);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(125, 32);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // cbMonitores
            // 
            this.cbMonitores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMonitores.FormattingEnabled = true;
            this.cbMonitores.Location = new System.Drawing.Point(290, 57);
            this.cbMonitores.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbMonitores.Name = "cbMonitores";
            this.cbMonitores.Size = new System.Drawing.Size(199, 26);
            this.cbMonitores.TabIndex = 1;
            // 
            // lblSelMonitor
            // 
            this.lblSelMonitor.AutoSize = true;
            this.lblSelMonitor.Location = new System.Drawing.Point(78, 62);
            this.lblSelMonitor.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSelMonitor.Name = "lblSelMonitor";
            this.lblSelMonitor.Size = new System.Drawing.Size(208, 18);
            this.lblSelMonitor.TabIndex = 2;
            this.lblSelMonitor.Text = "Cargar temporizador en:";
            // 
            // btnIdentificar
            // 
            this.btnIdentificar.Location = new System.Drawing.Point(502, 55);
            this.btnIdentificar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnIdentificar.Name = "btnIdentificar";
            this.btnIdentificar.Size = new System.Drawing.Size(125, 32);
            this.btnIdentificar.TabIndex = 3;
            this.btnIdentificar.Text = "Identificar";
            this.btnIdentificar.UseVisualStyleBackColor = true;
            this.btnIdentificar.Click += new System.EventHandler(this.btnIdentificar_Click);
            // 
            // lblpp
            // 
            this.lblpp.AutoSize = true;
            this.lblpp.Location = new System.Drawing.Point(270, 192);
            this.lblpp.Name = "lblpp";
            this.lblpp.Size = new System.Drawing.Size(15, 18);
            this.lblpp.TabIndex = 5;
            this.lblpp.Text = ":";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(381, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = ":";
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Location = new System.Drawing.Point(192, 168);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(55, 18);
            this.lblHoras.TabIndex = 9;
            this.lblHoras.Text = "Horas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Minutos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(402, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Segundos";
            // 
            // nudHoras
            // 
            this.nudHoras.Location = new System.Drawing.Point(187, 189);
            this.nudHoras.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nudHoras.Name = "nudHoras";
            this.nudHoras.Size = new System.Drawing.Size(77, 27);
            this.nudHoras.TabIndex = 12;
            this.nudHoras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudHoras_KeyPress);
            // 
            // btnContador
            // 
            this.btnContador.Location = new System.Drawing.Point(232, 277);
            this.btnContador.Name = "btnContador";
            this.btnContador.Size = new System.Drawing.Size(93, 50);
            this.btnContador.TabIndex = 13;
            this.btnContador.Text = "Iniciar contador";
            this.btnContador.UseVisualStyleBackColor = true;
            this.btnContador.Click += new System.EventHandler(this.btnContador_Click);
            // 
            // nudSegundos
            // 
            this.nudSegundos.Location = new System.Drawing.Point(405, 189);
            this.nudSegundos.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudSegundos.Name = "nudSegundos";
            this.nudSegundos.Size = new System.Drawing.Size(77, 27);
            this.nudSegundos.TabIndex = 14;
            this.nudSegundos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudSegundos_KeyPress);
            // 
            // nudMinutos
            // 
            this.nudMinutos.Location = new System.Drawing.Point(290, 190);
            this.nudMinutos.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudMinutos.Name = "nudMinutos";
            this.nudMinutos.Size = new System.Drawing.Size(77, 27);
            this.nudMinutos.TabIndex = 15;
            this.nudMinutos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudMinutos_KeyPress);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(352, 277);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(137, 50);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar contador";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 623);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.nudMinutos);
            this.Controls.Add(this.nudSegundos);
            this.Controls.Add(this.btnContador);
            this.Controls.Add(this.nudHoras);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblHoras);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblpp);
            this.Controls.Add(this.btnIdentificar);
            this.Controls.Add(this.lblSelMonitor);
            this.Controls.Add(this.cbMonitores);
            this.Controls.Add(this.btnSalir);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ComboBox cbMonitores;
        private System.Windows.Forms.Label lblSelMonitor;
        private System.Windows.Forms.Button btnIdentificar;
        private System.Windows.Forms.Label lblpp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudHoras;
        private System.Windows.Forms.Button btnContador;
        private System.Windows.Forms.NumericUpDown nudSegundos;
        private System.Windows.Forms.NumericUpDown nudMinutos;
        private System.Windows.Forms.Button btnCancelar;
    }
}

