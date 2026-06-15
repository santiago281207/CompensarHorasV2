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
        public formApagarAluno()
        {
            InitializeComponent();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tem serteza que quer apagar aluno?", "Apagar Aluno", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void formApagarAluno_Load(object sender, EventArgs e)
        {
            
        }
    }
}
