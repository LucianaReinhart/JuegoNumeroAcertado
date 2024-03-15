namespace JuegoNumeroAcertado
{
    partial class Form1
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnEmpezarJuego = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumeroIngresado = new System.Windows.Forms.Label();
            this.btnIntentar = new System.Windows.Forms.Button();
            this.lblPista = new System.Windows.Forms.Label();
            this.tBoxNumeroIngresado = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblIntentos = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTitulo.Location = new System.Drawing.Point(54, 66);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(405, 28);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Números Misteriosos: ¡Adivina y Gana!";
            // 
            // btnEmpezarJuego
            // 
            this.btnEmpezarJuego.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnEmpezarJuego.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpezarJuego.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnEmpezarJuego.Location = new System.Drawing.Point(151, 154);
            this.btnEmpezarJuego.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmpezarJuego.Name = "btnEmpezarJuego";
            this.btnEmpezarJuego.Size = new System.Drawing.Size(136, 56);
            this.btnEmpezarJuego.TabIndex = 1;
            this.btnEmpezarJuego.Text = "Intentar";
            this.btnEmpezarJuego.UseVisualStyleBackColor = false;
            this.btnEmpezarJuego.Click += new System.EventHandler(this.btnEmpezarJuego_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSalir.Location = new System.Drawing.Point(260, 456);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(136, 42);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(16, 135);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Adivina el número oculto del 1 al 100 en la menor cantidad de intentos posible.";
            // 
            // lblNumeroIngresado
            // 
            this.lblNumeroIngresado.AutoSize = true;
            this.lblNumeroIngresado.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroIngresado.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblNumeroIngresado.Location = new System.Drawing.Point(67, 45);
            this.lblNumeroIngresado.Name = "lblNumeroIngresado";
            this.lblNumeroIngresado.Size = new System.Drawing.Size(167, 22);
            this.lblNumeroIngresado.TabIndex = 4;
            this.lblNumeroIngresado.Text = "Ingrese un número:";
            // 
            // btnIntentar
            // 
            this.btnIntentar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIntentar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnIntentar.Location = new System.Drawing.Point(111, 456);
            this.btnIntentar.Name = "btnIntentar";
            this.btnIntentar.Size = new System.Drawing.Size(136, 42);
            this.btnIntentar.TabIndex = 5;
            this.btnIntentar.Text = "Volver a Iniciar";
            this.btnIntentar.UseVisualStyleBackColor = true;
            this.btnIntentar.Click += new System.EventHandler(this.btnIntentar_Click);
            // 
            // lblPista
            // 
            this.lblPista.AutoSize = true;
            this.lblPista.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPista.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblPista.Location = new System.Drawing.Point(67, 86);
            this.lblPista.Name = "lblPista";
            this.lblPista.Size = new System.Drawing.Size(0, 19);
            this.lblPista.TabIndex = 7;
            // 
            // tBoxNumeroIngresado
            // 
            this.tBoxNumeroIngresado.Location = new System.Drawing.Point(242, 45);
            this.tBoxNumeroIngresado.Name = "tBoxNumeroIngresado";
            this.tBoxNumeroIngresado.Size = new System.Drawing.Size(100, 22);
            this.tBoxNumeroIngresado.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblIntentos);
            this.groupBox1.Controls.Add(this.btnEmpezarJuego);
            this.groupBox1.Controls.Add(this.tBoxNumeroIngresado);
            this.groupBox1.Controls.Add(this.lblPista);
            this.groupBox1.Controls.Add(this.lblNumeroIngresado);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox1.Location = new System.Drawing.Point(37, 166);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 248);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "¡Juega y Gana!";
            // 
            // lblIntentos
            // 
            this.lblIntentos.AutoSize = true;
            this.lblIntentos.Location = new System.Drawing.Point(68, 124);
            this.lblIntentos.Name = "lblIntentos";
            this.lblIntentos.Size = new System.Drawing.Size(0, 16);
            this.lblIntentos.TabIndex = 9;
            this.lblIntentos.Click += new System.EventHandler(this.lblIntentos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(498, 558);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnIntentar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(514, 597);
            this.MinimumSize = new System.Drawing.Size(514, 597);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " NÚMERO ACERTADO";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnEmpezarJuego;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumeroIngresado;
        private System.Windows.Forms.Button btnIntentar;
        private System.Windows.Forms.Label lblPista;
        private System.Windows.Forms.TextBox tBoxNumeroIngresado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblIntentos;
    }
}

