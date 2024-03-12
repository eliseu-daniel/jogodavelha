using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jogo_da_velha
{
    public partial class Form1 : Form
    {
        string jogador = "X";

        int jogador1 = 0, jogador2 = 0;

        public Form1()
        {
            InitializeComponent();
        }



        private void btn1_Click(object sender, EventArgs e)
        {
            if (btn1.Text == "")
            {
                if (jogador == "X")
                {
                    btn1.Text = "X";
                    btn1.BackColor = Color.Red;
                    jogador = "O";
                }
                else
                {
                    btn1.Text = "O";
                    btn1.BackColor = Color.Blue;
                    jogador = "X";

                }
            }

            //somando pontos
            if (btn1.Text == "X")
            {
                jogador1 = jogador1++;
            }
            else
            {
                jogador2 = jogador2++;
            }

            //conferindo ganhador
            if (jogador1 == 3)
            {
                lblContX.Text = Convert.ToString(jogador1 + 1);
            }
            if (jogador2 == 3)
            {
                lblContO.Text = Convert.ToString(jogador2);
            }

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (btn2.Text == "")
            {
                if (jogador == "X")
                {
                    btn2.Text = "X";
                    btn2.BackColor = Color.Red;
                    jogador = "O";
                }
                else
                {
                    btn2.Text = "O";
                    btn2.BackColor = Color.Blue;
                    jogador = "X";

                }
            }

            //somando pontos
            if (btn1.Text == "X")
            {
                jogador1 = jogador1++;
            }
            else
            {
                jogador2 = jogador2++;
            }

            //conferindo ganhador
            if (jogador1 == 3)
            {
                lblContX.Text = Convert.ToString(jogador1);
            }
            if (jogador2 == 3)
            {
                lblContO.Text = Convert.ToString(jogador2);
            }

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (btn3.Text == "")
            {
                if (jogador == "X")
                {
                    btn3.Text = "X";
                    btn3.BackColor = Color.Red;
                    jogador = "O";
                }
                else
                {
                    btn3.Text = "O";
                    btn3.BackColor = Color.Blue;
                    jogador = "X";

                }
            }

            //somando pontos
            if (btn1.Text == "X")
            {
                jogador1 = jogador1++;
            }
            else
            {
                jogador2 = jogador2++;
            }

            //conferindo ganhador
            if (jogador1 == 3)
            {
                lblContX.Text = Convert.ToString(jogador1);
            }
            if (jogador2 == 3)
            {
                lblContO.Text = Convert.ToString(jogador2);
            }

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (btn4.Text == "")
            {
                if (jogador == "X")
                {
                    btn4.Text = "X";
                    btn4.BackColor = Color.Red;
                    jogador = "O";
                }
                else
                {
                    btn4.Text = "O";
                    btn4.BackColor = Color.Blue;
                    jogador = "X";

                }
            }

            //somando pontos
            if (btn1.Text == "X")
            {
                jogador1 = jogador1++;
            }
            else
            {
                jogador2 = jogador2++;
            }

            //conferindo ganhador
            if (jogador1 == 3)
            {
                lblContX.Text = Convert.ToString(jogador1);
            }
            if (jogador2 == 3)
            {
                lblContO.Text = Convert.ToString(jogador2);
            }

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (btn5.Text == "")
            {
                if (jogador == "X")
                {
                    btn5.Text = "X";
                    btn5.BackColor = Color.Red;
                    jogador = "O";
                }
                else
                {
                    btn5.Text = "O";
                    btn5.BackColor = Color.Blue;
                    jogador = "X";

                }
            }

            //somando pontos
            if (btn1.Text == "X")
            {
                jogador1 = jogador1++;
            }
            else
            {
                jogador2 = jogador2++;
            }

            //conferindo ganhador
            if (jogador1 == 3)
            {
                lblContX.Text = Convert.ToString(jogador1);
            }
            if (jogador2 == 3)
            {
                lblContO.Text = Convert.ToString(jogador2);
            }

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (btn6.Text == "")
            {
                if (jogador == "X")
                {
                    btn6.Text = "X";
                    btn6.BackColor = Color.Red;
                    jogador = "O";
                }
                else
                {
                    btn6.Text = "O";
                    btn6.BackColor = Color.Blue;
                    jogador = "X";

                }
            }

            //somando pontos
            if (btn1.Text == "X")
            {
                jogador1 = jogador1++;
            }
            else
            {
                jogador2 = jogador2++;
            }

            //conferindo ganhador
            if (jogador1 == 3)
            {
                lblContX.Text = Convert.ToString(jogador1);
            }
            if (jogador2 == 3)
            {
                lblContO.Text = Convert.ToString(jogador2);
            }

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (btn7.Text == "")
            {
                if (jogador == "X")
                {
                    btn7.Text = "X";
                    btn7.BackColor = Color.Red;
                    jogador = "O";
                }
                else
                {
                    btn7.Text = "O";
                    btn7.BackColor = Color.Blue;
                    jogador = "X";

                }
            }

            //somando pontos
            if (btn1.Text == "X")
            {
                jogador1 = jogador1++;
            }
            else
            {
                jogador2 = jogador2++;
            }

            //conferindo ganhador
            if (jogador1 == 3)
            {
                lblContX.Text = Convert.ToString(jogador1);
            }
            if (jogador2 == 3)
            {
                lblContO.Text = Convert.ToString(jogador2);
            }

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (btn8.Text == "")
            {
                if (jogador == "X")
                {
                    btn8.Text = "X";
                    btn8.BackColor = Color.Red;
                    jogador = "O";
                }
                else
                {
                    btn8.Text = "O";
                    btn8.BackColor = Color.Blue;
                    jogador = "X";

                }
            }

            //somando pontos
            if (btn1.Text == "X")
            {
                jogador1 = jogador1++;
            }
            else
            {
                jogador2 = jogador2++;
            }

            //conferindo ganhador
            if (jogador1 == 3)
            {
                lblContX.Text = Convert.ToString(jogador1);
            }
            if (jogador2 == 3)
            {
                lblContO.Text = Convert.ToString(jogador2);
            }

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (btn9.Text == "")
            {
                if (jogador == "X")
                {
                    btn9.Text = "X";
                    btn9.BackColor = Color.Red;
                    jogador = "O";
                }
                else
                {
                    btn9.Text = "O";
                    btn9.BackColor = Color.Blue;
                    jogador = "X";

                }
            }

            //somando pontos
            if (btn1.Text == "X")
            {
                jogador1 = jogador1++;
            }
            else
            {
                jogador2 = jogador2++;
            }

            //conferindo ganhador
            if(jogador1 == 3)
            {
                lblContX.Text = Convert.ToString(jogador1);
            }
            if(jogador2 == 3)
            {
                lblContO.Text = Convert.ToString(jogador2);
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btn1.Text =
            btn2.Text =
            btn3.Text =
            btn4.Text =
            btn5.Text =
            btn6.Text =
            btn7.Text =
            btn8.Text =
            btn9.Text = string.Empty;

            btn1.BackColor = 
            btn2.BackColor =
            btn3.BackColor =
            btn4.BackColor =
            btn5.BackColor =
            btn6.BackColor =
            btn7.BackColor =
            btn8.BackColor =
            btn9.BackColor = DefaultBackColor;
        }
    }
}
