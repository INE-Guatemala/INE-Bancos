namespace BancosINE
{
    partial class MenuLeft
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Bancos");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Tipos de cuentas");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Tipos de moneda");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Cuentas");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Cuentas bancarias", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Movimientos y transacciones");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Saldo de cuentas");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Reporte de movimientos");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Operaciones", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(132)))), ((int)(((byte)(135)))));
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Nodo6";
            treeNode1.Text = "Bancos";
            treeNode2.Name = "Nodo7";
            treeNode2.Text = "Tipos de cuentas";
            treeNode3.Name = "Nodo8";
            treeNode3.Text = "Tipos de moneda";
            treeNode4.Name = "Nodo9";
            treeNode4.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode4.Text = "Cuentas";
            treeNode5.Name = "Nodo0";
            treeNode5.Text = "Cuentas bancarias";
            treeNode6.Name = "Nodo11";
            treeNode6.Text = "Movimientos y transacciones";
            treeNode7.Name = "Nodo12";
            treeNode7.Text = "Saldo de cuentas";
            treeNode8.Name = "Nodo13";
            treeNode8.Text = "Reporte de movimientos";
            treeNode9.Name = "Nodo10";
            treeNode9.Text = "Operaciones";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode9});
            this.treeView1.Size = new System.Drawing.Size(300, 600);
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            // 
            // MenuLeft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.treeView1);
            this.Name = "MenuLeft";
            this.Size = new System.Drawing.Size(301, 768);
            this.Resize += new System.EventHandler(this.MenuLeft_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;

    }
}
