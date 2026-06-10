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


        public Form1()
        {
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
            

        }

        private void registoDeCompensaçãoDeHorasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void totalHorasACompensarAnoLetivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mostrarAInformaçãoDeUmAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
