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
            this.lbCARGANDO = new System.Windows.Forms.Label();
            this.cbAÑODesde = new System.Windows.Forms.ComboBox();
            this.cbAÑOHasta = new System.Windows.Forms.ComboBox();
            this.cbMEShasta = new System.Windows.Forms.ComboBox();
            this.cbMESDesde = new System.Windows.Forms.ComboBox();
            this.lbInicioVenta = new System.Windows.Forms.Label();
            this.lbFinVenta = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkDimensiones = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 163;
            this.label2.Text = "Desde";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 164;
            this.label3.Text = "Hasta";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(24, 259);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(539, 30);
            this.progressBar1.TabIndex = 165;
            // 
            // tmProgresaBar
            // 
            this.tmProgresaBar.Interval = 250;
            this.tmProgresaBar.Tick += new System.EventHandler(this.tmProgresaBar_Tick);
            // 
            // lbCARGANDO
            // 
            this.lbCARGANDO.AutoSize = true;
            this.lbCARGANDO.BackColor = System.Drawing.Color.Transparent;
            this.lbCARGANDO.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCARGANDO.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbCARGANDO.Location = new System.Drawing.Point(129, 246);
            this.lbCARGANDO.Name = "lbCARGANDO";
            this.lbCARGANDO.Size = new System.Drawing.Size(0, 20);
            this.lbCARGANDO.TabIndex = 167;
            // 
            // cbAÑODesde
            // 
            this.cbAÑODesde.FormattingEnabled = true;
            this.cbAÑODesde.Location = new System.Drawing.Point(130, 89);
            this.cbAÑODesde.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbAÑODesde.Name = "cbAÑODesde";
            this.cbAÑODesde.Size = new System.Drawing.Size(92, 21);
            this.cbAÑODesde.TabIndex = 168;
            this.cbAÑODesde.SelectedIndexChanged += new System.EventHandler(this.cbAÑODesde_SelectedIndexChanged);
            // 
            // cbAÑOHasta
            // 
            this.cbAÑOHasta.FormattingEnabled = true;
            this.cbAÑOHasta.Location = new System.Drawing.Point(130, 126);
            this.cbAÑOHasta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbAÑOHasta.Name = "cbAÑOHasta";
            this.cbAÑOHasta.Size = new System.Drawing.Size(92, 21);
            this.cbAÑOHasta.TabIndex = 169;
            this.cbAÑOHasta.SelectedIndexChanged += new System.EventHandler(this.cbAÑOHasta_SelectedIndexChanged);
            // 
            // cbMEShasta
            // 
            this.cbMEShasta.FormattingEnabled = true;
            this.cbMEShasta.Location = new System.Drawing.Point(255, 126);
            this.cbMEShasta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbMEShasta.Name = "cbMEShasta";
            this.cbMEShasta.Size = new System.Drawing.Size(92, 21);
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
            this.cbMESDesde.Location = new System.Drawing.Point(255, 89);
            this.cbMESDesde.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbMESDesde.Name = "cbMESDesde";
            this.cbMESDesde.Size = new System.Drawing.Size(92, 21);
            this.cbMESDesde.TabIndex = 170;
            this.cbMESDesde.SelectedIndexChanged += new System.EventHandler(this.cbMESDesde_SelectedIndexChanged);
            // 
            // lbInicioVenta
            // 
            this.lbInicioVenta.AutoSize = true;
            this.lbInicioVenta.Location = new System.Drawing.Point(388, 94);
            this.lbInicioVenta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbInicioVenta.Name = "lbInicioVenta";
            this.lbInicioVenta.Size = new System.Drawing.Size(32, 13);
            this.lbInicioVenta.TabIndex = 172;
            this.lbInicioVenta.Text = "Inicio";
            this.lbInicioVenta.Click += new System.EventHandler(this.lbInicioVenta_Click);
            // 
            // lbFinVenta
            // 
            this.lbFinVenta.AutoSize = true;
            this.lbFinVenta.Location = new System.Drawing.Point(388, 147);
            this.lbFinVenta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFinVenta.Name = "lbFinVenta";
            this.lbFinVenta.Size = new System.Drawing.Size(21, 13);
            this.lbFinVenta.TabIndex = 173;
            this.lbFinVenta.Text = "Fin";
            this.lbFinVenta.Click += new System.EventHandler(this.lbFinVenta_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, -180);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(547, 43);
            this.pictureBox1.TabIndex = 174;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // checkDimensiones
            // 
            this.checkDimensiones.AutoSize = true;
            this.checkDimensiones.Location = new System.Drawing.Point(64, 162);
            this.checkDimensiones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkDimensiones.Name = "checkDimensiones";
            this.checkDimensiones.Size = new System.Drawing.Size(120, 17);
            this.checkDimensiones.TabIndex = 177;
            this.checkDimensiones.Text = "Cargar Dimensiones";
            this.checkDimensiones.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(172, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 181;
            this.label5.Text = "Aceptar";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.BackgroundImage = global::CapaPresentación.Properties.Resources.aceptar_icon;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.Location = new System.Drawing.Point(152, 181);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 50);
            this.button3.TabIndex = 178;
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(261, 233);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 180;
            this.label10.Text = "ESC &Salir";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.BackgroundImage = global::CapaPresentación.Properties.Resources.salir_icon;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalir.Location = new System.Drawing.Point(246, 181);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(85, 50);
            this.btnSalir.TabIndex = 179;
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(16, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(547, 43);
            this.pictureBox2.TabIndex = 182;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(119, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 25);
            this.label1.TabIndex = 183;
            this.label1.Text = "CARGA DE DATOS GENERAL";
            // 
            // frmGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 319);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.checkDimensiones);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbFinVenta);
            this.Controls.Add(this.lbInicioVenta);
            this.Controls.Add(this.cbMEShasta);
            this.Controls.Add(this.cbMESDesde);
            this.Controls.Add(this.cbAÑOHasta);
            this.Controls.Add(this.cbAÑODesde);
            this.Controls.Add(this.lbCARGANDO);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmGeneral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGeneral";
            this.Load += new System.EventHandler(this.frmGeneral_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer tmProgresaBar;
        private System.Windows.Forms.Label lbCARGANDO;
        private System.Windows.Forms.ComboBox cbAÑODesde;
        private System.Windows.Forms.ComboBox cbAÑOHasta;
        private System.Windows.Forms.ComboBox cbMEShasta;
        private System.Windows.Forms.ComboBox cbMESDesde;
        private System.Windows.Forms.Label lbInicioVenta;
        private System.Windows.Forms.Label lbFinVenta;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkDimensiones;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}