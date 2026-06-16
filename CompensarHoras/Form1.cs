using CompensacaoHoras;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompensarHoras
{
    

    public partial class Form1 : Form
    {
        Registos registos = new Registos();
        public Aluno[] Alunos = new Aluno[30];
        
        public int QuantidadeAlunos
        {
            get { return qtdAlunos; }
            set { qtdAlunos = value; }
        }


        public Form1()
        {
            Alunos[0] = new Aluno();
            Alunos[0].Nome = "Aluno1";
            Alunos[0].Numero = 123456;
            Alunos[0].Turma = "Tgpsi";
            InitializeComponent();
        }



        private void criarALunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCriarAluno criarAluno = new formCriarAluno();
            criarAluno.Show();

        }

        private void registrarHorasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void totalHorasAlunoACompensarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mostrarAInformaçãoDeTodosOsAlunosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //=================//
        private void apagarAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = Form1OneSelectedItem;
            if(i == -1) 
            {
                MessageBox.Show("Deve selecionar so um aluno.", "Apagar Aluno", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            formApagarAluno novoForm = new formApagarAluno(Alunos[i]);
            novoForm.ShowDialog();
            if (novoForm.Apagar)
            {
                lvwAlunos.Items.RemoveAt(Form1OneSelectedItem);
            }
            novoForm.Dispose();
        }

        private void registoDeCompensaçãoDeHorasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formRegistoCompensado newForm = new formRegistoCompensado(Alunos);
            newForm.ShowDialog();

        }

        private void totalHorasACompensarAnoLetivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mostrarAInformaçãoDeUmAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        public ListViewItem Form1ListviewItem
        {
            get { return (ListViewItem)lvwAlunos.FocusedItem.Clone(); }
        }

        public int Form1OneSelectedItem
        {
            get
            {
                if(lvwAlunos.SelectedItems.Count != 1)
                {
                    return -1;
                }
                else
                {
                    return lvwAlunos.SelectedIndices[0];
                }
            }
        }

        public void AtualizarListView()
        {
            lvwAlunos.Items.Clear();
            for(int i=0;i < qtdAlunos;i++)
            {
                ListViewItem item = new ListViewItem();
                item.Text = registos.Alunos[0].Nome;
            }
        }
    }
}
