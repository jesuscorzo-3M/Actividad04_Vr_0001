namespace Actividad04_Vr_0001
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
            this.Lbl_Nom = new System.Windows.Forms.Label();
            this.Lbl_Ape = new System.Windows.Forms.Label();
            this.Lbl_Tel = new System.Windows.Forms.Label();
            this.Lbl_Edad = new System.Windows.Forms.Label();
            this.Lbl_Est = new System.Windows.Forms.Label();
            this.Txtb_Nom = new System.Windows.Forms.TextBox();
            this.Txtb_Ape = new System.Windows.Forms.TextBox();
            this.Txtb_Tel = new System.Windows.Forms.TextBox();
            this.Txtb_Edad = new System.Windows.Forms.TextBox();
            this.Txtb_Est = new System.Windows.Forms.TextBox();
            this.Gb_Gen = new System.Windows.Forms.GroupBox();
            this.Rbtn_Mas = new System.Windows.Forms.RadioButton();
            this.Rbtn_Fem = new System.Windows.Forms.RadioButton();
            this.Rbtn_Otro = new System.Windows.Forms.RadioButton();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Btn_Limpiar = new System.Windows.Forms.Button();
            this.Gb_Gen.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_Nom
            // 
            this.Lbl_Nom.AutoSize = true;
            this.Lbl_Nom.Location = new System.Drawing.Point(57, 36);
            this.Lbl_Nom.Name = "Lbl_Nom";
            this.Lbl_Nom.Size = new System.Drawing.Size(59, 16);
            this.Lbl_Nom.TabIndex = 0;
            this.Lbl_Nom.Text = "Nombre:";
            // 
            // Lbl_Ape
            // 
            this.Lbl_Ape.AutoSize = true;
            this.Lbl_Ape.Location = new System.Drawing.Point(57, 73);
            this.Lbl_Ape.Name = "Lbl_Ape";
            this.Lbl_Ape.Size = new System.Drawing.Size(60, 16);
            this.Lbl_Ape.TabIndex = 1;
            this.Lbl_Ape.Text = "Apellido:";
            // 
            // Lbl_Tel
            // 
            this.Lbl_Tel.AutoSize = true;
            this.Lbl_Tel.Location = new System.Drawing.Point(57, 115);
            this.Lbl_Tel.Name = "Lbl_Tel";
            this.Lbl_Tel.Size = new System.Drawing.Size(64, 16);
            this.Lbl_Tel.TabIndex = 2;
            this.Lbl_Tel.Text = "Telefono:";
            // 
            // Lbl_Edad
            // 
            this.Lbl_Edad.AutoSize = true;
            this.Lbl_Edad.Location = new System.Drawing.Point(57, 156);
            this.Lbl_Edad.Name = "Lbl_Edad";
            this.Lbl_Edad.Size = new System.Drawing.Size(43, 16);
            this.Lbl_Edad.TabIndex = 3;
            this.Lbl_Edad.Text = "Edad:";
            // 
            // Lbl_Est
            // 
            this.Lbl_Est.AutoSize = true;
            this.Lbl_Est.Location = new System.Drawing.Point(57, 197);
            this.Lbl_Est.Name = "Lbl_Est";
            this.Lbl_Est.Size = new System.Drawing.Size(59, 16);
            this.Lbl_Est.TabIndex = 4;
            this.Lbl_Est.Text = "Estatura:";
            // 
            // Txtb_Nom
            // 
            this.Txtb_Nom.Location = new System.Drawing.Point(148, 36);
            this.Txtb_Nom.Name = "Txtb_Nom";
            this.Txtb_Nom.Size = new System.Drawing.Size(100, 22);
            this.Txtb_Nom.TabIndex = 5;
            // 
            // Txtb_Ape
            // 
            this.Txtb_Ape.Location = new System.Drawing.Point(148, 73);
            this.Txtb_Ape.Name = "Txtb_Ape";
            this.Txtb_Ape.Size = new System.Drawing.Size(100, 22);
            this.Txtb_Ape.TabIndex = 6;
            // 
            // Txtb_Tel
            // 
            this.Txtb_Tel.Location = new System.Drawing.Point(148, 115);
            this.Txtb_Tel.Name = "Txtb_Tel";
            this.Txtb_Tel.Size = new System.Drawing.Size(100, 22);
            this.Txtb_Tel.TabIndex = 7;
            // 
            // Txtb_Edad
            // 
            this.Txtb_Edad.Location = new System.Drawing.Point(148, 156);
            this.Txtb_Edad.Name = "Txtb_Edad";
            this.Txtb_Edad.Size = new System.Drawing.Size(100, 22);
            this.Txtb_Edad.TabIndex = 8;
            // 
            // Txtb_Est
            // 
            this.Txtb_Est.Location = new System.Drawing.Point(148, 197);
            this.Txtb_Est.Name = "Txtb_Est";
            this.Txtb_Est.Size = new System.Drawing.Size(100, 22);
            this.Txtb_Est.TabIndex = 9;
            // 
            // Gb_Gen
            // 
            this.Gb_Gen.Controls.Add(this.Rbtn_Otro);
            this.Gb_Gen.Controls.Add(this.Rbtn_Fem);
            this.Gb_Gen.Controls.Add(this.Rbtn_Mas);
            this.Gb_Gen.Location = new System.Drawing.Point(60, 263);
            this.Gb_Gen.Name = "Gb_Gen";
            this.Gb_Gen.Size = new System.Drawing.Size(319, 100);
            this.Gb_Gen.TabIndex = 10;
            this.Gb_Gen.TabStop = false;
            this.Gb_Gen.Text = "Genero";
            // 
            // Rbtn_Mas
            // 
            this.Rbtn_Mas.AutoSize = true;
            this.Rbtn_Mas.Location = new System.Drawing.Point(6, 43);
            this.Rbtn_Mas.Name = "Rbtn_Mas";
            this.Rbtn_Mas.Size = new System.Drawing.Size(89, 20);
            this.Rbtn_Mas.TabIndex = 0;
            this.Rbtn_Mas.TabStop = true;
            this.Rbtn_Mas.Text = "Masculino";
            this.Rbtn_Mas.UseVisualStyleBackColor = true;
            // 
            // Rbtn_Fem
            // 
            this.Rbtn_Fem.AutoSize = true;
            this.Rbtn_Fem.Location = new System.Drawing.Point(131, 43);
            this.Rbtn_Fem.Name = "Rbtn_Fem";
            this.Rbtn_Fem.Size = new System.Drawing.Size(88, 20);
            this.Rbtn_Fem.TabIndex = 1;
            this.Rbtn_Fem.TabStop = true;
            this.Rbtn_Fem.Text = "Femenino";
            this.Rbtn_Fem.UseVisualStyleBackColor = true;
            // 
            // Rbtn_Otro
            // 
            this.Rbtn_Otro.AutoSize = true;
            this.Rbtn_Otro.Location = new System.Drawing.Point(258, 43);
            this.Rbtn_Otro.Name = "Rbtn_Otro";
            this.Rbtn_Otro.Size = new System.Drawing.Size(53, 20);
            this.Rbtn_Otro.TabIndex = 2;
            this.Rbtn_Otro.TabStop = true;
            this.Rbtn_Otro.Text = "Otro";
            this.Rbtn_Otro.UseVisualStyleBackColor = true;
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.Location = new System.Drawing.Point(66, 424);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(75, 47);
            this.Btn_Guardar.TabIndex = 11;
            this.Btn_Guardar.Text = "Guardar";
            this.Btn_Guardar.UseVisualStyleBackColor = true;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // Btn_Limpiar
            // 
            this.Btn_Limpiar.Location = new System.Drawing.Point(191, 424);
            this.Btn_Limpiar.Name = "Btn_Limpiar";
            this.Btn_Limpiar.Size = new System.Drawing.Size(75, 47);
            this.Btn_Limpiar.TabIndex = 12;
            this.Btn_Limpiar.Text = "Limpiar";
            this.Btn_Limpiar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 597);
            this.Controls.Add(this.Btn_Limpiar);
            this.Controls.Add(this.Btn_Guardar);
            this.Controls.Add(this.Gb_Gen);
            this.Controls.Add(this.Txtb_Est);
            this.Controls.Add(this.Txtb_Edad);
            this.Controls.Add(this.Txtb_Tel);
            this.Controls.Add(this.Txtb_Ape);
            this.Controls.Add(this.Txtb_Nom);
            this.Controls.Add(this.Lbl_Est);
            this.Controls.Add(this.Lbl_Edad);
            this.Controls.Add(this.Lbl_Tel);
            this.Controls.Add(this.Lbl_Ape);
            this.Controls.Add(this.Lbl_Nom);
            this.Name = "Form1";
            this.Text = "Actividad04_FormulariodeRegistro_Vr0001";
            this.Gb_Gen.ResumeLayout(false);
            this.Gb_Gen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Nom;
        private System.Windows.Forms.Label Lbl_Ape;
        private System.Windows.Forms.Label Lbl_Tel;
        private System.Windows.Forms.Label Lbl_Edad;
        private System.Windows.Forms.Label Lbl_Est;
        private System.Windows.Forms.TextBox Txtb_Nom;
        private System.Windows.Forms.TextBox Txtb_Ape;
        private System.Windows.Forms.TextBox Txtb_Tel;
        private System.Windows.Forms.TextBox Txtb_Edad;
        private System.Windows.Forms.TextBox Txtb_Est;
        private System.Windows.Forms.GroupBox Gb_Gen;
        private System.Windows.Forms.RadioButton Rbtn_Otro;
        private System.Windows.Forms.RadioButton Rbtn_Fem;
        private System.Windows.Forms.RadioButton Rbtn_Mas;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.Button Btn_Limpiar;
    }
}

