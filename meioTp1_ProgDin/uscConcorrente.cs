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
    public partial class uscConcorrente : UserControl
    {
        private int _dimension;
        private DataGridView projecao;
        private DataGridView rendimentos;


        public uscConcorrente(int dimension)
        {
            InitializeComponent();
            _dimension = dimension;
            buildMatrixes();
            this.AutoScroll = true;
        }

        private void buildMatrixes()
        {
            projecao = new DataGridView();
            rendimentos = new DataGridView();
            Label lblProjection = new Label();
            lblProjection.Text = "Matriz de Projeção:";
            lblProjection.AutoSize = true;
            Label lblWeights = new Label();
            lblWeights.Text = "Matriz de Rendimentos:";
            lblWeights.AutoSize = true;

            fillGrid(projecao);
            fillGrid(rendimentos);
            flpConcorrente.Controls.Add(lblProjection);
            flpConcorrente.Controls.Add(projecao);
            flpConcorrente.Controls.Add(lblWeights);
            flpConcorrente.Controls.Add(rendimentos);
        }

        private void fillGrid(DataGridView dgv)
        {
            int index;

            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToOrderColumns = false;
            dgv.EditMode = DataGridViewEditMode.EditOnEnter;
            for (int i = 1; i <= _dimension; i++)
            {
                dgv.Columns.Add(projecao.Name + "_" + i.ToString(), i.ToString());
                index = dgv.Rows.Add();
                dgv.Rows[index].HeaderCell.Value = String.Format("{0}", index + 1);
            }
            dgv.AutoSize = true;
        }

        public decimal[,] getProjectionMatrix()
        {
            return getMatrixFromDgv(projecao);
        }

        public decimal[,] getWeightMatrix()
        {
            return getMatrixFromDgv(rendimentos);
        }

        private decimal[,] getMatrixFromDgv(DataGridView dgv)
        {
            decimal[,] res = new decimal[_dimension, _dimension];
            decimal aux = 0;
            for (int i = 0; i < dgv.RowCount; i++)
            {
                for (int j = 0; j < dgv.ColumnCount; j++)
                {
                    if ((dgv[j,i].Value == null) ||
                        (String.IsNullOrEmpty(dgv[j, i].Value.ToString())) ||
                        (decimal.TryParse(dgv[j, i].Value.ToString(), out aux) == false))
                    {
                        dgv[j, i].Value = 0;
                        res[i, j] = 0;
                    }
                    else
                    {
                        res[i, j] = aux;
                    }
                }
            }
            return res;
        }
    }
}
