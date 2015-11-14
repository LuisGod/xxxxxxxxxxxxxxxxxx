namespace PRIMER_PROYECTO_UAM
{
    partial class Agrega_Ruta
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxRutaNom = new System.Windows.Forms.TextBox();
            this.textBoxDistanK = new System.Windows.Forms.TextBox();
            this.textBoxMontPas = new System.Windows.Forms.TextBox();
            this.buttonAlmaRut = new System.Windows.Forms.Button();
            this.buttonBuscRut = new System.Windows.Forms.Button();
            this.buttonActRut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ruta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Distancia en Km ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Monto del Pasaje";
            // 
            // textBoxRutaNom
            // 
            this.textBoxRutaNom.Location = new System.Drawing.Point(96, 78);
            this.textBoxRutaNom.Name = "textBoxRutaNom";
            this.textBoxRutaNom.Size = new System.Drawing.Size(194, 20);
            this.textBoxRutaNom.TabIndex = 3;
            // 
            // textBoxDistanK
            // 
            this.textBoxDistanK.Location = new System.Drawing.Point(154, 131);
            this.textBoxDistanK.Name = "textBoxDistanK";
            this.textBoxDistanK.Size = new System.Drawing.Size(136, 20);
            this.textBoxDistanK.TabIndex = 4;
            // 
            // textBoxMontPas
            // 
            this.textBoxMontPas.Location = new System.Drawing.Point(154, 186);
            this.textBoxMontPas.Name = "textBoxMontPas";
            this.textBoxMontPas.Size = new System.Drawing.Size(136, 20);
            this.textBoxMontPas.TabIndex = 5;
            // 
            // buttonAlmaRut
            // 
            this.buttonAlmaRut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonAlmaRut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlmaRut.ForeColor = System.Drawing.Color.Black;
            this.buttonAlmaRut.Location = new System.Drawing.Point(154, 256);
            this.buttonAlmaRut.Name = "buttonAlmaRut";
            this.buttonAlmaRut.Size = new System.Drawing.Size(90, 41);
            this.buttonAlmaRut.TabIndex = 6;
            this.buttonAlmaRut.Text = "Almacenar Ruta";
            this.buttonAlmaRut.UseVisualStyleBackColor = false;
            this.buttonAlmaRut.Click += new System.EventHandler(this.buttonAlmaRut_Click);
            // 
            // buttonBuscRut
            // 
            this.buttonBuscRut.BackColor = System.Drawing.Color.Black;
            this.buttonBuscRut.ForeColor = System.Drawing.Color.Yellow;
            this.buttonBuscRut.Location = new System.Drawing.Point(290, 256);
            this.buttonBuscRut.Name = "buttonBuscRut";
            this.buttonBuscRut.Size = new System.Drawing.Size(79, 41);
            this.buttonBuscRut.TabIndex = 7;
            this.buttonBuscRut.Text = "Buscar y Editar";
            this.buttonBuscRut.UseVisualStyleBackColor = false;
            this.buttonBuscRut.Click += new System.EventHandler(this.buttonBuscRut_Click);
            // 
            // buttonActRut
            // 
            this.buttonActRut.BackColor = System.Drawing.Color.Black;
            this.buttonActRut.ForeColor = System.Drawing.Color.Yellow;
            this.buttonActRut.Location = new System.Drawing.Point(310, 12);
            this.buttonActRut.Name = "buttonActRut";
            this.buttonActRut.Size = new System.Drawing.Size(79, 58);
            this.buttonActRut.TabIndex = 8;
            this.buttonActRut.Text = "Actualizar Info. Ruta";
            this.buttonActRut.UseVisualStyleBackColor = false;
            // 
            // Agrega_Ruta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(392, 329);
            this.Controls.Add(this.buttonActRut);
            this.Controls.Add(this.buttonBuscRut);
            this.Controls.Add(this.buttonAlmaRut);
            this.Controls.Add(this.textBoxMontPas);
            this.Controls.Add(this.textBoxDistanK);
            this.Controls.Add(this.textBoxRutaNom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Agrega_Ruta";
            this.Text = "Agrega_Ruta";
            this.Load += new System.EventHandler(this.Agrega_Ruta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxRutaNom;
        private System.Windows.Forms.TextBox textBoxDistanK;
        private System.Windows.Forms.TextBox textBoxMontPas;
        private System.Windows.Forms.Button buttonAlmaRut;
        private System.Windows.Forms.Button buttonBuscRut;
        private System.Windows.Forms.Button buttonActRut;
    }
}