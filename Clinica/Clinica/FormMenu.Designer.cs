namespace Clinica
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.citasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.citasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.resetariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeCitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDePacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDePatologiasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeMedicamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preguntasFrecuentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDelProgramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.citasToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.seguridadToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(373, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // citasToolStripMenuItem
            // 
            this.citasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pacientesToolStripMenuItem,
            this.medicosToolStripMenuItem,
            this.citasToolStripMenuItem1,
            this.resetariosToolStripMenuItem});
            this.citasToolStripMenuItem.Name = "citasToolStripMenuItem";
            this.citasToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.citasToolStripMenuItem.Text = "Citas";
            // 
            // pacientesToolStripMenuItem
            // 
            this.pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            this.pacientesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pacientesToolStripMenuItem.Text = "Pacientes";
            this.pacientesToolStripMenuItem.Click += new System.EventHandler(this.pacientesToolStripMenuItem_Click);
            // 
            // medicosToolStripMenuItem
            // 
            this.medicosToolStripMenuItem.Name = "medicosToolStripMenuItem";
            this.medicosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.medicosToolStripMenuItem.Text = "Medicos";
            this.medicosToolStripMenuItem.Click += new System.EventHandler(this.medicosToolStripMenuItem_Click);
            // 
            // citasToolStripMenuItem1
            // 
            this.citasToolStripMenuItem1.Name = "citasToolStripMenuItem1";
            this.citasToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.citasToolStripMenuItem1.Text = "Citas";
            this.citasToolStripMenuItem1.Click += new System.EventHandler(this.citasToolStripMenuItem1_Click);
            // 
            // resetariosToolStripMenuItem
            // 
            this.resetariosToolStripMenuItem.Name = "resetariosToolStripMenuItem";
            this.resetariosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.resetariosToolStripMenuItem.Text = "Resetarios";
            this.resetariosToolStripMenuItem.Click += new System.EventHandler(this.resetariosToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteDeCitasToolStripMenuItem,
            this.reporteDePacientesToolStripMenuItem,
            this.reporteDePatologiasToolStripMenuItem,
            this.reporteDeMedicamentosToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // reporteDeCitasToolStripMenuItem
            // 
            this.reporteDeCitasToolStripMenuItem.Name = "reporteDeCitasToolStripMenuItem";
            this.reporteDeCitasToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.reporteDeCitasToolStripMenuItem.Text = "Reporte de Citas";
            this.reporteDeCitasToolStripMenuItem.Click += new System.EventHandler(this.reporteDeCitasToolStripMenuItem_Click);
            // 
            // reporteDePacientesToolStripMenuItem
            // 
            this.reporteDePacientesToolStripMenuItem.Name = "reporteDePacientesToolStripMenuItem";
            this.reporteDePacientesToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.reporteDePacientesToolStripMenuItem.Text = "Reporte de Pacientes";
            this.reporteDePacientesToolStripMenuItem.Click += new System.EventHandler(this.reporteDePacientesToolStripMenuItem_Click);
            // 
            // reporteDePatologiasToolStripMenuItem
            // 
            this.reporteDePatologiasToolStripMenuItem.Name = "reporteDePatologiasToolStripMenuItem";
            this.reporteDePatologiasToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.reporteDePatologiasToolStripMenuItem.Text = "Reporte de Patologias";
            this.reporteDePatologiasToolStripMenuItem.Click += new System.EventHandler(this.reporteDePatologiasToolStripMenuItem_Click);
            // 
            // reporteDeMedicamentosToolStripMenuItem
            // 
            this.reporteDeMedicamentosToolStripMenuItem.Name = "reporteDeMedicamentosToolStripMenuItem";
            this.reporteDeMedicamentosToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.reporteDeMedicamentosToolStripMenuItem.Text = "Reporte de Medicamentos";
            this.reporteDeMedicamentosToolStripMenuItem.Click += new System.EventHandler(this.reporteDeMedicamentosToolStripMenuItem_Click);
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem});
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.seguridadToolStripMenuItem.Text = "Seguridad";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preguntasFrecuentesToolStripMenuItem,
            this.acercaDelProgramaToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // preguntasFrecuentesToolStripMenuItem
            // 
            this.preguntasFrecuentesToolStripMenuItem.Name = "preguntasFrecuentesToolStripMenuItem";
            this.preguntasFrecuentesToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.preguntasFrecuentesToolStripMenuItem.Text = "Preguntas Frecuentes";
            // 
            // acercaDelProgramaToolStripMenuItem
            // 
            this.acercaDelProgramaToolStripMenuItem.Name = "acercaDelProgramaToolStripMenuItem";
            this.acercaDelProgramaToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.acercaDelProgramaToolStripMenuItem.Text = "Acerca del Programa";
            this.acercaDelProgramaToolStripMenuItem.Click += new System.EventHandler(this.acercaDelProgramaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 261);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMenu";
            this.Text = "Menú Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem citasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem citasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem resetariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeCitasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDePacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDePatologiasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeMedicamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preguntasFrecuentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDelProgramaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}