using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.BorodulinMS.Sprint6.Review.V6.Lib;
namespace Tyuiu.BorodulinMS.Sprint6.Review.V5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        DataService ds = new DataService();

        int[,] mrtx;
        private void buttonDone_BMS_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox_N_BMS.Text) > 1 && Convert.ToInt32(textBox_M_BMS.Text) > 1)
            {
                int N = Convert.ToInt32(textBox_N_BMS.Text);
                int M = Convert.ToInt32(textBox_M_BMS.Text);
                int K = Convert.ToInt32(textBox_k_BMS.Text);
                int L = Convert.ToInt32(textBox_l_BMS.Text);
                int C = Convert.ToInt32(textBox_c_BMS.Text);
                int n1 = Convert.ToInt32(textBox_n1_BMS.Text);
                int n2 = Convert.ToInt32(textBox_n2_BMS.Text);
                int x  = Convert.ToInt32(textBox_x_BMS.Text);

                /*int[,] mrtx = new int[N, M];



                // Заполнение массива с чередованием числа X
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < M; j++)
                    {
                        if (j % 2 == 0)
                        {
                            mrtx[i, j] = x;
                        }
                        else
                        {
                            mrtx[i, j] = rnd.Next(n1, n2);
                        }
                    }
                }
                */


                // Подсчет нечетных элементов в заданном столбце C с номерами от K до L
                int oddCount = 0;
                for (int i = K; i <= L; i++)
                {
                    if (mrtx[i, C] % 2 != 0)
                    {
                        oddCount++;
                    }
                }

                // Вывод результата в текстовое поле
                textBoxResult_BMS.Text = oddCount.ToString();

               
            }
            else
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void textBox_l_BMS_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonHelp_BMS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ТаскРевью 6 выполнил студент группы ИИПБ-23-1 Бородулин Матвей Сергеевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonMatrix_BMS_Click(object sender, EventArgs e)
        {

            int N = Convert.ToInt32(textBox_N_BMS.Text);
            int M = Convert.ToInt32(textBox_M_BMS.Text);
            int n1 = Convert.ToInt32(textBox_n1_BMS.Text);
            int n2 = Convert.ToInt32(textBox_n2_BMS.Text);
            int x = Convert.ToInt32(textBox_x_BMS.Text);

            mrtx = new int[N, M];

            Random rnd = new Random();

            // Заполнение массива с чередованием числа X
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (j % 2 == 0)
                    {
                        mrtx[i, j] = x;
                    }
                    else
                    {
                        mrtx[i, j] = rnd.Next(n1, n2);
                    }
                }
            }
          

            // Отображение массива в DataGridView
            dataGridViewMatrix_BMS.RowCount = N;
            dataGridViewMatrix_BMS.ColumnCount = M;
            for (int i = 0; i < N; i++)
            {
                dataGridViewMatrix_BMS.Columns[i].Width = 25;
            }

            for (int r = 0; r < N; r++)
            {
                for (int c = 0; c < M; c++)
                {
                    dataGridViewMatrix_BMS.Rows[r].Cells[c].Value = mrtx[r, c];
                }
            }
        }
    }
}
