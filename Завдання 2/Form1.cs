using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Завдання_2
{
    public partial class frmDiagrams : Form
    {
        
            int mGist, mRound;
            int minAge, minYear;
            double Sum;

            private void btCreateMasRound_Click(object sender, EventArgs e)
            {
                if (txtMasRound.Text == "" || txtMinAge.Text == "")
                { MessageBox.Show("Не все данные введены!", "Ошибка"); }
                else
                {
                    mRound = Int32.Parse(txtMasRound.Text);
                    minAge = Int32.Parse(txtMinAge.Text);

                    if (minAge < 10)
                    { MessageBox.Show("Минимальный возраст для курсов - 10 лет!", "Ошибка"); }
                    else
                    {
                        dgvMasRound.ColumnCount = mRound;
                        for (int j = 0; j < mRound; j++)
                        {
                            dgvMasRound.Columns[j].Width = 180;
                            dgvMasRound.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            dgvMasRound.Columns[j].HeaderText = " Возр. катег. (" + minAge.ToString() + ")";
                            minAge++;
                        }
                    }
                }
            }

            private void btCreateRound_Click(object sender, EventArgs e)
            {
                Sum = 0;
                double[] A = new double[mRound];
                string[] B = new string[mRound];
                minAge = minAge - mRound;

                for (int j = 0; j < mRound; j++)
                {
                    A[j] = Convert.ToDouble(dgvMasRound.Rows[0].Cells[j].Value);
                    B[j] = "Возр. катег. (" + minAge.ToString() + ")";
                    Sum += A[j];
                    minAge++;
                    if (A[j] <= 0)
                    { MessageBox.Show("Среди введённых элементов есть отрицательные или нулевые!", "Ошибка"); }
                }

                if (Sum != 100)
                { MessageBox.Show("Сумма процентного соотношения возрастов должна равняться 100%! Перепроверьте данные!", "Ошибка"); }
                else
                {
                    chartDiagrams.Series[1].Points.DataBindXY(B, A);
                    chartDiagrams.ChartAreas[1].Area3DStyle.Enable3D = true;
                }
            }

            private void btExit_Click(object sender, EventArgs e)
            {
                Application.Exit();
            }

            private void btCreateGist_Click(object sender, EventArgs e)
            {
                int[] C = new int[mGist];
                int[] D = new int[mGist];
                minYear = minYear - mGist;

                for (int j = 0; j < mGist; j++)
                {
                    C[j] = Convert.ToInt32(dgvMasGist.Rows[0].Cells[j].Value);
                    D[j] = minYear;
                    minYear++;
                    if (C[j] < 0)
                    { MessageBox.Show("Среди введённых элементов есть отрицательные!", "Ошибка"); }
                }

                chartDiagrams.Series[0].Points.DataBindXY(D, C);
            }

            private void btCreateMasGist_Click(object sender, EventArgs e)
            {
                if (txtMasGist.Text == "" || txtMinYear.Text == "")
                { MessageBox.Show("Не все данные введены!", "Ошибка"); }
                else
                {
                    minYear = Int32.Parse(txtMinYear.Text);
                    mGist = Int32.Parse(txtMasGist.Text);

                    if (minYear < 2000)
                    { MessageBox.Show("Год начала курсов - 2000-й!", "Ошибка"); }
                    else
                    {
                        dgvMasGist.ColumnCount = mGist;
                        for (int j = 0; j < mGist; j++)
                        {
                            dgvMasGist.Columns[j].Width = 110;

                            dgvMasGist.ColumnHeadersDefaultCellStyle.Alignment =
                                DataGridViewContentAlignment.MiddleCenter;

                            dgvMasGist.Columns[j].HeaderText = minYear.ToString() + " год";
                            minYear++;
                        }
                    }
                }
            }

            public frmDiagrams()
            {
                InitializeComponent();
            }
        }

    }

