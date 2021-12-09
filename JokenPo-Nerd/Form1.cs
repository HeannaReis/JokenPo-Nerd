using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JokenPo_Nerd
{
    public partial class Form1 : Form
    {
        string[] cpulist = { "r", "p", "s", "l", "k", "r", "p", "s", "l", "k" };
        public int aleatorio;
        string armas;
        Random rnd  = new Random();
        string suajogada;
        int jogador = 0 ;
        int computador = 0;
        string motivo = "";
        
        public Form1()
        {
            InitializeComponent();
            suajogada = "nada";
            pictureBox2.Image = Properties.Resources.i;
            pictureBox1.Image = Properties.Resources.i;
            button1.Enabled = false;
        }
         private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void pblagarto_Click(object sender, EventArgs e)
        {
            suajogada = "l";
            pictureBox1.Image = Properties.Resources.l;
            pbpapel.Visible = false;
            pbpedra.Visible = false;
            pbtesoura.Visible = false;
            pbspock.Visible = false;
            pblagarto.Visible = false;
            button1.Enabled = true;
        }
        private void pbpapel_Click(object sender, EventArgs e)
        {
            suajogada = "p";
            pictureBox1.Image = Properties.Resources.p;
            pblagarto.Visible = false;
            pbpedra.Visible = false;
            pbtesoura.Visible = false;
            pbspock.Visible = false;
            pbpapel.Visible = false;
            button1.Enabled = true;
        }
        private void pbpedra_Click(object sender, EventArgs e)
        {
            suajogada = "r";
            pictureBox1.Image = Properties.Resources.r;
            pblagarto.Visible = false;
            pbpapel.Visible = false;
            pbtesoura.Visible = false;
            pbspock.Visible = false;
            pbpedra.Visible = false;
            button1.Enabled = true;
        }
        private void pbtesoura_Click(object sender, EventArgs e)
        {
            suajogada = "s";
            pictureBox1.Image = Properties.Resources.s;
            pblagarto.Visible = false;
            pbpedra.Visible = false;
            pbpapel.Visible = false;
            pbspock.Visible = false;
            pbtesoura.Visible = false;
            button1.Enabled = true;
        }
        private void pbspock_Click(object sender, EventArgs e)
        {
            suajogada = "k";
            pictureBox1.Image = Properties.Resources.k;
            pblagarto.Visible = false;
            pbpedra.Visible = false;
            pbtesoura.Visible = false;
            pbpapel.Visible = false;
            pbspock.Visible = false;
            button1.Enabled = true;
        }        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pblagarto.Visible = true;
            pbpedra.Visible = true;
            pbtesoura.Visible = true;
            pbspock.Visible = true;
            pbpapel.Visible = true;
            pictureBox1.Image = Properties.Resources.i;
            button1.Enabled = false;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
         
        }
        private void button1_Click(object sender, EventArgs e)
        {
            aleatorio = rnd.Next(0, 5);
            armas = cpulist[aleatorio];
            pbpapel.Visible = false;
            pbpedra.Visible = false;
            pbtesoura.Visible = false;
            pbspock.Visible = false;
            pblagarto.Visible = false;


            switch (armas)
            {
                case "l":
                    pictureBox2.Image = Properties.Resources.l;
                    break;
                case "r":
                    pictureBox2.Image = Properties.Resources.r;
                    break;
                case "p":
                    pictureBox2.Image = Properties.Resources.p;
                    break;
                case "s":
                    pictureBox2.Image = Properties.Resources.s;
                    break;
                case "k":
                    pictureBox2.Image = Properties.Resources.k;
                    break;

                default:
                    break;
            }


            if (suajogada == armas)
            {
                MessageBox.Show("Empate !!! Vamos de Novo ??? ");
            }


            if (suajogada == "s" && armas == "p")
            {
                motivo = " Tesoura corta papel!";
                jogador++;
                label3.Text = jogador.ToString();
                MessageBox.Show(textBox1.Text + ", Você Venceu !!! " + motivo);
            }
            else if (suajogada == "p" && armas == "s")
            {
                motivo = " Tesoura corta papel!";
                computador++;
                label4.Text = computador.ToString();
                MessageBox.Show(textBox1.Text + " ... Perdeu !!!" + motivo);
            }
          

            if (suajogada == "p" && armas == "r")
            {
                motivo = " Papel Embrulha Pedra !";
                jogador++;
                label3.Text = jogador.ToString();
                MessageBox.Show(textBox1.Text + ", Você Venceu !!! " + motivo);
            }
            else if (suajogada == "r" && armas == "p")
            {
                motivo = " Papel Embrulha Pedra !";
                computador++;
                label4.Text = computador.ToString();
                MessageBox.Show(textBox1.Text + " ... Perdeu !!!" + motivo);
            }
            if (suajogada == "r" && armas == "l")
            {
                motivo = " Pedra esmaga Lagarto !";
                jogador++;
                label3.Text = jogador.ToString();
                MessageBox.Show(textBox1.Text + ", Você Venceu !!! " + motivo);
            }
            else if (suajogada == "l" && armas == "r")
            {
                motivo = " Pedra esmaga Lagarto !";
                computador++;
                label4.Text = computador.ToString();
                MessageBox.Show(textBox1.Text + " ... Perdeu !!!" + motivo);
            }
            if (suajogada == "l" && armas == "k")
            {
                motivo = " Lagarto Envenena Spock !";
                jogador++;
                label3.Text = jogador.ToString();
                MessageBox.Show(textBox1.Text + ", Você Venceu !!! " + motivo);
            }

            else if (suajogada == "k" && armas == "l")
            {
                motivo = " Lagarto Envenena Spock !";
                computador++;
                label4.Text = computador.ToString();
                MessageBox.Show(textBox1.Text + " ... Perdeu !!!" + motivo);
            }
            if (suajogada == "k" && armas == "s")
            {
                motivo = " Spock derrete Tesoura !";
                jogador++;
                label3.Text = jogador.ToString();
                MessageBox.Show(textBox1.Text + ", Você Venceu !!! " + motivo);
            }
            else if (suajogada == "s" && armas == "k")
            {
                motivo = " Spock derrete Tesoura !";
                computador++;
                label4.Text = computador.ToString();
                MessageBox.Show(textBox1.Text + " ... Perdeu !!!" + motivo);
            }
            if (suajogada == "s" && armas == "l")
            {
                motivo = " Tesoura Decapita Lagarto !";
                jogador++;
                label3.Text = jogador.ToString();
                MessageBox.Show(textBox1.Text + ", Você Venceu !!! " + motivo);
            }
            else if (suajogada == "l" && armas == "s")
            {
                motivo = " Tesoura Decapita Lagarto !";
                computador++;
                label4.Text = computador.ToString();
                MessageBox.Show(textBox1.Text + " ... Perdeu !!!" + motivo);
            }
            if (suajogada == "l" && armas == "p")
            {
                motivo = " Lagarto come Papel !";
                jogador++;
                label3.Text = jogador.ToString();
                MessageBox.Show(textBox1.Text + ", Você Venceu !!! " + motivo);
            }
            else if (suajogada == "p" && armas == "l")
            {
                motivo = " Lagarto come Papel !";
                computador++;
                label4.Text = computador.ToString();
                MessageBox.Show(textBox1.Text + " ... Perdeu !!!" + motivo);
            }
            if (suajogada == "p" && armas == "k")
            {
                motivo = " Papel refuta Spock !";
                jogador++;
                label3.Text = jogador.ToString();
                MessageBox.Show(textBox1.Text + ", Você Venceu !!! " + motivo);
            }
            else if (suajogada == "k" && armas == "p")
            {
                motivo = " Papel refuta Spock !";
                computador++;
                label4.Text = computador.ToString();
                MessageBox.Show(textBox1.Text + " ... Perdeu !!!" + motivo);
            }
            if (suajogada == "k" && armas == "r")
            {
                motivo = " Spock vaporiza Pedra !";
                jogador++;
                label3.Text = jogador.ToString();
                MessageBox.Show(textBox1.Text + ", Você Venceu !!! " + motivo);
            }
            else if (suajogada == "r" && armas == "k")
            {
                motivo = " Spock vaporiza Pedra !";
                computador++;
                label4.Text = computador.ToString();
                MessageBox.Show(textBox1.Text + " ... Perdeu !!!" + motivo);
            }
            if (suajogada == "r" && armas == "s")
            {
                motivo = " Pedra Quebra Tesoura !";
                jogador++;
                label3.Text = jogador.ToString();
                MessageBox.Show(textBox1.Text + ", Você Venceu !!! " + motivo);
            }
            else if (suajogada == "s" && armas == "r")
            {
                motivo = " Pedra Quebra Tesoura !";
                computador++;
                label4.Text = computador.ToString();
                MessageBox.Show(textBox1.Text + " ... Perdeu !!!" + motivo);
            }

            pblagarto.Visible = true;
            pbpedra.Visible = true;
            pbtesoura.Visible = true;
            pbspock.Visible = true;
            pbpapel.Visible = true;
            pictureBox2.Image = Properties.Resources.i;
            pictureBox1.Image = Properties.Resources.i;
            button1.Enabled = false;
            {
            
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }
        private void label4_Click(object sender, EventArgs e)
        {
            
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Até logo " + textBox1.Text);
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        { 
            label5.Text = (" Olá ") + textBox1.Text + (", Vamos jogar Pedra, Papel, Tesoura, Lagarto, Spock ??");
            label6.Text = textBox1.Text;
            textBox1.Visible = false;
            button3.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            jogador = 0;
            computador = 0;
            label3.Text = jogador.ToString();
            label4.Text = computador.ToString();
            label6.Text = "Jogador";    
            textBox1.Visible = true;
            button3.Visible = true;
            label5.Text = " Digite seu Nome e Tecle Ok !!! ";
        }
    }
}


