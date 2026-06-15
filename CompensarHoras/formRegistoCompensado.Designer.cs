namespace CompensarHoras
{
    partial class formRegistoCompensado
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
            this.txtNum = new System.Windows.Forms.TextBox();
            this.gpbAno = new System.Windows.Forms.GroupBox();
            this.lblTrim = new System.Windows.Forms.Label();
            this.rdbTr3 = new System.Windows.Forms.RadioButton();
            this.tdbTr2 = new System.Windows.Forms.RadioButton();
            this.dtpAno = new System.Windows.Forms.DateTimePicker();
            this.rdbTr1 = new System.Windows.Forms.RadioButton();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.ccbDisp = new System.Windows.Forms.ComboBox();
            this.lblDisp = new System.Windows.Forms.Label();
            this.gpbTipo = new System.Windows.Forms.GroupBox();
            this.rdbPAIR = new System.Windows.Forms.RadioButton();
            this.rdbNormal = new System.Windows.Forms.RadioButton();
            this.dtpHoraIni = new System.Windows.Forms.DateTimePicker();
            this.lblHoraIni = new System.Windows.Forms.Label();
            this.lblHoraFinal = new System.Windows.Forms.Label();
            this.dtpHoraFinal = new System.Windows.Forms.DateTimePicker();
            this.lblData = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConf = new System.Windows.Forms.Button();
            this.gpbAno.SuspendLayout();
            this.gpbTipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(12, 28);
            this.txtNum.MaxLength = 6;
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(69, 22);
            this.txtNum.TabIndex = 0;
            this.txtNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNum.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // gpbAno
            // 
            this.gpbAno.Controls.Add(this.lblTrim);
            this.gpbAno.Controls.Add(this.rdbTr3);
            this.gpbAno.Controls.Add(this.tdbTr2);
            this.gpbAno.Controls.Add(this.dtpAno);
            this.gpbAno.Controls.Add(this.rdbTr1);
            this.gpbAno.Location = new System.Drawing.Point(15, 124);
            this.gpbAno.Name = "gpbAno";
            this.gpbAno.Size = new System.Drawing.Size(116, 169);
            this.gpbAno.TabIndex = 3;
            this.gpbAno.TabStop = false;
            this.gpbAno.Text = "Ano Letivo";
            // 
            // lblTrim
            // 
            this.lblTrim.AutoSize = true;
            this.lblTrim.Location = new System.Drawing.Point(6, 62);
            this.lblTrim.Name = "lblTrim";
            this.lblTrim.Size = new System.Drawing.Size(64, 16);
            this.lblTrim.TabIndex = 8;
            this.lblTrim.Text = "Trimestre";
            // 
            // rdbTr3
            // 
            this.rdbTr3.AutoSize = true;
            this.rdbTr3.Location = new System.Drawing.Point(6, 137);
            this.rdbTr3.Name = "rdbTr3";
            this.rdbTr3.Size = new System.Drawing.Size(100, 20);
            this.rdbTr3.TabIndex = 10;
            this.rdbTr3.Text = "3º Trimestre";
            this.rdbTr3.UseVisualStyleBackColor = true;
            // 
            // tdbTr2
            // 
            this.tdbTr2.AutoSize = true;
            this.tdbTr2.Location = new System.Drawing.Point(6, 111);
            this.tdbTr2.Name = "tdbTr2";
            this.tdbTr2.Size = new System.Drawing.Size(100, 20);
            this.tdbTr2.TabIndex = 9;
            this.tdbTr2.Text = "2º Trimestre";
            this.tdbTr2.UseVisualStyleBackColor = true;
            // 
            // dtpAno
            // 
            this.dtpAno.CustomFormat = "yyyy";
            this.dtpAno.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAno.Location = new System.Drawing.Point(6, 21);
            this.dtpAno.Name = "dtpAno";
            this.dtpAno.ShowUpDown = true;
            this.dtpAno.Size = new System.Drawing.Size(93, 22);
            this.dtpAno.TabIndex = 8;
            // 
            // rdbTr1
            // 
            this.rdbTr1.AutoSize = true;
            this.rdbTr1.Checked = true;
            this.rdbTr1.Location = new System.Drawing.Point(6, 85);
            this.rdbTr1.Name = "rdbTr1";
            this.rdbTr1.Size = new System.Drawing.Size(100, 20);
            this.rdbTr1.TabIndex = 0;
            this.rdbTr1.TabStop = true;
            this.rdbTr1.Text = "1º Trimestre";
            this.rdbTr1.UseVisualStyleBackColor = true;
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(137, 94);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(116, 22);
            this.dtpData.TabIndex = 1;
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(12, 9);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(55, 16);
            this.lblNum.TabIndex = 4;
            this.lblNum.Text = "Número";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(87, 31);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(27, 16);
            this.lblNome.TabIndex = 5;
            this.lblNome.Text = "-----";
            // 
            // ccbDisp
            // 
            this.ccbDisp.FormattingEnabled = true;
            this.ccbDisp.Items.AddRange(new object[] {
            " PSI",
            " PT",
            " ING",
            " RC",
            " AC",
            " MAT",
            " TIC",
            " FQ",
            " SO"});
            this.ccbDisp.Location = new System.Drawing.Point(15, 94);
            this.ccbDisp.Name = "ccbDisp";
            this.ccbDisp.Size = new System.Drawing.Size(116, 24);
            this.ccbDisp.TabIndex = 6;
            // 
            // lblDisp
            // 
            this.lblDisp.AutoSize = true;
            this.lblDisp.Location = new System.Drawing.Point(12, 75);
            this.lblDisp.Name = "lblDisp";
            this.lblDisp.Size = new System.Drawing.Size(66, 16);
            this.lblDisp.TabIndex = 7;
            this.lblDisp.Text = "Disciplina";
            // 
            // gpbTipo
            // 
            this.gpbTipo.Controls.Add(this.rdbPAIR);
            this.gpbTipo.Controls.Add(this.rdbNormal);
            this.gpbTipo.Location = new System.Drawing.Point(137, 124);
            this.gpbTipo.Name = "gpbTipo";
            this.gpbTipo.Size = new System.Drawing.Size(161, 55);
            this.gpbTipo.TabIndex = 11;
            this.gpbTipo.TabStop = false;
            this.gpbTipo.Text = "Tipo";
            // 
            // rdbPAIR
            // 
            this.rdbPAIR.AutoSize = true;
            this.rdbPAIR.Location = new System.Drawing.Point(84, 24);
            this.rdbPAIR.Name = "rdbPAIR";
            this.rdbPAIR.Size = new System.Drawing.Size(59, 20);
            this.rdbPAIR.TabIndex = 9;
            this.rdbPAIR.Text = "PAIR";
            this.rdbPAIR.UseVisualStyleBackColor = true;
            // 
            // rdbNormal
            // 
            this.rdbNormal.AutoSize = true;
            this.rdbNormal.Checked = true;
            this.rdbNormal.Location = new System.Drawing.Point(6, 24);
            this.rdbNormal.Name = "rdbNormal";
            this.rdbNormal.Size = new System.Drawing.Size(72, 20);
            this.rdbNormal.TabIndex = 0;
            this.rdbNormal.TabStop = true;
            this.rdbNormal.Text = "Normal";
            this.rdbNormal.UseVisualStyleBackColor = true;
            // 
            // dtpHoraIni
            // 
            this.dtpHoraIni.CustomFormat = "HH:mm";
            this.dtpHoraIni.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraIni.Location = new System.Drawing.Point(143, 208);
            this.dtpHoraIni.Name = "dtpHoraIni";
            this.dtpHoraIni.ShowUpDown = true;
            this.dtpHoraIni.Size = new System.Drawing.Size(77, 22);
            this.dtpHoraIni.TabIndex = 12;
            this.dtpHoraIni.Value = new System.DateTime(2026, 6, 12, 8, 0, 0, 0);
            // 
            // lblHoraIni
            // 
            this.lblHoraIni.AutoSize = true;
            this.lblHoraIni.Location = new System.Drawing.Point(140, 186);
            this.lblHoraIni.Name = "lblHoraIni";
            this.lblHoraIni.Size = new System.Drawing.Size(74, 16);
            this.lblHoraIni.TabIndex = 11;
            this.lblHoraIni.Text = "Hora inicial";
            // 
            // lblHoraFinal
            // 
            this.lblHoraFinal.AutoSize = true;
            this.lblHoraFinal.Location = new System.Drawing.Point(234, 186);
            this.lblHoraFinal.Name = "lblHoraFinal";
            this.lblHoraFinal.Size = new System.Drawing.Size(64, 16);
            this.lblHoraFinal.TabIndex = 14;
            this.lblHoraFinal.Text = "Hora final";
            // 
            // dtpHoraFinal
            // 
            this.dtpHoraFinal.CustomFormat = "HH:mm";
            this.dtpHoraFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraFinal.Location = new System.Drawing.Point(237, 208);
            this.dtpHoraFinal.Name = "dtpHoraFinal";
            this.dtpHoraFinal.ShowUpDown = true;
            this.dtpHoraFinal.Size = new System.Drawing.Size(77, 22);
            this.dtpHoraFinal.TabIndex = 15;
            this.dtpHoraFinal.Value = new System.DateTime(2026, 6, 12, 8, 30, 0, 0);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(134, 75);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(36, 16);
            this.lblData.TabIndex = 16;
            this.lblData.Text = "Data";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(156, 274);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnConf
            // 
            this.btnConf.Location = new System.Drawing.Point(237, 274);
            this.btnConf.Name = "btnConf";
            this.btnConf.Size = new System.Drawing.Size(75, 23);
            this.btnConf.TabIndex = 18;
            this.btnConf.Text = "Confirmar";
            this.btnConf.UseVisualStyleBackColor = true;
            // 
            // formRegistoCompensado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 309);
            this.Controls.Add(this.btnConf);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.dtpHoraFinal);
            this.Controls.Add(this.lblHoraFinal);
            this.Controls.Add(this.lblHoraIni);
            this.Controls.Add(this.dtpHoraIni);
            this.Controls.Add(this.gpbTipo);
            this.Controls.Add(this.lblDisp);
            this.Controls.Add(this.ccbDisp);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.gpbAno);
            this.Controls.Add(this.txtNum);
            this.Name = "formRegistoCompensado";
            this.Text = "formRegistoCompensado";
            this.Load += new System.EventHandler(this.formRegistoCompensado_Load);
            this.gpbAno.ResumeLayout(false);
            this.gpbAno.PerformLayout();
            this.gpbTipo.ResumeLayout(false);
            this.gpbTipo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.RadioButton rdbTr1;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.ComboBox ccbDisp;
        private System.Windows.Forms.Label lblDisp;
        private System.Windows.Forms.DateTimePicker dtpAno;
        private System.Windows.Forms.Label lblTrim;
        private System.Windows.Forms.RadioButton rdbTr3;
        private System.Windows.Forms.RadioButton tdbTr2;
        private System.Windows.Forms.GroupBox gpbTipo;
        private System.Windows.Forms.RadioButton rdbPAIR;
        private System.Windows.Forms.RadioButton rdbNormal;
        private System.Windows.Forms.DateTimePicker dtpHoraIni;
        private System.Windows.Forms.Label lblHoraIni;
        private System.Windows.Forms.Label lblHoraFinal;
        private System.Windows.Forms.DateTimePicker dtpHoraFinal;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.GroupBox gpbAno;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConf;
    }
}