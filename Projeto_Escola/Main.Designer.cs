
namespace Projeto_Escola
{
    partial class Main
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_Import = new System.Windows.Forms.Button();
            this.lst_Turmas = new System.Windows.Forms.ListBox();
            this.Btn_Select = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbl_Students = new System.Windows.Forms.DataGridView();
            this.coRM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coGrupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Students)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_Import);
            this.groupBox1.Controls.Add(this.lst_Turmas);
            this.groupBox1.Controls.Add(this.Btn_Select);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 310);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de Turmas";
            // 
            // Btn_Import
            // 
            this.Btn_Import.Location = new System.Drawing.Point(6, 267);
            this.Btn_Import.Name = "Btn_Import";
            this.Btn_Import.Size = new System.Drawing.Size(188, 36);
            this.Btn_Import.TabIndex = 2;
            this.Btn_Import.Text = "Iniciar Importações";
            this.Btn_Import.UseVisualStyleBackColor = true;
            this.Btn_Import.Click += new System.EventHandler(this.Btn_Import_Click);
            // 
            // lst_Turmas
            // 
            this.lst_Turmas.FormattingEnabled = true;
            this.lst_Turmas.Location = new System.Drawing.Point(7, 62);
            this.lst_Turmas.Name = "lst_Turmas";
            this.lst_Turmas.Size = new System.Drawing.Size(187, 199);
            this.lst_Turmas.TabIndex = 1;
            // 
            // Btn_Select
            // 
            this.Btn_Select.Location = new System.Drawing.Point(6, 19);
            this.Btn_Select.Name = "Btn_Select";
            this.Btn_Select.Size = new System.Drawing.Size(188, 36);
            this.Btn_Select.TabIndex = 0;
            this.Btn_Select.Text = "Selecionar planilhas";
            this.Btn_Select.UseVisualStyleBackColor = true;
            this.Btn_Select.Click += new System.EventHandler(this.Btn_Select_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbl_Students);
            this.groupBox2.Location = new System.Drawing.Point(218, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(443, 310);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Turma em Importação";
            // 
            // tbl_Students
            // 
            this.tbl_Students.AllowUserToAddRows = false;
            this.tbl_Students.AllowUserToDeleteRows = false;
            this.tbl_Students.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_Students.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coRM,
            this.coNome,
            this.coGrupo});
            this.tbl_Students.Location = new System.Drawing.Point(6, 19);
            this.tbl_Students.Name = "tbl_Students";
            this.tbl_Students.ReadOnly = true;
            this.tbl_Students.RowHeadersVisible = false;
            this.tbl_Students.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tbl_Students.Size = new System.Drawing.Size(431, 284);
            this.tbl_Students.TabIndex = 0;
            // 
            // coRM
            // 
            this.coRM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.coRM.HeaderText = "RM";
            this.coRM.Name = "coRM";
            this.coRM.ReadOnly = true;
            this.coRM.Width = 49;
            // 
            // coNome
            // 
            this.coNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.coNome.HeaderText = "Nome";
            this.coNome.Name = "coNome";
            this.coNome.ReadOnly = true;
            // 
            // coGrupo
            // 
            this.coGrupo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.coGrupo.HeaderText = "Grupo";
            this.coGrupo.Name = "coGrupo";
            this.coGrupo.ReadOnly = true;
            this.coGrupo.Width = 61;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 329);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(648, 10);
            this.progressBar1.TabIndex = 2;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(12, 350);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(649, 10);
            this.progressBar2.TabIndex = 3;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 372);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Importação de Turmas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Students)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_Import;
        private System.Windows.Forms.ListBox lst_Turmas;
        private System.Windows.Forms.Button Btn_Select;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView tbl_Students;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.DataGridViewTextBoxColumn coRM;
        private System.Windows.Forms.DataGridViewTextBoxColumn coNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn coGrupo;
    }
}

