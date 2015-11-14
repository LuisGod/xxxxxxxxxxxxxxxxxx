namespace PRIMER_PROYECTO_UAM
{
    partial class BuscarConductores
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
            this.txtboxnombrebusca = new System.Windows.Forms.TextBox();
            this.txtboxapellbusca = new System.Windows.Forms.TextBox();
            this.buttonbuscar = new System.Windows.Forms.Button();
            this.dgvBuscar = new System.Windows.Forms.DataGridView();
            this.buttonacept = new System.Windows.Forms.Button();
            this.buttoncancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido";
            // 
            // txtboxnombrebusca
            // 
            this.txtboxnombrebusca.Location = new System.Drawing.Point(193, 22);
            this.txtboxnombrebusca.Name = "txtboxnombrebusca";
            this.txtboxnombrebusca.Size = new System.Drawing.Size(206, 20);
            this.txtboxnombrebusca.TabIndex = 2;
            this.txtboxnombrebusca.TextChanged += new System.EventHandler(this.txtboxnombrebusca_TextChanged);
            // 
            // txtboxapellbusca
            // 
            this.txtboxapellbusca.Location = new System.Drawing.Point(193, 68);
            this.txtboxapellbusca.Name = "txtboxapellbusca";
            this.txtboxapellbusca.Size = new System.Drawing.Size(206, 20);
            this.txtboxapellbusca.TabIndex = 3;
            // 
            // buttonbuscar
            // 
            this.buttonbuscar.Location = new System.Drawing.Point(217, 94);
            this.buttonbuscar.Name = "buttonbuscar";
            this.buttonbuscar.Size = new System.Drawing.Size(105, 34);
            this.buttonbuscar.TabIndex = 4;
            this.buttonbuscar.Text = "Buscar";
            this.buttonbuscar.UseVisualStyleBackColor = true;
            this.buttonbuscar.Click += new System.EventHandler(this.buttonbuscar_Click);
            // 
            // dgvBuscar
            // 
            this.dgvBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscar.Location = new System.Drawing.Point(39, 140);
            this.dgvBuscar.Name = "dgvBuscar";
            this.dgvBuscar.Size = new System.Drawing.Size(455, 140);
            this.dgvBuscar.TabIndex = 5;
            this.dgvBuscar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBuscar_CellContentClick);
            // 
            // buttonacept
            // 
            this.buttonacept.Location = new System.Drawing.Point(60, 286);
            this.buttonacept.Name = "buttonacept";
            this.buttonacept.Size = new System.Drawing.Size(111, 33);
            this.buttonacept.TabIndex = 6;
            this.buttonacept.Text = "Aceptar";
            this.buttonacept.UseVisualStyleBackColor = true;
            this.buttonacept.Click += new System.EventHandler(this.buttonacept_Click);
            // 
            // buttoncancel
            // 
            this.buttoncancel.Location = new System.Drawing.Point(362, 286);
            this.buttoncancel.Name = "buttoncancel";
            this.buttoncancel.Size = new System.Drawing.Size(111, 33);
            this.buttoncancel.TabIndex = 7;
            this.buttoncancel.Text = "Cancelar";
            this.buttoncancel.UseVisualStyleBackColor = true;
            this.buttoncancel.Click += new System.EventHandler(this.buttoncancel_Click);
            // 
            // BuscarConductores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PRIMER_PROYECTO_UAM.Properties.Resources.unnamed;
            this.ClientSize = new System.Drawing.Size(532, 339);
            this.Controls.Add(this.buttoncancel);
            this.Controls.Add(this.buttonacept);
            this.Controls.Add(this.dgvBuscar);
            this.Controls.Add(this.buttonbuscar);
            this.Controls.Add(this.txtboxapellbusca);
            this.Controls.Add(this.txtboxnombrebusca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BuscarConductores";
            this.Text = "BuscarConductores";
            this.Load += new System.EventHandler(this.BuscarConductores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxnombrebusca;
        private System.Windows.Forms.TextBox txtboxapellbusca;
        private System.Windows.Forms.Button buttonbuscar;
        private System.Windows.Forms.DataGridView dgvBuscar;
        private System.Windows.Forms.Button buttonacept;
        private System.Windows.Forms.Button buttoncancel;
    }
}