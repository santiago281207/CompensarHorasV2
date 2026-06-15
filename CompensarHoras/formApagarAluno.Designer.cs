namespace CompensarHoras
{
    partial class formApagarAluno
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
            this.btnApagar = new System.Windows.Forms.Button();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblTurma = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(156, 104);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(75, 23);
            this.btnApagar.TabIndex = 0;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(12, 9);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(44, 16);
            this.lblNum.TabIndex = 1;
            this.lblNum.Text = "label1";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 38);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(44, 16);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "label2";
            // 
            // lblTurma
            // 
            this.lblTurma.AutoSize = true;
            this.lblTurma.Location = new System.Drawing.Point(12, 70);
            this.lblTurma.Name = "lblTurma";
            this.lblTurma.Size = new System.Drawing.Size(44, 16);
            this.lblTurma.TabIndex = 3;
            this.lblTurma.Text = "label3";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(15, 104);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // formApagarAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 137);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblTurma);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.btnApagar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formApagarAluno";
            this.Text = "formApagarAluno";
            this.Load += new System.EventHandler(this.formApagarAluno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblTurma;
        private System.Windows.Forms.Button btnCancelar;
    }
}