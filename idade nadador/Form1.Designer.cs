namespace idade_nadador
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblresultado = new System.Windows.Forms.Label();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.txtEnunciado = new System.Windows.Forms.TextBox();
            this.cmdCalcular = new System.Windows.Forms.Button();
            this.lblidadenadador = new System.Windows.Forms.Label();
            this.txtidadenadador = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblresultado);
            this.groupBox1.Controls.Add(this.txtresultado);
            this.groupBox1.Controls.Add(this.txtEnunciado);
            this.groupBox1.Controls.Add(this.cmdCalcular);
            this.groupBox1.Controls.Add(this.lblidadenadador);
            this.groupBox1.Controls.Add(this.txtidadenadador);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(164, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 507);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Exercício Classificar Nadador";
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(7, 365);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(100, 25);
            this.lblresultado.TabIndex = 10;
            this.lblresultado.Text = "Resultado";
            // 
            // txtresultado
            // 
            this.txtresultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtresultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtresultado.ForeColor = System.Drawing.Color.Blue;
            this.txtresultado.Location = new System.Drawing.Point(7, 399);
            this.txtresultado.Multiline = true;
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(441, 88);
            this.txtresultado.TabIndex = 9;
            this.txtresultado.Text = "Resultado";
            // 
            // txtEnunciado
            // 
            this.txtEnunciado.BackColor = System.Drawing.Color.Yellow;
            this.txtEnunciado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEnunciado.Location = new System.Drawing.Point(7, 32);
            this.txtEnunciado.Multiline = true;
            this.txtEnunciado.Name = "txtEnunciado";
            this.txtEnunciado.Size = new System.Drawing.Size(451, 157);
            this.txtEnunciado.TabIndex = 4;
            this.txtEnunciado.Text = resources.GetString("txtEnunciado.Text");
            // 
            // cmdCalcular
            // 
            this.cmdCalcular.Location = new System.Drawing.Point(7, 296);
            this.cmdCalcular.Name = "cmdCalcular";
            this.cmdCalcular.Size = new System.Drawing.Size(451, 44);
            this.cmdCalcular.TabIndex = 2;
            this.cmdCalcular.Text = "Classificar Nadador";
            this.cmdCalcular.UseVisualStyleBackColor = true;
            this.cmdCalcular.Click += new System.EventHandler(this.cmdCalcular_Click);
            // 
            // lblidadenadador
            // 
            this.lblidadenadador.AutoSize = true;
            this.lblidadenadador.Location = new System.Drawing.Point(7, 225);
            this.lblidadenadador.Name = "lblidadenadador";
            this.lblidadenadador.Size = new System.Drawing.Size(281, 25);
            this.lblidadenadador.TabIndex = 1;
            this.lblidadenadador.Text = "Entre com a idade do nadador";
            // 
            // txtidadenadador
            // 
            this.txtidadenadador.Location = new System.Drawing.Point(298, 221);
            this.txtidadenadador.Name = "txtidadenadador";
            this.txtidadenadador.Size = new System.Drawing.Size(159, 32);
            this.txtidadenadador.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 517);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label lblresultado;
        private TextBox txtresultado;
        private TextBox txtEnunciado;
        private Button cmdCalcular;
        private Label lblidadenadador;
        private TextBox txtidadenadador;
    }
}