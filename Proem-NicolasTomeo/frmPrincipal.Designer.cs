
namespace Proem_NicolasTomeo
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.msPrincipal = new System.Windows.Forms.MenuStrip();
            this.pacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeMedicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadisticasHistoricasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // msPrincipal
            // 
            this.msPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pacientesToolStripMenuItem,
            this.medicosToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.msPrincipal.Location = new System.Drawing.Point(0, 0);
            this.msPrincipal.Name = "msPrincipal";
            this.msPrincipal.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.msPrincipal.Size = new System.Drawing.Size(1168, 24);
            this.msPrincipal.TabIndex = 5;
            this.msPrincipal.Text = "Menu Principal";
            // 
            // pacientesToolStripMenuItem
            // 
            this.pacientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresoToolStripMenuItem});
            this.pacientesToolStripMenuItem.Image = global::Proem_NicolasTomeo.Properties.Resources.usuario;
            this.pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            this.pacientesToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.pacientesToolStripMenuItem.Text = "Pacientes";
            // 
            // ingresoToolStripMenuItem
            // 
            this.ingresoToolStripMenuItem.Image = global::Proem_NicolasTomeo.Properties.Resources.clinica_consulta;
            this.ingresoToolStripMenuItem.Name = "ingresoToolStripMenuItem";
            this.ingresoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ingresoToolStripMenuItem.Text = "Ingreso/Consulta";
            this.ingresoToolStripMenuItem.Click += new System.EventHandler(this.ingresoToolStripMenuItem_Click);
            // 
            // medicosToolStripMenuItem
            // 
            this.medicosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDeMedicosToolStripMenuItem});
            this.medicosToolStripMenuItem.Image = global::Proem_NicolasTomeo.Properties.Resources.clinica_medico;
            this.medicosToolStripMenuItem.Name = "medicosToolStripMenuItem";
            this.medicosToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.medicosToolStripMenuItem.Text = "Medicos";
            // 
            // listaDeMedicosToolStripMenuItem
            // 
            this.listaDeMedicosToolStripMenuItem.Image = global::Proem_NicolasTomeo.Properties.Resources.clinica_medico;
            this.listaDeMedicosToolStripMenuItem.Name = "listaDeMedicosToolStripMenuItem";
            this.listaDeMedicosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listaDeMedicosToolStripMenuItem.Text = "Lista de Medicos";
            this.listaDeMedicosToolStripMenuItem.Click += new System.EventHandler(this.listaDeMedicosToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estadisticasHistoricasToolStripMenuItem});
            this.reportesToolStripMenuItem.Image = global::Proem_NicolasTomeo.Properties.Resources.clinica_libreta;
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // estadisticasHistoricasToolStripMenuItem
            // 
            this.estadisticasHistoricasToolStripMenuItem.Image = global::Proem_NicolasTomeo.Properties.Resources.clinica_consulta;
            this.estadisticasHistoricasToolStripMenuItem.Name = "estadisticasHistoricasToolStripMenuItem";
            this.estadisticasHistoricasToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.estadisticasHistoricasToolStripMenuItem.Text = "Estadisticas Historicas";
            this.estadisticasHistoricasToolStripMenuItem.Click += new System.EventHandler(this.estadisticasHistoricasToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.BackgroundImage = global::Proem_NicolasTomeo.Properties.Resources.clinica;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1168, 450);
            this.Controls.Add(this.msPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msPrincipal;
            this.Name = "frmPrincipal";
            this.Text = "Clinica sys";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.msPrincipal.ResumeLayout(false);
            this.msPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip msPrincipal;
        private System.Windows.Forms.ToolStripMenuItem pacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeMedicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadisticasHistoricasToolStripMenuItem;
    }
}

