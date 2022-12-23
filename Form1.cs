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
    public partial class Form1 : Form
    {
        private List<AllVariables> alldata = new List<AllVariables>();
        private readonly AllVariableTex alldataTex = new AllVariableTex();
        private readonly DataDaseContext dbContext = new DataDaseContext();
        public Form1()
        {
            InitializeComponent();
            label3.Visible = false;
            dataGridView1.Visible = false;
        }

        //скрытие параметров
        private void HideFields()
        {
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
            label21.Visible = false;
            label22.Visible = false;
            label23.Visible = false;

            comboBox1.Visible = false;
            comboBox2.Visible = false;
            comboBox3.Visible = false;
            comboBox4.Visible = false;

            groupBox1.Visible = false;
            groupBox3.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;

            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
            textBox11.Visible = false;

            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";

            button6.Visible = false;

        }
        //показать поля
        private void ShowFields(AllVariables data = null)
        {
            //код передачи
            if (data == null)
            {
                label6.Text = Guid.NewGuid().ToString();
            }
            else
            {
                label6.Text = data.CodeSE.ToString();
            }

            //TypeMaterial
           
            if (data == null)
            {
                
            }
            else
            {
                if(data.TypeMaterial == StaticData.TypeMaterial[0])
                {
                   
                }
                else
                {
                   
                }
            }

            //Material
            
            if (data == null)
            {
               
            }
            else
            {
                if(data.Material == StaticData.Material[0])
                {
                    
                }
                else
                {
                   
                }
            }

            //TypeTransmission
            comboBox1.Items.Clear();
            comboBox1.Items.Add(StaticData.TypeTransmission[0]);
            comboBox1.Items.Add(StaticData.TypeTransmission[1]);
            if (data == null)
            {
                comboBox1.SelectedIndex = 0;
            }
            else
            {
                if(data.TypeTransmission == StaticData.TypeTransmission[0])
                {
                    comboBox1.SelectedIndex = 0;
                }
                else
                {
                    comboBox1.SelectedIndex = 1;
                }
            }

            //TypeTransmissionStroke
            comboBox2.Items.Clear();
            comboBox2.Items.Add(StaticData.TypeTransmissionStroke[0]);
            comboBox2.Items.Add(StaticData.TypeTransmissionStroke[1]);
            if (data == null)
            {
                comboBox2.SelectedIndex = 0;
            }
            else
            {
                if(data.TypeTransmissionStroke == StaticData.TypeTransmissionStroke[0])
                {
                    comboBox2.SelectedIndex = 0;
                }
                else
                {
                    comboBox2.SelectedIndex = 1;
                }
            }

            //Type(Dmin/delta)
            comboBox3.Items.Clear();
            comboBox3.Items.Add(StaticData.TypeDminDelta[0]);
            comboBox3.Items.Add(StaticData.TypeDminDelta[1]);
            if (data == null)
            {
                comboBox3.SelectedIndex = 0;
            }
            else
            {
                if(data.TypeDminDelta == StaticData.TypeDminDelta[0])
                {
                    comboBox3.SelectedIndex = 0;
                }
                else
                {
                    comboBox3.SelectedIndex = 1;
                }
            }

            //TypeCalcul_L
            comboBox4.Items.Clear();
            comboBox4.Items.Add(StaticData.TypeCalcul_L[0]);
            comboBox4.Items.Add(StaticData.TypeCalcul_L[1]);
            if (data == null)
            {
                comboBox4.SelectedIndex = 0;
            }
            else
            {
                if(data.TypeCalcul_L == StaticData.TypeCalcul_L[0])
                {
                    comboBox4.SelectedIndex = 0;
                }
                else
                {
                    comboBox4.SelectedIndex = 1;
                }
            }

            if(data != null)
            {
                //n1
               
                //n2 textBox2.Text = data.n2.ToString();
                //K_speed
                textBox8.Text = Math.Round(data.K_speed, 3).ToString();
                //C0
                textBox9.Text = Math.Round(data.C0, 3).ToString();
                //C3
                textBox10.Text = Math.Round(data.C3, 3).ToString();
                //N
                textBox3.Text = Math.Round(data.N, 3).ToString();
                //I
                textBox4.Text = Math.Round(data.I, 3).ToString();
                //sigma_0
                textBox5.Text = Math.Round(data.sigma_0, 3).ToString();
                //delta_0
                textBox6.Text = Math.Round(data.delta_0, 3).ToString();
                //gamma
                textBox7.Text = Math.Round(data.gamma, 3).ToString();
                //E
                textBox11.Text = Math.Round(data.E, 3).ToString();
            }

            //открываем окна

            groupBox1.Visible = true;
           
            groupBox3.Visible = true;
           
            groupBox5.Visible = true;
            groupBox6.Visible = true;

            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
           
            label9.Visible = true;
            label10.Visible = true;
            
            label13.Visible = true;
            label14.Visible = true;
            label15.Visible = true;
            label16.Visible = true;
            label17.Visible = true;
            label18.Visible = true;
            label19.Visible = true;
            label20.Visible = true;
            label21.Visible = true;
            label22.Visible = true;
            label23.Visible = true;

            comboBox1.Visible = true;
            comboBox2.Visible = true;
            comboBox3.Visible = true;
            comboBox4.Visible = true;
           

           
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            textBox7.Visible = true;
            textBox8.Visible = true;
            textBox9.Visible = true;
            textBox10.Visible = true;
            textBox11.Visible = true;

            button6.Visible = true;
        }

        //обновляем таблицу
        void UpdateTable()
        {
            if(alldata.Count != 0)
            {
                label3.Visible = false;
                dataGridView1.Visible = false;

                dataGridView1.RowCount = alldata.Count + 1;
                dataGridView1.ColumnCount = 18;
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    dataGridView1.Rows[0].Cells[i].Value = alldataTex.AllVariable[i];
                }

                //заполянем таблицу
                for(int i = 1; i <= alldata.Count; i++)
                {
                    dataGridView1.Rows[i].Cells[0].Value = alldata[i - 1].CodeSE.ToString();
                    dataGridView1.Rows[i].Cells[1].Value = alldata[i - 1].TypeMaterial;
                    dataGridView1.Rows[i].Cells[2].Value = alldata[i - 1].Material;
                    dataGridView1.Rows[i].Cells[3].Value = alldata[i - 1].n1.ToString();
                    dataGridView1.Rows[i].Cells[4].Value = alldata[i - 1].n2.ToString();
                    dataGridView1.Rows[i].Cells[5].Value = Math.Round(alldata[i - 1].K_speed, 3).ToString();
                    dataGridView1.Rows[i].Cells[6].Value = Math.Round(alldata[i - 1].C0, 3).ToString();
                    dataGridView1.Rows[i].Cells[7].Value = Math.Round(alldata[i - 1].C3, 3).ToString();
                    dataGridView1.Rows[i].Cells[8].Value = alldata[i - 1].TypeTransmission;
                    dataGridView1.Rows[i].Cells[9].Value = alldata[i - 1].TypeTransmissionStroke;
                    dataGridView1.Rows[i].Cells[10].Value = alldata[i - 1].TypeDminDelta;
                    dataGridView1.Rows[i].Cells[11].Value = alldata[i - 1].TypeCalcul_L;
                    dataGridView1.Rows[i].Cells[12].Value = Math.Round(alldata[i - 1].N, 3);
                    dataGridView1.Rows[i].Cells[13].Value = Math.Round(alldata[i - 1].I, 3);
                    dataGridView1.Rows[i].Cells[14].Value = Math.Round(alldata[i - 1].sigma_0, 3);
                    dataGridView1.Rows[i].Cells[15].Value = Math.Round(alldata[i - 1].delta_0, 3);
                    dataGridView1.Rows[i].Cells[16].Value = Math.Round(alldata[i - 1].gamma, 3);
                    dataGridView1.Rows[i].Cells[17].Value = Math.Round(alldata[i - 1].E, 3);
                }

                label3.Visible = true;
                dataGridView1.Visible = true;
                
            }
            else
            {
                label3.Visible = false;
                dataGridView1.Visible = false;
                dataGridView1.RowCount = 0;
                dataGridView1.ColumnCount = 0;
                ErrorManager.InfoOK("Передачи не добавлены или все удалены!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HideFields();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
        //сохранить
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                bool flag = false;
                bool error = false;
                double n_1 = 0;
                int n_2 = 0;

                string text = "";

                AllVariables data = new AllVariables();
                data.CodeSE = Guid.Parse(label6.Text);

               
                data.TypeTransmission = comboBox1.SelectedItem.ToString();
                data.TypeTransmissionStroke = comboBox2.SelectedItem.ToString();
                data.TypeDminDelta = comboBox3.SelectedItem.ToString();
                data.TypeCalcul_L = comboBox4.SelectedItem.ToString();

                //n1
               
                if (flag)
                {
                        data.n1 = n_2;
                }
                else
                {
                    error = true;
                    text += "Неверный формат данных n1! ";
                }

                //n2 = int.TryParse(textBox2.Text.Replace(".", ","), out n_2);
                if (flag)
                {
                    if (n_2 > 0)
                    {
                        data.n2 = n_2;
                    }
                    else
                    {
                        error = true;
                        text += "Неверный формат данных n2 > 0! ";
                    }
                }
                else
                {
                    error = true;
                    text += "Неверный формат данных n2! ";
                }

                //K_speed
                flag = double.TryParse(textBox8.Text.Replace(".", ","), out n_1);
                if (flag)
                {
                    //среднескоростные
                    if (StaticData.TypeTransmissionStroke[0] == data.TypeTransmissionStroke)
                    {
                        if (n_1 == 2)
                        {
                            data.K_speed = n_1;
                        }
                        else
                        {
                            error = true;
                            text += "Неверный формат данных, для среднескоростных передач K_speed = 2! ";
                        }
                    }
                    else
                    {
                        //быстроскоростные
                        if (n_1 == 1.5)
                        {
                            data.K_speed = n_1;
                        }
                        else
                        {
                            error = true;
                            text += "Неверный формат данных, для быстроскоростных передач K_speed = 1.5! ";
                        }
                    }
                }
                else
                {
                    error = true;
                    text += "Неверный формат данных K_speed! ";
                }

                //C0
                flag = double.TryParse(textBox9.Text.Replace(".", ","), out n_1);
                if (flag)
                {
                    if (n_1 > 0 && n_1 <= 1.0f)
                    {
                        data.C0 = n_1;
                    }
                    else
                    {
                        error = true;
                        text += "Неверный формат данных 0 < С0 <= 1! ";
                    }
                }
                else
                {
                    error = true;
                    text += "Неверный формат данных C0! ";
                }

                //C3
                flag = double.TryParse(textBox10.Text.Replace(".", ","), out n_1);
                if (flag)
                {
                    if (n_1 > 0 && n_1 <= 1.0f)
                    {
                        data.C3 = n_1;
                    }
                    else
                    {
                        error = true;
                        text += "Неверный формат данных 0 < С0 <= 1! ";
                    }
                }
                else
                {
                    error = true;
                    text += "Неверный формат данных C3! ";
                }

                //N
                flag = double.TryParse(textBox3.Text.Replace(".", ","), out n_1);
                if (flag)
                {
                    if (n_1 > 0)
                    {
                        data.N = n_1;
                    }
                    else
                    {
                        error = true;
                        text += "Неверный формат данных N > 0! ";
                    }
                }
                else
                {
                    error = true;
                    text += "Неверный формат данных N! ";
                }

                //I
                flag = double.TryParse(textBox4.Text.Replace(".", ","), out n_1);
                if (flag)
                {
                    //среднескоростные
                    if (data.TypeTransmissionStroke == StaticData.TypeTransmissionStroke[0])
                    {
                        if (n_1 > 0 && n_1 <= 5)
                        {
                            data.I = n_1;
                        }
                        else
                        {
                            error = true;
                            text += "Неверный формат данных для среднескоростной передачи 0 < I <= 5! ";
                        }
                    }
                    else
                    {
                        //быстроскоростные
                        if (n_1 > 0 && n_1 <= 50)
                        {
                            data.I = n_1;
                        }
                        else
                        {
                            error = true;
                            text += "Неверный формат данных для быстроскоростной передачи 0 < I <= 50! ";
                        }
                    }
                }
                else
                {
                    error = true;
                    text += "Неверный формат данных I! ";
                }

                //sigma_0
                flag = double.TryParse(textBox5.Text.Replace(".", ","), out n_1);
                if (flag)
                {
                    if (n_1 > 0 && n_1 <= 10)
                    {
                        data.sigma_0 = n_1;
                    }
                    else
                    {
                        error = true;
                        text += "Неверный формат данных 0 < sigma_0 <= 10! ";
                    }
                }
                else
                {
                    error = true;
                    text += "Неверный формат данных sigma_0! ";
                }

                //delta_0
                flag = double.TryParse(textBox6.Text.Replace(".", ","), out n_1);
                if (flag)
                {
                    if (n_1 >= 1.6 && n_1 <= 10.0)
                    {
                        data.delta_0 = n_1;
                    }
                    else
                    {
                        error = true;
                        text += "Неверный формат данных 0 < delta_0 <= 10! ";
                    }
                }
                else
                {
                    error = true;
                    text += "Неверный формат данных delta_0! ";
                }

                //gamma
                flag = double.TryParse(textBox7.Text.Replace(".", ","), out n_1);
                if (flag)
                {
                    if (n_1 >= 110 && n_1 <= 180)
                    {
                        data.gamma = n_1;
                    }
                    else
                    {
                        error = true;
                        text += "Неверный формат данных 110 <= gamma <= 180! ";
                    }
                }
                else
                {
                    error = true;
                    text += "Неверный формат данных gamma! ";
                }

                //E
                flag = double.TryParse(textBox11.Text.Replace(".", ","), out n_1);
                if (flag)
                {
                    if (n_1 >= 0.01 && n_1 <= 0.02)
                    {
                        data.E = n_1;
                    }
                    else
                    {
                        error = true;
                        text += "Неверный формат данных 0.01 <= E <= 0.02! ";
                    }
                }
                else
                {
                    error = true;
                    text += "Неверный формат данных E! ";
                }

                if (false)
                {
                    ErrorManager.InfoOK(text, "Неверный формат данных");
                }
                else
                {
                    AllVariables olddata = alldata.FirstOrDefault(g => g.CodeSE == data.CodeSE);
                    if (olddata == null)
                    {
                        alldata.Add(data);
                    }
                    else
                    {
                        alldata.Remove(olddata);
                        alldata.Add(data);
                    }
                    //скрыть элементы
                    HideFields();
                    //обновить таблицу
                    UpdateTable();

                }
            }
            catch
            {
                ErrorManager.ErrorOK("Произошла непредвиденная ошибка!");
                Application.Exit();
            }
        }
        //добавить передачу
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //очищаем все поля
                HideFields();

                //показываем поля
                ShowFields();
            }
            catch
            {
                ErrorManager.ErrorOK("Произошла непредвиденная ошибка!");
                Application.Exit();
            }
        }
        //удалить передачу
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (alldata.Count != 0)
                {
                    int row = dataGridView1.CurrentRow.Index;
                    if (row != 0)
                    {
                        AllVariables data = alldata[row - 1];
                        string text = "Вы действительно хотите удалить передачу " + data.CodeSE.ToString() + " ?";
                        string error = "Удаление передачи";
                        DialogResult result = ErrorManager.InfoYesNo(text, error);
                        if (result == DialogResult.Yes)
                        {
                            alldata.Remove(data);
                            UpdateTable();
                        }
                    }
                    else
                    {
                        string text = "Вы не можете удалить эту строку!";
                        ErrorManager.InfoOK(text);
                    }
                }
                else
                {
                    ErrorManager.ErrorOK("Передачи не добавлены!");
                }
            }
            catch
            {
                ErrorManager.ErrorOK("Произошла непредвиденная ошибка!");
                Application.Exit();
            }
        }
        //редактировать передачу
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (alldata.Count != 0)
                {
                    int row = dataGridView1.CurrentRow.Index;
                    if (row != 0)
                    {
                        AllVariables data = alldata[row - 1];
                        ShowFields(data);
                    }
                    else
                    {
                        string text = "Вы не можете редактировать эту строку!";
                        ErrorManager.InfoOK(text);
                    }
                }
                else
                {
                    ErrorManager.ErrorOK("Передачи не добавлены!");
                }
            }
            catch
            {
                ErrorManager.ErrorOK("Произошла непредвиденная ошибка!");
                Application.Exit();
            }
        }
        //просмотреть используемые таблицы
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                Form2 form2 = new Form2(dbContext, alldataTex);
                form2.Show();
            }
            catch
            {
                ErrorManager.ErrorOK("Произошла непредвиденная ошибка!");
                Application.Exit();
            }
        }
        //выполнить расчет
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (alldata.Count != 0)
                {
                    Decision decision = new Decision(dbContext, alldata);

                    Form3 form3 = new Form3(alldataTex, decision.Result());
                    form3.Show();
                }
                else
                {
                    ErrorManager.ErrorOK("Передачи не добавлены!");
                }
            }
            catch
            {
                ErrorManager.ErrorOK("Произошла непредвиденная ошибка!");
                Application.Exit();
            }
        }
    }
}
