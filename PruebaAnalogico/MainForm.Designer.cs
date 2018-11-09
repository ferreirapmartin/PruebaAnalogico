namespace PruebaAnalogico
{
    partial class MainForm
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
            this.btnIniciar = new System.Windows.Forms.Button();
            this.txtBaudRate = new System.Windows.Forms.TextBox();
            this.txtPuerto = new System.Windows.Forms.TextBox();
            this.lblBaudRate = new System.Windows.Forms.Label();
            this.lblPuerto = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(213, 10);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(94, 49);
            this.btnIniciar.TabIndex = 0;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // txtBaudRate
            // 
            this.txtBaudRate.Location = new System.Drawing.Point(86, 12);
            this.txtBaudRate.Name = "txtBaudRate";
            this.txtBaudRate.Size = new System.Drawing.Size(109, 20);
            this.txtBaudRate.TabIndex = 1;
            // 
            // txtPuerto
            // 
            this.txtPuerto.Location = new System.Drawing.Point(86, 39);
            this.txtPuerto.Name = "txtPuerto";
            this.txtPuerto.Size = new System.Drawing.Size(109, 20);
            this.txtPuerto.TabIndex = 2;
            // 
            // lblBaudRate
            // 
            this.lblBaudRate.AutoSize = true;
            this.lblBaudRate.Location = new System.Drawing.Point(12, 15);
            this.lblBaudRate.Name = "lblBaudRate";
            this.lblBaudRate.Size = new System.Drawing.Size(58, 13);
            this.lblBaudRate.TabIndex = 3;
            this.lblBaudRate.Text = "Baud Rate";
            // 
            // lblPuerto
            // 
            this.lblPuerto.AutoSize = true;
            this.lblPuerto.Location = new System.Drawing.Point(32, 39);
            this.lblPuerto.Name = "lblPuerto";
            this.lblPuerto.Size = new System.Drawing.Size(38, 13);
            this.lblPuerto.TabIndex = 4;
            this.lblPuerto.Text = "Puerto";
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(15, 77);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(292, 317);
            this.txtLog.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(320, 406);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.lblPuerto);
            this.Controls.Add(this.lblBaudRate);
            this.Controls.Add(this.txtPuerto);
            this.Controls.Add(this.txtBaudRate);
            this.Controls.Add(this.btnIniciar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "Prueba analógico";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.TextBox txtBaudRate;
        private System.Windows.Forms.TextBox txtPuerto;
        private System.Windows.Forms.Label lblBaudRate;
        private System.Windows.Forms.Label lblPuerto;
        private System.Windows.Forms.TextBox txtLog;
    }
}

