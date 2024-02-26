namespace form_ejercicio13_asignatura_y_profesor
{
    partial class Form1
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
            this.txt_asignatura = new System.Windows.Forms.TextBox();
            this.lbl_Asignatura = new System.Windows.Forms.Label();
            this.rdo_virtual = new System.Windows.Forms.RadioButton();
            this.btn_procesar = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.lbl_profesor = new System.Windows.Forms.Label();
            this.txt_profesor = new System.Windows.Forms.TextBox();
            this.gpb_modalidad = new System.Windows.Forms.GroupBox();
            this.rdo_Precensiar = new System.Windows.Forms.RadioButton();
            this.gpb_modalidad.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_asignatura
            // 
            this.txt_asignatura.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_asignatura.Location = new System.Drawing.Point(250, 98);
            this.txt_asignatura.Name = "txt_asignatura";
            this.txt_asignatura.Size = new System.Drawing.Size(164, 30);
            this.txt_asignatura.TabIndex = 0;
            // 
            // lbl_Asignatura
            // 
            this.lbl_Asignatura.AutoSize = true;
            this.lbl_Asignatura.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Asignatura.Location = new System.Drawing.Point(141, 101);
            this.lbl_Asignatura.Name = "lbl_Asignatura";
            this.lbl_Asignatura.Size = new System.Drawing.Size(95, 22);
            this.lbl_Asignatura.TabIndex = 1;
            this.lbl_Asignatura.Text = "Asignatura";
            // 
            // rdo_virtual
            // 
            this.rdo_virtual.AutoSize = true;
            this.rdo_virtual.Location = new System.Drawing.Point(16, 37);
            this.rdo_virtual.Name = "rdo_virtual";
            this.rdo_virtual.Size = new System.Drawing.Size(89, 26);
            this.rdo_virtual.TabIndex = 2;
            this.rdo_virtual.TabStop = true;
            this.rdo_virtual.Text = "Virtual";
            this.rdo_virtual.UseVisualStyleBackColor = true;
            // 
            // btn_procesar
            // 
            this.btn_procesar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_procesar.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_procesar.Location = new System.Drawing.Point(139, 309);
            this.btn_procesar.Name = "btn_procesar";
            this.btn_procesar.Size = new System.Drawing.Size(139, 40);
            this.btn_procesar.TabIndex = 3;
            this.btn_procesar.Text = "Procesar";
            this.btn_procesar.UseVisualStyleBackColor = false;
            this.btn_procesar.Click += new System.EventHandler(this.btn_procesar_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_limpiar.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.Location = new System.Drawing.Point(318, 309);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(139, 40);
            this.btn_limpiar.TabIndex = 4;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = false;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_cerrar.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar.Location = new System.Drawing.Point(505, 309);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(139, 40);
            this.btn_cerrar.TabIndex = 5;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // lbl_profesor
            // 
            this.lbl_profesor.AutoSize = true;
            this.lbl_profesor.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_profesor.Location = new System.Drawing.Point(141, 156);
            this.lbl_profesor.Name = "lbl_profesor";
            this.lbl_profesor.Size = new System.Drawing.Size(78, 22);
            this.lbl_profesor.TabIndex = 7;
            this.lbl_profesor.Text = "Profesor";
            // 
            // txt_profesor
            // 
            this.txt_profesor.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_profesor.Location = new System.Drawing.Point(250, 153);
            this.txt_profesor.Name = "txt_profesor";
            this.txt_profesor.Size = new System.Drawing.Size(164, 30);
            this.txt_profesor.TabIndex = 6;
            // 
            // gpb_modalidad
            // 
            this.gpb_modalidad.Controls.Add(this.rdo_Precensiar);
            this.gpb_modalidad.Controls.Add(this.rdo_virtual);
            this.gpb_modalidad.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_modalidad.Location = new System.Drawing.Point(453, 78);
            this.gpb_modalidad.Name = "gpb_modalidad";
            this.gpb_modalidad.Size = new System.Drawing.Size(207, 137);
            this.gpb_modalidad.TabIndex = 8;
            this.gpb_modalidad.TabStop = false;
            this.gpb_modalidad.Text = "Modalidad:";
            // 
            // rdo_Precensiar
            // 
            this.rdo_Precensiar.AutoSize = true;
            this.rdo_Precensiar.Location = new System.Drawing.Point(16, 84);
            this.rdo_Precensiar.Name = "rdo_Precensiar";
            this.rdo_Precensiar.Size = new System.Drawing.Size(119, 26);
            this.rdo_Precensiar.TabIndex = 9;
            this.rdo_Precensiar.TabStop = true;
            this.rdo_Precensiar.Text = "Precensiar";
            this.rdo_Precensiar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gpb_modalidad);
            this.Controls.Add(this.lbl_profesor);
            this.Controls.Add(this.txt_profesor);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_procesar);
            this.Controls.Add(this.lbl_Asignatura);
            this.Controls.Add(this.txt_asignatura);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpb_modalidad.ResumeLayout(false);
            this.gpb_modalidad.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_asignatura;
        private System.Windows.Forms.Label lbl_Asignatura;
        private System.Windows.Forms.RadioButton rdo_virtual;
        private System.Windows.Forms.Button btn_procesar;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Label lbl_profesor;
        private System.Windows.Forms.TextBox txt_profesor;
        private System.Windows.Forms.GroupBox gpb_modalidad;
        private System.Windows.Forms.RadioButton rdo_Precensiar;
    }
}

