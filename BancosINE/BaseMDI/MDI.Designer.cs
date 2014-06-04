namespace BancosINE
{
    partial class MDI
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDI));
            this.PanelContainer = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMenuUp = new System.Windows.Forms.Panel();
            this.menuUp1 = new BancosINE.MenuUp();
            this.closeBtnCurrentPage = new System.Windows.Forms.Button();
            this.panelPublicitario = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuLeft1 = new BancosINE.MenuLeft();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panelMenuUp.SuspendLayout();
            this.panelPublicitario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelContainer
            // 
            this.PanelContainer.Location = new System.Drawing.Point(300, 76);
            this.PanelContainer.Name = "PanelContainer";
            this.PanelContainer.Size = new System.Drawing.Size(704, 652);
            this.PanelContainer.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.usuarioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1006, 36);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesiónToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(132)))), ((int)(((byte)(135)))));
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(91, 32);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.perfilToolStripMenuItem});
            this.usuarioToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(132)))), ((int)(((byte)(135)))));
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(91, 32);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // panelMenuUp
            // 
            this.panelMenuUp.Controls.Add(this.menuUp1);
            this.panelMenuUp.Controls.Add(this.closeBtnCurrentPage);
            this.panelMenuUp.Location = new System.Drawing.Point(300, 36);
            this.panelMenuUp.Name = "panelMenuUp";
            this.panelMenuUp.Size = new System.Drawing.Size(704, 40);
            this.panelMenuUp.TabIndex = 3;
            // 
            // menuUp1
            // 
            this.menuUp1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.menuUp1.Location = new System.Drawing.Point(0, 0);
            this.menuUp1.Name = "menuUp1";
            this.menuUp1.Size = new System.Drawing.Size(655, 37);
            this.menuUp1.TabIndex = 2;
            // 
            // closeBtnCurrentPage
            // 
            this.closeBtnCurrentPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.closeBtnCurrentPage.BackgroundImage = global::BancosINE.Properties.Resources.remove;
            this.closeBtnCurrentPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeBtnCurrentPage.Location = new System.Drawing.Point(664, 3);
            this.closeBtnCurrentPage.Name = "closeBtnCurrentPage";
            this.closeBtnCurrentPage.Size = new System.Drawing.Size(37, 34);
            this.closeBtnCurrentPage.TabIndex = 1;
            this.closeBtnCurrentPage.UseVisualStyleBackColor = false;
            this.closeBtnCurrentPage.Click += new System.EventHandler(this.closeBtnCurrentPage_Click);
            // 
            // panelPublicitario
            // 
            this.panelPublicitario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
            this.panelPublicitario.Controls.Add(this.label1);
            this.panelPublicitario.Controls.Add(this.pictureBox1);
            this.panelPublicitario.Location = new System.Drawing.Point(0, 625);
            this.panelPublicitario.Name = "panelPublicitario";
            this.panelPublicitario.Size = new System.Drawing.Size(300, 100);
            this.panelPublicitario.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Leelawadee", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(104, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 93);
            this.label1.TabIndex = 1;
            this.label1.Text = "INE BANCOS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::BancosINE.Properties.Resources.logo_nube;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 93);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuLeft1
            // 
            this.menuLeft1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.menuLeft1.Location = new System.Drawing.Point(0, 36);
            this.menuLeft1.Name = "menuLeft1";
            this.menuLeft1.Size = new System.Drawing.Size(300, 600);
            this.menuLeft1.TabIndex = 0;
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(196, 32);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar sesión";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(196, 32);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // perfilToolStripMenuItem
            // 
            this.perfilToolStripMenuItem.Name = "perfilToolStripMenuItem";
            this.perfilToolStripMenuItem.Size = new System.Drawing.Size(175, 32);
            this.perfilToolStripMenuItem.Text = "Perfil";
            // 
            // MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.panelPublicitario);
            this.Controls.Add(this.panelMenuUp);
            this.Controls.Add(this.PanelContainer);
            this.Controls.Add(this.menuLeft1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MDI";
            this.Text = "INE Bancos";
            this.ResizeEnd += new System.EventHandler(this.MDI_ResizeEnd);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelMenuUp.ResumeLayout(false);
            this.panelPublicitario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuLeft menuLeft1;
        private System.Windows.Forms.Panel PanelContainer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.Panel panelMenuUp;
        private System.Windows.Forms.Button closeBtnCurrentPage;
        private MenuUp menuUp1;
        private System.Windows.Forms.Panel panelPublicitario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perfilToolStripMenuItem;
    }
}

