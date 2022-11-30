namespace CREACIONES_NANCY.CLIENTE
{
    partial class CLIENTE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CLIENTE));
            this.BTNSALIR = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTAPELLIDOS = new System.Windows.Forms.TextBox();
            this.TXTNOMBRES = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TXTCI = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTNREFRESCAR = new System.Windows.Forms.Button();
            this.BTNNUEVO = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BTNBUSCAR = new System.Windows.Forms.Button();
            this.BTNMODIFICAR = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNSALIR
            // 
            this.BTNSALIR.BackColor = System.Drawing.Color.DarkSalmon;
            this.BTNSALIR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTNSALIR.BackgroundImage")));
            this.BTNSALIR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BTNSALIR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSALIR.Location = new System.Drawing.Point(630, -1);
            this.BTNSALIR.Name = "BTNSALIR";
            this.BTNSALIR.Size = new System.Drawing.Size(80, 74);
            this.BTNSALIR.TabIndex = 141;
            this.BTNSALIR.Text = "SALIR";
            this.BTNSALIR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTNSALIR.UseVisualStyleBackColor = false;
            this.BTNSALIR.Click += new System.EventHandler(this.BTNSALIR_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LightSalmon;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(2, -1);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(708, 74);
            this.label2.TabIndex = 140;
            this.label2.Text = "CLIENTES";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TXTAPELLIDOS
            // 
            this.TXTAPELLIDOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTAPELLIDOS.Location = new System.Drawing.Point(128, 99);
            this.TXTAPELLIDOS.Name = "TXTAPELLIDOS";
            this.TXTAPELLIDOS.Size = new System.Drawing.Size(134, 22);
            this.TXTAPELLIDOS.TabIndex = 150;
            this.TXTAPELLIDOS.TextChanged += new System.EventHandler(this.TXTAPELLIDOS_TextChanged);
            this.TXTAPELLIDOS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTAPELLIDOS_KeyPress);
            // 
            // TXTNOMBRES
            // 
            this.TXTNOMBRES.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTNOMBRES.Location = new System.Drawing.Point(128, 71);
            this.TXTNOMBRES.Name = "TXTNOMBRES";
            this.TXTNOMBRES.Size = new System.Drawing.Size(134, 22);
            this.TXTNOMBRES.TabIndex = 149;
            this.TXTNOMBRES.TextChanged += new System.EventHandler(this.TXTNOMBRES_TextChanged);
            this.TXTNOMBRES.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTNOMBRES_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(24, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 148;
            this.label5.Text = "NOMBRES:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(17, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 147;
            this.label4.Text = "APELLIDOS:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(47, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 145;
            this.label1.Text = "NIT/C.I.:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TXTCI
            // 
            this.TXTCI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTCI.Location = new System.Drawing.Point(128, 129);
            this.TXTCI.Name = "TXTCI";
            this.TXTCI.Size = new System.Drawing.Size(134, 22);
            this.TXTCI.TabIndex = 144;
            this.TXTCI.TextChanged += new System.EventHandler(this.TXTCI_TextChanged);
            this.TXTCI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTCI_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(325, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(369, 263);
            this.dataGridView1.TabIndex = 142;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.LightSalmon;
            this.label7.Location = new System.Drawing.Point(322, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 15);
            this.label7.TabIndex = 153;
            this.label7.Text = "LISTA DE CLIENTES";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightSalmon;
            this.label6.Location = new System.Drawing.Point(83, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 15);
            this.label6.TabIndex = 152;
            this.label6.Text = "DETALLE CLIENTE";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(278, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(25, 372);
            this.groupBox1.TabIndex = 151;
            this.groupBox1.TabStop = false;
            // 
            // BTNREFRESCAR
            // 
            this.BTNREFRESCAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNREFRESCAR.Image = ((System.Drawing.Image)(resources.GetObject("BTNREFRESCAR.Image")));
            this.BTNREFRESCAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNREFRESCAR.Location = new System.Drawing.Point(55, 314);
            this.BTNREFRESCAR.Name = "BTNREFRESCAR";
            this.BTNREFRESCAR.Size = new System.Drawing.Size(171, 46);
            this.BTNREFRESCAR.TabIndex = 155;
            this.BTNREFRESCAR.Text = "           REFRESCAR";
            this.BTNREFRESCAR.UseVisualStyleBackColor = true;
            // 
            // BTNNUEVO
            // 
            this.BTNNUEVO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTNNUEVO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNNUEVO.Image = ((System.Drawing.Image)(resources.GetObject("BTNNUEVO.Image")));
            this.BTNNUEVO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNNUEVO.Location = new System.Drawing.Point(55, 167);
            this.BTNNUEVO.Name = "BTNNUEVO";
            this.BTNNUEVO.Size = new System.Drawing.Size(171, 43);
            this.BTNNUEVO.TabIndex = 154;
            this.BTNNUEVO.Text = "            NUEVO CLIENTE";
            this.BTNNUEVO.UseVisualStyleBackColor = true;
            this.BTNNUEVO.Click += new System.EventHandler(this.BTNNUEVO_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.BTNBUSCAR);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.BTNMODIFICAR);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.BTNNUEVO);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.BTNREFRESCAR);
            this.groupBox2.Controls.Add(this.TXTCI);
            this.groupBox2.Controls.Add(this.TXTAPELLIDOS);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.TXTNOMBRES);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(2, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(698, 372);
            this.groupBox2.TabIndex = 156;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CLIENTES";
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(55, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 43);
            this.button1.TabIndex = 159;
            this.button1.Text = "             ELIMINAR ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTNBUSCAR
            // 
            this.BTNBUSCAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTNBUSCAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNBUSCAR.Image = ((System.Drawing.Image)(resources.GetObject("BTNBUSCAR.Image")));
            this.BTNBUSCAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNBUSCAR.Location = new System.Drawing.Point(325, 52);
            this.BTNBUSCAR.Name = "BTNBUSCAR";
            this.BTNBUSCAR.Size = new System.Drawing.Size(160, 39);
            this.BTNBUSCAR.TabIndex = 160;
            this.BTNBUSCAR.Text = "             BUSCAR";
            this.BTNBUSCAR.UseVisualStyleBackColor = true;
            this.BTNBUSCAR.Click += new System.EventHandler(this.BTNBUSCAR_Click);
            // 
            // BTNMODIFICAR
            // 
            this.BTNMODIFICAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTNMODIFICAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNMODIFICAR.Image = ((System.Drawing.Image)(resources.GetObject("BTNMODIFICAR.Image")));
            this.BTNMODIFICAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNMODIFICAR.Location = new System.Drawing.Point(55, 216);
            this.BTNMODIFICAR.Name = "BTNMODIFICAR";
            this.BTNMODIFICAR.Size = new System.Drawing.Size(171, 43);
            this.BTNMODIFICAR.TabIndex = 157;
            this.BTNMODIFICAR.Text = "          MODIFICAR ";
            this.BTNMODIFICAR.UseVisualStyleBackColor = true;
            this.BTNMODIFICAR.Click += new System.EventHandler(this.BTNMODIFICAR_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // CLIENTE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 458);
            this.Controls.Add(this.BTNSALIR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CLIENTE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CLIENTE";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTNSALIR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXTAPELLIDOS;
        private System.Windows.Forms.TextBox TXTNOMBRES;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXTCI;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BTNREFRESCAR;
        private System.Windows.Forms.Button BTNNUEVO;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BTNMODIFICAR;
        private System.Windows.Forms.Button BTNBUSCAR;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}