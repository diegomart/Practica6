namespace Practica_6
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
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Limpiar = new System.Windows.Forms.Button();
            this.Facturar = new System.Windows.Forms.Button();
            this.iva = new System.Windows.Forms.TextBox();
            this.total = new System.Windows.Forms.TextBox();
            this.subtotal = new System.Windows.Forms.TextBox();
            this.p3 = new System.Windows.Forms.TextBox();
            this.p1 = new System.Windows.Forms.TextBox();
            this.p2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Limpiar);
            this.panel1.Controls.Add(this.Facturar);
            this.panel1.Controls.Add(this.iva);
            this.panel1.Controls.Add(this.total);
            this.panel1.Controls.Add(this.subtotal);
            this.panel1.Controls.Add(this.p3);
            this.panel1.Controls.Add(this.p1);
            this.panel1.Controls.Add(this.p2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 403);
            this.panel1.TabIndex = 0;
            // 
            // Limpiar
            // 
            this.Limpiar.Location = new System.Drawing.Point(131, 342);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(75, 23);
            this.Limpiar.TabIndex = 12;
            this.Limpiar.Text = "Limpiar";
            this.Limpiar.UseVisualStyleBackColor = true;
            this.Limpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // Facturar
            // 
            this.Facturar.Location = new System.Drawing.Point(35, 342);
            this.Facturar.Name = "Facturar";
            this.Facturar.Size = new System.Drawing.Size(75, 23);
            this.Facturar.TabIndex = 11;
            this.Facturar.Text = "Facturar";
            this.Facturar.UseVisualStyleBackColor = true;
            this.Facturar.Click += new System.EventHandler(this.Facturar_Click);
            // 
            // iva
            // 
            this.iva.Location = new System.Drawing.Point(131, 229);
            this.iva.Name = "iva";
            this.iva.Size = new System.Drawing.Size(100, 20);
            this.iva.TabIndex = 10;
            // 
            // total
            // 
            this.total.Location = new System.Drawing.Point(131, 266);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(100, 20);
            this.total.TabIndex = 9;
            // 
            // subtotal
            // 
            this.subtotal.Location = new System.Drawing.Point(131, 192);
            this.subtotal.Name = "subtotal";
            this.subtotal.Size = new System.Drawing.Size(100, 20);
            this.subtotal.TabIndex = 1;
            // 
            // p3
            // 
            this.p3.Location = new System.Drawing.Point(131, 119);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(100, 20);
            this.p3.TabIndex = 8;
            // 
            // p1
            // 
            this.p1.Location = new System.Drawing.Point(131, 31);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(100, 20);
            this.p1.TabIndex = 7;
            // 
            // p2
            // 
            this.p2.Location = new System.Drawing.Point(131, 78);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(100, 20);
            this.p2.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "IVA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "SubTotal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prodcuto 3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prodcuto 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prodcuto 1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(340, 404);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox p2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox p1;
        private System.Windows.Forms.TextBox subtotal;
        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.Button Facturar;
        private System.Windows.Forms.TextBox iva;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.TextBox p3;
    }
}

