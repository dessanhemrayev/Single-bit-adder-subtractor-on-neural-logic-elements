using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace neutal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            chart1.Series[0].Points.Clear();
            chart2.Series[0].Points.Clear();
            chart3.Series[0].Points.Clear();
            chart4.Series[0].Points.Clear();
            chart5.Series[0].Points.Clear();
            chart6.Series[0].Points.Clear();
            dataGridView1.Enabled= false;
            this.dataGridView1.SelectionMode =  DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.MultiSelect = false;
           
        }
       
        static List<int> cbs = new List<int>() {0};
        static List<int> cbs1 = new List<int>() { 1 };
        static List<int> p= new List<int>() {  };
        static List<int> ak = new List<int>() {  };
        static List<int> bk = new List<int>() {  };
        static List<int> sk = new List<int>() {  };
        static List<int> pk = new List<int>() {  };
        public static int row = 0;

        private void ClearCharts()
        {
            chart1.Series[0].Points.Clear();
            chart2.Series[0].Points.Clear();
            chart3.Series[0].Points.Clear();
            chart4.Series[0].Points.Clear();
            chart5.Series[0].Points.Clear();
            chart6.Series[0].Points.Clear();


            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Maximum = 8;
            chart1.ChartAreas[0].AxisX.MajorGrid.Interval = 1;

            chart2.ChartAreas[0].AxisX.Minimum = 0;
            chart2.ChartAreas[0].AxisX.Maximum = 8;
            chart2.ChartAreas[0].AxisX.MajorGrid.Interval = 1;

            chart3.ChartAreas[0].AxisX.Minimum = 0;
            chart3.ChartAreas[0].AxisX.Maximum = 8;
            chart3.ChartAreas[0].AxisX.MajorGrid.Interval = 1;

            chart4.ChartAreas[0].AxisX.Minimum = 0;
            chart4.ChartAreas[0].AxisX.Maximum = 8;
            chart4.ChartAreas[0].AxisX.MajorGrid.Interval = 1;

            chart5.ChartAreas[0].AxisX.Minimum = 0;
            chart5.ChartAreas[0].AxisX.Maximum = 8;
            chart5.ChartAreas[0].AxisX.MajorGrid.Interval = 1;


            chart5.ChartAreas[0].AxisX.Minimum = 0;
            chart5.ChartAreas[0].AxisX.Maximum = 8;
            chart5.ChartAreas[0].AxisX.MajorGrid.Interval = 1;


            chart5.ChartAreas[0].AxisX.Minimum = 0;
            chart5.ChartAreas[0].AxisX.Maximum = 8;
            chart5.ChartAreas[0].AxisX.MajorGrid.Interval = 1;

            chart6.ChartAreas[0].AxisX.Minimum = 0;
            chart6.ChartAreas[0].AxisX.Maximum = 8;
            chart6.ChartAreas[0].AxisX.MajorGrid.Interval = 1;
        }

        private int logil2(int a, int b)
        {
            int result;
            bool a1;
            bool b1;
            if (a == 1) 
            {
                a1 = true; 
            }
            else
            {
                a1 = false;
            }
            if (b == 1)
            {
                b1 = true;
            }
            else
            {
                b1 = false;
            }

            if (a1 || b1)
            {
                result = 1;
            }
            else
            {
                result = 0;
            }

            return result;
        }

        private int neuron(int a, int b, int c)
        {
            int res = 0; ;
            if (a * (-1) + 2 * b + -1 * c >= 1)
            {
                res = 1;
            }
            else
            {
                res = 0;
            }
            return res; 
        }
        private void grafik(int cb1)
        {
            for (int i = 0; i < sk.Count; i++)
            {
                if (cb1 == 0)
                {
                    chart1.Series[0].Points.AddXY(i, cbs[i]);
                }
                else
                {
                    chart1.Series[0].Points.AddXY(i, cbs1[i]);
                }

                chart2.Series[0].Points.AddXY(i, p[i]);
                chart3.Series[0].Points.AddXY(i, ak[i]);
                chart4.Series[0].Points.AddXY(i, bk[i]);
                chart5.Series[0].Points.AddXY(i, sk[i]);
                chart6.Series[0].Points.AddXY(i, pk[i]);
            }
            

        
        }

        private void setka()
        {
            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart2.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart2.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart3.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart3.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart4.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart4.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart5.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart5.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart6.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart6.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (checkBox1.Checked)
            {
                setka();
            }
            

            if (textBox5.Text.Length != 0 && row<8)
            {
                ClearCharts();
                textBox1.Text = dataGridView1[1, row].Value.ToString();
                textBox4.Text = dataGridView1[1, row].Value.ToString();
                textBox2.Text = dataGridView1[2, row].Value.ToString();
                textBox3.Text = dataGridView1[0, row].Value.ToString();
                int ai = Convert.ToInt32(textBox1.Text);
                int bi = Convert.ToInt32(textBox2.Text);
                int pi1 = Convert.ToInt32(textBox3.Text);
                int cb = Convert.ToInt32(textBox5.Text);
                dataGridView1.Rows[row].Selected = true;

                ak.Add(ai);
                bk.Add(bi);
                p.Add(pi1);
                //первый НЭ


                int logic1 = logil2(ai, bi);
                textBox15.Text = logic1.ToString();


                int neuronElement1 = neuron(ai, logic1, bi);
                textBox6.Text = neuronElement1.ToString();



                // второй НЭ

                int logic2 = logil2(neuronElement1, pi1);
                textBox7.Text = logic2.ToString();

                int neuronElement2 = neuron(neuronElement1, logic2, pi1);
                textBox12.Text = neuronElement2.ToString();

                dataGridView1[3, row].Value = neuronElement2;
                sk.Add(neuronElement2);


                // третий НЭ
                int logic3 = logil2(ai, cb);
                textBox14.Text = logic3.ToString();

                int neuronElement3 = neuron(ai, logic3, cb);
                textBox10.Text = neuronElement3.ToString();


                // пороговый элемент

                if (pi1 * 1 + neuronElement3 * 1 + bi * 1 >= 2)
                {
                    dataGridView1[4, row].Value = 1;
                    pk.Add(1);
                    textBox13.Text = "1";
                }
                else
                {
                    dataGridView1[4, row].Value = 0;
                    pk.Add(0);
                    textBox13.Text = "0";
                }



                if (cb == 0) {
                    label26.Text = "Si";
                    label27.Text = "Pi";
                    label28.Text = "СВ=0";
                    label32.Text = "Si";
                    label33.Text = "Pi";
                    if (row == 7) {
                        cbs.Add(0);
                        ak.Add(1);
                        bk.Add(1);
                        p.Add(1);
                        pk.Add(1);
                        pk.Add(1);
                        sk.Add(1);
                        button1.Enabled = false;
                    }
                    else
                    {
                        cbs.Add(cb);
                    }
                    
                    grafik(cb);
                }
                else
                {
                    label26.Text = "Ri";
                    label27.Text = "Zi";
                    label28.Text = "СВ=1";
                    label32.Text = "Ri";
                    label33.Text = "Zi";
                    if (row == 7)
                    {
                        cbs1.Add(1);
                        ak.Add(1);
                        bk.Add(1);
                        p.Add(1);
                        pk.Add(1);
                        pk.Add(1);
                        sk.Add(1);
                        button1.Enabled = false;
                    }
                    else
                    {
                        cbs1.Add(cb);
                    }

                    grafik(cb);
                   
                }

                row++;
                

            }
            else
            {
                MessageBox.Show("Введите СВ!!!");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            dataGridView1.RowCount = 8;
            dataGridView1.Columns[0].Width = 94;
            dataGridView1.Columns[1].Width =94;
            dataGridView1.Columns[2].Width = 94;
            dataGridView1.Columns[3].Width = 94;
            dataGridView1.Columns[4].Width = 94;
            int[,] matr = { {0,0,0 },
                            {0,0,1 },
                            {0,1,0 },
                            {0,1,1 },
                            {1,0,0 },
                            {1,0,1 },
                            {1,1,0 },
                            {1,1,1 }};

            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j <matr.GetLength(1); j++)
                {
                    dataGridView1[j, i].Value = matr[i, j];
                }
            }
        }

        private void label30_Click(object sender, EventArgs e)
        {

        }
    }
}
