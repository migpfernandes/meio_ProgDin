using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace meioTp1_ProgDin
{
    public partial class frmSolver : Form
    {
        private List<uscConcorrente> concorrentes = new List<uscConcorrente>();

        public frmSolver()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            uscConcorrente usc;
            int dimensao;
            try
            {
                Clear();

                dimensao = (int)nudDimensao.Value;

                for (int i = 1; i <= nudConcorrentes.Value; i++)
                {
                    usc = new uscConcorrente(dimensao);
                    usc.Dock = DockStyle.Fill;
                    tbcConcorrentes.TabPages.Add("Concorrente " + i.ToString());
                    tbcConcorrentes.TabPages[i - 1].AutoScroll = true;
                    tbcConcorrentes.TabPages[i - 1].Controls.Add(usc);
                    concorrentes.Add(usc);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            List<decimal[,]> projecoes = new List<decimal[,]>();
            List<decimal[,]> rendimentos = new List<decimal[,]>();
            List<IterationResults> res;
            try
            {
                foreach(uscConcorrente usc in concorrentes){
                    projecoes.Add(usc.getProjectionMatrix());
                    rendimentos.Add(usc.getWeightMatrix());
                }

                res = modProgDin.Calculate(projecoes, rendimentos, (int)nudDimensao.Value, (int)nudNumIteracoes.Value, Operation.Min);
                frmResultados frm = new frmResultados(res);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Clear()
        {
            tbcConcorrentes.TabPages.Clear();
            concorrentes.Clear();
        }
    }
}
