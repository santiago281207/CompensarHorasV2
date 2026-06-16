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
using System.Text.RegularExpressions;

namespace CompensarHoras
{
    public partial class formRegistarHorasCompensar : Form
    {
        Registos registos;
        Form1 form;
        public formRegistarHorasCompensar(Form1 form1,Registos registos)
        {
            InitializeComponent();
            this.registos = registos;
            this.form = form1;
        }


        private void formRegistarHorasCompensar_Load(object sender, EventArgs e)
        {

            for(int i = 0;i < registos.QuantidadeAlunos;i++)
            {
                cmbAluno.Items.Add(registos.NameAluno(i));
            }

            cmbTrimestre.SelectedIndex = 0;
            cmbTipo.SelectedIndex = 0;
            cmbDisciplina.SelectedIndex = 0;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtAnoLetivo.Text, @"^\d{4}/\d{4}$"))
            {
                MessageBox.Show("Formato inválido. Use xxxx/xxxx",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            // separar os anos
            int ano1 = int.Parse(txtAnoLetivo.Text.Substring(0, 4));
            int ano2 = int.Parse(txtAnoLetivo.Text.Substring(5, 4));

            // validar sequência se ano2 e o proximo ano do primeiro
            if (ano2 != ano1 + 1)
            {
                MessageBox.Show("O segundo ano tem de ser o seguinte ao primeiro (ex: 2024/2025).",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            /*Note ainda que se já existir um registo para essa disciplina/trimestre/ano lectivo/tipo, a
                acção é cancelada.
            */

            int indexAluno = registos.IndexPorNome(cmbAluno.SelectedItem.ToString());
            int checkValidRegisto = registos.AlunoCheck(indexAluno).CheckRegistoCompensar(indexAluno, (Disciplina)cmbDisciplina.SelectedIndex, int.Parse(cmbTrimestre.SelectedItem.ToString()), txtAnoLetivo.Text, cmbTipo.SelectedItem.ToString());
            
            if(checkValidRegisto == -1)
            {
                MessageBox.Show("Já existe um registo igual!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            {
                MessageBox.Show("Registo adicionado com sucesso!", "Sucesso na inserção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                ListViewItem lvi = new ListViewItem();
                lvi.Text = registos.NameAluno(indexAluno);

                ListViewItem.ListViewSubItem lvsi1 = new ListViewItem.ListViewSubItem();
                lvsi1.Text = txtAnoLetivo.Text;

                ListViewItem.ListViewSubItem lvsi2 = new ListViewItem.ListViewSubItem();
                lvsi2.Text = cmbTrimestre.SelectedItem.ToString();

                ListViewItem.ListViewSubItem lvsi3 = new ListViewItem.ListViewSubItem();
                lvsi3.Text = cmbDisciplina.SelectedItem.ToString();

                ListViewItem.ListViewSubItem lvsi4 = new ListViewItem.ListViewSubItem();
                lvsi4.Text = cmbTipo.SelectedItem.ToString();

                ListViewItem.ListViewSubItem lvsi5 = new ListViewItem.ListViewSubItem();
                lvsi5.Text = cmbDisciplina.Text = dtpData.Value.ToString();

                ListViewItem.ListViewSubItem lvsi6 = new ListViewItem.ListViewSubItem();
                lvsi6.Text = dtpHoraIncial.Value.ToString("HH:mm:ss");

                ListViewItem.ListViewSubItem lvsi7 = new ListViewItem.ListViewSubItem();
                lvsi7.Text = dtpHoraFinal.Value.ToString("HH:mm:ss");

                ListViewItem.ListViewSubItem lvsi8 = new ListViewItem.ListViewSubItem();
                lvsi8.Text = txtSaldo.Text;

                lvi.SubItems.Add(lvsi1);
                lvi.SubItems.Add(lvsi2);
                lvi.SubItems.Add(lvsi3);
                lvi.SubItems.Add(lvsi4);
                lvi.SubItems.Add(lvsi5);
                lvi.SubItems.Add(lvsi6);
                lvi.SubItems.Add(lvsi7);
                lvi.SubItems.Add(lvsi8);

                form.lvwAlunos.Items.Add(lvi);
            }

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
