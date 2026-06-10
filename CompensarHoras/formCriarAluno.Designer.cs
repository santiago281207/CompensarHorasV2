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
            this.label3 = new System.Windows.Forms.Label();
            this.lblDisciplina = new System.Windows.Forms.Label();
            this.lblHoraFinal = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblAnoLetivo = new System.Windows.Forms.Label();
            this.lblTrimestre = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtAnoLetivo = new System.Windows.Forms.TextBox();
            this.txtDisciplina = new System.Windows.Forms.TextBox();
            this.cmbDisciplina = new System.Windows.Forms.ComboBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
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
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(131, 33);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(113, 20);
            this.txtNome.TabIndex = 0;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(128, 17);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(250, 65);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(30, 13);
            this.lblData.TabIndex = 3;
            this.lblData.Text = "Data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hora Inicial";
            // 
            // lblDisciplina
            // 
            this.lblDisciplina.AutoSize = true;
            this.lblDisciplina.Location = new System.Drawing.Point(9, 65);
            this.lblDisciplina.Name = "lblDisciplina";
            this.lblDisciplina.Size = new System.Drawing.Size(52, 13);
            this.lblDisciplina.TabIndex = 5;
            this.lblDisciplina.Text = "Disciplina";
            // 
            // lblHoraFinal
            // 
            this.lblHoraFinal.AutoSize = true;
            this.lblHoraFinal.Location = new System.Drawing.Point(158, 122);
            this.lblHoraFinal.Name = "lblHoraFinal";
            this.lblHoraFinal.Size = new System.Drawing.Size(55, 13);
            this.lblHoraFinal.TabIndex = 6;
            this.lblHoraFinal.Text = "Hora Final";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(303, 122);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(34, 13);
            this.lblSaldo.TabIndex = 7;
            this.lblSaldo.Text = "Saldo";
            // 
            // lblAnoLetivo
            // 
            this.lblAnoLetivo.AutoSize = true;
            this.lblAnoLetivo.Location = new System.Drawing.Point(247, 17);
            this.lblAnoLetivo.Name = "lblAnoLetivo";
            this.lblAnoLetivo.Size = new System.Drawing.Size(112, 13);
            this.lblAnoLetivo.TabIndex = 8;
            this.lblAnoLetivo.Text = "Ano Letivo (xxxx/xxxx)";
            // 
            // lblTrimestre
            // 
            this.lblTrimestre.AutoSize = true;
            this.lblTrimestre.Location = new System.Drawing.Point(366, 17);
            this.lblTrimestre.Name = "lblTrimestre";
            this.lblTrimestre.Size = new System.Drawing.Size(50, 13);
            this.lblTrimestre.TabIndex = 9;
            this.lblTrimestre.Text = "Trimestre";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(128, 65);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(99, 13);
            this.lblTipo.TabIndex = 10;
            this.lblTipo.Text = "Tipo Compensação";
            // 
            // txtAnoLetivo
            // 
            this.txtAnoLetivo.Location = new System.Drawing.Point(250, 33);
            this.txtAnoLetivo.MaxLength = 9;
            this.txtAnoLetivo.Name = "txtAnoLetivo";
            this.txtAnoLetivo.Size = new System.Drawing.Size(113, 20);
            this.txtAnoLetivo.TabIndex = 11;
            this.txtAnoLetivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnoLetivo_KeyPress);
            // 
            // txtDisciplina
            // 
            this.txtDisciplina.Location = new System.Drawing.Point(369, 33);
            this.txtDisciplina.MaxLength = 1;
            this.txtDisciplina.Name = "txtDisciplina";
            this.txtDisciplina.Size = new System.Drawing.Size(113, 20);
            this.txtDisciplina.TabIndex = 12;
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
            this.cmbDisciplina.Location = new System.Drawing.Point(12, 81);
            this.cmbDisciplina.Name = "cmbDisciplina";
            this.cmbDisciplina.Size = new System.Drawing.Size(103, 21);
            this.cmbDisciplina.TabIndex = 13;
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(131, 81);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(113, 20);
            this.txtTipo.TabIndex = 14;
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(253, 81);
            this.dtpData.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpData.MinDate = new System.DateTime(2026, 6, 10, 0, 0, 0, 0);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(139, 20);
            this.dtpData.TabIndex = 15;
            // 
            // dtpHoraIncial
            // 
            this.dtpHoraIncial.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraIncial.Location = new System.Drawing.Point(12, 138);
            this.dtpHoraIncial.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpHoraIncial.MinDate = new System.DateTime(2026, 6, 10, 0, 0, 0, 0);
            this.dtpHoraIncial.Name = "dtpHoraIncial";
            this.dtpHoraIncial.Size = new System.Drawing.Size(139, 20);
            this.dtpHoraIncial.TabIndex = 16;
            this.dtpHoraIncial.Value = new System.DateTime(2026, 6, 10, 0, 0, 0, 0);
            // 
            // dtpHoraFinal
            // 
            this.dtpHoraFinal.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraFinal.Location = new System.Drawing.Point(158, 138);
            this.dtpHoraFinal.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpHoraFinal.MinDate = new System.DateTime(2026, 6, 10, 0, 0, 0, 0);
            this.dtpHoraFinal.Name = "dtpHoraFinal";
            this.dtpHoraFinal.Size = new System.Drawing.Size(139, 20);
            this.dtpHoraFinal.TabIndex = 17;
            this.dtpHoraFinal.Value = new System.DateTime(2026, 6, 10, 0, 0, 0, 0);
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(306, 138);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(113, 20);
            this.txtSaldo.TabIndex = 18;
            this.ttDicas.SetToolTip(this.txtSaldo, "Saldo de horas para compensar");
            this.txtSaldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSaldo_KeyPress);
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(12, 17);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(74, 13);
            this.lblNumero.TabIndex = 19;
            this.lblNumero.Text = "Número Aluno";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(12, 33);
            this.txtNumero.MaxLength = 6;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(113, 20);
            this.txtNumero.TabIndex = 20;
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(12, 170);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 31);
            this.btnEnviar.TabIndex = 21;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(439, 170);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 31);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtTurma
            // 
            this.txtTurma.Location = new System.Drawing.Point(401, 81);
            this.txtTurma.MaxLength = 4;
            this.txtTurma.Name = "txtTurma";
            this.txtTurma.Size = new System.Drawing.Size(113, 20);
            this.txtTurma.TabIndex = 23;
            this.ttDicas.SetToolTip(this.txtTurma, "XX - Ano do curso xx - Turma");
            // 
            // lblTurma
            // 
            this.lblTurma.AutoSize = true;
            this.lblTurma.Location = new System.Drawing.Point(398, 65);
            this.lblTurma.Name = "lblTurma";
            this.lblTurma.Size = new System.Drawing.Size(37, 13);
            this.lblTurma.TabIndex = 24;
            this.lblTurma.Text = "Turma\r\n";
            // 
            // formCriarAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 205);
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
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.cmbDisciplina);
            this.Controls.Add(this.txtDisciplina);
            this.Controls.Add(this.txtAnoLetivo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblTrimestre);
            this.Controls.Add(this.lblAnoLetivo);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.lblHoraFinal);
            this.Controls.Add(this.lblDisciplina);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDisciplina;
        private System.Windows.Forms.Label lblHoraFinal;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblAnoLetivo;
        private System.Windows.Forms.Label lblTrimestre;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtAnoLetivo;
        private System.Windows.Forms.TextBox txtDisciplina;
        private System.Windows.Forms.ComboBox cmbDisciplina;
        private System.Windows.Forms.TextBox txtTipo;
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
    }
}