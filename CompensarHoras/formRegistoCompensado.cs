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
        public formRegistoCompensado()
        {
            InitializeComponent();
        }

        private void formRegistoCompensado_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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
            }
        }

        private void dtpData_ValueChanged(object sender, EventArgs e)
        {
            if (dtpData.Value > DateTime.Now)
            {
                dtpData.Value = DateTime.Now;
            }
        }
    }
}
