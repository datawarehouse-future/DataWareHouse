namespace CapaPresentación
{
    partial class FrmExportarPeriodicamente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExportarPeriodicamente));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtMES = new System.Windows.Forms.TextBox();
            this.txtAÑO = new System.Windows.Forms.TextBox();
            this.txtMESEX = new System.Windows.Forms.TextBox();
            this.txtAÑOEX = new System.Windows.Forms.TextBox();
            this.lbMES2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbMES = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(9, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Exporta informacion periodica de ventas";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnAceptar);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.txtMES);
            this.groupBox1.Controls.Add(this.txtAÑO);
            this.groupBox1.Controls.Add(this.txtMESEX);
            this.groupBox1.Controls.Add(this.txtAÑOEX);
            this.groupBox1.Controls.Add(this.lbMES2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbMES);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBox1.Location = new System.Drawing.Point(12, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 209);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Exportar";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(115, 187);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 161;
            this.label9.Text = "Aceptar";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.White;
            this.btnAceptar.BackgroundImage = global::CapaPresentación.Properties.Resources.aceptar_icon;
            this.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAceptar.Location = new System.Drawing.Point(95, 134);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(85, 50);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(204, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 159;
            this.label6.Text = "ESC &Salir";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.BackgroundImage = global::CapaPresentación.Properties.Resources.salir_icon;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalir.Location = new System.Drawing.Point(189, 134);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(85, 50);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // txtMES
            // 
            this.txtMES.Enabled = false;
            this.txtMES.Location = new System.Drawing.Point(280, 84);
            this.txtMES.Margin = new System.Windows.Forms.Padding(2);
            this.txtMES.MaxLength = 2;
            this.txtMES.Name = "txtMES";
            this.txtMES.Size = new System.Drawing.Size(40, 20);
            this.txtMES.TabIndex = 158;
            this.txtMES.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAÑO
            // 
            this.txtAÑO.Enabled = false;
            this.txtAÑO.Location = new System.Drawing.Point(194, 84);
            this.txtAÑO.Margin = new System.Windows.Forms.Padding(2);
            this.txtAÑO.MaxLength = 4;
            this.txtAÑO.Name = "txtAÑO";
            this.txtAÑO.Size = new System.Drawing.Size(51, 20);
            this.txtAÑO.TabIndex = 157;
            this.txtAÑO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMESEX
            // 
            this.txtMESEX.Location = new System.Drawing.Point(280, 50);
            this.txtMESEX.Margin = new System.Windows.Forms.Padding(2);
            this.txtMESEX.MaxLength = 2;
            this.txtMESEX.Name = "txtMESEX";
            this.txtMESEX.Size = new System.Drawing.Size(40, 20);
            this.txtMESEX.TabIndex = 1;
            this.txtMESEX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMESEX.TextChanged += new System.EventHandler(this.txtMESEX_TextChanged);
            this.txtMESEX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMESEX_KeyPress);
            // 
            // txtAÑOEX
            // 
            this.txtAÑOEX.Location = new System.Drawing.Point(195, 49);
            this.txtAÑOEX.Margin = new System.Windows.Forms.Padding(2);
            this.txtAÑOEX.MaxLength = 4;
            this.txtAÑOEX.Name = "txtAÑOEX";
            this.txtAÑOEX.Size = new System.Drawing.Size(51, 20);
            this.txtAÑOEX.TabIndex = 0;
            this.txtAÑOEX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAÑOEX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAÑOEX_KeyPress);
            // 
            // lbMES2
            // 
            this.lbMES2.AutoSize = true;
            this.lbMES2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbMES2.Location = new System.Drawing.Point(324, 90);
            this.lbMES2.Name = "lbMES2";
            this.lbMES2.Size = new System.Drawing.Size(35, 13);
            this.lbMES2.TabIndex = 11;
            this.lbMES2.Text = "Enero";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label8.Location = new System.Drawing.Point(256, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "/";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(14, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ultimo periodo Exportado:";
            // 
            // lbMES
            // 
            this.lbMES.AutoSize = true;
            this.lbMES.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbMES.Location = new System.Drawing.Point(324, 52);
            this.lbMES.Name = "lbMES";
            this.lbMES.Size = new System.Drawing.Size(27, 13);
            this.lbMES.TabIndex = 6;
            this.lbMES.Text = "Mes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(256, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "/";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(14, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Periodo a Exportar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(27, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(343, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "EXPORTAR PERIODICAMENTE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(335, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Nota: Se exportara informacion en el siguiente archivo C:\\ARCHIVOS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(377, 43);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // FrmExportarPeriodicamente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 378);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FrmExportarPeriodicamente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmExportarPeriodicamente_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmExportarPeriodicamente_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmExportarPeriodicamente_KeyPress);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMES;
        private System.Windows.Forms.TextBox txtAÑO;
        private System.Windows.Forms.TextBox txtMESEX;
        private System.Windows.Forms.TextBox txtAÑOEX;
        private System.Windows.Forms.Label lbMES2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbMES;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label9;
    }
}