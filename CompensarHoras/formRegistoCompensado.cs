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
    public partial class formRegistoCompensado : Form
    {
        private Aluno[] Form1Alunos;
        public formRegistoCompensado(Aluno[] alunos)
        {
            Form1Alunos = alunos;
            InitializeComponent();
        }

        private void formRegistoCompensado_Load(object sender, EventArgs e)
        {
            dtpAno.CustomFormat = $"{dtpAno.Value.Year - 1}/yyyy";
            ccbDisp.SelectedIndex = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtNum.Text.Length == 6)
            {
                foreach (Aluno aln in Form1Alunos)
                {
                    if (txtNum.Text == aln.Numero.ToString())
                    {
                        lblNome.Text = aln.Nome;
                        break;
                    }
                }
                lblNome.Text = "Aluno com este numero nao existe!";
            }
            else
            {   
                lblNome.Text = "-----";
            }
         }
        

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8);
        }

        private void dtpHoraIni_ValueChanged(object sender, EventArgs e)
        {
            if (dtpHoraIni.Value.AddMinutes(30) > dtpHoraFinal.Value)
            {
                dtpHoraFinal.Value = dtpHoraIni.Value.AddMinutes(30);
            }
        }

        private void dtpHoraFinal_ValueChanged(object sender, EventArgs e)
        {
            if (dtpHoraIni.Value.AddMinutes(30) > dtpHoraFinal.Value)
            {
                dtpHoraFinal.Value = dtpHoraIni.Value.AddMinutes(30);
                System.Media.SystemSounds.Exclamation.Play();
            }
        }

        private void dtpData_ValueChanged(object sender, EventArgs e)
        {
            if (dtpData.Value > DateTime.Now)
            {
                dtpData.Value = DateTime.Now;
                System.Media.SystemSounds.Exclamation.Play();
            }
        }

        private void dtpAno_ValueChanged(object sender, EventArgs e)
        {
            dtpAno.CustomFormat = $"{dtpAno.Value.Year - 1}/yyyy";
        }
    }
}
