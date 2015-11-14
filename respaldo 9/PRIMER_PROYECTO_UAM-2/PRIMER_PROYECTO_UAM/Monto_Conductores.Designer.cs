namespace PRIMER_PROYECTO_UAM
{
    partial class Monto_Conductores
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
            this.dgvMontoC = new System.Windows.Forms.DataGridView();
            this.buttonMontoC = new System.Windows.Forms.Button();
            this.buttonCancelC = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMontoC)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMontoC
            // 
            this.dgvMontoC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMontoC.Location = new System.Drawing.Point(19, 26);
            this.dgvMontoC.Name = "dgvMontoC";
            this.dgvMontoC.Size = new System.Drawing.Size(428, 155);
            this.dgvMontoC.TabIndex = 0;
            // 
            // buttonMontoC
            // 
            this.buttonMontoC.Location = new System.Drawing.Point(12, 231);
            this.buttonMontoC.Name = "buttonMontoC";
            this.buttonMontoC.Size = new System.Drawing.Size(139, 40);
            this.buttonMontoC.TabIndex = 1;
            this.buttonMontoC.Text = "Agregar Monto Recaudado";
            this.buttonMontoC.UseVisualStyleBackColor = true;
            this.buttonMontoC.Click += new System.EventHandler(this.buttonMontoC_Click);
            // 
            // buttonCancelC
            // 
            this.buttonCancelC.Location = new System.Drawing.Point(308, 231);
            this.buttonCancelC.Name = "buttonCancelC";
            this.buttonCancelC.Size = new System.Drawing.Size(139, 40);
            this.buttonCancelC.TabIndex = 2;
            this.buttonCancelC.Text = "Cancelar";
            this.buttonCancelC.UseVisualStyleBackColor = true;
            // 
            // Monto_Conductores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 305);
            this.Controls.Add(this.buttonCancelC);
            this.Controls.Add(this.buttonMontoC);
            this.Controls.Add(this.dgvMontoC);
            this.Name = "Monto_Conductores";
            this.Text = "Monto_Conductores";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMontoC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMontoC;
        private System.Windows.Forms.Button buttonMontoC;
        private System.Windows.Forms.Button buttonCancelC;
    }
}