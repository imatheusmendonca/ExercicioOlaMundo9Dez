namespace PROJETO09DEZ
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
            this.primeiroTexto = new System.Windows.Forms.Label();
            this.botao1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // primeiroTexto
            // 
            this.primeiroTexto.AutoSize = true;
            this.primeiroTexto.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.primeiroTexto.ForeColor = System.Drawing.SystemColors.Highlight;
            this.primeiroTexto.Location = new System.Drawing.Point(291, 104);
            this.primeiroTexto.Name = "primeiroTexto";
            this.primeiroTexto.Size = new System.Drawing.Size(120, 30);
            this.primeiroTexto.TabIndex = 0;
            this.primeiroTexto.Text = "olá mundo";
            // 
            // botao1
            // 
            this.botao1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.botao1.Location = new System.Drawing.Point(218, 37);
            this.botao1.Name = "botao1";
            this.botao1.Size = new System.Drawing.Size(193, 64);
            this.botao1.TabIndex = 1;
            this.botao1.Text = "CLIQUE AQUI ";
            this.botao1.UseVisualStyleBackColor = true;
            this.botao1.Click += new System.EventHandler(this.botao1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botao1);
            this.Controls.Add(this.primeiroTexto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label primeiroTexto;
        private Button botao1;
    }
}