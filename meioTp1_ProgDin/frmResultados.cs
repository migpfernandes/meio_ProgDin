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
    }
}
