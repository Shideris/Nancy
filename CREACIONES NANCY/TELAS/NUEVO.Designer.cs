namespace CREACIONES_NANCY.Telas
{
    partial class NUEVO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NUEVO));
            this.label2 = new System.Windows.Forms.Label();
            this.BTNSALIR = new System.Windows.Forms.Button();
            this.TXTPRECIOMENOR = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BTNNUEVO = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TXTCOLOR = new System.Windows.Forms.ComboBox();
            this.TXTMODELO = new System.Windows.Forms.ComboBox();
            this.BTNREFRESCAR = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LightSalmon;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1, -2);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(675, 74);
            this.label2.TabIndex = 138;
            this.label2.Text = "Nueva Tela";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BTNSALIR
            // 
            this.BTNSALIR.BackColor = System.Drawing.Color.DarkSalmon;
            this.BTNSALIR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTNSALIR.BackgroundImage")));
            this.BTNSALIR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BTNSALIR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSALIR.Location = new System.Drawing.Point(596, -2);
            this.BTNSALIR.Name = "BTNSALIR";
            this.BTNSALIR.Size = new System.Drawing.Size(80, 74);
            this.BTNSALIR.TabIndex = 139;
            this.BTNSALIR.Text = "SALIR";
            this.BTNSALIR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTNSALIR.UseVisualStyleBackColor = false;
            this.BTNSALIR.Click += new System.EventHandler(this.BTNSALIR_Click);
            // 
            // TXTPRECIOMENOR
            // 
            this.TXTPRECIOMENOR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTPRECIOMENOR.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.TXTPRECIOMENOR.Location = new System.Drawing.Point(101, 61);
            this.TXTPRECIOMENOR.Name = "TXTPRECIOMENOR";
            this.TXTPRECIOMENOR.Size = new System.Drawing.Size(134, 22);
            this.TXTPRECIOMENOR.TabIndex = 145;
            this.TXTPRECIOMENOR.Text = "PRECIO";
            this.TXTPRECIOMENOR.Enter += new System.EventHandler(this.TXTPRECIOMENOR_Enter);
            this.TXTPRECIOMENOR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTPRECIOMENOR_KeyPress);
            this.TXTPRECIOMENOR.Leave += new System.EventHandler(this.TXTPRECIOMENOR_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(21, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 144;
            this.label7.Text = "PRECIO:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(258, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 142;
            this.label6.Text = "COLOR:\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(21, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 140;
            this.label1.Text = "MODELO:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(462, 269);
            this.dataGridView1.TabIndex = 148;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BTNNUEVO
            // 
            this.BTNNUEVO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTNNUEVO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNNUEVO.Image = ((System.Drawing.Image)(resources.GetObject("BTNNUEVO.Image")));
            this.BTNNUEVO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNNUEVO.Location = new System.Drawing.Point(495, 275);
            this.BTNNUEVO.Name = "BTNNUEVO";
            this.BTNNUEVO.Size = new System.Drawing.Size(151, 43);
            this.BTNNUEVO.TabIndex = 149;
            this.BTNNUEVO.Text = "             NUEVA TELA";
            this.BTNNUEVO.UseVisualStyleBackColor = true;
            this.BTNNUEVO.Click += new System.EventHandler(this.BTNNUEVO_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TXTCOLOR);
            this.groupBox1.Controls.Add(this.TXTMODELO);
            this.groupBox1.Controls.Add(this.BTNREFRESCAR);
            this.groupBox1.Controls.Add(this.BTNNUEVO);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.TXTPRECIOMENOR);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(12, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(655, 376);
            this.groupBox1.TabIndex = 150;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tela";
            // 
            // TXTCOLOR
            // 
            this.TXTCOLOR.ForeColor = System.Drawing.Color.Black;
            this.TXTCOLOR.FormattingEnabled = true;
            this.TXTCOLOR.Location = new System.Drawing.Point(326, 26);
            this.TXTCOLOR.Name = "TXTCOLOR";
            this.TXTCOLOR.Size = new System.Drawing.Size(134, 24);
            this.TXTCOLOR.TabIndex = 153;
            this.TXTCOLOR.Enter += new System.EventHandler(this.TXTCOLOR_Enter);
            this.TXTCOLOR.Leave += new System.EventHandler(this.TXTCOLOR_Leave);
            // 
            // TXTMODELO
            // 
            this.TXTMODELO.ForeColor = System.Drawing.Color.Black;
            this.TXTMODELO.FormattingEnabled = true;
            this.TXTMODELO.Location = new System.Drawing.Point(101, 26);
            this.TXTMODELO.Name = "TXTMODELO";
            this.TXTMODELO.Size = new System.Drawing.Size(134, 24);
            this.TXTMODELO.TabIndex = 152;
            this.TXTMODELO.SelectedIndexChanged += new System.EventHandler(this.TXTMODELO_SelectedIndexChanged);
            this.TXTMODELO.Enter += new System.EventHandler(this.TXTMODELO_Enter);
            this.TXTMODELO.Leave += new System.EventHandler(this.TXTMODELO_Leave);
            // 
            // BTNREFRESCAR
            // 
            this.BTNREFRESCAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNREFRESCAR.Image = ((System.Drawing.Image)(resources.GetObject("BTNREFRESCAR.Image")));
            this.BTNREFRESCAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNREFRESCAR.Location = new System.Drawing.Point(495, 324);
            this.BTNREFRESCAR.Name = "BTNREFRESCAR";
            this.BTNREFRESCAR.Size = new System.Drawing.Size(151, 46);
            this.BTNREFRESCAR.TabIndex = 150;
            this.BTNREFRESCAR.Text = "           REFRESCAR";
            this.BTNREFRESCAR.UseVisualStyleBackColor = true;
            this.BTNREFRESCAR.Click += new System.EventHandler(this.BTNREFRESCAR_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // NUEVO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 465);
            this.Controls.Add(this.BTNSALIR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NUEVO";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NUEVO";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTNSALIR;
        private System.Windows.Forms.TextBox TXTPRECIOMENOR;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BTNNUEVO;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BTNREFRESCAR;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox TXTMODELO;
        private System.Windows.Forms.ComboBox TXTCOLOR;
    }
}