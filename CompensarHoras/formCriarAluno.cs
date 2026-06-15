using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CompensacaoHoras;
using CompensarHoras;

namespace CompensarHoras
{
    public partial class formCriarAluno : Form
    {
        private Form1 form1;
        public formCriarAluno(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            cmbDisciplina.SelectedIndex = 0;
            cmbTipo.SelectedIndex = 0;
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar < 'a' || e.KeyChar > 'z') && (e.KeyChar < 'A' || e.KeyChar > 'Z') && (e.KeyChar != '-' && e.KeyChar != ' ' && e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void txtAnoLetivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8 || e.KeyChar == '/');
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        { 
            this.Close();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    if (string.IsNullOrWhiteSpace(c.Text))
                    {
                        MessageBox.Show("Necessita preencher todos os campos primeiro!","Erro de inserção",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        return;
                    }
                }else if(c is ComboBox)
                {
                    if(c is ComboBox cb && cb.SelectedIndex == -1)
                    {
                        MessageBox.Show("Necessita preencher todos os campos primeiro!", "Erro de inserção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            Aluno aluno = new Aluno();
            aluno.Numero = int.Parse(txtNumero.Text);
            aluno.Nome = txtNome.Text;
            aluno.Turma = txtTurma.Text;

            aluno.AddCompensar(aluno.ACompensar, (Disciplina)cmbDisciplina.SelectedIndex, cmbTipo.Text);
            aluno.AddCompensar(aluno.ACompensar,int.Parse(txt);

            form1.Alunos[form1.QuantidadeAlunos] = aluno;
        }
        
        private void txtSaldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8);
        }
    }
}
