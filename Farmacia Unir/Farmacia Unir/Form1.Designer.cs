namespace Farmacia_Unir
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbCemefar = new System.Windows.Forms.RadioButton();
            this.rbEmpsephar = new System.Windows.Forms.RadioButton();
            this.rbCofarma = new System.Windows.Forms.RadioButton();
            this.cbSecundaria = new System.Windows.Forms.CheckBox();
            this.cbPrincipal = new System.Windows.Forms.CheckBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textCantidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTipoMedicamento = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textNombMed = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(654, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(205, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Farmacia Unir";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(3, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(168, 263);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Farmacia_Unir.Properties.Resources.icono2;
            this.pictureBox1.Location = new System.Drawing.Point(29, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 118);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rbCemefar);
            this.panel3.Controls.Add(this.rbEmpsephar);
            this.panel3.Controls.Add(this.rbCofarma);
            this.panel3.Controls.Add(this.cbSecundaria);
            this.panel3.Controls.Add(this.cbPrincipal);
            this.panel3.Controls.Add(this.btnConfirmar);
            this.panel3.Controls.Add(this.btnBorrar);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.textCantidad);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.cbTipoMedicamento);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.textNombMed);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(177, 109);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(480, 263);
            this.panel3.TabIndex = 2;
            // 
            // rbCemefar
            // 
            this.rbCemefar.AutoSize = true;
            this.rbCemefar.Location = new System.Drawing.Point(350, 137);
            this.rbCemefar.Name = "rbCemefar";
            this.rbCemefar.Size = new System.Drawing.Size(64, 17);
            this.rbCemefar.TabIndex = 14;
            this.rbCemefar.TabStop = true;
            this.rbCemefar.Text = "Cemefar";
            this.rbCemefar.UseVisualStyleBackColor = true;
            // 
            // rbEmpsephar
            // 
            this.rbEmpsephar.AutoSize = true;
            this.rbEmpsephar.Location = new System.Drawing.Point(266, 137);
            this.rbEmpsephar.Name = "rbEmpsephar";
            this.rbEmpsephar.Size = new System.Drawing.Size(78, 17);
            this.rbEmpsephar.TabIndex = 13;
            this.rbEmpsephar.TabStop = true;
            this.rbEmpsephar.Text = "Empsephar";
            this.rbEmpsephar.UseVisualStyleBackColor = true;
            // 
            // rbCofarma
            // 
            this.rbCofarma.AutoSize = true;
            this.rbCofarma.Location = new System.Drawing.Point(196, 137);
            this.rbCofarma.Name = "rbCofarma";
            this.rbCofarma.Size = new System.Drawing.Size(64, 17);
            this.rbCofarma.TabIndex = 12;
            this.rbCofarma.TabStop = true;
            this.rbCofarma.Text = "Cofarma";
            this.rbCofarma.UseVisualStyleBackColor = true;
            // 
            // cbSecundaria
            // 
            this.cbSecundaria.AutoSize = true;
            this.cbSecundaria.Location = new System.Drawing.Point(268, 173);
            this.cbSecundaria.Name = "cbSecundaria";
            this.cbSecundaria.Size = new System.Drawing.Size(80, 17);
            this.cbSecundaria.TabIndex = 11;
            this.cbSecundaria.Text = "Secundaria";
            this.cbSecundaria.UseVisualStyleBackColor = true;
            // 
            // cbPrincipal
            // 
            this.cbPrincipal.AutoSize = true;
            this.cbPrincipal.Location = new System.Drawing.Point(196, 173);
            this.cbPrincipal.Name = "cbPrincipal";
            this.cbPrincipal.Size = new System.Drawing.Size(66, 17);
            this.cbPrincipal.TabIndex = 10;
            this.cbPrincipal.Text = "Principal";
            this.cbPrincipal.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(252, 216);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(81, 23);
            this.btnConfirmar.TabIndex = 9;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(125, 216);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 8;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Sucursal de la farmacia:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Distribuidor Farmaceutico:";
            // 
            // textCantidad
            // 
            this.textCantidad.Location = new System.Drawing.Point(196, 96);
            this.textCantidad.Name = "textCantidad";
            this.textCantidad.Size = new System.Drawing.Size(100, 20);
            this.textCantidad.TabIndex = 5;
            this.textCantidad.Text = "0";
            this.textCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCantidad_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cantidad:";
            // 
            // cbTipoMedicamento
            // 
            this.cbTipoMedicamento.FormattingEnabled = true;
            this.cbTipoMedicamento.Items.AddRange(new object[] {
            "analgésico",
            "analéptico",
            "anestésico",
            "antiácido",
            "antidepresivo",
            "antibióticos"});
            this.cbTipoMedicamento.Location = new System.Drawing.Point(196, 59);
            this.cbTipoMedicamento.Name = "cbTipoMedicamento";
            this.cbTipoMedicamento.Size = new System.Drawing.Size(247, 21);
            this.cbTipoMedicamento.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo de medicamento:";
            // 
            // textNombMed
            // 
            this.textNombMed.Location = new System.Drawing.Point(196, 24);
            this.textNombMed.Name = "textNombMed";
            this.textNombMed.Size = new System.Drawing.Size(247, 20);
            this.textNombMed.TabIndex = 1;
            this.textNombMed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNombMed_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre del Medicamento:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 378);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Farmacia Unir";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbTipoMedicamento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textNombMed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textCantidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbCemefar;
        private System.Windows.Forms.RadioButton rbEmpsephar;
        private System.Windows.Forms.RadioButton rbCofarma;
        private System.Windows.Forms.CheckBox cbSecundaria;
        private System.Windows.Forms.CheckBox cbPrincipal;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnBorrar;
    }
}

