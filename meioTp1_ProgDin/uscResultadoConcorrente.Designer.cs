namespace meioTp1_ProgDin
{
    partial class uscResultadoConcorrente
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
            this.flpResultado = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvVn = new System.Windows.Forms.DataGridView();
            this.dgvVn_Vn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flpResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVn)).BeginInit();
            this.SuspendLayout();
            // 
            // flpResultado
            // 
            this.flpResultado.Controls.Add(this.label1);
            this.flpResultado.Controls.Add(this.dgvVn);
            this.flpResultado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpResultado.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpResultado.Location = new System.Drawing.Point(0, 0);
            this.flpResultado.Name = "flpResultado";
            this.flpResultado.Size = new System.Drawing.Size(436, 327);
            this.flpResultado.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Resultados da Iteração:";
            // 
            // dgvVn
            // 
            this.dgvVn.AllowUserToAddRows = false;
            this.dgvVn.AllowUserToDeleteRows = false;
            this.dgvVn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvVn_Vn});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVn.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVn.Location = new System.Drawing.Point(3, 16);
            this.dgvVn.MultiSelect = false;
            this.dgvVn.Name = "dgvVn";
            this.dgvVn.ReadOnly = true;
            this.dgvVn.Size = new System.Drawing.Size(240, 206);
            this.dgvVn.TabIndex = 1;
            // 
            // dgvVn_Vn
            // 
            this.dgvVn_Vn.HeaderText = "Vn";
            this.dgvVn_Vn.Name = "dgvVn_Vn";
            this.dgvVn_Vn.ReadOnly = true;
            // 
            // uscResultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flpResultado);
            this.Name = "uscResultado";
            this.Size = new System.Drawing.Size(436, 327);
            this.flpResultado.ResumeLayout(false);
            this.flpResultado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvVn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvVn_Vn;
    }
}
