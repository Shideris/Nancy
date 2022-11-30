namespace CREACIONES_NANCY.INVENTARIO
{
    partial class BUSQUEDA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BUSQUEDA));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TXTDISENO = new System.Windows.Forms.ComboBox();
            this.TXTBODEGA = new System.Windows.Forms.ComboBox();
            this.TXTIDTELA = new System.Windows.Forms.ComboBox();
            this.TXTMODELO = new System.Windows.Forms.ComboBox();
            this.BTNNUEVO = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BTNREFRESCAR = new System.Windows.Forms.Button();
            this.TXTCODIGO = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BTNSALIR = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TXTDISENO);
            this.groupBox1.Controls.Add(this.TXTBODEGA);
            this.groupBox1.Controls.Add(this.TXTIDTELA);
            this.groupBox1.Controls.Add(this.TXTMODELO);
            this.groupBox1.Controls.Add(this.BTNNUEVO);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.BTNREFRESCAR);
            this.groupBox1.Controls.Add(this.TXTCODIGO);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(805, 502);
            this.groupBox1.TabIndex = 157;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inventario";
            // 
            // TXTDISENO
            // 
            this.TXTDISENO.FormattingEnabled = true;
            this.TXTDISENO.Location = new System.Drawing.Point(573, 66);
            this.TXTDISENO.Name = "TXTDISENO";
            this.TXTDISENO.Size = new System.Drawing.Size(134, 24);
            this.TXTDISENO.TabIndex = 165;
            this.TXTDISENO.SelectedIndexChanged += new System.EventHandler(this.TXTDISENO_SelectedIndexChanged);
            // 
            // TXTBODEGA
            // 
            this.TXTBODEGA.FormattingEnabled = true;
            this.TXTBODEGA.Items.AddRange(new object[] {
            "1",
            "2"});
            this.TXTBODEGA.Location = new System.Drawing.Point(278, 69);
            this.TXTBODEGA.Name = "TXTBODEGA";
            this.TXTBODEGA.Size = new System.Drawing.Size(134, 24);
            this.TXTBODEGA.TabIndex = 164;
            this.TXTBODEGA.Text = "----BODEGA----";
            // 
            // TXTIDTELA
            // 
            this.TXTIDTELA.FormattingEnabled = true;
            this.TXTIDTELA.Location = new System.Drawing.Point(107, 24);
            this.TXTIDTELA.Name = "TXTIDTELA";
            this.TXTIDTELA.Size = new System.Drawing.Size(134, 24);
            this.TXTIDTELA.TabIndex = 163;
            // 
            // TXTMODELO
            // 
            this.TXTMODELO.FormattingEnabled = true;
            this.TXTMODELO.Location = new System.Drawing.Point(374, 27);
            this.TXTMODELO.Name = "TXTMODELO";
            this.TXTMODELO.Size = new System.Drawing.Size(134, 24);
            this.TXTMODELO.TabIndex = 161;
            // 
            // BTNNUEVO
            // 
            this.BTNNUEVO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTNNUEVO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNNUEVO.Image = ((System.Drawing.Image)(resources.GetObject("BTNNUEVO.Image")));
            this.BTNNUEVO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNNUEVO.Location = new System.Drawing.Point(241, 445);
            this.BTNNUEVO.Name = "BTNNUEVO";
            this.BTNNUEVO.Size = new System.Drawing.Size(220, 46);
            this.BTNNUEVO.TabIndex = 158;
            this.BTNNUEVO.Text = "               BUSCAR  INVENTARIO";
            this.BTNNUEVO.UseVisualStyleBackColor = true;
            this.BTNNUEVO.Click += new System.EventHandler(this.BTNNUEVO_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(20, 445);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 46);
            this.button1.TabIndex = 153;
            this.button1.Text = "             DESCARGAR EXCEL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTNREFRESCAR
            // 
            this.BTNREFRESCAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNREFRESCAR.Image = ((System.Drawing.Image)(resources.GetObject("BTNREFRESCAR.Image")));
            this.BTNREFRESCAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNREFRESCAR.Location = new System.Drawing.Point(643, 445);
            this.BTNREFRESCAR.Name = "BTNREFRESCAR";
            this.BTNREFRESCAR.Size = new System.Drawing.Size(151, 46);
            this.BTNREFRESCAR.TabIndex = 152;
            this.BTNREFRESCAR.Text = "           REFRESCAR";
            this.BTNREFRESCAR.UseVisualStyleBackColor = true;
            this.BTNREFRESCAR.Click += new System.EventHandler(this.BTNREFRESCAR_Click);
            // 
            // TXTCODIGO
            // 
            this.TXTCODIGO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTCODIGO.Location = new System.Drawing.Point(645, 25);
            this.TXTCODIGO.Name = "TXTCODIGO";
            this.TXTCODIGO.Size = new System.Drawing.Size(134, 22);
            this.TXTCODIGO.TabIndex = 109;
            this.TXTCODIGO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTCODIGO_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(570, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 16);
            this.label11.TabIndex = 108;
            this.label11.Text = "CODIGO:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(480, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 16);
            this.label10.TabIndex = 106;
            this.label10.Text = "DISEÑO:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(37, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 105;
            this.label4.Text = "N TELA:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(275, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 98;
            this.label5.Text = "MODELO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(175, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 96;
            this.label3.Text = "BODEGA:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(774, 331);
            this.dataGridView1.TabIndex = 93;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // BTNSALIR
            // 
            this.BTNSALIR.BackColor = System.Drawing.Color.LightCoral;
            this.BTNSALIR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTNSALIR.BackgroundImage")));
            this.BTNSALIR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BTNSALIR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSALIR.Location = new System.Drawing.Point(743, -2);
            this.BTNSALIR.Name = "BTNSALIR";
            this.BTNSALIR.Size = new System.Drawing.Size(85, 80);
            this.BTNSALIR.TabIndex = 156;
            this.BTNSALIR.Text = "SALIR";
            this.BTNSALIR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTNSALIR.UseVisualStyleBackColor = false;
            this.BTNSALIR.Click += new System.EventHandler(this.BTNSALIR_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LightCoral;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1, -3);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(827, 81);
            this.label2.TabIndex = 155;
            this.label2.Text = "INVENTARIO";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // BUSQUEDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 602);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BTNSALIR);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BUSQUEDA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BUSQUEDA";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BTNREFRESCAR;
        private System.Windows.Forms.TextBox TXTCODIGO;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BTNSALIR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTNNUEVO;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox TXTIDTELA;
        private System.Windows.Forms.ComboBox TXTMODELO;
        private System.Windows.Forms.ComboBox TXTDISENO;
        private System.Windows.Forms.ComboBox TXTBODEGA;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
    }
}