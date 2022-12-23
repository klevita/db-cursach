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
using Курсовой_проект.model;

namespace Курсовой_проект
{
    public partial class Form2 : Form
    {
        private DataDaseContext dbContext;
        private AllVariableTex alldataTex;
        //таблица 1
        private void none()
        {
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;

            label2.Visible = true;
            dataGridView1.Visible = false;
            dataGridView1.ColumnCount = 3;
            dataGridView1.RowCount = dbContext.table1.Count + 1;

            dataGridView1.Rows[0].Cells[0].Value = "Вид материала";
            dataGridView1.Rows[0].Cells[1].Value = "Допускаемое отношение диаметра меньшего шкива к толщине ремня";
            dataGridView1.Rows[0].Cells[2].Value = "Рекомендуемое отношение диаметра меньшего шкива к толщине ремня";

            int i = 1;
            foreach (var x in dbContext.table1)
            {
                dataGridView1.Rows[i].Cells[0].Value = x.TypeMaterial;
                dataGridView1.Rows[i].Cells[1].Value = Math.Round(x.AcceptableRatio, 3).ToString();
                dataGridView1.Rows[i].Cells[2].Value = Math.Round(x.RecommendedRatio, 3).ToString();

                i = i + 1;
            }
            dataGridView1.Visible = true;
        }

        public Form2(DataDaseContext dbContext, AllVariableTex alldataTex)
        {
            InitializeComponent();

            this.dbContext = dbContext;
            this.alldataTex = alldataTex;

            //таблица 1
            none();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Таблица 1";
            none();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            label4.Visible = false;
            label5.Visible = false;

            label1.Text = "Таблица 2";
            label3.Visible = true;
            dataGridView1.Visible = false;
            dataGridView1.ColumnCount = 4;
            dataGridView1.RowCount = dbContext.table2.Count + 1;

            dataGridView1.Rows[0].Cells[0].Value = "Материал";
            dataGridView1.Rows[0].Cells[1].Value = "Начальное напряжение δ_0, МПа";
            dataGridView1.Rows[0].Cells[2].Value = "А";
            dataGridView1.Rows[0].Cells[3].Value = "W";

            int i = 1;
            foreach (var x in dbContext.table2)
            {
                dataGridView1.Rows[i].Cells[0].Value = x.Material;
                dataGridView1.Rows[i].Cells[1].Value = Math.Round(x.InitialStress, 3).ToString();
                dataGridView1.Rows[i].Cells[2].Value = Math.Round(x.A, 3).ToString();
                dataGridView1.Rows[i].Cells[3].Value = Math.Round(x.W, 3).ToString();

                i = i + 1;
            }
            dataGridView1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            label3.Visible = false;
            label5.Visible = false;

            label1.Text = "Таблица 3";
            label4.Visible = true;
            dataGridView1.Visible = false;

            dataGridView1.ColumnCount = 2;
            dataGridView1.RowCount = dbContext.table3.Count + 1;

            dataGridView1.Rows[0].Cells[0].Value = "Угол обхвата gamma, град";
            dataGridView1.Rows[0].Cells[1].Value = "Коэффициент C1";

            int i = 1;
            foreach (var x in dbContext.table3)
            {
                dataGridView1.Rows[i].Cells[0].Value = x.gamma.ToString();
                dataGridView1.Rows[i].Cells[1].Value = Math.Round(x.C1, 3).ToString();

                i = i + 1;
            }

            dataGridView1.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;

            label1.Text = "Таблица 4";
            label5.Visible = true;
            dataGridView1.Visible = false;

            dataGridView1.ColumnCount = 3;
            dataGridView1.RowCount = dbContext.table4.Count + 1;

            dataGridView1.Rows[0].Cells[0].Value = "Материал";
            dataGridView1.Rows[0].Cells[1].Value = "Скорость ремня v, м/с";
            dataGridView1.Rows[0].Cells[2].Value = "Коэффициент С2";

            int i = 1;
            foreach (var x in dbContext.table4)
            {
                dataGridView1.Rows[i].Cells[0].Value = x.Material;
                dataGridView1.Rows[i].Cells[1].Value = Math.Round(x.V, 3).ToString();
                if(x.C2 != null)
                {
                    dataGridView1.Rows[i].Cells[2].Value = Math.Round((double)x.C2, 3).ToString();
                }
                else
                {
                    dataGridView1.Rows[i].Cells[2].Value = " - ";
                }

                i = i + 1;
            }

            dataGridView1.Visible = true;
        }
    }
}
