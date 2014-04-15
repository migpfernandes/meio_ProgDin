using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace meioTp1_ProgDin
{
    public partial class uscResultadoConcorrente : UserControl
    {
        public uscResultadoConcorrente(decimal[] Vn, decimal[] Fn)
        {
            InitializeComponent();
            fillGrid(Vn, Fn);
            this.AutoScroll = true;
        }

        private void fillGrid(decimal[] Vn, decimal[] Fn)
        {
            int index;

            for (int i = 0; i < Vn.Length; i++)
            {
                index = dgvVn.Rows.Add();
                dgvVn.Rows[index].Cells[0].Value = Vn[i];
                if (Vn[i] == Fn[i]) dgvVn.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
                dgvVn.Rows[i].DefaultCellStyle.SelectionBackColor = dgvVn.Rows[i].DefaultCellStyle.BackColor;
                dgvVn.Rows[i].DefaultCellStyle.SelectionForeColor = dgvVn.Rows[i].DefaultCellStyle.ForeColor;
            }
            dgvVn.AutoSize = true;
        }
    }
}
