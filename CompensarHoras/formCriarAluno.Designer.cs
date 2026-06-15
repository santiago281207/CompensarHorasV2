namespace CompensarHoras
{
    partial class formCriarAluno
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
            this.components = new System.ComponentModel.Container();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblHoraIncial = new System.Windows.Forms.Label();
            this.lblDisciplina = new System.Windows.Forms.Label();
            this.lblHoraFinal = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblAnoLetivo = new System.Windows.Forms.Label();
            this.lblTrimestre = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtAnoLetivo = new System.Windows.Forms.TextBox();
            this.cmbDisciplina = new System.Windows.Forms.ComboBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraIncial = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraFinal = new System.Windows.Forms.DateTimePicker();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtTurma = new System.Windows.Forms.TextBox();
            this.lblTurma = new System.Windows.Forms.Label();
            this.ttDicas = new System.Windows.Forms.ToolTip(this.components);
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(175, 41);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(149, 22);
            this.txtNome.TabIndex = 0;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(171, 21);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(44, 16);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(333, 80);
            this.lblData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(36, 16);
            this.lblData.TabIndex = 3;
            this.lblData.Text = "Data";
            // 
            // lblHoraIncial
            // 
            this.lblHoraIncial.AutoSize = true;
            this.lblHoraIncial.Location = new System.Drawing.Point(12, 144);
            this.lblHoraIncial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHoraIncial.Name = "lblHoraIncial";
            this.lblHoraIncial.Size = new System.Drawing.Size(74, 16);
            this.lblHoraIncial.TabIndex = 4;
            this.lblHoraIncial.Text = "Hora Inicial";
            // 
            // lblDisciplina
            // 
            this.lblDisciplina.AutoSize = true;
            this.lblDisciplina.Location = new System.Drawing.Point(12, 80);
            this.lblDisciplina.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDisciplina.Name = "lblDisciplina";
            this.lblDisciplina.Size = new System.Drawing.Size(66, 16);
            this.lblDisciplina.TabIndex = 5;
            this.lblDisciplina.Text = "Disciplina";
            // 
            // lblHoraFinal
            // 
            this.lblHoraFinal.AutoSize = true;
            this.lblHoraFinal.Location = new System.Drawing.Point(211, 150);
            this.lblHoraFinal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHoraFinal.Name = "lblHoraFinal";
            this.lblHoraFinal.Size = new System.Drawing.Size(69, 16);
            this.lblHoraFinal.TabIndex = 6;
            this.lblHoraFinal.Text = "Hora Final";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(404, 150);
            this.lblSaldo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(43, 16);
            this.lblSaldo.TabIndex = 7;
            this.lblSaldo.Text = "Saldo";
            // 
            // lblAnoLetivo
            // 
            this.lblAnoLetivo.AutoSize = true;
            this.lblAnoLetivo.Location = new System.Drawing.Point(329, 21);
            this.lblAnoLetivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnoLetivo.Name = "lblAnoLetivo";
            this.lblAnoLetivo.Size = new System.Drawing.Size(133, 16);
            this.lblAnoLetivo.TabIndex = 8;
            this.lblAnoLetivo.Text = "Ano Letivo (xxxx/xxxx)";
            // 
            // lblTrimestre
            // 
            this.lblTrimestre.AutoSize = true;
            this.lblTrimestre.Location = new System.Drawing.Point(488, 21);
            this.lblTrimestre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTrimestre.Name = "lblTrimestre";
            this.lblTrimestre.Size = new System.Drawing.Size(64, 16);
            this.lblTrimestre.TabIndex = 9;
            this.lblTrimestre.Text = "Trimestre";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(171, 80);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(127, 16);
            this.lblTipo.TabIndex = 10;
            this.lblTipo.Text = "Tipo Compensação";
            // 
            // txtAnoLetivo
            // 
            this.txtAnoLetivo.Location = new System.Drawing.Point(333, 41);
            this.txtAnoLetivo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAnoLetivo.MaxLength = 9;
            this.txtAnoLetivo.Name = "txtAnoLetivo";
            this.txtAnoLetivo.Size = new System.Drawing.Size(149, 22);
            this.txtAnoLetivo.TabIndex = 11;
            this.txtAnoLetivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnoLetivo_KeyPress);
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
            this.cmbDisciplina.Location = new System.Drawing.Point(16, 100);
            this.cmbDisciplina.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbDisciplina.Name = "cmbDisciplina";
            this.cmbDisciplina.Size = new System.Drawing.Size(136, 24);
            this.cmbDisciplina.TabIndex = 13;
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(337, 100);
            this.dtpData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpData.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpData.MinDate = new System.DateTime(2026, 6, 10, 0, 0, 0, 0);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(184, 22);
            this.dtpData.TabIndex = 15;
            // 
            // dtpHoraIncial
            // 
            this.dtpHoraIncial.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraIncial.Location = new System.Drawing.Point(16, 170);
            this.dtpHoraIncial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpHoraIncial.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpHoraIncial.MinDate = new System.DateTime(2026, 6, 10, 0, 0, 0, 0);
            this.dtpHoraIncial.Name = "dtpHoraIncial";
            this.dtpHoraIncial.Size = new System.Drawing.Size(184, 22);
            this.dtpHoraIncial.TabIndex = 16;
            this.dtpHoraIncial.Value = new System.DateTime(2026, 6, 10, 0, 0, 0, 0);
            // 
            // dtpHoraFinal
            // 
            this.dtpHoraFinal.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraFinal.Location = new System.Drawing.Point(211, 170);
            this.dtpHoraFinal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpHoraFinal.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpHoraFinal.MinDate = new System.DateTime(2026, 6, 10, 0, 0, 0, 0);
            this.dtpHoraFinal.Name = "dtpHoraFinal";
            this.dtpHoraFinal.Size = new System.Drawing.Size(184, 22);
            this.dtpHoraFinal.TabIndex = 17;
            this.dtpHoraFinal.Value = new System.DateTime(2026, 6, 10, 0, 0, 0, 0);
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(408, 170);
            this.txtSaldo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(113, 22);
            this.txtSaldo.TabIndex = 18;
            this.ttDicas.SetToolTip(this.txtSaldo, "Saldo de horas para compensar");
            this.txtSaldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSaldo_KeyPress);
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(16, 21);
            this.lblNumero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(92, 16);
            this.lblNumero.TabIndex = 19;
            this.lblNumero.Text = "Número Aluno";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(16, 41);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumero.MaxLength = 6;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(149, 22);
            this.txtNumero.TabIndex = 20;
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(16, 209);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(100, 38);
            this.btnEnviar.TabIndex = 21;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(584, 201);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 38);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtTurma
            // 
            this.txtTurma.Location = new System.Drawing.Point(535, 100);
            this.txtTurma.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTurma.MaxLength = 4;
            this.txtTurma.Name = "txtTurma";
            this.txtTurma.Size = new System.Drawing.Size(149, 22);
            this.txtTurma.TabIndex = 23;
            this.ttDicas.SetToolTip(this.txtTurma, "XX - Ano do curso xx - Turma");
            // 
            // lblTurma
            // 
            this.lblTurma.AutoSize = true;
            this.lblTurma.Location = new System.Drawing.Point(531, 80);
            this.lblTurma.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTurma.Name = "lblTurma";
            this.lblTurma.Size = new System.Drawing.Size(46, 16);
            this.lblTurma.TabIndex = 24;
            this.lblTurma.Text = "Turma\r\n";
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "PAIR",
            "NORMAL"});
            this.cmbTipo.Location = new System.Drawing.Point(174, 102);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(150, 24);
            this.cmbTipo.TabIndex = 25;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(491, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 26;
            // 
            // formCriarAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 252);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.lblTurma);
            this.Controls.Add(this.txtTurma);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.dtpHoraFinal);
            this.Controls.Add(this.dtpHoraIncial);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.cmbDisciplina);
            this.Controls.Add(this.txtAnoLetivo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblTrimestre);
            this.Controls.Add(this.lblAnoLetivo);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.lblHoraFinal);
            this.Controls.Add(this.lblDisciplina);
            this.Controls.Add(this.lblHoraIncial);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimizeBox = false;
            this.Name = "formCriarAluno";
            this.Text = "Criar Aluno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblHoraIncial;
        private System.Windows.Forms.Label lblDisciplina;
        private System.Windows.Forms.Label lblHoraFinal;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblAnoLetivo;
        private System.Windows.Forms.Label lblTrimestre;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtAnoLetivo;
        private System.Windows.Forms.ComboBox cmbDisciplina;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.DateTimePicker dtpHoraIncial;
        private System.Windows.Forms.DateTimePicker dtpHoraFinal;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ToolTip ttDicas;
        private System.Windows.Forms.TextBox txtTurma;
        private System.Windows.Forms.Label lblTurma;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}