namespace PRIMER_PROYECTO_UAM
{
    partial class ListaSolicitudes
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
            this.datasolicitudes = new System.Windows.Forms.DataGridView();
            this.btnver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datasolicitudes)).BeginInit();
            this.SuspendLayout();
            // 
            // datasolicitudes
            // 
            this.datasolicitudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datasolicitudes.Location = new System.Drawing.Point(12, 102);
            this.datasolicitudes.Name = "datasolicitudes";
            this.datasolicitudes.Size = new System.Drawing.Size(888, 183);
            this.datasolicitudes.TabIndex = 0;
            // 
            // btnver
            // 
            this.btnver.BackColor = System.Drawing.Color.Coral;
            this.btnver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnver.Location = new System.Drawing.Point(794, 291);
            this.btnver.Name = "btnver";
            this.btnver.Size = new System.Drawing.Size(106, 37);
            this.btnver.TabIndex = 1;
            this.btnver.Text = "Visualizar";
            this.btnver.UseVisualStyleBackColor = false;
            this.btnver.Click += new System.EventHandler(this.btnver_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Coral;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(909, 92);
            this.label1.TabIndex = 2;
            this.label1.Text = "LISTA DE SOLICITUDES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(-1, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(910, 259);
            this.label2.TabIndex = 3;
            // 
            // ListaSolicitudes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 337);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnver);
            this.Controls.Add(this.datasolicitudes);
            this.Controls.Add(this.label2);
            this.Name = "ListaSolicitudes";
            this.Text = "ListaSolicitudes";
            ((System.ComponentModel.ISupportInitialize)(this.datasolicitudes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datasolicitudes;
        private System.Windows.Forms.Button btnver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}