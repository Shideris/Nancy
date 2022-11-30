namespace CREACIONES_NANCY
{
    partial class LOGIN
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOGIN));
            this.BTNVER = new System.Windows.Forms.Button();
            this.BTNSALIR = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TXTCONTRASENA = new System.Windows.Forms.TextBox();
            this.TXTUSUARIO = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BTNENTRAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTNVER
            // 
            this.BTNVER.BackColor = System.Drawing.Color.Firebrick;
            this.BTNVER.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNVER.ForeColor = System.Drawing.Color.White;
            this.BTNVER.Location = new System.Drawing.Point(289, 341);
            this.BTNVER.Name = "BTNVER";
            this.BTNVER.Size = new System.Drawing.Size(53, 38);
            this.BTNVER.TabIndex = 16;
            this.BTNVER.Text = "VER";
            this.BTNVER.UseVisualStyleBackColor = false;
            this.BTNVER.Click += new System.EventHandler(this.BTNVER_Click);
            // 
            // BTNSALIR
            // 
            this.BTNSALIR.BackColor = System.Drawing.Color.Firebrick;
            this.BTNSALIR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSALIR.ForeColor = System.Drawing.Color.White;
            this.BTNSALIR.Location = new System.Drawing.Point(409, 400);
            this.BTNSALIR.Name = "BTNSALIR";
            this.BTNSALIR.Size = new System.Drawing.Size(99, 38);
            this.BTNSALIR.TabIndex = 15;
            this.BTNSALIR.Text = "SALIR";
            this.BTNSALIR.UseVisualStyleBackColor = false;
            this.BTNSALIR.Click += new System.EventHandler(this.BTNSALIR_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(315, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 29);
            this.label3.TabIndex = 14;
            this.label3.Text = "CONTRASEÑA:";
            // 
            // TXTCONTRASENA
            // 
            this.TXTCONTRASENA.BackColor = System.Drawing.Color.LightCoral;
            this.TXTCONTRASENA.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTCONTRASENA.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.TXTCONTRASENA.Location = new System.Drawing.Point(348, 340);
            this.TXTCONTRASENA.Name = "TXTCONTRASENA";
            this.TXTCONTRASENA.PasswordChar = '*';
            this.TXTCONTRASENA.Size = new System.Drawing.Size(169, 35);
            this.TXTCONTRASENA.TabIndex = 13;
            // 
            // TXTUSUARIO
            // 
            this.TXTUSUARIO.BackColor = System.Drawing.Color.LightCoral;
            this.TXTUSUARIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTUSUARIO.Location = new System.Drawing.Point(348, 265);
            this.TXTUSUARIO.Multiline = true;
            this.TXTUSUARIO.Name = "TXTUSUARIO";
            this.TXTUSUARIO.Size = new System.Drawing.Size(169, 31);
            this.TXTUSUARIO.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(363, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 31);
            this.label2.TabIndex = 11;
            this.label2.Text = "USUARIO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 39.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepPink;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(496, 128);
            this.label1.TabIndex = 10;
            this.label1.Text = "CREACIONES \r\n                       NANCY";
            // 
            // BTNENTRAR
            // 
            this.BTNENTRAR.BackColor = System.Drawing.Color.Firebrick;
            this.BTNENTRAR.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNENTRAR.ForeColor = System.Drawing.Color.White;
            this.BTNENTRAR.Location = new System.Drawing.Point(289, 400);
            this.BTNENTRAR.Name = "BTNENTRAR";
            this.BTNENTRAR.Size = new System.Drawing.Size(112, 38);
            this.BTNENTRAR.TabIndex = 9;
            this.BTNENTRAR.Text = "ENTRAR";
            this.BTNENTRAR.UseVisualStyleBackColor = false;
            this.BTNENTRAR.Click += new System.EventHandler(this.BTNENTRAR_Click);
            // 
            // LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(533, 453);
            this.Controls.Add(this.BTNVER);
            this.Controls.Add(this.BTNSALIR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TXTCONTRASENA);
            this.Controls.Add(this.TXTUSUARIO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTNENTRAR);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LOGIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNVER;
        private System.Windows.Forms.Button BTNSALIR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXTCONTRASENA;
        private System.Windows.Forms.TextBox TXTUSUARIO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTNENTRAR;
    }
}

