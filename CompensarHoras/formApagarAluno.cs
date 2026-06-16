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
    public partial class formApagarAluno : Form
    {
        private Aluno alunoForm1;
        private bool apagar = false;
        public formApagarAluno(Aluno aluno)
        {
            alunoForm1 = aluno;
            InitializeComponent();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem serteza que quer apagar aluno?", "Apagar Aluno", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            apagar = (result == DialogResult.Yes);
            this.Close();
        }

        private void formApagarAluno_Load(object sender, EventArgs e)
        {
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public bool Apagar
        {
            get { return apagar; }
        }

        private void lblNum_Click(object sender, EventArgs e)
        {

        }
    }
}   
