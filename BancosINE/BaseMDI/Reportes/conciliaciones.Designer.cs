namespace BancosINE
{
    partial class Conciliaciones
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
            this.datagrid = new BancosINE.CustomGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbcuenta = new System.Windows.Forms.ComboBox();
            this.lblfechainicial = new System.Windows.Forms.Label();
            this.txtfechainicial = new System.Windows.Forms.DateTimePicker();
            this.txtfechafinal = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtfecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsaldo = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chkoperado = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.newRegistro = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // datagrid
            // 
            this.datagrid.Location = new System.Drawing.Point(15, 52);
            this.datagrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datagrid.Name = "datagrid";
            this.datagrid.Size = new System.Drawing.Size(991, 344);
            this.datagrid.TabIndex = 2;
            this.datagrid.Load += new System.EventHandler(this.datagrid_Load);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cuenta";
            // 
            // cmbcuenta
            // 
            this.cmbcuenta.FormattingEnabled = true;
            this.cmbcuenta.Location = new System.Drawing.Point(132, 73);
            this.cmbcuenta.Margin = new System.Windows.Forms.Padding(4);
            this.cmbcuenta.Name = "cmbcuenta";
            this.cmbcuenta.Size = new System.Drawing.Size(359, 24);
            this.cmbcuenta.TabIndex = 4;
            // 
            // lblfechainicial
            // 
            this.lblfechainicial.AutoSize = true;
            this.lblfechainicial.Location = new System.Drawing.Point(29, 110);
            this.lblfechainicial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfechainicial.Name = "lblfechainicial";
            this.lblfechainicial.Size = new System.Drawing.Size(86, 17);
            this.lblfechainicial.TabIndex = 5;
            this.lblfechainicial.Text = "Fecha Inicial";
            // 
            // txtfechainicial
            // 
            this.txtfechainicial.Location = new System.Drawing.Point(132, 110);
            this.txtfechainicial.Margin = new System.Windows.Forms.Padding(4);
            this.txtfechainicial.Name = "txtfechainicial";
            this.txtfechainicial.Size = new System.Drawing.Size(359, 22);
            this.txtfechainicial.TabIndex = 6;
            // 
            // txtfechafinal
            // 
            this.txtfechafinal.Location = new System.Drawing.Point(132, 145);
            this.txtfechafinal.Margin = new System.Windows.Forms.Padding(4);
            this.txtfechafinal.Name = "txtfechafinal";
            this.txtfechafinal.Size = new System.Drawing.Size(359, 22);
            this.txtfechafinal.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fecha Final";
            // 
            // txtfecha
            // 
            this.txtfecha.Enabled = false;
            this.txtfecha.Location = new System.Drawing.Point(185, 33);
            this.txtfecha.Margin = new System.Windows.Forms.Padding(4);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(306, 22);
            this.txtfecha.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Fecha Conciliacion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(519, 80);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Saldo";
            // 
            // txtsaldo
            // 
            this.txtsaldo.Location = new System.Drawing.Point(571, 77);
            this.txtsaldo.Margin = new System.Windows.Forms.Padding(4);
            this.txtsaldo.Name = "txtsaldo";
            this.txtsaldo.Size = new System.Drawing.Size(161, 22);
            this.txtsaldo.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtdescripcion);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.chkoperado);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtfecha);
            this.panel1.Controls.Add(this.txtsaldo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cmbcuenta);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblfechainicial);
            this.panel1.Controls.Add(this.txtfechainicial);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtfechafinal);
            this.panel1.Location = new System.Drawing.Point(39, 446);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(927, 260);
            this.panel1.TabIndex = 13;
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(132, 175);
            this.txtdescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(359, 22);
            this.txtdescripcion.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 175);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Descripcion";
            // 
            // chkoperado
            // 
            this.chkoperado.AutoSize = true;
            this.chkoperado.Checked = true;
            this.chkoperado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkoperado.Location = new System.Drawing.Point(571, 116);
            this.chkoperado.Margin = new System.Windows.Forms.Padding(4);
            this.chkoperado.Name = "chkoperado";
            this.chkoperado.Size = new System.Drawing.Size(93, 21);
            this.chkoperado.TabIndex = 19;
            this.chkoperado.Text = "Operados";
            this.chkoperado.UseVisualStyleBackColor = true;
            this.chkoperado.CheckedChanged += new System.EventHandler(this.chkoperado_CheckedChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.button2.BackgroundImage = global::BancosINE.Properties.Resources.accept;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(571, 149);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 39);
            this.button2.TabIndex = 18;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.button1.BackgroundImage = global::BancosINE.Properties.Resources.remove;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(617, 149);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 39);
            this.button1.TabIndex = 17;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // newRegistro
            // 
            this.newRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.newRegistro.BackgroundImage = global::BancosINE.Properties.Resources._new;
            this.newRegistro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.newRegistro.Location = new System.Drawing.Point(19, 400);
            this.newRegistro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newRegistro.Name = "newRegistro";
            this.newRegistro.Size = new System.Drawing.Size(40, 39);
            this.newRegistro.TabIndex = 18;
            this.newRegistro.UseVisualStyleBackColor = false;
            this.newRegistro.Click += new System.EventHandler(this.newRegistro_Click);
            // 
            // Conciliaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.newRegistro);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.datagrid);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Conciliaciones";
            this.Text = "Conciliaciones";
            this.Load += new System.EventHandler(this.Conciliaciones_Load);
            this.Controls.SetChildIndex(this.datagrid, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.newRegistro, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomGridView datagrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbcuenta;
        private System.Windows.Forms.Label lblfechainicial;
        private System.Windows.Forms.DateTimePicker txtfechainicial;
        private System.Windows.Forms.DateTimePicker txtfechafinal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker txtfecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsaldo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chkoperado;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button newRegistro;
    }
}