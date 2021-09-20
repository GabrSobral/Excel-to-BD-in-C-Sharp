using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Text.RegularExpressions;
using Proffreddy;
using System.IO;
using Projeto_Escola.classes;

namespace Projeto_Escola
{
    public partial class Main : Form
    {
        List<string> FilePaths;
        public Main() { InitializeComponent(); }

        #region Select Students Plain
        private void Btn_Select_Click_1(object sender, EventArgs e)
        {
            FilePaths = new List<string>();
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Selecione planilhas de turma do NSA";
            openFile.Filter = "Excel | *.xls;*.xlsx";
            openFile.CheckFileExists = true;
            openFile.Multiselect = true;

            if (openFile.ShowDialog() == DialogResult.OK) 
            {
                lst_Turmas.Items.Clear();
                foreach (var item in openFile.FileNames) 
                {
                    FilePaths.Add(item);
                    string fileName = Path.GetFileNameWithoutExtension(item);
                    lst_Turmas.Items.Add(fileName);
                }
                progressBar2.Maximum = lst_Turmas.Items.Count;
            }
        }
        #endregion

        #region Import Students Plain to Grid
        private void Btn_Import_Click(object sender, EventArgs e)
        {
            if (lst_Turmas.Items.Count == 0) 
            {
                MessageBox.Show(
                    "Selecione arquivos de planilhas de turmas para importação!",
                    "Atenção!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
               );
                return;
            }

            for (int i = 0; i < lst_Turmas.Items.Count; i++)
            {
                LoadStudentsPlain(FilePaths[i]);
                StoreStudents(lst_Turmas.Items[i].ToString());
                progressBar2.Value++;
                Application.DoEvents();
            }
            progressBar2.Value = 0;
            progressBar1.Value = 0;
            tbl_Students.Rows.Clear();
            lst_Turmas.Items.Clear();
            FilePaths.Clear();

            MessageBox.Show(
                "Importações realizadas com sucesso!", 
                "Aviso", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information
            );
        }

        void LoadStudentsPlain(string path)
        {
            tbl_Students.Rows.Clear();
            clsExcel excel = new clsExcel();
            excel.AbreArquivo(path);
            excel.EscolhaPlan(1);
            int line = 5;

            while(excel.Leitura($"A{line}") != "")
            {
                string rm = excel.Leitura($"A{line}");
                string name = excel.Leitura($"B{line}");
                string group = excel.Leitura($"C{line}");

                if (group != "")
                    group = group.Substring(group.Length - 1, 1);
                else
                    group = "T";

                tbl_Students.Rows.Add(rm, name, group);
                line++;
            }

            excel.Fechar();
        }
        #endregion

        #region Store each Student from Grid to Database
        void StoreStudents(string initialsTurma)
        {
            progressBar1.Maximum = tbl_Students.Rows.Count;
            for (int i = 0; i < tbl_Students.Rows.Count; i++)
            {
                tbl_Students.CurrentCell = tbl_Students.Rows[i].Cells[0];
                
                int rm = int.Parse(tbl_Students.Rows[i].Cells[0].Value.ToString());
                string name = tbl_Students.Rows[i].Cells[1].Value.ToString();
                string group = tbl_Students.Rows[i].Cells[2].Value.ToString();
                Student student = new Student(rm, name, new Turma(initialsTurma, group));
                student.Insert();

                progressBar1.Value++;
                Application.DoEvents();
            }
            progressBar1.Value = 0;
        }
        #endregion
    }
}
