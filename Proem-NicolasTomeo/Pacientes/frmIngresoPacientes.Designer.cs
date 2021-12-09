
namespace Proem_NicolasTomeo.Pacientes
{
    partial class frmIngresoPacientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIngresoPacientes));
            this.spIngresoPaciente = new System.Windows.Forms.SplitContainer();
            this.rdbEspecialidad = new System.Windows.Forms.RadioButton();
            this.rdbMedico = new System.Windows.Forms.RadioButton();
            this.cbEspecialidades = new System.Windows.Forms.ComboBox();
            this.cbMedico = new System.Windows.Forms.ComboBox();
            this.btnRegistrarLlegada = new System.Windows.Forms.Button();
            this.lstPacientes = new System.Windows.Forms.ListBox();
            this.btnConsultarPacientes = new System.Windows.Forms.Button();
            this.btnIniciarConsulta = new System.Windows.Forms.Button();
            this.dgvListaDeEspera = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.spIngresoPaciente)).BeginInit();
            this.spIngresoPaciente.Panel1.SuspendLayout();
            this.spIngresoPaciente.Panel2.SuspendLayout();
            this.spIngresoPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDeEspera)).BeginInit();
            this.SuspendLayout();
            // 
            // spIngresoPaciente
            // 
            this.spIngresoPaciente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.spIngresoPaciente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spIngresoPaciente.Location = new System.Drawing.Point(0, 0);
            this.spIngresoPaciente.Name = "spIngresoPaciente";
            // 
            // spIngresoPaciente.Panel1
            // 
            this.spIngresoPaciente.Panel1.Controls.Add(this.rdbEspecialidad);
            this.spIngresoPaciente.Panel1.Controls.Add(this.rdbMedico);
            this.spIngresoPaciente.Panel1.Controls.Add(this.cbEspecialidades);
            this.spIngresoPaciente.Panel1.Controls.Add(this.cbMedico);
            this.spIngresoPaciente.Panel1.Controls.Add(this.btnRegistrarLlegada);
            this.spIngresoPaciente.Panel1.Controls.Add(this.lstPacientes);
            this.spIngresoPaciente.Panel1.Controls.Add(this.btnConsultarPacientes);
            // 
            // spIngresoPaciente.Panel2
            // 
            this.spIngresoPaciente.Panel2.Controls.Add(this.btnIniciarConsulta);
            this.spIngresoPaciente.Panel2.Controls.Add(this.dgvListaDeEspera);
            this.spIngresoPaciente.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.spIngresoPaciente.Size = new System.Drawing.Size(800, 493);
            this.spIngresoPaciente.SplitterDistance = 283;
            this.spIngresoPaciente.TabIndex = 6;
            // 
            // rdbEspecialidad
            // 
            this.rdbEspecialidad.AutoSize = true;
            this.rdbEspecialidad.Location = new System.Drawing.Point(10, 359);
            this.rdbEspecialidad.Name = "rdbEspecialidad";
            this.rdbEspecialidad.Size = new System.Drawing.Size(138, 17);
            this.rdbEspecialidad.TabIndex = 25;
            this.rdbEspecialidad.TabStop = true;
            this.rdbEspecialidad.Text = "Buscar por especialidad";
            this.rdbEspecialidad.UseVisualStyleBackColor = true;
            this.rdbEspecialidad.CheckedChanged += new System.EventHandler(this.rdbMedicoEspecialidad_CheckedChanged);
            // 
            // rdbMedico
            // 
            this.rdbMedico.AutoSize = true;
            this.rdbMedico.Location = new System.Drawing.Point(10, 336);
            this.rdbMedico.Name = "rdbMedico";
            this.rdbMedico.Size = new System.Drawing.Size(113, 17);
            this.rdbMedico.TabIndex = 24;
            this.rdbMedico.TabStop = true;
            this.rdbMedico.Text = "Buscar por medico";
            this.rdbMedico.UseVisualStyleBackColor = true;
            this.rdbMedico.CheckedChanged += new System.EventHandler(this.rdbMedicoEspecialidad_CheckedChanged);
            // 
            // cbEspecialidades
            // 
            this.cbEspecialidades.Enabled = false;
            this.cbEspecialidades.FormattingEnabled = true;
            this.cbEspecialidades.Location = new System.Drawing.Point(154, 359);
            this.cbEspecialidades.Name = "cbEspecialidades";
            this.cbEspecialidades.Size = new System.Drawing.Size(121, 21);
            this.cbEspecialidades.TabIndex = 23;
            // 
            // cbMedico
            // 
            this.cbMedico.Enabled = false;
            this.cbMedico.FormattingEnabled = true;
            this.cbMedico.Location = new System.Drawing.Point(154, 332);
            this.cbMedico.Name = "cbMedico";
            this.cbMedico.Size = new System.Drawing.Size(121, 21);
            this.cbMedico.TabIndex = 22;
            // 
            // btnRegistrarLlegada
            // 
            this.btnRegistrarLlegada.AutoSize = true;
            this.btnRegistrarLlegada.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarLlegada.Location = new System.Drawing.Point(109, 399);
            this.btnRegistrarLlegada.Name = "btnRegistrarLlegada";
            this.btnRegistrarLlegada.Size = new System.Drawing.Size(149, 30);
            this.btnRegistrarLlegada.TabIndex = 21;
            this.btnRegistrarLlegada.Text = "Registrar llegada";
            this.btnRegistrarLlegada.UseVisualStyleBackColor = true;
            this.btnRegistrarLlegada.Click += new System.EventHandler(this.btnRegistrarLlegada_Click);
            // 
            // lstPacientes
            // 
            this.lstPacientes.FormattingEnabled = true;
            this.lstPacientes.Location = new System.Drawing.Point(10, 10);
            this.lstPacientes.Name = "lstPacientes";
            this.lstPacientes.Size = new System.Drawing.Size(265, 316);
            this.lstPacientes.TabIndex = 20;
            // 
            // btnConsultarPacientes
            // 
            this.btnConsultarPacientes.AutoSize = true;
            this.btnConsultarPacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarPacientes.Location = new System.Drawing.Point(88, 449);
            this.btnConsultarPacientes.Name = "btnConsultarPacientes";
            this.btnConsultarPacientes.Size = new System.Drawing.Size(170, 30);
            this.btnConsultarPacientes.TabIndex = 11;
            this.btnConsultarPacientes.Text = "Consultar Pacientes";
            this.btnConsultarPacientes.UseVisualStyleBackColor = true;
            this.btnConsultarPacientes.Click += new System.EventHandler(this.btnConsultarPacientes_Click);
            // 
            // btnIniciarConsulta
            // 
            this.btnIniciarConsulta.AutoSize = true;
            this.btnIniciarConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarConsulta.Location = new System.Drawing.Point(329, 449);
            this.btnIniciarConsulta.Name = "btnIniciarConsulta";
            this.btnIniciarConsulta.Size = new System.Drawing.Size(170, 30);
            this.btnIniciarConsulta.TabIndex = 26;
            this.btnIniciarConsulta.Text = "Iniciar Consulta";
            this.btnIniciarConsulta.UseVisualStyleBackColor = true;
            this.btnIniciarConsulta.Click += new System.EventHandler(this.btnIniciarConsulta_Click);
            // 
            // dgvListaDeEspera
            // 
            this.dgvListaDeEspera.AllowUserToAddRows = false;
            this.dgvListaDeEspera.AllowUserToDeleteRows = false;
            this.dgvListaDeEspera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaDeEspera.Location = new System.Drawing.Point(0, 0);
            this.dgvListaDeEspera.MultiSelect = false;
            this.dgvListaDeEspera.Name = "dgvListaDeEspera";
            this.dgvListaDeEspera.ReadOnly = true;
            this.dgvListaDeEspera.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaDeEspera.Size = new System.Drawing.Size(509, 429);
            this.dgvListaDeEspera.TabIndex = 1;
            // 
            // frmIngresoPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 493);
            this.Controls.Add(this.spIngresoPaciente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmIngresoPacientes";
            this.Text = "frmIngresoPacientes";
            this.Load += new System.EventHandler(this.frmIngresoPacientes_Load);
            this.spIngresoPaciente.Panel1.ResumeLayout(false);
            this.spIngresoPaciente.Panel1.PerformLayout();
            this.spIngresoPaciente.Panel2.ResumeLayout(false);
            this.spIngresoPaciente.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spIngresoPaciente)).EndInit();
            this.spIngresoPaciente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDeEspera)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer spIngresoPaciente;
        private System.Windows.Forms.Button btnConsultarPacientes;
        private System.Windows.Forms.ListBox lstPacientes;
        private System.Windows.Forms.Button btnRegistrarLlegada;
        private System.Windows.Forms.DataGridView dgvListaDeEspera;
        private System.Windows.Forms.ComboBox cbMedico;
        private System.Windows.Forms.ComboBox cbEspecialidades;
        private System.Windows.Forms.RadioButton rdbEspecialidad;
        private System.Windows.Forms.RadioButton rdbMedico;
        private System.Windows.Forms.Button btnIniciarConsulta;
    }
}