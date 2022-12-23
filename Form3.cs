using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Курсовой_проект.entity;
using Курсовой_проект.Manager;
using Курсовой_проект.model;

namespace Курсовой_проект
{
    public partial class Form3 : Form
    {
        private readonly AllVariableTex alldataTex;
        private List<AllVariables> alldata;

        private void UpdateTable(List<AllVariables> copy = null)
        {
            if(copy == null)
            {
                copy = alldata;
            }

            label3.Visible = false;
            dataGridView1.Visible = false;

            dataGridView1.RowCount = copy.Count + 1;
            dataGridView1.ColumnCount = alldataTex.AllVariable.Count();

            for(int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                dataGridView1.Rows[0].Cells[i].Value = alldataTex.AllVariable[i];
            }

            for (int i = 1; i < dataGridView1.RowCount; i++)
            {
                //начальные данные
                dataGridView1.Rows[i].Cells[0].Value = copy[i - 1].CodeSE.ToString();
                dataGridView1.Rows[i].Cells[1].Value = copy[i - 1].TypeMaterial;
                dataGridView1.Rows[i].Cells[2].Value = copy[i - 1].Material;
                dataGridView1.Rows[i].Cells[3].Value = copy[i - 1].n1.ToString();
                dataGridView1.Rows[i].Cells[4].Value = copy[i - 1].n2.ToString();
                dataGridView1.Rows[i].Cells[5].Value = Math.Round(copy[i - 1].K_speed, 3).ToString();
                dataGridView1.Rows[i].Cells[6].Value = Math.Round(copy[i - 1].C0, 3).ToString();
                dataGridView1.Rows[i].Cells[7].Value = Math.Round(copy[i - 1].C3, 3).ToString();
                dataGridView1.Rows[i].Cells[8].Value = copy[i - 1].TypeTransmission;
                dataGridView1.Rows[i].Cells[9].Value = copy[i - 1].TypeTransmissionStroke;
                dataGridView1.Rows[i].Cells[10].Value = copy[i - 1].TypeDminDelta;
                dataGridView1.Rows[i].Cells[11].Value = copy[i - 1].TypeCalcul_L;
                dataGridView1.Rows[i].Cells[12].Value = Math.Round(copy[i - 1].N, 3);
                dataGridView1.Rows[i].Cells[13].Value = Math.Round(copy[i - 1].I, 3);
                dataGridView1.Rows[i].Cells[14].Value = Math.Round(copy[i - 1].sigma_0, 3);
                dataGridView1.Rows[i].Cells[15].Value = Math.Round(copy[i - 1].delta_0, 3);
                dataGridView1.Rows[i].Cells[16].Value = Math.Round(copy[i - 1].gamma, 3);
                dataGridView1.Rows[i].Cells[17].Value = Math.Round(copy[i - 1].E, 3);

                //расчетные данные
                dataGridView1.Rows[i].Cells[18].Value = Math.Round(copy[i - 1].D1, 3);
                dataGridView1.Rows[i].Cells[19].Value = Math.Round(copy[i - 1].u, 3);
                dataGridView1.Rows[i].Cells[20].Value = Math.Round(copy[i - 1].D2, 3);
                dataGridView1.Rows[i].Cells[21].Value = Math.Round(copy[i - 1].V, 3);
                dataGridView1.Rows[i].Cells[22].Value = Math.Round(copy[i - 1].aMIN, 3);
                dataGridView1.Rows[i].Cells[23].Value = Math.Round(copy[i - 1].L, 3);
                dataGridView1.Rows[i].Cells[24].Value = Math.Round(copy[i - 1].Dcp, 3);
                dataGridView1.Rows[i].Cells[25].Value = Math.Round(copy[i - 1].delta, 3);
                dataGridView1.Rows[i].Cells[26].Value = Math.Round(copy[i - 1].lambda, 3);
                dataGridView1.Rows[i].Cells[27].Value = Math.Round(copy[i - 1].a, 3);
                dataGridView1.Rows[i].Cells[28].Value = Math.Round(copy[i - 1].alpha, 3);
                dataGridView1.Rows[i].Cells[29].Value = Math.Round(copy[i - 1].K, 3);
                dataGridView1.Rows[i].Cells[30].Value = Math.Round(copy[i - 1].delta_belt, 3);
                dataGridView1.Rows[i].Cells[31].Value = Math.Round(copy[i - 1].F, 3);
                dataGridView1.Rows[i].Cells[32].Value = Math.Round(copy[i - 1].A, 3);
                dataGridView1.Rows[i].Cells[33].Value = Math.Round(copy[i - 1].W, 3);
                dataGridView1.Rows[i].Cells[34].Value = Math.Round(copy[i - 1].sigma_F_0, 3);
                dataGridView1.Rows[i].Cells[35].Value = Math.Round(copy[i - 1].C1, 3);
                dataGridView1.Rows[i].Cells[36].Value = Math.Round(copy[i - 1].C2, 3);
                dataGridView1.Rows[i].Cells[37].Value = Math.Round(copy[i - 1].sigma_F, 3);
                dataGridView1.Rows[i].Cells[38].Value = Math.Round(copy[i - 1].b, 3);

                label3.Visible = true;
                dataGridView1.Visible = true;
            }
        }

        public Form3(AllVariableTex alldataTex, List<AllVariables> alldata)
        {
            InitializeComponent();

            this.alldataTex = alldataTex;
            this.alldata = alldata;

            //сортировка
            comboBox2.Items.Clear();
            comboBox2.Items.Add(alldataTex.CodeSE);
            comboBox2.Items.Add(alldataTex.D1);
            comboBox2.Items.Add(alldataTex.D2);
            comboBox2.Items.Add(alldataTex.V);
            comboBox2.Items.Add(alldataTex.L);
            comboBox2.Items.Add(alldataTex.a);
            comboBox2.Items.Add(alldataTex.alpha);
            comboBox2.Items.Add(alldataTex.delta);
            comboBox2.Items.Add(alldataTex.F);
            comboBox2.Items.Add(alldataTex.sigma_F);
            comboBox2.Items.Add(alldataTex.b);
            comboBox2.SelectedIndex = 0;

            //поиск
            comboBox1.Items.Clear();
            comboBox1.Items.Add(alldataTex.TypeMaterial);
            comboBox1.Items.Add(alldataTex.Material);
            comboBox1.Items.Add(alldataTex.TypeTransmission);
            comboBox1.Items.Add(alldataTex.TypeTransmissionStroke);
            comboBox1.Items.Add(alldataTex.TypeDminDelta);
            comboBox1.Items.Add(alldataTex.TypeCalcul_L);
            comboBox1.SelectedIndex = 0;
            
            UpdateTable();
        }
        //скрыть переменную
        private void button4_Click(object sender, EventArgs e)
        {
            if (alldata.Count != 0)
            {
                int col = dataGridView1.CurrentCell.ColumnIndex;
                if (col >= 0)
                {
                    dataGridView1.Visible = false;
                    for (int j = col; j < dataGridView1.ColumnCount - 1; j++)
                    {
                        for (int i = 0; i < dataGridView1.RowCount; i++)
                        {
                            dataGridView1.Rows[i].Cells[j].Value = dataGridView1.Rows[i].Cells[j + 1].Value;
                        }
                    }
                    dataGridView1.ColumnCount = dataGridView1.ColumnCount - 1;
                    dataGridView1.Visible = true;
                }
                else
                {
                    string text = "Все переменные скрыты!";
                    ErrorManager.InfoOK(text);
                }
            }
            else
            {
                string text = "Информация о всех передачах удалена";
                ErrorManager.InfoOK(text);
            }
        }
        //показать переменную
        private void button9_Click(object sender, EventArgs e)
        {
            if (alldata.Count != 0)
            {
                UpdateTable();

            }
            else
            {
                string text = "Список передач пуст!";
                ErrorManager.InfoOK(text);
            }
        }
        //сортировать по возрастанию
        private void button7_Click(object sender, EventArgs e)
        {
            if(alldata.Count != 0)
            {
                string text = comboBox2.SelectedItem.ToString();
                List<AllVariables> copy = new List<AllVariables>();

                //CodeSE
                if (text == alldataTex.CodeSE)
                {
                    copy = alldata.OrderBy(g => g.CodeSE).ToList();
                }

                //D1
                if(text == alldataTex.D1)
                {
                    copy = alldata.OrderBy(g => g.D1).ToList();
                }

                //D2
                if (text == alldataTex.D2)
                {
                    copy = alldata.OrderBy(g => g.D2).ToList();
                }

                //V
                if (text == alldataTex.V)
                {
                    copy = alldata.OrderBy(g => g.V).ToList();
                }

                //L
                if (text == alldataTex.L)
                {
                    copy = alldata.OrderBy(g => g.L).ToList();
                }

                //a
                if (text == alldataTex.a)
                {
                    copy = alldata.OrderBy(g => g.a).ToList();
                }

                //alpha
                if (text == alldataTex.alpha)
                {
                    copy = alldata.OrderBy(g => g.alpha).ToList();
                }

                //delta
                if (text == alldataTex.delta)
                {
                    copy = alldata.OrderBy(g => g.delta).ToList();
                }

                //F
                if (text == alldataTex.F)
                {
                    copy = alldata.OrderBy(g => g.F).ToList();
                }

                //sigma_F
                if (text == alldataTex.sigma_F)
                {
                    copy = alldata.OrderBy(g => g.sigma_F).ToList();
                }

                //b
                if (text == alldataTex.b)
                {
                    copy = alldata.OrderBy(g => g.b).ToList();
                }

                if(copy.Count != 0)
                {
                    UpdateTable(copy);
                }
                else
                {
                    ErrorManager.InfoOK("В ходе сортировки произошел сбой!");
                }
            }
        }
        //найти
        private void button8_Click(object sender, EventArgs e)
        {
            if(alldata.Count != 0)
            {
                List<AllVariables> copy = new List<AllVariables>();
                string param = comboBox1.SelectedItem.ToString();
                string text = "";

                //TypeMaterial
                if(param == alldataTex.TypeMaterial)
                {
                    copy = alldata.Where(g => g.TypeMaterial.ToLower().Contains(text)).ToList();
                }

                //Material
                if(param == alldataTex.Material)
                {
                    copy = alldata.Where(g => g.Material.ToLower().Contains(text)).ToList();
                }

                //TypeTransmission
                if (param == alldataTex.TypeTransmission)
                {
                    copy = alldata.Where(g => g.TypeTransmission.ToLower().Contains(text)).ToList();
                }

                //TypeTransmissionStroke
                if (param == alldataTex.TypeTransmissionStroke)
                {
                    copy = alldata.Where(g => g.TypeTransmissionStroke.ToLower().Contains(text)).ToList();
                }

                //TypeDminDelta
                if (param == alldataTex.TypeDminDelta)
                {
                    copy = alldata.Where(g => g.TypeDminDelta.ToLower().Contains(text)).ToList();
                }

                //TypeCalcul_L
                if (param == alldataTex.TypeCalcul_L)
                {
                    copy = alldata.Where(g => g.TypeCalcul_L.ToLower().Contains(text)).ToList();
                }

                if (copy.Count == 0)
                {
                    ErrorManager.InfoOK("Поиск не дал результатов!");
                }
                else
                {
                    UpdateTable(copy);
                }
            }
        }
        //сортировать по убыванию
        private void button1_Click(object sender, EventArgs e)
        {
            if (alldata.Count != 0)
            {
                string text = comboBox2.SelectedItem.ToString();
                List<AllVariables> copy = new List<AllVariables>();

                //CodeSE
                if (text == alldataTex.CodeSE)
                {
                    copy = alldata.OrderByDescending(g => g.CodeSE).ToList();
                }

                //D1
                if (text == alldataTex.D1)
                {
                    copy = alldata.OrderByDescending(g => g.D1).ToList();
                }

                //D2
                if (text == alldataTex.D2)
                {
                    copy = alldata.OrderByDescending(g => g.D2).ToList();
                }

                //V
                if (text == alldataTex.V)
                {
                    copy = alldata.OrderByDescending(g => g.V).ToList();
                }

                //L
                if (text == alldataTex.L)
                {
                    copy = alldata.OrderByDescending(g => g.L).ToList();
                }

                //a
                if (text == alldataTex.a)
                {
                    copy = alldata.OrderByDescending(g => g.a).ToList();
                }

                //alpha
                if (text == alldataTex.alpha)
                {
                    copy = alldata.OrderByDescending(g => g.alpha).ToList();
                }

                //delta
                if (text == alldataTex.delta)
                {
                    copy = alldata.OrderByDescending(g => g.delta).ToList();
                }

                //F
                if (text == alldataTex.F)
                {
                    copy = alldata.OrderByDescending(g => g.F).ToList();
                }

                //sigma_F
                if (text == alldataTex.sigma_F)
                {
                    copy = alldata.OrderByDescending(g => g.sigma_F).ToList();
                }

                //b
                if (text == alldataTex.b)
                {
                    copy = alldata.OrderByDescending(g => g.b).ToList();
                }

                if (copy.Count != 0)
                {
                    UpdateTable(copy);
                }
                else
                {
                    ErrorManager.InfoOK("В ходе сортировки произошел сбой!");
                }
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
