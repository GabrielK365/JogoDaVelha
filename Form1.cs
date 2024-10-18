namespace JogaDaVelha
{
    public partial class Form1 : Form
    {
        //Button[] botoes = new Button[] { Btn1, Btn2, Btn3, Btn4, Btn5, Btn6, Btn7, Btn8, Btn9 };
        string turno = "j1";
        string jogador1 = "";
        string jogador2 = "";

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LimparTabuleiro(false);
        }

        private void LimparTabuleiro(bool habilita)
        {
            Btn1.Text = string.Empty;
            Btn2.Text = string.Empty;
            Btn3.Text = string.Empty;
            Btn4.Text = string.Empty;
            Btn5.Text = string.Empty;
            Btn6.Text = string.Empty;
            Btn7.Text = string.Empty;
            Btn8.Text = string.Empty;
            Btn9.Text = string.Empty;
            Btn1.Enabled = habilita;
            Btn2.Enabled = habilita;
            Btn3.Enabled = habilita;
            Btn4.Enabled = habilita;
            Btn5.Enabled = habilita;
            Btn6.Enabled = habilita;
            Btn7.Enabled = habilita;
            Btn8.Enabled = habilita;
            Btn9.Enabled = habilita;
        }

        private void BtnX_Click(object sender, EventArgs e)
        {
            if (jogador1 == "")
            {
                jogador1 = "X";
                jogador2 = "O";
                BtnIniciar.Enabled = true;
                LblJogadorX.Text = "Jogador 1";
                LblJogadorO.Text = "Jogador 2";

            }
        }

        private void BtnO_Click(object sender, EventArgs e)
        {
            if (jogador1 == string.Empty)
            {
                jogador1 = "O";
                jogador2 = "X";
                BtnIniciar.Enabled = true;
                LblJogadorO.Text = "Jogador 1";
                LblJogadorX.Text = "Jogador 2";

            }
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Btn1.Text))
                return;

            if (turno == "j1")
            {
                Btn1.Text = jogador1;
                turno = "j2";
            }
            else
            {
                Btn1.Text = jogador2;
                turno = "j1";
            }
            VerificarVencedor();
        }

        private void VerificarVencedor()
        {
            if(Btn1.Text == jogador1 && Btn2.Text == jogador1 && Btn3.Text == jogador1)
            {
                ResetarPartida(jogador1);
            }
        }

        private void ResetarPartida(string jogadorVitorioso)
        {
            LimparTabuleiro(false);
            turno = "j1";
            BtnIniciar.Enabled = false;
            LblJogadorX.Text = "<<<";
            LblJogadorO.Text = ">>>";
            MessageBox.Show("Vitória do jogador " + jogadorVitorioso);
            jogador1 = "";
            jogador2 = "";
        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            turno = "j1";
            BtnIniciar.Enabled = false;
            BtnReiniciar.Enabled = true;
            LimparTabuleiro(true);

        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Btn2.Text))
                return;
            if (turno == "j1")
            {
                Btn2.Text = jogador1;
                turno = "j2";
            }
            else
            {
                Btn2.Text = jogador2;
                turno = "j1";
            }
            VerificarVencedor();
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Btn3.Text))
                return;
            if (turno == "j1")
            {
                Btn3.Text = jogador1;
                turno = "j2";
            }
            else
            {
                Btn3.Text = jogador2;
                turno = "j1";
            }
            VerificarVencedor();
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Btn4.Text))
                return;
            if (turno == "j1")
            {
                Btn4.Text = jogador1;
                turno = "j2";
            }
            else
            {
                Btn4.Text = jogador2;
                turno = "j1";
            }
            VerificarVencedor();
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Btn5.Text))
                return;
            if (turno == "j1")
            {
                Btn5.Text = jogador1;
                turno = "j2";
            }
            else
            {
                Btn5.Text = jogador2;
                turno = "j1";
            }
            VerificarVencedor();
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Btn6.Text))
                return;
            if (turno == "j1")
            {
                Btn6.Text = jogador1;
                turno = "j2";
            }
            else
            {
                Btn6.Text = jogador2;
                turno = "j1";
            }
            VerificarVencedor();
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Btn7.Text))
                return;
            if (turno == "j1")
            {
                Btn7.Text = jogador1;
                turno = "j2";
            }
            else
            {
                Btn7.Text = jogador2;
                turno = "j1";
            }
            VerificarVencedor();
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Btn8.Text))
                return;
            if (turno == "j1")
            {
                Btn8.Text = jogador1;
                turno = "j2";
            }
            else
            {
                Btn8.Text = jogador2;
                turno = "j1";
            }
            VerificarVencedor();
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Btn9.Text))
                return;
            if (turno == "j1")
            {
                Btn9.Text = jogador1;
                turno = "j2";
            }
            else
            {
                Btn9.Text = jogador2;
                turno = "j1";
            }
            VerificarVencedor();
        }

        private void BtnReiniciar_Click(object sender, EventArgs e)
        {
            LimparTabuleiro(true);
            Btn1.Enabled = false;
            Btn2.Enabled = false;
            Btn3.Enabled = false;
            Btn4.Enabled = false;
            Btn5.Enabled = false;
            Btn6.Enabled = false;
            Btn7.Enabled = false;
            Btn8.Enabled = false;
            Btn9.Enabled = false;
            turno = "j1";
            LblJogadorX.Text = "<<<";
            LblJogadorO.Text = ">>>";
            jogador1 = "";
            jogador2 = "";
        }
    }
}
