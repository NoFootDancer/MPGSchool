namespace ProyectoF
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
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
            this.tx1 = new System.Windows.Forms.TextBox();
            this.tx2 = new System.Windows.Forms.TextBox();
            this.tx3 = new System.Windows.Forms.TextBox();
            this.salvar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Mas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tx1
            // 
            this.tx1.Location = new System.Drawing.Point(213, 226);
            this.tx1.Name = "tx1";
            this.tx1.Size = new System.Drawing.Size(100, 20);
            this.tx1.TabIndex = 0;
            // 
            // tx2
            // 
            this.tx2.Location = new System.Drawing.Point(107, 226);
            this.tx2.Name = "tx2";
            this.tx2.Size = new System.Drawing.Size(100, 20);
            this.tx2.TabIndex = 1;
            // 
            // tx3
            // 
            this.tx3.Location = new System.Drawing.Point(1, 226);
            this.tx3.Name = "tx3";
            this.tx3.Size = new System.Drawing.Size(100, 20);
            this.tx3.TabIndex = 2;
            // 
            // salvar
            // 
            this.salvar.Location = new System.Drawing.Point(319, 197);
            this.salvar.Name = "salvar";
            this.salvar.Size = new System.Drawing.Size(75, 23);
            this.salvar.TabIndex = 3;
            this.salvar.Text = "Salvar";
            this.salvar.UseVisualStyleBackColor = true;
            this.salvar.Click += new System.EventHandler(this.salvar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(319, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cargar...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Mas
            // 
            this.Mas.Location = new System.Drawing.Point(319, 168);
            this.Mas.Name = "Mas";
            this.Mas.Size = new System.Drawing.Size(15, 23);
            this.Mas.TabIndex = 5;
            this.Mas.Text = "+";
            this.Mas.UseVisualStyleBackColor = true;
            this.Mas.Click += new System.EventHandler(this.Mas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(341, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Contador";
            this.label1.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(319, 256);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Rellenar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 427);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Mas);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.salvar);
            this.Controls.Add(this.tx3);
            this.Controls.Add(this.tx2);
            this.Controls.Add(this.tx1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tx1;
        private System.Windows.Forms.TextBox tx2;
        private System.Windows.Forms.TextBox tx3;
        private System.Windows.Forms.Button salvar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Mas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}

