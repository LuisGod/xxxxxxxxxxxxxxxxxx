namespace PRIMER_PROYECTO_UAM
{
    partial class Elimina_Ruta
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
            this.textBoxRutDesac = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDesac = new System.Windows.Forms.Button();
            this.buttonCanc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(33, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ruta a Desactivar";
            // 
            // textBoxRutDesac
            // 
            this.textBoxRutDesac.Location = new System.Drawing.Point(165, 103);
            this.textBoxRutDesac.Name = "textBoxRutDesac";
            this.textBoxRutDesac.Size = new System.Drawing.Size(199, 20);
            this.textBoxRutDesac.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Bernard MT Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(-4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(440, 60);
            this.label2.TabIndex = 2;
            this.label2.Text = "Desactivar Ruta";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttonDesac
            // 
            this.buttonDesac.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDesac.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDesac.ForeColor = System.Drawing.Color.White;
            this.buttonDesac.Location = new System.Drawing.Point(165, 196);
            this.buttonDesac.Name = "buttonDesac";
            this.buttonDesac.Size = new System.Drawing.Size(92, 34);
            this.buttonDesac.TabIndex = 3;
            this.buttonDesac.Text = "Desactivar";
            this.buttonDesac.UseVisualStyleBackColor = true;
            this.buttonDesac.Click += new System.EventHandler(this.buttonDesac_Click);
            // 
            // buttonCanc
            // 
            this.buttonCanc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCanc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCanc.ForeColor = System.Drawing.Color.White;
            this.buttonCanc.Location = new System.Drawing.Point(319, 196);
            this.buttonCanc.Name = "buttonCanc";
            this.buttonCanc.Size = new System.Drawing.Size(92, 34);
            this.buttonCanc.TabIndex = 4;
            this.buttonCanc.Text = "Salir";
            this.buttonCanc.UseVisualStyleBackColor = true;
            this.buttonCanc.Click += new System.EventHandler(this.buttonCanc_Click);
            // 
            // Elimina_Ruta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(433, 255);
            this.Controls.Add(this.buttonCanc);
            this.Controls.Add(this.buttonDesac);
            this.Controls.Add(this.textBoxRutDesac);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Elimina_Ruta";
            this.Text = "Elimina_Ruta";
            this.Load += new System.EventHandler(this.Elimina_Ruta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRutDesac;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonDesac;
        private System.Windows.Forms.Button buttonCanc;
    }
}