namespace CompensarHoras
{
    partial class formRegistarHorasCompensar
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
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.lblTrimestre = new System.Windows.Forms.Label();
            this.cmbTrimestre = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpHoraIncial = new System.Windows.Forms.DateTimePicker();
            this.lblHoraFinal = new System.Windows.Forms.Label();
            this.dtpHoraFinal = new System.Windows.Forms.DateTimePicker();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.lblDisciplina = new System.Windows.Forms.Label();
            this.cmbDisciplina = new System.Windows.Forms.ComboBox();
            this.lblAnoLetivo = new System.Windows.Forms.Label();
            this.txtAnoLetivo = new System.Windows.Forms.TextBox();
            this.cmbAluno = new System.Windows.Forms.ComboBox();
            this.lblAluno = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "PAIR",
            "Normal"});
            this.cmbTipo.Location = new System.Drawing.Point(12, 72);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbTipo.TabIndex = 26;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(9, 56);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(99, 13);
            this.lblTipo.TabIndex = 27;
            this.lblTipo.Text = "Tipo Compensação";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(139, 56);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(30, 13);
            this.lblData.TabIndex = 28;
            this.lblData.Text = "Data";
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(139, 73);
            this.dtpData.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpData.MinDate = new System.DateTime(2026, 6, 10, 0, 0, 0, 0);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(139, 20);
            this.dtpData.TabIndex = 29;
            // 
            // lblTrimestre
            // 
            this.lblTrimestre.AutoSize = true;
            this.lblTrimestre.Location = new System.Drawing.Point(260, 5);
            this.lblTrimestre.Name = "lblTrimestre";
            this.lblTrimestre.Size = new System.Drawing.Size(50, 13);
            this.lblTrimestre.TabIndex = 30;
            this.lblTrimestre.Text = "Trimestre";
            // 
            // cmbTrimestre
            // 
            this.cmbTrimestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTrimestre.FormattingEnabled = true;
            this.cmbTrimestre.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbTrimestre.Location = new System.Drawing.Point(263, 22);
            this.cmbTrimestre.Name = "cmbTrimestre";
            this.cmbTrimestre.Size = new System.Drawing.Size(121, 21);
            this.cmbTrimestre.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Hora Inicial";
            // 
            // dtpHoraIncial
            // 
            this.dtpHoraIncial.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraIncial.Location = new System.Drawing.Point(277, 122);
            this.dtpHoraIncial.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpHoraIncial.MinDate = new System.DateTime(2026, 6, 10, 0, 0, 0, 0);
            this.dtpHoraIncial.Name = "dtpHoraIncial";
            this.dtpHoraIncial.Size = new System.Drawing.Size(139, 20);
            this.dtpHoraIncial.TabIndex = 33;
            this.dtpHoraIncial.Value = new System.DateTime(2026, 6, 10, 0, 0, 0, 0);
            // 
            // lblHoraFinal
            // 
            this.lblHoraFinal.AutoSize = true;
            this.lblHoraFinal.Location = new System.Drawing.Point(9, 105);
            this.lblHoraFinal.Name = "lblHoraFinal";
            this.lblHoraFinal.Size = new System.Drawing.Size(55, 13);
            this.lblHoraFinal.TabIndex = 34;
            this.lblHoraFinal.Text = "Hora Final";
            // 
            // dtpHoraFinal
            // 
            this.dtpHoraFinal.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraFinal.Location = new System.Drawing.Point(12, 121);
            this.dtpHoraFinal.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpHoraFinal.MinDate = new System.DateTime(2026, 6, 10, 0, 0, 0, 0);
            this.dtpHoraFinal.Name = "dtpHoraFinal";
            this.dtpHoraFinal.Size = new System.Drawing.Size(139, 20);
            this.dtpHoraFinal.TabIndex = 35;
            this.dtpHoraFinal.Value = new System.DateTime(2026, 6, 10, 0, 0, 0, 0);
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(284, 56);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(34, 13);
            this.lblSaldo.TabIndex = 36;
            this.lblSaldo.Text = "Saldo";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(287, 73);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(113, 20);
            this.txtSaldo.TabIndex = 37;
            // 
            // lblDisciplina
            // 
            this.lblDisciplina.AutoSize = true;
            this.lblDisciplina.Location = new System.Drawing.Point(154, 105);
            this.lblDisciplina.Name = "lblDisciplina";
            this.lblDisciplina.Size = new System.Drawing.Size(52, 13);
            this.lblDisciplina.TabIndex = 38;
            this.lblDisciplina.Text = "Disciplina";
            // 
            // cmbDisciplina
            // 
            this.cmbDisciplina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDisciplina.FormattingEnabled = true;
            this.cmbDisciplina.Items.AddRange(new object[] {
            "PSI",
            "PT",
            "ING",
            "RC",
            "AC",
            "MAT",
            "TIC",
            "FQ",
            "SO"});
            this.cmbDisciplina.Location = new System.Drawing.Point(157, 121);
            this.cmbDisciplina.Name = "cmbDisciplina";
            this.cmbDisciplina.Size = new System.Drawing.Size(103, 21);
            this.cmbDisciplina.TabIndex = 39;
            // 
            // lblAnoLetivo
            // 
            this.lblAnoLetivo.AutoSize = true;
            this.lblAnoLetivo.Location = new System.Drawing.Point(142, 5);
            this.lblAnoLetivo.Name = "lblAnoLetivo";
            this.lblAnoLetivo.Size = new System.Drawing.Size(112, 13);
            this.lblAnoLetivo.TabIndex = 40;
            this.lblAnoLetivo.Text = "Ano Letivo (xxxx/xxxx)";
            // 
            // txtAnoLetivo
            // 
            this.txtAnoLetivo.Location = new System.Drawing.Point(145, 22);
            this.txtAnoLetivo.MaxLength = 9;
            this.txtAnoLetivo.Name = "txtAnoLetivo";
            this.txtAnoLetivo.Size = new System.Drawing.Size(113, 20);
            this.txtAnoLetivo.TabIndex = 41;
            // 
            // cmbAluno
            // 
            this.cmbAluno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAluno.FormattingEnabled = true;
            this.cmbAluno.Location = new System.Drawing.Point(12, 22);
            this.cmbAluno.Name = "cmbAluno";
            this.cmbAluno.Size = new System.Drawing.Size(121, 21);
            this.cmbAluno.TabIndex = 42;
            // 
            // lblAluno
            // 
            this.lblAluno.AutoSize = true;
            this.lblAluno.Location = new System.Drawing.Point(12, 9);
            this.lblAluno.Name = "lblAluno";
            this.lblAluno.Size = new System.Drawing.Size(34, 13);
            this.lblAluno.TabIndex = 43;
            this.lblAluno.Text = "Aluno";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(325, 162);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 23);
            this.btnCancel.TabIndex = 44;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(12, 162);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(91, 23);
            this.btnEnviar.TabIndex = 45;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // formRegistarHorasCompensar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 197);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblAluno);
            this.Controls.Add(this.cmbAluno);
            this.Controls.Add(this.txtAnoLetivo);
            this.Controls.Add(this.lblAnoLetivo);
            this.Controls.Add(this.cmbDisciplina);
            this.Controls.Add(this.lblDisciplina);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.dtpHoraFinal);
            this.Controls.Add(this.lblHoraFinal);
            this.Controls.Add(this.dtpHoraIncial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbTrimestre);
            this.Controls.Add(this.lblTrimestre);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.cmbTipo);
            this.Name = "formRegistarHorasCompensar";
            this.Text = "Registar horas compensar";
            this.Load += new System.EventHandler(this.formRegistarHorasCompensar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label lblTrimestre;
        private System.Windows.Forms.ComboBox cmbTrimestre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpHoraIncial;
        private System.Windows.Forms.Label lblHoraFinal;
        private System.Windows.Forms.DateTimePicker dtpHoraFinal;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label lblDisciplina;
        private System.Windows.Forms.ComboBox cmbDisciplina;
        private System.Windows.Forms.Label lblAnoLetivo;
        private System.Windows.Forms.TextBox txtAnoLetivo;
        private System.Windows.Forms.ComboBox cmbAluno;
        private System.Windows.Forms.Label lblAluno;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEnviar;
    }
}