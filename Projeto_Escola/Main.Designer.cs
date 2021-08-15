
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_select = new System.Windows.Forms.Button();
            this.lbl_result = new System.Windows.Forms.Label();
            this.lbl_QtFiles = new System.Windows.Forms.Label();
            this.lbl_finished = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione os arquivos Excel";
            // 
            // btn_select
            // 
            this.btn_select.Location = new System.Drawing.Point(95, 39);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(191, 51);
            this.btn_select.TabIndex = 1;
            this.btn_select.Text = "Selecionar";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // lbl_result
            // 
            this.lbl_result.Location = new System.Drawing.Point(12, 106);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(349, 39);
            this.lbl_result.TabIndex = 2;
            this.lbl_result.Text = "Resultado:";
            this.lbl_result.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_QtFiles
            // 
            this.lbl_QtFiles.Location = new System.Drawing.Point(288, 142);
            this.lbl_QtFiles.Name = "lbl_QtFiles";
            this.lbl_QtFiles.Size = new System.Drawing.Size(73, 20);
            this.lbl_QtFiles.TabIndex = 3;
            this.lbl_QtFiles.Text = "Arquivos:";
            // 
            // lbl_finished
            // 
            this.lbl_finished.Location = new System.Drawing.Point(209, 142);
            this.lbl_finished.Name = "lbl_finished";
            this.lbl_finished.Size = new System.Drawing.Size(73, 20);
            this.lbl_finished.TabIndex = 4;
            this.lbl_finished.Text = "Finalizados:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 190);
            this.Controls.Add(this.lbl_finished);
            this.Controls.Add(this.lbl_QtFiles);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.btn_select);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.Text = "Projeto_escola";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.Label lbl_QtFiles;
        private System.Windows.Forms.Label lbl_finished;
    }
}

