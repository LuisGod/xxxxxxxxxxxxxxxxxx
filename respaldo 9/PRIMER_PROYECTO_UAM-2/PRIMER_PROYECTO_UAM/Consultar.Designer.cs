﻿namespace PRIMER_PROYECTO_UAM
{
    partial class Consultar
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
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbcedula = new System.Windows.Forms.ComboBox();
            this.txtbuscarcliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btneditar = new System.Windows.Forms.Button();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.cmbprovincia = new System.Windows.Forms.ComboBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.picfoto3 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picfoto3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dirección";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Provincia";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(19, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 74);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BUSQUEDA ESTUDIANTE";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbcedula);
            this.groupBox2.Controls.Add(this.txtbuscarcliente);
            this.groupBox2.Location = new System.Drawing.Point(3, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(330, 44);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Consultar";
            // 
            // cmbcedula
            // 
            this.cmbcedula.BackColor = System.Drawing.Color.Coral;
            this.cmbcedula.FormattingEnabled = true;
            this.cmbcedula.Items.AddRange(new object[] {
            "Cedula",
            "Apellido"});
            this.cmbcedula.Location = new System.Drawing.Point(28, 17);
            this.cmbcedula.Name = "cmbcedula";
            this.cmbcedula.Size = new System.Drawing.Size(72, 21);
            this.cmbcedula.TabIndex = 7;
            this.cmbcedula.SelectedIndexChanged += new System.EventHandler(this.cmbcedula_SelectedIndexChanged_1);
            // 
            // txtbuscarcliente
            // 
            this.txtbuscarcliente.BackColor = System.Drawing.Color.Coral;
            this.txtbuscarcliente.Location = new System.Drawing.Point(165, 17);
            this.txtbuscarcliente.Name = "txtbuscarcliente";
            this.txtbuscarcliente.Size = new System.Drawing.Size(113, 20);
            this.txtbuscarcliente.TabIndex = 6;
            this.txtbuscarcliente.TextChanged += new System.EventHandler(this.txtbuscarcliente_TextChanged);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label6.Location = new System.Drawing.Point(-19, -3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(491, 292);
            this.label6.TabIndex = 16;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(480, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = ".";
            this.label7.Visible = false;
            // 
            // btneditar
            // 
            this.btneditar.BackColor = System.Drawing.Color.Coral;
            this.btneditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btneditar.Location = new System.Drawing.Point(377, 151);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(94, 27);
            this.btneditar.TabIndex = 11;
            this.btneditar.Text = "Editar Datos";
            this.btneditar.UseVisualStyleBackColor = false;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // txtnombre
            // 
            this.txtnombre.BackColor = System.Drawing.Color.Coral;
            this.txtnombre.Location = new System.Drawing.Point(129, 237);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(113, 20);
            this.txtnombre.TabIndex = 7;
            // 
            // txtapellido
            // 
            this.txtapellido.BackColor = System.Drawing.Color.Coral;
            this.txtapellido.Location = new System.Drawing.Point(129, 280);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(113, 20);
            this.txtapellido.TabIndex = 8;
            // 
            // txtdireccion
            // 
            this.txtdireccion.BackColor = System.Drawing.Color.Coral;
            this.txtdireccion.Location = new System.Drawing.Point(129, 324);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(113, 20);
            this.txtdireccion.TabIndex = 9;
            this.txtdireccion.TextChanged += new System.EventHandler(this.txtdirección_TextChanged);
            // 
            // cmbprovincia
            // 
            this.cmbprovincia.BackColor = System.Drawing.Color.Coral;
            this.cmbprovincia.FormattingEnabled = true;
            this.cmbprovincia.Location = new System.Drawing.Point(129, 366);
            this.cmbprovincia.Name = "cmbprovincia";
            this.cmbprovincia.Size = new System.Drawing.Size(114, 21);
            this.cmbprovincia.TabIndex = 10;
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.Coral;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnbuscar.Location = new System.Drawing.Point(377, 118);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(94, 27);
            this.btnbuscar.TabIndex = 13;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Coral;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(505, 101);
            this.label5.TabIndex = 15;
            this.label5.Text = "Consultar y Modificar";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picfoto3
            // 
            this.picfoto3.BackColor = System.Drawing.Color.Blue;
            this.picfoto3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picfoto3.Image = global::PRIMER_PROYECTO_UAM.Properties.Resources.contact;
            this.picfoto3.Location = new System.Drawing.Point(278, 216);
            this.picfoto3.Name = "picfoto3";
            this.picfoto3.Size = new System.Drawing.Size(213, 177);
            this.picfoto3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picfoto3.TabIndex = 14;
            this.picfoto3.TabStop = false;
            // 
            // Consultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(502, 422);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.picfoto3);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.cmbprovincia);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Name = "Consultar";
            this.Text = "Consultar";
            this.Load += new System.EventHandler(this.Consultar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picfoto3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtbuscarcliente;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.ComboBox cmbprovincia;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.ComboBox cmbcedula;
        private System.Windows.Forms.PictureBox picfoto3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}