namespace BancosINE
{
    partial class MenuUp
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.prevLbl = new System.Windows.Forms.Label();
            this.nextLbl = new System.Windows.Forms.Label();
            this.listadoPages = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.button3.BackgroundImage = global::BancosINE.Properties.Resources.expand;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(313, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 34);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.button2.BackgroundImage = global::BancosINE.Properties.Resources.next_item;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(409, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(37, 34);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.button1.BackgroundImage = global::BancosINE.Properties.Resources.previous_item;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(270, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 34);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // prevLbl
            // 
            this.prevLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prevLbl.ForeColor = System.Drawing.Color.White;
            this.prevLbl.Location = new System.Drawing.Point(3, 3);
            this.prevLbl.Name = "prevLbl";
            this.prevLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.prevLbl.Size = new System.Drawing.Size(270, 34);
            this.prevLbl.TabIndex = 3;
            this.prevLbl.Text = "Buenas tardes ";
            this.prevLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nextLbl
            // 
            this.nextLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextLbl.ForeColor = System.Drawing.Color.White;
            this.nextLbl.Location = new System.Drawing.Point(444, 0);
            this.nextLbl.Name = "nextLbl";
            this.nextLbl.Size = new System.Drawing.Size(263, 37);
            this.nextLbl.TabIndex = 4;
            this.nextLbl.Text = "Movimientos Bancarios";
            this.nextLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listadoPages
            // 
            this.listadoPages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.listadoPages.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listadoPages.Name = "listadoPages";
            this.listadoPages.ShowImageMargin = false;
            this.listadoPages.Size = new System.Drawing.Size(151, 32);
            this.listadoPages.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.listadoPages_ItemClicked);
            // 
            // MenuUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.Controls.Add(this.nextLbl);
            this.Controls.Add(this.prevLbl);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "MenuUp";
            this.Size = new System.Drawing.Size(710, 40);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label prevLbl;
        private System.Windows.Forms.Label nextLbl;
        private System.Windows.Forms.ContextMenuStrip listadoPages;
    }
}
