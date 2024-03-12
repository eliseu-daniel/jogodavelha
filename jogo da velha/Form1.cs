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

        int jogador1 = 0, jogador2 = 0, empate = 0;
        int click = 1;

        public Form1()
        {
            InitializeComponent();
        }



        private void botaoClique(Object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if(jogador == "X" && b.Text == "")
            {
                b.Text = "X";
                b.BackColor = Color.Red;
                Vencedor();
                jogador = "O";
                click++;
            }else
            {
                b.Text = "O";
                b.BackColor = Color.Green;
                Vencedor();
                jogador = "X";
                click++;
            }
        }

        private void Vencedor()
        {
            if (
                ((btn1.Text == jogador) && (btn2.Text == jogador) && (btn3.Text == jogador)) ||
                ((btn4.Text == jogador) && (btn5.Text == jogador) && (btn6.Text == jogador)) ||
                ((btn7.Text == jogador) && (btn8.Text == jogador) && (btn9.Text == jogador)) ||
                ((btn1.Text == jogador) && (btn4.Text == jogador) && (btn7.Text == jogador)) ||
                ((btn2.Text == jogador) && (btn5.Text == jogador) && (btn8.Text == jogador)) ||
                ((btn3.Text == jogador) && (btn6.Text == jogador) && (btn9.Text == jogador)) ||
                ((btn1.Text == jogador) && (btn5.Text == jogador) && (btn9.Text == jogador)) ||
                ((btn3.Text == jogador) && (btn5.Text == jogador) && (btn7.Text == jogador))
               )
                {
                    if(jogador == "X")
                    {
                        jogador1++;
                        lblContX.Text = jogador1.ToString();
                    }
                    else
                    {
                        jogador2++;
                        lblContO.Text = jogador2.ToString();
                    }
                    
                    MessageBox.Show("O Jogador " + jogador + " venceu!");
                    limpaJogo();
                }
                else
                {
                    if(click>= 9)
                    {
                        empate++;
                        lblContEmpate.Text = empate.ToString();
                        MessageBox.Show("DEU VELHA!!");
                        limpaJogo();
                    }
                }
        }

        private void limpaJogo()
        {
            foreach(Control c in this.Controls)
            {
                if(c is Button)
                {
                    c.Text = string.Empty;
                    c.BackColor = SystemColors.Control;
                }
            }
        }



    }
}
