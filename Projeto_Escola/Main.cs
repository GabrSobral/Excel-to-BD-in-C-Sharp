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

namespace Projeto_Escola
{
    public partial class Main : Form
    {
        public Main() { InitializeComponent(); }

        private void btn_select_Click(object sender, EventArgs e)
        {
            clsExcel ClsExcel = new clsExcel();
            OpenFileDialog files = new OpenFileDialog();
            files.Multiselect = true;

            if (files.ShowDialog() == DialogResult.OK)
            {
                int finishedCounter = 0;
                lbl_QtFiles.Text = $"Arquivos {files.FileNames.Length}";
                lbl_finished.Text = $"Finalizados: {finishedCounter}";

                for (int index = 0; index < files.FileNames.Length; index++)
                {
                    ClsExcel.AbreArquivo(files.FileNames[index]);
                    ClsExcel.EscolhaPlan(1);
                    lbl_result.Text = "Carregando...";
                    ArrayList users = new ArrayList(); //array to store users

                    string[] columns = new string[] { "A", "B", "C" }; //quantity of columns
                    string cell = ClsExcel.Leitura("A4"); //start at title of columns
                    int counter = 4; //start at title too, but will be increment in while loop
                    bool hasFinished = false;

                    string descriptionCell = ClsExcel.Leitura("A2");
                    string[] arrDescription = descriptionCell.Split(null);
                    string year = "";

                    for (int i = 0; i < arrDescription.Length; i++)
                    {
                        if (arrDescription[i] == "Ano:")
                        {
                            year = arrDescription[i + 1];
                        }
                    }

                    while (!hasFinished)
                    {
                        UserClass user = new UserClass(); //single user class
                        counter++;

                        foreach (string column in columns)
                        {
                            cell = ClsExcel.Leitura($"{column}{counter}");

                            if (cell == "" && column == "A")
                            {
                                hasFinished = true; //finish loop
                                break;
                            }
                            if (cell == "" && column == "C")
                            {
                                cell = null; //prevent the loop finish without read all data
                                continue;
                            }

                            switch (column)
                            {
                                case "A": user.rm = int.Parse(cell); break;
                                case "B": user.nome = cell; break;
                                case "C": user.grupo = cell?.Split(null)[1]; break;
                            }

                        }
                        if (hasFinished) { break; }
                        user.turma = files.SafeFileNames[index].Split('.')[0];
                        user.ano_turma = int.Parse(year);
                        users.Add(user);
                    }
                    UserClass userMethods = new UserClass();
                    string result = userMethods.register(users);
                    finishedCounter++;
                    lbl_finished.Text = $"Finalizados: {finishedCounter}";
                    lbl_result.Text = result;
                }
            }
        }
    }
}
