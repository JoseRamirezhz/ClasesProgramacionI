namespace WindowsFormsApplication3
{
    partial class frmOperaciones
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
            this.grbGrupoA = new System.Windows.Forms.GroupBox();
            this.btnRestar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtValorB = new System.Windows.Forms.TextBox();
            this.lblValorB = new System.Windows.Forms.Label();
            this.txtValorA = new System.Windows.Forms.TextBox();
            this.lblValorA = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.grbGrupoA.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbGrupoA
            // 
            this.grbGrupoA.Controls.Add(this.button2);
            this.grbGrupoA.Controls.Add(this.button1);
            this.grbGrupoA.Controls.Add(this.btnRestar);
            this.grbGrupoA.Controls.Add(this.btnCalcular);
            this.grbGrupoA.Controls.Add(this.txtResultado);
            this.grbGrupoA.Controls.Add(this.lblResultado);
            this.grbGrupoA.Controls.Add(this.txtValorB);
            this.grbGrupoA.Controls.Add(this.lblValorB);
            this.grbGrupoA.Controls.Add(this.txtValorA);
            this.grbGrupoA.Controls.Add(this.lblValorA);
            this.grbGrupoA.Location = new System.Drawing.Point(28, 12);
            this.grbGrupoA.Name = "grbGrupoA";
            this.grbGrupoA.Size = new System.Drawing.Size(255, 235);
            this.grbGrupoA.TabIndex = 0;
            this.grbGrupoA.TabStop = false;
            this.grbGrupoA.Text = "grbGrupoA";
            this.grbGrupoA.Enter += new System.EventHandler(this.grbGrupoA_Enter);
            // 
            // btnRestar
            // 
            this.btnRestar.Location = new System.Drawing.Point(141, 148);
            this.btnRestar.Name = "btnRestar";
            this.btnRestar.Size = new System.Drawing.Size(86, 27);
            this.btnRestar.TabIndex = 14;
            this.btnRestar.Text = "&Restar";
            this.btnRestar.UseVisualStyleBackColor = true;
            this.btnRestar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(16, 148);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(74, 27);
            this.btnCalcular.TabIndex = 13;
            this.btnCalcular.Text = "&Sumar";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(127, 121);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 20);
            this.txtResultado.TabIndex = 12;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(12, 121);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(109, 24);
            this.lblResultado.TabIndex = 11;
            this.lblResultado.Text = "Resultado:";
            // 
            // txtValorB
            // 
            this.txtValorB.Location = new System.Drawing.Point(108, 73);
            this.txtValorB.Name = "txtValorB";
            this.txtValorB.Size = new System.Drawing.Size(119, 20);
            this.txtValorB.TabIndex = 10;
            // 
            // lblValorB
            // 
            this.lblValorB.AutoSize = true;
            this.lblValorB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorB.Location = new System.Drawing.Point(28, 80);
            this.lblValorB.Name = "lblValorB";
            this.lblValorB.Size = new System.Drawing.Size(52, 13);
            this.lblValorB.TabIndex = 9;
            this.lblValorB.Text = "Valor B:";
            // 
            // txtValorA
            // 
            this.txtValorA.Location = new System.Drawing.Point(108, 33);
            this.txtValorA.Name = "txtValorA";
            this.txtValorA.Size = new System.Drawing.Size(119, 20);
            this.txtValorA.TabIndex = 8;
            // 
            // lblValorA
            // 
            this.lblValorA.AutoSize = true;
            this.lblValorA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorA.Location = new System.Drawing.Point(28, 40);
            this.lblValorA.Name = "lblValorA";
            this.lblValorA.Size = new System.Drawing.Size(52, 13);
            this.lblValorA.TabIndex = 7;
            this.lblValorA.Text = "Valor A:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 27);
            this.button1.TabIndex = 15;
            this.button1.Text = "&Multiplicar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(141, 202);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 27);
            this.button2.TabIndex = 16;
            this.button2.Text = "&Dividir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 285);
            this.Controls.Add(this.grbGrupoA);
            this.Name = "frmOperaciones";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmOperaciones_Load);
            this.grbGrupoA.ResumeLayout(false);
            this.grbGrupoA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbGrupoA;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtValorB;
        private System.Windows.Forms.Label lblValorB;
        private System.Windows.Forms.TextBox txtValorA;
        private System.Windows.Forms.Label lblValorA;
        private System.Windows.Forms.Button btnRestar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

