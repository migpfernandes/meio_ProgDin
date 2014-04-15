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
    public partial class uscResultadoFinal : UserControl
    {
        public uscResultadoFinal(IterationResults result)
        {
            InitializeComponent();
            lblResultado.Text = "Resultados após " + result.Iteration.ToString() + " iterações:";
            lblResultado.AutoSize = true;
            fillGrid(result);
            this.AutoScroll = true;
        }

        private void fillGrid(IterationResults result)
        {
            int index;
            List<int> concorrentes;

            for (int i = 0; i < result.Fn.Length; i++)
            {
                index = dgvFn.Rows.Add();
                dgvFn.Rows[index].Cells[dgvFn_Fn.Index].Value = result.Fn[i];
                dgvFn.Rows[index].Cells[dgvFn_DeltaFn.Index].Value = result.DiffFn[i];

                concorrentes = new List<int>();
                for(int j = 0;j < result.Fn.Length;j++){
                    if (result.Vn[j][i] == result.Fn[i]) concorrentes.Add(j+1);
                }
                dgvFn.Rows[index].Cells[dgvFn_Concorrentes.Index].Value = string.Join(", ",concorrentes.ToArray());
            }
            dgvFn.AutoSize = true;
        }
    }
}
