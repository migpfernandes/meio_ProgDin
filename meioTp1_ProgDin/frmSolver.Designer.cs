namespace meioTp1_ProgDin
{
    partial class frmSolver
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSolver));
            this.label1 = new System.Windows.Forms.Label();
            this.nudDimensao = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudConcorrentes = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.tbcConcorrentes = new System.Windows.Forms.TabControl();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.rbtNumIteracoes = new System.Windows.Forms.RadioButton();
            this.nudNumIteracoes = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbtMaximizacao = new System.Windows.Forms.RadioButton();
            this.rbtMinimizacao = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.nudDimensao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudConcorrentes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumIteracoes)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dimensão:";
            // 
            // nudDimensao
            // 
            this.nudDimensao.Location = new System.Drawing.Point(118, 29);
            this.nudDimensao.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDimensao.Name = "nudDimensao";
            this.nudDimensao.Size = new System.Drawing.Size(60, 20);
            this.nudDimensao.TabIndex = 1;
            this.nudDimensao.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Concorrentes:";
            // 
            // nudConcorrentes
            // 
            this.nudConcorrentes.Location = new System.Drawing.Point(118, 55);
            this.nudConcorrentes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudConcorrentes.Name = "nudConcorrentes";
            this.nudConcorrentes.Size = new System.Drawing.Size(60, 20);
            this.nudConcorrentes.TabIndex = 5;
            this.nudConcorrentes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNovo);
            this.groupBox1.Controls.Add(this.nudDimensao);
            this.groupBox1.Controls.Add(this.nudConcorrentes);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Definições iniciais:";
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(199, 31);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(52, 44);
            this.btnNovo.TabIndex = 6;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // tbcConcorrentes
            // 
            this.tbcConcorrentes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcConcorrentes.Location = new System.Drawing.Point(13, 119);
            this.tbcConcorrentes.Name = "tbcConcorrentes";
            this.tbcConcorrentes.SelectedIndex = 0;
            this.tbcConcorrentes.Size = new System.Drawing.Size(785, 319);
            this.tbcConcorrentes.TabIndex = 7;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCalcular.Location = new System.Drawing.Point(444, 452);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 53);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.numericUpDown2);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.rbtNumIteracoes);
            this.groupBox2.Controls.Add(this.nudNumIteracoes);
            this.groupBox2.Location = new System.Drawing.Point(13, 444);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 75);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Critérios de paragem:";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DecimalPlaces = 2;
            this.numericUpDown2.Enabled = false;
            this.numericUpDown2.Location = new System.Drawing.Point(152, 44);
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(98, 20);
            this.numericUpDown2.TabIndex = 10;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Enabled = false;
            this.radioButton2.Location = new System.Drawing.Point(41, 44);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(80, 17);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.Text = "Margem(%):";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // rbtNumIteracoes
            // 
            this.rbtNumIteracoes.AutoSize = true;
            this.rbtNumIteracoes.Checked = true;
            this.rbtNumIteracoes.Location = new System.Drawing.Point(41, 18);
            this.rbtNumIteracoes.Name = "rbtNumIteracoes";
            this.rbtNumIteracoes.Size = new System.Drawing.Size(87, 17);
            this.rbtNumIteracoes.TabIndex = 8;
            this.rbtNumIteracoes.TabStop = true;
            this.rbtNumIteracoes.Text = "Nº Iterações:";
            this.rbtNumIteracoes.UseVisualStyleBackColor = true;
            // 
            // nudNumIteracoes
            // 
            this.nudNumIteracoes.Location = new System.Drawing.Point(152, 18);
            this.nudNumIteracoes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumIteracoes.Name = "nudNumIteracoes";
            this.nudNumIteracoes.Size = new System.Drawing.Size(98, 20);
            this.nudNumIteracoes.TabIndex = 7;
            this.nudNumIteracoes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.rbtMaximizacao);
            this.groupBox3.Controls.Add(this.rbtMinimizacao);
            this.groupBox3.Location = new System.Drawing.Point(291, 444);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(147, 75);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tipo de objetivo:";
            // 
            // rbtMaximizacao
            // 
            this.rbtMaximizacao.AutoSize = true;
            this.rbtMaximizacao.Location = new System.Drawing.Point(41, 44);
            this.rbtMaximizacao.Name = "rbtMaximizacao";
            this.rbtMaximizacao.Size = new System.Drawing.Size(86, 17);
            this.rbtMaximizacao.TabIndex = 9;
            this.rbtMaximizacao.Text = "Maximização";
            this.rbtMaximizacao.UseVisualStyleBackColor = true;
            // 
            // rbtMinimizacao
            // 
            this.rbtMinimizacao.AutoSize = true;
            this.rbtMinimizacao.Checked = true;
            this.rbtMinimizacao.Location = new System.Drawing.Point(41, 18);
            this.rbtMinimizacao.Name = "rbtMinimizacao";
            this.rbtMinimizacao.Size = new System.Drawing.Size(83, 17);
            this.rbtMinimizacao.TabIndex = 8;
            this.rbtMinimizacao.TabStop = true;
            this.rbtMinimizacao.Text = "Minimização";
            this.rbtMinimizacao.UseVisualStyleBackColor = true;
            // 
            // frmSolver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 531);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.tbcConcorrentes);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSolver";
            this.Text = "Programação Dinâmica";
            ((System.ComponentModel.ISupportInitialize)(this.nudDimensao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudConcorrentes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumIteracoes)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudDimensao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudConcorrentes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.TabControl tbcConcorrentes;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton rbtNumIteracoes;
        private System.Windows.Forms.NumericUpDown nudNumIteracoes;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbtMaximizacao;
        private System.Windows.Forms.RadioButton rbtMinimizacao;
    }
}

