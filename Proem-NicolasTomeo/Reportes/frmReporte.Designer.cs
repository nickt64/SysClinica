
namespace Proem_NicolasTomeo.Reportes
{
    partial class frmReporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporte));
            this.dgvMedicos = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblListadoMedicos = new System.Windows.Forms.Label();
            this.lblEspecialidadConMasConsultas = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMedicoConMenosPacientes = new System.Windows.Forms.Label();
            this.lblMedicoConMasPacientes = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMedicos
            // 
            this.dgvMedicos.AllowUserToAddRows = false;
            this.dgvMedicos.AllowUserToDeleteRows = false;
            this.dgvMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicos.Location = new System.Drawing.Point(0, 0);
            this.dgvMedicos.MultiSelect = false;
            this.dgvMedicos.Name = "dgvMedicos";
            this.dgvMedicos.ReadOnly = true;
            this.dgvMedicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedicos.Size = new System.Drawing.Size(800, 386);
            this.dgvMedicos.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lblListadoMedicos);
            this.splitContainer1.Panel1MinSize = 50;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lblEspecialidadConMasConsultas);
            this.splitContainer1.Panel2.Controls.Add(this.dgvMedicos);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.lblMedicoConMenosPacientes);
            this.splitContainer1.Panel2.Controls.Add(this.lblMedicoConMasPacientes);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Size = new System.Drawing.Size(800, 587);
            this.splitContainer1.SplitterDistance = 78;
            this.splitContainer1.TabIndex = 2;
            // 
            // lblListadoMedicos
            // 
            this.lblListadoMedicos.AutoSize = true;
            this.lblListadoMedicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListadoMedicos.Location = new System.Drawing.Point(323, 19);
            this.lblListadoMedicos.Name = "lblListadoMedicos";
            this.lblListadoMedicos.Size = new System.Drawing.Size(139, 20);
            this.lblListadoMedicos.TabIndex = 0;
            this.lblListadoMedicos.Text = "Listado Medicos";
            // 
            // lblEspecialidadConMasConsultas
            // 
            this.lblEspecialidadConMasConsultas.AutoSize = true;
            this.lblEspecialidadConMasConsultas.Location = new System.Drawing.Point(635, 419);
            this.lblEspecialidadConMasConsultas.Name = "lblEspecialidadConMasConsultas";
            this.lblEspecialidadConMasConsultas.Size = new System.Drawing.Size(10, 13);
            this.lblEspecialidadConMasConsultas.TabIndex = 8;
            this.lblEspecialidadConMasConsultas.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(580, 389);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Especialidad con mas consultas:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 389);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Medico con mas pacientes atendidos:";
            // 
            // lblMedicoConMenosPacientes
            // 
            this.lblMedicoConMenosPacientes.AutoSize = true;
            this.lblMedicoConMenosPacientes.Location = new System.Drawing.Point(324, 419);
            this.lblMedicoConMenosPacientes.Name = "lblMedicoConMenosPacientes";
            this.lblMedicoConMenosPacientes.Size = new System.Drawing.Size(10, 13);
            this.lblMedicoConMenosPacientes.TabIndex = 6;
            this.lblMedicoConMenosPacientes.Text = "-";
            // 
            // lblMedicoConMasPacientes
            // 
            this.lblMedicoConMasPacientes.AutoSize = true;
            this.lblMedicoConMasPacientes.Location = new System.Drawing.Point(16, 419);
            this.lblMedicoConMasPacientes.Name = "lblMedicoConMasPacientes";
            this.lblMedicoConMasPacientes.Size = new System.Drawing.Size(10, 13);
            this.lblMedicoConMasPacientes.TabIndex = 4;
            this.lblMedicoConMasPacientes.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(276, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Medico con menos pacientes atendidos:";
            // 
            // frmReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 587);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReporte";
            this.Text = "frmReporte";
            this.Load += new System.EventHandler(this.frmReporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicos)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMedicos;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblListadoMedicos;
        private System.Windows.Forms.Label lblEspecialidadConMasConsultas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMedicoConMenosPacientes;
        private System.Windows.Forms.Label lblMedicoConMasPacientes;
        private System.Windows.Forms.Label label3;
    }
}