namespace CapaPresentación
{
    partial class frmGeneral
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tmProgresaBar = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.lbCARGANDO = new System.Windows.Forms.Label();
            this.cbAÑODesde = new System.Windows.Forms.ComboBox();
            this.cbAÑOHasta = new System.Windows.Forms.ComboBox();
            this.cbMEShasta = new System.Windows.Forms.ComboBox();
            this.cbMESDesde = new System.Windows.Forms.ComboBox();
            this.lbInicioVenta = new System.Windows.Forms.Label();
            this.lbFinVenta = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.checkDimensiones = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 163;
            this.label2.Text = "Desde";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 164;
            this.label3.Text = "Hasta";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(118, 303);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(359, 37);
            this.progressBar1.TabIndex = 165;
            // 
            // tmProgresaBar
            // 
            this.tmProgresaBar.Interval = 250;
            this.tmProgresaBar.Tick += new System.EventHandler(this.tmProgresaBar_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(203, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 28);
            this.button1.TabIndex = 166;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbCARGANDO
            // 
            this.lbCARGANDO.AutoSize = true;
            this.lbCARGANDO.BackColor = System.Drawing.Color.Transparent;
            this.lbCARGANDO.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCARGANDO.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbCARGANDO.Location = new System.Drawing.Point(172, 355);
            this.lbCARGANDO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCARGANDO.Name = "lbCARGANDO";
            this.lbCARGANDO.Size = new System.Drawing.Size(0, 24);
            this.lbCARGANDO.TabIndex = 167;
            // 
            // cbAÑODesde
            // 
            this.cbAÑODesde.FormattingEnabled = true;
            this.cbAÑODesde.Location = new System.Drawing.Point(174, 109);
            this.cbAÑODesde.Name = "cbAÑODesde";
            this.cbAÑODesde.Size = new System.Drawing.Size(121, 24);
            this.cbAÑODesde.TabIndex = 168;
            this.cbAÑODesde.SelectedIndexChanged += new System.EventHandler(this.cbAÑODesde_SelectedIndexChanged);
            // 
            // cbAÑOHasta
            // 
            this.cbAÑOHasta.FormattingEnabled = true;
            this.cbAÑOHasta.Location = new System.Drawing.Point(174, 155);
            this.cbAÑOHasta.Name = "cbAÑOHasta";
            this.cbAÑOHasta.Size = new System.Drawing.Size(121, 24);
            this.cbAÑOHasta.TabIndex = 169;
            this.cbAÑOHasta.SelectedIndexChanged += new System.EventHandler(this.cbAÑOHasta_SelectedIndexChanged);
            // 
            // cbMEShasta
            // 
            this.cbMEShasta.FormattingEnabled = true;
            this.cbMEShasta.Location = new System.Drawing.Point(340, 155);
            this.cbMEShasta.Name = "cbMEShasta";
            this.cbMEShasta.Size = new System.Drawing.Size(121, 24);
            this.cbMEShasta.TabIndex = 171;
            // 
            // cbMESDesde
            // 
            this.cbMESDesde.FormattingEnabled = true;
            this.cbMESDesde.Items.AddRange(new object[] {
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
            this.cbMESDesde.Location = new System.Drawing.Point(340, 109);
            this.cbMESDesde.Name = "cbMESDesde";
            this.cbMESDesde.Size = new System.Drawing.Size(121, 24);
            this.cbMESDesde.TabIndex = 170;
            this.cbMESDesde.SelectedIndexChanged += new System.EventHandler(this.cbMESDesde_SelectedIndexChanged);
            // 
            // lbInicioVenta
            // 
            this.lbInicioVenta.AutoSize = true;
            this.lbInicioVenta.Location = new System.Drawing.Point(518, 116);
            this.lbInicioVenta.Name = "lbInicioVenta";
            this.lbInicioVenta.Size = new System.Drawing.Size(40, 17);
            this.lbInicioVenta.TabIndex = 172;
            this.lbInicioVenta.Text = "Inicio";
            this.lbInicioVenta.Click += new System.EventHandler(this.lbInicioVenta_Click);
            // 
            // lbFinVenta
            // 
            this.lbFinVenta.AutoSize = true;
            this.lbFinVenta.Location = new System.Drawing.Point(518, 181);
            this.lbFinVenta.Name = "lbFinVenta";
            this.lbFinVenta.Size = new System.Drawing.Size(27, 17);
            this.lbFinVenta.TabIndex = 173;
            this.lbFinVenta.Text = "Fin";
            this.lbFinVenta.Click += new System.EventHandler(this.lbFinVenta_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(204, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(416, 31);
            this.label4.TabIndex = 175;
            this.label4.Text = "CARGA DE DATOS GENERAL";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(66, 25);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(680, 52);
            this.pictureBox1.TabIndex = 174;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(328, 240);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 28);
            this.button2.TabIndex = 176;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkDimensiones
            // 
            this.checkDimensiones.AutoSize = true;
            this.checkDimensiones.Location = new System.Drawing.Point(86, 199);
            this.checkDimensiones.Name = "checkDimensiones";
            this.checkDimensiones.Size = new System.Drawing.Size(158, 21);
            this.checkDimensiones.TabIndex = 177;
            this.checkDimensiones.Text = "Cargar Dimensiones";
            this.checkDimensiones.UseVisualStyleBackColor = true;
            // 
            // frmGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 428);
            this.Controls.Add(this.checkDimensiones);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbFinVenta);
            this.Controls.Add(this.lbInicioVenta);
            this.Controls.Add(this.cbMEShasta);
            this.Controls.Add(this.cbMESDesde);
            this.Controls.Add(this.cbAÑOHasta);
            this.Controls.Add(this.cbAÑODesde);
            this.Controls.Add(this.lbCARGANDO);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "frmGeneral";
            this.Text = "frmGeneral";
            this.Load += new System.EventHandler(this.frmGeneral_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer tmProgresaBar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbCARGANDO;
        private System.Windows.Forms.ComboBox cbAÑODesde;
        private System.Windows.Forms.ComboBox cbAÑOHasta;
        private System.Windows.Forms.ComboBox cbMEShasta;
        private System.Windows.Forms.ComboBox cbMESDesde;
        private System.Windows.Forms.Label lbInicioVenta;
        private System.Windows.Forms.Label lbFinVenta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkDimensiones;
    }
}