namespace BancosINE
{
    partial class Agenda
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
            this.customGridView1 = new BancosINE.CustomGridView();
            this.newRegistro = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.estadoCmb = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.montoTbx = new System.Windows.Forms.TextBox();
            this.acceptBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.transaccionCmb = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.descripcionTxb = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.diaCmb = new System.Windows.Forms.ComboBox();
            this.mesCmb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cuentaCmb = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // customGridView1
            // 
            this.customGridView1.Location = new System.Drawing.Point(18, 100);
            this.customGridView1.Name = "customGridView1";
            this.customGridView1.Size = new System.Drawing.Size(971, 332);
            this.customGridView1.TabIndex = 2;
            // 
            // newRegistro
            // 
            this.newRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.newRegistro.BackgroundImage = global::BancosINE.Properties.Resources._new;
            this.newRegistro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.newRegistro.Location = new System.Drawing.Point(18, 438);
            this.newRegistro.Name = "newRegistro";
            this.newRegistro.Size = new System.Drawing.Size(40, 40);
            this.newRegistro.TabIndex = 4;
            this.newRegistro.UseVisualStyleBackColor = false;
            this.newRegistro.Click += new System.EventHandler(this.newRegistro_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.estadoCmb);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.montoTbx);
            this.panel1.Controls.Add(this.acceptBtn);
            this.panel1.Controls.Add(this.cancelBtn);
            this.panel1.Controls.Add(this.transaccionCmb);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.descripcionTxb);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.diaCmb);
            this.panel1.Controls.Add(this.mesCmb);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(18, 484);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(994, 272);
            this.panel1.TabIndex = 5;
            this.panel1.Visible = false;
            // 
            // estadoCmb
            // 
            this.estadoCmb.FormattingEnabled = true;
            this.estadoCmb.Location = new System.Drawing.Point(120, 103);
            this.estadoCmb.Name = "estadoCmb";
            this.estadoCmb.Size = new System.Drawing.Size(609, 24);
            this.estadoCmb.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(52, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 18);
            this.label8.TabIndex = 19;
            this.label8.Text = "Estado:";
            // 
            // montoTbx
            // 
            this.montoTbx.Location = new System.Drawing.Point(543, 27);
            this.montoTbx.Name = "montoTbx";
            this.montoTbx.Size = new System.Drawing.Size(186, 22);
            this.montoTbx.TabIndex = 2;
            // 
            // acceptBtn
            // 
            this.acceptBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.acceptBtn.BackgroundImage = global::BancosINE.Properties.Resources.accept;
            this.acceptBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.acceptBtn.Location = new System.Drawing.Point(735, 205);
            this.acceptBtn.Name = "acceptBtn";
            this.acceptBtn.Size = new System.Drawing.Size(40, 40);
            this.acceptBtn.TabIndex = 6;
            this.acceptBtn.UseVisualStyleBackColor = false;
            this.acceptBtn.Click += new System.EventHandler(this.acceptBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.cancelBtn.BackgroundImage = global::BancosINE.Properties.Resources.remove;
            this.cancelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancelBtn.Location = new System.Drawing.Point(781, 205);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(40, 40);
            this.cancelBtn.TabIndex = 7;
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // transaccionCmb
            // 
            this.transaccionCmb.FormattingEnabled = true;
            this.transaccionCmb.Location = new System.Drawing.Point(120, 68);
            this.transaccionCmb.Name = "transaccionCmb";
            this.transaccionCmb.Size = new System.Drawing.Size(609, 24);
            this.transaccionCmb.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Transacción:";
            // 
            // descripcionTxb
            // 
            this.descripcionTxb.Location = new System.Drawing.Point(120, 138);
            this.descripcionTxb.Name = "descripcionTxb";
            this.descripcionTxb.Size = new System.Drawing.Size(609, 107);
            this.descripcionTxb.TabIndex = 5;
            this.descripcionTxb.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Descripción:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(481, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Monto:";
            // 
            // diaCmb
            // 
            this.diaCmb.FormattingEnabled = true;
            this.diaCmb.Location = new System.Drawing.Point(390, 26);
            this.diaCmb.Name = "diaCmb";
            this.diaCmb.Size = new System.Drawing.Size(69, 24);
            this.diaCmb.TabIndex = 1;
            // 
            // mesCmb
            // 
            this.mesCmb.FormattingEnabled = true;
            this.mesCmb.Items.AddRange(new object[] {
            "Todos los meses",
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.mesCmb.Location = new System.Drawing.Point(120, 27);
            this.mesCmb.Name = "mesCmb";
            this.mesCmb.Size = new System.Drawing.Size(219, 24);
            this.mesCmb.TabIndex = 0;
            this.mesCmb.SelectedIndexChanged += new System.EventHandler(this.mesCmb_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(350, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Día:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mes:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cuenta:";
            // 
            // cuentaCmb
            // 
            this.cuentaCmb.FormattingEnabled = true;
            this.cuentaCmb.Location = new System.Drawing.Point(85, 67);
            this.cuentaCmb.Name = "cuentaCmb";
            this.cuentaCmb.Size = new System.Drawing.Size(510, 24);
            this.cuentaCmb.TabIndex = 7;
            this.cuentaCmb.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.cuentaCmb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.newRegistro);
            this.Controls.Add(this.customGridView1);
            this.Name = "Agenda";
            this.Text = "Agenda";
            this.Controls.SetChildIndex(this.customGridView1, 0);
            this.Controls.SetChildIndex(this.newRegistro, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.cuentaCmb, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomGridView customGridView1;
        private System.Windows.Forms.Button newRegistro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cuentaCmb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox diaCmb;
        private System.Windows.Forms.ComboBox mesCmb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox descripcionTxb;
        private System.Windows.Forms.ComboBox transaccionCmb;
        private System.Windows.Forms.Button acceptBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.TextBox montoTbx;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox estadoCmb;
    }
}