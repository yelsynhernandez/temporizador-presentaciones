namespace Temporizador
{
    partial class FrmContador
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
            this.tlpBase = new System.Windows.Forms.TableLayoutPanel();
            this.lblContador = new System.Windows.Forms.Label();
            this.tlpBase.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpBase
            // 
            this.tlpBase.ColumnCount = 1;
            this.tlpBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBase.Controls.Add(this.lblContador, 0, 0);
            this.tlpBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBase.Location = new System.Drawing.Point(0, 0);
            this.tlpBase.Margin = new System.Windows.Forms.Padding(30, 27, 30, 27);
            this.tlpBase.Name = "tlpBase";
            this.tlpBase.RowCount = 1;
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBase.Size = new System.Drawing.Size(1000, 361);
            this.tlpBase.TabIndex = 0;
            // 
            // lblContador
            // 
            this.lblContador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblContador.Font = new System.Drawing.Font("Verdana", 125F, System.Drawing.FontStyle.Bold);
            this.lblContador.Location = new System.Drawing.Point(30, 0);
            this.lblContador.Margin = new System.Windows.Forms.Padding(30, 0, 30, 0);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(940, 361);
            this.lblContador.TabIndex = 0;
            this.lblContador.Text = "00:00:00";
            this.lblContador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmContador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(60F, 116F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 361);
            this.Controls.Add(this.tlpBase);
            this.Font = new System.Drawing.Font("Verdana", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(30, 27, 30, 27);
            this.Name = "FrmContador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contador";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tlpBase.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpBase;
        private System.Windows.Forms.Label lblContador;
    }
}