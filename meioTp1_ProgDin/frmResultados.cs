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
    public partial class frmResultados : Form
    {
        private List<IterationResults> _resultados;
        public frmResultados(List<IterationResults> resultados)
        {
            InitializeComponent();
            _resultados = resultados;
        }

        private void frmResultados_Load(object sender, EventArgs e)
        {
            try
            {
                Fill();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Fill()
        {
            uscResultadoConcorrente usc;
            uscResultadoFinal uscFinal;
            IterationResults lastResult = _resultados.LastOrDefault<IterationResults>();

            tbcResultados.TabPages.Add("Conclusões");
            uscFinal = new uscResultadoFinal(lastResult);
            uscFinal.Dock = DockStyle.Fill;
            tbcResultados.TabPages[0].AutoScroll = true;
            tbcResultados.TabPages[0].Controls.Add(uscFinal);

            for (int i=0;i< lastResult.Vn.Count;i++)
            {
                usc = new uscResultadoConcorrente(lastResult.Vn[i], lastResult.Fn);
                usc.Dock = DockStyle.Fill;
                tbcResultados.TabPages.Add("Concorrente " + (i + 1).ToString());
                tbcResultados.TabPages[i+1].AutoScroll = true;
                tbcResultados.TabPages[i+1].Controls.Add(usc);
            }

        }

        private void frmResultados_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
