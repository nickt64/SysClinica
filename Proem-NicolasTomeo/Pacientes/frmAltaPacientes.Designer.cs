
namespace Proem_NicolasTomeo
{
    partial class frmAltaPacientes
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
            this.lblNombrePaciente = new System.Windows.Forms.Label();
            this.lblApellidoPaciente = new System.Windows.Forms.Label();
            this.lblEdadPaciente = new System.Windows.Forms.Label();
            this.lblDniPaciente = new System.Windows.Forms.Label();
            this.lblObraSocialPaciente = new System.Windows.Forms.Label();
            this.spIngresoPaciente = new System.Windows.Forms.SplitContainer();
            this.btnActualizarPaciente = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.btnEliminarPaciente = new System.Windows.Forms.Button();
            this.btnIngresarPaciente = new System.Windows.Forms.Button();
            this.cbObraSocialPaciente = new System.Windows.Forms.ComboBox();
            this.txtbDniPaciente = new System.Windows.Forms.TextBox();
            this.txtbApellidoPaciente = new System.Windows.Forms.TextBox();
            this.txtbNombrePaciente = new System.Windows.Forms.TextBox();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.dgvPacientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.spIngresoPaciente)).BeginInit();
            this.spIngresoPaciente.Panel1.SuspendLayout();
            this.spIngresoPaciente.Panel2.SuspendLayout();
            this.spIngresoPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombrePaciente
            // 
            this.lblNombrePaciente.AutoSize = true;
            this.lblNombrePaciente.Location = new System.Drawing.Point(33, 106);
            this.lblNombrePaciente.Name = "lblNombrePaciente";
            this.lblNombrePaciente.Size = new System.Drawing.Size(44, 13);
            this.lblNombrePaciente.TabIndex = 0;
            this.lblNombrePaciente.Text = "Nombre";
            // 
            // lblApellidoPaciente
            // 
            this.lblApellidoPaciente.AutoSize = true;
            this.lblApellidoPaciente.Location = new System.Drawing.Point(33, 138);
            this.lblApellidoPaciente.Name = "lblApellidoPaciente";
            this.lblApellidoPaciente.Size = new System.Drawing.Size(44, 13);
            this.lblApellidoPaciente.TabIndex = 1;
            this.lblApellidoPaciente.Text = "Apellido";
            // 
            // lblEdadPaciente
            // 
            this.lblEdadPaciente.AutoSize = true;
            this.lblEdadPaciente.Location = new System.Drawing.Point(15, 177);
            this.lblEdadPaciente.Name = "lblEdadPaciente";
            this.lblEdadPaciente.Size = new System.Drawing.Size(93, 13);
            this.lblEdadPaciente.TabIndex = 2;
            this.lblEdadPaciente.Text = "Fecha Nacimiento";
            // 
            // lblDniPaciente
            // 
            this.lblDniPaciente.AutoSize = true;
            this.lblDniPaciente.Location = new System.Drawing.Point(51, 212);
            this.lblDniPaciente.Name = "lblDniPaciente";
            this.lblDniPaciente.Size = new System.Drawing.Size(26, 13);
            this.lblDniPaciente.TabIndex = 3;
            this.lblDniPaciente.Text = "DNI";
            // 
            // lblObraSocialPaciente
            // 
            this.lblObraSocialPaciente.AutoSize = true;
            this.lblObraSocialPaciente.Location = new System.Drawing.Point(15, 243);
            this.lblObraSocialPaciente.Name = "lblObraSocialPaciente";
            this.lblObraSocialPaciente.Size = new System.Drawing.Size(62, 13);
            this.lblObraSocialPaciente.TabIndex = 4;
            this.lblObraSocialPaciente.Text = "Obra Social";
            // 
            // spIngresoPaciente
            // 
            this.spIngresoPaciente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.spIngresoPaciente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spIngresoPaciente.Location = new System.Drawing.Point(10, 10);
            this.spIngresoPaciente.Name = "spIngresoPaciente";
            // 
            // spIngresoPaciente.Panel1
            // 
            this.spIngresoPaciente.Panel1.Controls.Add(this.btnActualizarPaciente);
            this.spIngresoPaciente.Panel1.Controls.Add(this.lblID);
            this.spIngresoPaciente.Panel1.Controls.Add(this.label1);
            this.spIngresoPaciente.Panel1.Controls.Add(this.dtpFechaNacimiento);
            this.spIngresoPaciente.Panel1.Controls.Add(this.btnEliminarPaciente);
            this.spIngresoPaciente.Panel1.Controls.Add(this.btnIngresarPaciente);
            this.spIngresoPaciente.Panel1.Controls.Add(this.cbObraSocialPaciente);
            this.spIngresoPaciente.Panel1.Controls.Add(this.txtbDniPaciente);
            this.spIngresoPaciente.Panel1.Controls.Add(this.txtbApellidoPaciente);
            this.spIngresoPaciente.Panel1.Controls.Add(this.txtbNombrePaciente);
            this.spIngresoPaciente.Panel1.Controls.Add(this.lblPaciente);
            this.spIngresoPaciente.Panel1.Controls.Add(this.lblObraSocialPaciente);
            this.spIngresoPaciente.Panel1.Controls.Add(this.lblNombrePaciente);
            this.spIngresoPaciente.Panel1.Controls.Add(this.lblDniPaciente);
            this.spIngresoPaciente.Panel1.Controls.Add(this.lblApellidoPaciente);
            this.spIngresoPaciente.Panel1.Controls.Add(this.lblEdadPaciente);
            // 
            // spIngresoPaciente.Panel2
            // 
            this.spIngresoPaciente.Panel2.Controls.Add(this.dgvPacientes);
            this.spIngresoPaciente.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.spIngresoPaciente.Size = new System.Drawing.Size(984, 450);
            this.spIngresoPaciente.SplitterDistance = 327;
            this.spIngresoPaciente.TabIndex = 5;
            // 
            // btnActualizarPaciente
            // 
            this.btnActualizarPaciente.AutoSize = true;
            this.btnActualizarPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarPaciente.Location = new System.Drawing.Point(18, 270);
            this.btnActualizarPaciente.Name = "btnActualizarPaciente";
            this.btnActualizarPaciente.Size = new System.Drawing.Size(92, 30);
            this.btnActualizarPaciente.TabIndex = 17;
            this.btnActualizarPaciente.Text = "Actualizar";
            this.btnActualizarPaciente.UseVisualStyleBackColor = true;
            this.btnActualizarPaciente.Visible = false;
            this.btnActualizarPaciente.Click += new System.EventHandler(this.btnActualizarPaciente_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(101, 74);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(13, 13);
            this.lblID.TabIndex = 16;
            this.lblID.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "ID";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(104, 170);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaNacimiento.TabIndex = 14;
            // 
            // btnEliminarPaciente
            // 
            this.btnEliminarPaciente.AutoSize = true;
            this.btnEliminarPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPaciente.Location = new System.Drawing.Point(118, 270);
            this.btnEliminarPaciente.Name = "btnEliminarPaciente";
            this.btnEliminarPaciente.Size = new System.Drawing.Size(86, 30);
            this.btnEliminarPaciente.TabIndex = 12;
            this.btnEliminarPaciente.Text = "Eliminar";
            this.btnEliminarPaciente.UseVisualStyleBackColor = true;
            this.btnEliminarPaciente.Click += new System.EventHandler(this.btnEliminarPaciente_Click);
            // 
            // btnIngresarPaciente
            // 
            this.btnIngresarPaciente.AutoSize = true;
            this.btnIngresarPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarPaciente.Location = new System.Drawing.Point(18, 270);
            this.btnIngresarPaciente.Name = "btnIngresarPaciente";
            this.btnIngresarPaciente.Size = new System.Drawing.Size(86, 30);
            this.btnIngresarPaciente.TabIndex = 11;
            this.btnIngresarPaciente.Text = "Ingresar";
            this.btnIngresarPaciente.UseVisualStyleBackColor = true;
            this.btnIngresarPaciente.Click += new System.EventHandler(this.btnIngresarPaciente_Click);
            // 
            // cbObraSocialPaciente
            // 
            this.cbObraSocialPaciente.AutoCompleteCustomSource.AddRange(new string[] {
            "",
            "No Tiene",
            "Cobertura Basica",
            "Cobertura Completa"});
            this.cbObraSocialPaciente.FormattingEnabled = true;
            this.cbObraSocialPaciente.Location = new System.Drawing.Point(104, 240);
            this.cbObraSocialPaciente.Name = "cbObraSocialPaciente";
            this.cbObraSocialPaciente.Size = new System.Drawing.Size(100, 21);
            this.cbObraSocialPaciente.TabIndex = 10;
            // 
            // txtbDniPaciente
            // 
            this.txtbDniPaciente.Location = new System.Drawing.Point(104, 209);
            this.txtbDniPaciente.Name = "txtbDniPaciente";
            this.txtbDniPaciente.Size = new System.Drawing.Size(100, 20);
            this.txtbDniPaciente.TabIndex = 9;
            // 
            // txtbApellidoPaciente
            // 
            this.txtbApellidoPaciente.Location = new System.Drawing.Point(104, 135);
            this.txtbApellidoPaciente.Name = "txtbApellidoPaciente";
            this.txtbApellidoPaciente.Size = new System.Drawing.Size(100, 20);
            this.txtbApellidoPaciente.TabIndex = 7;
            // 
            // txtbNombrePaciente
            // 
            this.txtbNombrePaciente.Location = new System.Drawing.Point(104, 103);
            this.txtbNombrePaciente.Name = "txtbNombrePaciente";
            this.txtbNombrePaciente.Size = new System.Drawing.Size(100, 20);
            this.txtbNombrePaciente.TabIndex = 6;
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaciente.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblPaciente.Location = new System.Drawing.Point(90, 53);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(63, 15);
            this.lblPaciente.TabIndex = 5;
            this.lblPaciente.Text = " Paciente";
            // 
            // dgvPacientes
            // 
            this.dgvPacientes.AllowUserToAddRows = false;
            this.dgvPacientes.AllowUserToDeleteRows = false;
            this.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPacientes.Location = new System.Drawing.Point(0, 0);
            this.dgvPacientes.MultiSelect = false;
            this.dgvPacientes.Name = "dgvPacientes";
            this.dgvPacientes.ReadOnly = true;
            this.dgvPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPacientes.Size = new System.Drawing.Size(649, 446);
            this.dgvPacientes.TabIndex = 0;
            this.dgvPacientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPacientes_CellDoubleClick);
            // 
            // frmAltaPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1004, 470);
            this.Controls.Add(this.spIngresoPaciente);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAltaPacientes";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de Pacientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAltaPacientes_FormClosing);
            this.Load += new System.EventHandler(this.frmIngresoPacientes_Load);
            this.spIngresoPaciente.Panel1.ResumeLayout(false);
            this.spIngresoPaciente.Panel1.PerformLayout();
            this.spIngresoPaciente.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spIngresoPaciente)).EndInit();
            this.spIngresoPaciente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNombrePaciente;
        private System.Windows.Forms.Label lblApellidoPaciente;
        private System.Windows.Forms.Label lblEdadPaciente;
        private System.Windows.Forms.Label lblDniPaciente;
        private System.Windows.Forms.Label lblObraSocialPaciente;
        private System.Windows.Forms.SplitContainer spIngresoPaciente;
        private System.Windows.Forms.ComboBox cbObraSocialPaciente;
        private System.Windows.Forms.TextBox txtbDniPaciente;
        private System.Windows.Forms.TextBox txtbApellidoPaciente;
        private System.Windows.Forms.TextBox txtbNombrePaciente;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.DataGridView dgvPacientes;
        private System.Windows.Forms.Button btnIngresarPaciente;
        private System.Windows.Forms.Button btnEliminarPaciente;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnActualizarPaciente;
    }
}