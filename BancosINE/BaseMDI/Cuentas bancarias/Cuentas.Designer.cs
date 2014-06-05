namespace BancosINE
{
    partial class Cuentas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.bancoCmb = new System.Windows.Forms.ComboBox();
            this.cuentaCmb = new System.Windows.Forms.ComboBox();
            this.monedaCmb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.numeroTxt = new System.Windows.Forms.TextBox();
            this.nombreTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.newRegistro = new System.Windows.Forms.Button();
            this.saldoTxb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // customGridView1
            // 
            this.customGridView1.Location = new System.Drawing.Point(18, 53);
            this.customGridView1.Name = "customGridView1";
            this.customGridView1.Size = new System.Drawing.Size(994, 376);
            this.customGridView1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.saldoTxb);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.bancoCmb);
            this.panel1.Controls.Add(this.cuentaCmb);
            this.panel1.Controls.Add(this.monedaCmb);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.numeroTxt);
            this.panel1.Controls.Add(this.nombreTxt);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 481);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 274);
            this.panel1.TabIndex = 6;
            this.panel1.Visible = false;
            // 
            // bancoCmb
            // 
            this.bancoCmb.FormattingEnabled = true;
            this.bancoCmb.Location = new System.Drawing.Point(131, 112);
            this.bancoCmb.Name = "bancoCmb";
            this.bancoCmb.Size = new System.Drawing.Size(549, 24);
            this.bancoCmb.TabIndex = 12;
            // 
            // cuentaCmb
            // 
            this.cuentaCmb.FormattingEnabled = true;
            this.cuentaCmb.Location = new System.Drawing.Point(131, 148);
            this.cuentaCmb.Name = "cuentaCmb";
            this.cuentaCmb.Size = new System.Drawing.Size(549, 24);
            this.cuentaCmb.TabIndex = 11;
            // 
            // monedaCmb
            // 
            this.monedaCmb.FormattingEnabled = true;
            this.monedaCmb.Location = new System.Drawing.Point(131, 186);
            this.monedaCmb.Name = "monedaCmb";
            this.monedaCmb.Size = new System.Drawing.Size(549, 24);
            this.monedaCmb.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Banco:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tipo de moneda:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.button2.BackgroundImage = global::BancosINE.Properties.Resources.accept;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(594, 216);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 40);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.button1.BackgroundImage = global::BancosINE.Properties.Resources.remove;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(640, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numeroTxt
            // 
            this.numeroTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroTxt.Location = new System.Drawing.Point(131, 45);
            this.numeroTxt.Name = "numeroTxt";
            this.numeroTxt.Size = new System.Drawing.Size(549, 24);
            this.numeroTxt.TabIndex = 4;
            // 
            // nombreTxt
            // 
            this.nombreTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTxt.Location = new System.Drawing.Point(131, 10);
            this.nombreTxt.Name = "nombreTxt";
            this.nombreTxt.Size = new System.Drawing.Size(549, 24);
            this.nombreTxt.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tipo de cuenta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Número:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre:";
            // 
            // newRegistro
            // 
            this.newRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.newRegistro.BackgroundImage = global::BancosINE.Properties.Resources._new;
            this.newRegistro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.newRegistro.Location = new System.Drawing.Point(12, 435);
            this.newRegistro.Name = "newRegistro";
            this.newRegistro.Size = new System.Drawing.Size(40, 40);
            this.newRegistro.TabIndex = 5;
            this.newRegistro.UseVisualStyleBackColor = false;
            this.newRegistro.Click += new System.EventHandler(this.newRegistro_Click);
            // 
            // saldoTxb
            // 
            this.saldoTxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saldoTxb.Location = new System.Drawing.Point(131, 78);
            this.saldoTxb.Name = "saldoTxb";
            this.saldoTxb.Size = new System.Drawing.Size(549, 24);
            this.saldoTxb.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Saldo inicial:";
            // 
            // Cuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.newRegistro);
            this.Controls.Add(this.customGridView1);
            this.Name = "Cuentas";
            this.Text = "Cuentas";
            this.Controls.SetChildIndex(this.customGridView1, 0);
            this.Controls.SetChildIndex(this.newRegistro, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomGridView customGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox numeroTxt;
        private System.Windows.Forms.TextBox nombreTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button newRegistro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox bancoCmb;
        private System.Windows.Forms.ComboBox cuentaCmb;
        private System.Windows.Forms.ComboBox monedaCmb;
        private System.Windows.Forms.TextBox saldoTxb;
        private System.Windows.Forms.Label label7;
    }
}