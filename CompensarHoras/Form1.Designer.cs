namespace CompensarHoras
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Aluno",
            "123456",
            "1",
            "PSI",
            "PAIR",
            "1/1/2026",
            "8:30",
            "9:30",
            "20$"}, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lvwAlunos = new System.Windows.Forms.ListView();
            this.chNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAnoLetivo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTrimestre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDisciplina = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chHoraIncial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chHoraFinal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSaldo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.mnuAluno = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCriarAluno = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuApagarAluno = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoras = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRegistarHoras = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRegistarCompensacao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFerramentas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTotalHorasAluno = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTotalAnoLetivo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVista = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuInfoTodosAlunos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuInfoAluno = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwAlunos
            // 
            this.lvwAlunos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvwAlunos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNome,
            this.chAnoLetivo,
            this.chTrimestre,
            this.chDisciplina,
            this.chTipo,
            this.chData,
            this.chHoraIncial,
            this.chHoraFinal,
            this.chSaldo});
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "Nome";
            listViewGroup2.Header = "ListViewGroup";
            listViewGroup2.Name = "listViewGroup1";
            this.lvwAlunos.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.lvwAlunos.HideSelection = false;
            this.lvwAlunos.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lvwAlunos.Location = new System.Drawing.Point(16, 58);
            this.lvwAlunos.Margin = new System.Windows.Forms.Padding(2);
            this.lvwAlunos.Name = "lvwAlunos";
            this.lvwAlunos.Size = new System.Drawing.Size(846, 289);
            this.lvwAlunos.TabIndex = 0;
            this.lvwAlunos.UseCompatibleStateImageBehavior = false;
            this.lvwAlunos.View = System.Windows.Forms.View.Details;
            // 
            // chNome
            // 
            this.chNome.Text = "Nome";
            this.chNome.Width = 120;
            // 
            // chAnoLetivo
            // 
            this.chAnoLetivo.Text = "Ano Letivo";
            this.chAnoLetivo.Width = 75;
            // 
            // chTrimestre
            // 
            this.chTrimestre.Text = "Trimestre";
            this.chTrimestre.Width = 70;
            // 
            // chDisciplina
            // 
            this.chDisciplina.Text = "Disciplina";
            this.chDisciplina.Width = 75;
            // 
            // chTipo
            // 
            this.chTipo.Text = "Tipo";
            // 
            // chData
            // 
            this.chData.Text = "Data";
            this.chData.Width = 80;
            // 
            // chHoraIncial
            // 
            this.chHoraIncial.Text = "Hora Inicial";
            this.chHoraIncial.Width = 80;
            // 
            // chHoraFinal
            // 
            this.chHoraFinal.Text = "Hora Final";
            this.chHoraFinal.Width = 80;
            // 
            // chSaldo
            // 
            this.chSaldo.Text = "Saldo";
            // 
            // msMenu
            // 
            this.msMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAluno,
            this.mnuHoras,
            this.mnuFerramentas,
            this.mnuVista});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.msMenu.Size = new System.Drawing.Size(878, 24);
            this.msMenu.TabIndex = 1;
            this.msMenu.Text = "Menu";
            // 
            // mnuAluno
            // 
            this.mnuAluno.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCriarAluno,
            this.mnuApagarAluno});
            this.mnuAluno.Name = "mnuAluno";
            this.mnuAluno.Size = new System.Drawing.Size(56, 20);
            this.mnuAluno.Text = "Alunos";
            // 
            // mnuCriarAluno
            // 
            this.mnuCriarAluno.Name = "mnuCriarAluno";
            this.mnuCriarAluno.Size = new System.Drawing.Size(147, 22);
            this.mnuCriarAluno.Text = "Criar Aluno";
            this.mnuCriarAluno.Click += new System.EventHandler(this.criarALunoToolStripMenuItem_Click);
            // 
            // mnuApagarAluno
            // 
            this.mnuApagarAluno.Name = "mnuApagarAluno";
            this.mnuApagarAluno.Size = new System.Drawing.Size(147, 22);
            this.mnuApagarAluno.Text = "Apagar Aluno";
            this.mnuApagarAluno.Click += new System.EventHandler(this.apagarAlunoToolStripMenuItem_Click);
            // 
            // mnuHoras
            // 
            this.mnuHoras.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRegistarHoras,
            this.mnuRegistarCompensacao});
            this.mnuHoras.Name = "mnuHoras";
            this.mnuHoras.Size = new System.Drawing.Size(50, 20);
            this.mnuHoras.Text = "Horas";
            // 
            // mnuRegistarHoras
            // 
            this.mnuRegistarHoras.Name = "mnuRegistarHoras";
            this.mnuRegistarHoras.Size = new System.Drawing.Size(241, 22);
            this.mnuRegistarHoras.Text = "Registrar horas a compensar";
            this.mnuRegistarHoras.Click += new System.EventHandler(this.registrarHorasToolStripMenuItem_Click);
            // 
            // mnuRegistarCompensacao
            // 
            this.mnuRegistarCompensacao.Name = "mnuRegistarCompensacao";
            this.mnuRegistarCompensacao.Size = new System.Drawing.Size(241, 22);
            this.mnuRegistarCompensacao.Text = "Registar compensação de horas";
            this.mnuRegistarCompensacao.Click += new System.EventHandler(this.registoDeCompensaçãoDeHorasToolStripMenuItem_Click);
            // 
            // mnuFerramentas
            // 
            this.mnuFerramentas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTotalHorasAluno,
            this.mnuTotalAnoLetivo});
            this.mnuFerramentas.Name = "mnuFerramentas";
            this.mnuFerramentas.Size = new System.Drawing.Size(84, 20);
            this.mnuFerramentas.Text = "Ferramentas";
            // 
            // mnuTotalHorasAluno
            // 
            this.mnuTotalHorasAluno.Name = "mnuTotalHorasAluno";
            this.mnuTotalHorasAluno.Size = new System.Drawing.Size(344, 22);
            this.mnuTotalHorasAluno.Text = "Total horas a compensar de um aluno";
            this.mnuTotalHorasAluno.Click += new System.EventHandler(this.totalHorasAlunoACompensarToolStripMenuItem_Click);
            // 
            // mnuTotalAnoLetivo
            // 
            this.mnuTotalAnoLetivo.Name = "mnuTotalAnoLetivo";
            this.mnuTotalAnoLetivo.Size = new System.Drawing.Size(344, 22);
            this.mnuTotalAnoLetivo.Text = "Total horas a compensar num ano lectivo/trimestre";
            this.mnuTotalAnoLetivo.Click += new System.EventHandler(this.totalHorasACompensarAnoLetivoToolStripMenuItem_Click);
            // 
            // mnuVista
            // 
            this.mnuVista.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuInfoTodosAlunos,
            this.mnuInfoAluno});
            this.mnuVista.Name = "mnuVista";
            this.mnuVista.Size = new System.Drawing.Size(44, 20);
            this.mnuVista.Text = "Vista";
            // 
            // mnuInfoTodosAlunos
            // 
            this.mnuInfoTodosAlunos.Name = "mnuInfoTodosAlunos";
            this.mnuInfoTodosAlunos.Size = new System.Drawing.Size(290, 22);
            this.mnuInfoTodosAlunos.Text = "Mostrar a informação de todos os alunos";
            this.mnuInfoTodosAlunos.Click += new System.EventHandler(this.mostrarAInformaçãoDeTodosOsAlunosToolStripMenuItem_Click);
            // 
            // mnuInfoAluno
            // 
            this.mnuInfoAluno.Name = "mnuInfoAluno";
            this.mnuInfoAluno.Size = new System.Drawing.Size(290, 22);
            this.mnuInfoAluno.Text = "Mostrar a informação de um aluno";
            this.mnuInfoAluno.Click += new System.EventHandler(this.mostrarAInformaçãoDeUmAlunoToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 366);
            this.Controls.Add(this.lvwAlunos);
            this.Controls.Add(this.msMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMenu;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Compensar Horas";
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvwAlunos;
        private System.Windows.Forms.ColumnHeader chNome;
        private System.Windows.Forms.ColumnHeader chAnoLetivo;
        private System.Windows.Forms.ColumnHeader chTrimestre;
        private System.Windows.Forms.ColumnHeader chDisciplina;
        private System.Windows.Forms.ColumnHeader chTipo;
        private System.Windows.Forms.ColumnHeader chData;
        private System.Windows.Forms.ColumnHeader chHoraIncial;
        private System.Windows.Forms.ColumnHeader chHoraFinal;
        private System.Windows.Forms.ColumnHeader chSaldo;
        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuAluno;
        private System.Windows.Forms.ToolStripMenuItem mnuHoras;
        private System.Windows.Forms.ToolStripMenuItem mnuFerramentas;
        private System.Windows.Forms.ToolStripMenuItem mnuVista;
        private System.Windows.Forms.ToolStripMenuItem mnuCriarAluno;
        private System.Windows.Forms.ToolStripMenuItem mnuApagarAluno;
        private System.Windows.Forms.ToolStripMenuItem mnuRegistarHoras;
        private System.Windows.Forms.ToolStripMenuItem mnuRegistarCompensacao;
        private System.Windows.Forms.ToolStripMenuItem mnuTotalHorasAluno;
        private System.Windows.Forms.ToolStripMenuItem mnuTotalAnoLetivo;
        private System.Windows.Forms.ToolStripMenuItem mnuInfoTodosAlunos;
        private System.Windows.Forms.ToolStripMenuItem mnuInfoAluno;
    }
}

