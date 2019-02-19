namespace MasterMind
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
            this.btnBlanco = new System.Windows.Forms.Button();
            this.btnNegro = new System.Windows.Forms.Button();
            this.btnRosa = new System.Windows.Forms.Button();
            this.btnNaranja = new System.Windows.Forms.Button();
            this.btnRojo = new System.Windows.Forms.Button();
            this.btnAmarillo = new System.Windows.Forms.Button();
            this.btnVerde = new System.Windows.Forms.Button();
            this.btnAzul = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBlanco
            // 
            this.btnBlanco.Location = new System.Drawing.Point(341, 163);
            this.btnBlanco.Name = "btnBlanco";
            this.btnBlanco.Size = new System.Drawing.Size(75, 50);
            this.btnBlanco.TabIndex = 0;
            this.btnBlanco.Text = "Blanco";
            this.btnBlanco.UseVisualStyleBackColor = true;
            this.btnBlanco.Click += new System.EventHandler(this.btnBlanco_Click);
            // 
            // btnNegro
            // 
            this.btnNegro.Location = new System.Drawing.Point(422, 163);
            this.btnNegro.Name = "btnNegro";
            this.btnNegro.Size = new System.Drawing.Size(75, 50);
            this.btnNegro.TabIndex = 1;
            this.btnNegro.Text = "Negro";
            this.btnNegro.UseVisualStyleBackColor = true;
            this.btnNegro.Click += new System.EventHandler(this.btnNegro_Click);
            // 
            // btnRosa
            // 
            this.btnRosa.Location = new System.Drawing.Point(503, 163);
            this.btnRosa.Name = "btnRosa";
            this.btnRosa.Size = new System.Drawing.Size(75, 50);
            this.btnRosa.TabIndex = 2;
            this.btnRosa.Text = "Rosa";
            this.btnRosa.UseVisualStyleBackColor = true;
            this.btnRosa.Click += new System.EventHandler(this.btnRosa_Click);
            // 
            // btnNaranja
            // 
            this.btnNaranja.Location = new System.Drawing.Point(584, 163);
            this.btnNaranja.Name = "btnNaranja";
            this.btnNaranja.Size = new System.Drawing.Size(75, 50);
            this.btnNaranja.TabIndex = 3;
            this.btnNaranja.Text = "Naranja";
            this.btnNaranja.UseVisualStyleBackColor = true;
            this.btnNaranja.Click += new System.EventHandler(this.btnNaranja_Click);
            // 
            // btnRojo
            // 
            this.btnRojo.Location = new System.Drawing.Point(341, 219);
            this.btnRojo.Name = "btnRojo";
            this.btnRojo.Size = new System.Drawing.Size(75, 50);
            this.btnRojo.TabIndex = 4;
            this.btnRojo.Text = "Rojo";
            this.btnRojo.UseVisualStyleBackColor = true;
            this.btnRojo.Click += new System.EventHandler(this.btnRojo_Click);
            // 
            // btnAmarillo
            // 
            this.btnAmarillo.Location = new System.Drawing.Point(422, 219);
            this.btnAmarillo.Name = "btnAmarillo";
            this.btnAmarillo.Size = new System.Drawing.Size(75, 50);
            this.btnAmarillo.TabIndex = 5;
            this.btnAmarillo.Text = "Amarillo";
            this.btnAmarillo.UseVisualStyleBackColor = true;
            this.btnAmarillo.Click += new System.EventHandler(this.btnAmarillo_Click);
            // 
            // btnVerde
            // 
            this.btnVerde.Location = new System.Drawing.Point(503, 219);
            this.btnVerde.Name = "btnVerde";
            this.btnVerde.Size = new System.Drawing.Size(75, 50);
            this.btnVerde.TabIndex = 6;
            this.btnVerde.Text = "Verde";
            this.btnVerde.UseVisualStyleBackColor = true;
            this.btnVerde.Click += new System.EventHandler(this.btnVerde_Click);
            // 
            // btnAzul
            // 
            this.btnAzul.Location = new System.Drawing.Point(584, 219);
            this.btnAzul.Name = "btnAzul";
            this.btnAzul.Size = new System.Drawing.Size(75, 50);
            this.btnAzul.TabIndex = 7;
            this.btnAzul.Text = "Azul";
            this.btnAzul.UseVisualStyleBackColor = true;
            this.btnAzul.Click += new System.EventHandler(this.btnAzul_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(321, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Adivina el codigo mastermind";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(321, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mastermind";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(321, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(254, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Los colores son los que hay en los botones de abajo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(321, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(246, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Si el color coincide en la posicion, saldra \'f. Negra\'.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(321, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(341, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Si el color existe pero no esta en la posicion correcta, saldra \'f. Blanca\'.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(321, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(206, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Si el color no esta en el array saldra vacio.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(321, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Los colores no se repiten";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Aciertos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Ultimo Codigo Insertado:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 281);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAzul);
            this.Controls.Add(this.btnVerde);
            this.Controls.Add(this.btnAmarillo);
            this.Controls.Add(this.btnRojo);
            this.Controls.Add(this.btnNaranja);
            this.Controls.Add(this.btnRosa);
            this.Controls.Add(this.btnNegro);
            this.Controls.Add(this.btnBlanco);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBlanco;
        private System.Windows.Forms.Button btnNegro;
        private System.Windows.Forms.Button btnRosa;
        private System.Windows.Forms.Button btnNaranja;
        private System.Windows.Forms.Button btnRojo;
        private System.Windows.Forms.Button btnAmarillo;
        private System.Windows.Forms.Button btnVerde;
        private System.Windows.Forms.Button btnAzul;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

