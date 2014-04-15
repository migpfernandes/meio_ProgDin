namespace meioTp1_ProgDin
{
    partial class uscResultadoFinal
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblResultado = new System.Windows.Forms.Label();
            this.dgvFn = new System.Windows.Forms.DataGridView();
            this.dgvFn_Fn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFn_DeltaFn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFn_Concorrentes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFn)).BeginInit();
            this.SuspendLayout();
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(3, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(120, 13);
            this.lblResultado.TabIndex = 0;
            this.lblResultado.Text = "Resultados da Iteração:";
            // 
            // dgvFn
            // 
            this.dgvFn.AllowUserToAddRows = false;
            this.dgvFn.AllowUserToDeleteRows = false;
            this.dgvFn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvFn_Fn,
            this.dgvFn_DeltaFn,
            this.dgvFn_Concorrentes});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFn.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFn.Location = new System.Drawing.Point(6, 16);
            this.dgvFn.MultiSelect = false;
            this.dgvFn.Name = "dgvFn";
            this.dgvFn.ReadOnly = true;
            this.dgvFn.Size = new System.Drawing.Size(430, 311);
            this.dgvFn.TabIndex = 1;
            // 
            // dgvFn_Fn
            // 
            this.dgvFn_Fn.HeaderText = "Fn";
            this.dgvFn_Fn.Name = "dgvFn_Fn";
            this.dgvFn_Fn.ReadOnly = true;
            // 
            // dgvFn_DeltaFn
            // 
            this.dgvFn_DeltaFn.HeaderText = "Delta Fn";
            this.dgvFn_DeltaFn.Name = "dgvFn_DeltaFn";
            this.dgvFn_DeltaFn.ReadOnly = true;
            // 
            // dgvFn_Concorrentes
            // 
            this.dgvFn_Concorrentes.HeaderText = "Concorrentes";
            this.dgvFn_Concorrentes.Name = "dgvFn_Concorrentes";
            this.dgvFn_Concorrentes.ReadOnly = true;
            // 
            // uscResultadoFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.dgvFn);
            this.Name = "uscResultadoFinal";
            this.Size = new System.Drawing.Size(436, 327);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.DataGridView dgvFn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFn_Fn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFn_DeltaFn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFn_Concorrentes;
    }
}
