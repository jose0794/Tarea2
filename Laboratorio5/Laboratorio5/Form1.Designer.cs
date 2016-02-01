namespace Laboratorio5
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtProyecto = new System.Windows.Forms.TextBox();
            this.btnProyecto = new System.Windows.Forms.Button();
            this.txtProyecto2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proyecto";
            // 
            // txtProyecto
            // 
            this.txtProyecto.Location = new System.Drawing.Point(61, 98);
            this.txtProyecto.Multiline = true;
            this.txtProyecto.Name = "txtProyecto";
            this.txtProyecto.Size = new System.Drawing.Size(342, 53);
            this.txtProyecto.TabIndex = 1;
            // 
            // btnProyecto
            // 
            this.btnProyecto.Location = new System.Drawing.Point(61, 261);
            this.btnProyecto.Name = "btnProyecto";
            this.btnProyecto.Size = new System.Drawing.Size(219, 39);
            this.btnProyecto.TabIndex = 2;
            this.btnProyecto.Text = "button1";
            this.btnProyecto.UseVisualStyleBackColor = true;
            this.btnProyecto.Click += new System.EventHandler(this.btnProyecto_Click);
            // 
            // txtProyecto2
            // 
            this.txtProyecto2.Location = new System.Drawing.Point(61, 166);
            this.txtProyecto2.Multiline = true;
            this.txtProyecto2.Name = "txtProyecto2";
            this.txtProyecto2.Size = new System.Drawing.Size(342, 67);
            this.txtProyecto2.TabIndex = 3;
            this.txtProyecto2.TextChanged += new System.EventHandler(this.txtProyecto2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(544, 337);
            this.Controls.Add(this.txtProyecto2);
            this.Controls.Add(this.btnProyecto);
            this.Controls.Add(this.txtProyecto);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProyecto;
        private System.Windows.Forms.TextBox txtProyecto;
        private System.Windows.Forms.TextBox txtProyecto2;
    }
}

