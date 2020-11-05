using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JogoDaVelha.Memento;

namespace JogoDaVelha
{
    public partial class Tabuleiro : UserControl
    {
        private int vitoriasX = 0;
        private int vitoriasO = 0;
        private Jogadas jogadas;
        private CareTakerJogadas careTakerJogadas;
        private int quantidadeJogadas = 0;

        public delegate void AtualizarPlacar(string placar);
        AtualizarPlacar atualizarPlacar;
        
        public Tabuleiro(AtualizarPlacar atualizarPlacar)
        {
            jogadas = new Jogadas();
            careTakerJogadas = new CareTakerJogadas();
            this.atualizarPlacar = atualizarPlacar;
            InitializeComponent();
        }

        private void selecionarCell(object sender, EventArgs e)
        {
            Label position = (Label)sender;

            if (string.IsNullOrEmpty(position.Text) && jogadas.jogadarPar)
            {
                position.Text = "X";
                careTakerJogadas.Add(jogadas.CreateMementoJogadas());
                jogadas.SetJogadas(position.Name, "X");
                this.Refresh();
            }
            else if (string.IsNullOrEmpty(position.Text) && !jogadas.jogadarPar)
            {
                position.Text = "O";
                careTakerJogadas.Add(jogadas.CreateMementoJogadas());
                jogadas.SetJogadas(position.Name, "O");
                this.Refresh();
            }

            if (existeVencedor())
            {
                if (exibirMensagemVencedor(position.Text))
                    ResetarTabuleiro();
                else
                    this.Enabled = false;
            }
            else
            {
                quantidadeJogadas++;

                if (resultouEmVelha(quantidadeJogadas))
                {
                    if (exibirMensagemVelha())
                        ResetarTabuleiro();
                    else
                        this.Enabled = false;
                }
            }

            atualizarPlacar.Invoke($"JOGADOR X: {vitoriasX}\n\nJOGADOR O: {vitoriasO}");
        }

        private bool existeVencedor()
        {
            string positionText;

            for (var i = 3; i <= 18; i += 3)
            {
                if (i <= 9)
                {
                    int linha = (i / 3) - 1;

                    positionText = tableLayoutPanel1.GetControlFromPosition(0, linha).Text;

                    if (!string.IsNullOrEmpty(positionText) &&
                    positionText == tableLayoutPanel1.GetControlFromPosition(1, linha).Text &&
                    positionText == tableLayoutPanel1.GetControlFromPosition(2, linha).Text)
                    {
                        marcarVetorVencedor(0, linha, 1, linha, 2, linha);
                        contabilizarVitorias(positionText);
                        return true;
                    }

                    if (linha == 1)
                    {
                        positionText = tableLayoutPanel1.GetControlFromPosition(1, linha).Text;

                        if (!string.IsNullOrEmpty(positionText) &&
                        positionText == tableLayoutPanel1.GetControlFromPosition(0, 0).Text &&
                        positionText == tableLayoutPanel1.GetControlFromPosition(2, 2).Text)
                        {
                            marcarVetorVencedor(0, 0, 1, linha, 2, 2);
                            contabilizarVitorias(positionText);
                            return true;
                        }
                        else if (!string.IsNullOrEmpty(positionText) &&
                        positionText == tableLayoutPanel1.GetControlFromPosition(2, 0).Text &&
                        positionText == tableLayoutPanel1.GetControlFromPosition(0, 2).Text)
                        {
                            marcarVetorVencedor(2, 0, 1, linha, 0, 2);
                            contabilizarVitorias(positionText);
                            return true;
                        }
                    }
                }
                else
                {
                    int coluna = ((i - 9) / 3) - 1;

                    positionText = tableLayoutPanel1.GetControlFromPosition(coluna, 0).Text;

                    if (!string.IsNullOrEmpty(positionText) &&
                    positionText == tableLayoutPanel1.GetControlFromPosition(coluna, 1).Text &&
                    positionText == tableLayoutPanel1.GetControlFromPosition(coluna, 2).Text)
                    {
                        marcarVetorVencedor(coluna, 0, coluna, 1, coluna, 2);
                        contabilizarVitorias(positionText);
                        return true;
                    }
                }                
            }

            return false;
        }

        public bool resultouEmVelha(int quantidadeJogada)
        {
            return quantidadeJogada == 9;
        }

        private void contabilizarVitorias(string jogador)
        {
            if (jogador.Equals("X"))
                vitoriasX += 1;
            else
                vitoriasO += 1;
        }   

        private bool exibirMensagemVencedor(string jogador)
        {
            string mensagem = $"Jogador {jogador} ganhou. Deseja jogar outra vez?";
            string titulo = "Parabéns!!!";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult resultado;

            resultado = MessageBox.Show(mensagem, titulo, buttons);
            
            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                return true;
            }

            return false;
        }

        private bool exibirMensagemVelha()
        {
            string mensagem = "O Jogo deu velha. Deseja jogar outra vez?";
            string titulo = "Não foi dessa vez.";
            MessageBoxButtons botoes = MessageBoxButtons.YesNo;
            DialogResult resultado;

            resultado = MessageBox.Show(mensagem, titulo, botoes);

            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                return true;
            }

            return false;
        }

        private void marcarVetorVencedor(int primeiraPosicaoColuna, int primeiraPosicaoLinha, int segundaPosicaoColuna, int segundaPosicaoLinha, int terceiraPosicaoColuna, int terceiraPosicaoLinha)
        {
            tableLayoutPanel1.GetControlFromPosition(primeiraPosicaoColuna, primeiraPosicaoLinha).BackColor = Color.Yellow;
            tableLayoutPanel1.GetControlFromPosition(segundaPosicaoColuna, segundaPosicaoLinha).BackColor = Color.Yellow;
            tableLayoutPanel1.GetControlFromPosition(terceiraPosicaoColuna, terceiraPosicaoLinha).BackColor = Color.Yellow;
        }

        public void ResetarTabuleiro()
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            label6.BackColor = Color.Transparent;
            label7.BackColor = Color.Transparent;
            label8.BackColor = Color.Transparent;
            label9.BackColor = Color.Transparent;
            this.Enabled = true;
            jogadas.jogadas.Clear();
            careTakerJogadas.mementosJogadas.Clear();
            quantidadeJogadas = 0;
            atualizarPlacar.Invoke($"JOGADOR X: {vitoriasX}\n\nJOGADOR O: {vitoriasO}");
        }

        public void DesfazerJogada()
        {
            if (quantidadeJogadas > 0)
            {
                quantidadeJogadas--;                   
                jogadas.SetMemento(careTakerJogadas.Get());
            }
           
            AtualizarMarcacoes();
        }

        public void AtualizarMarcacoes()
        {
            foreach (Control item in tableLayoutPanel1.Controls)
            {
                Label label = (Label)item;
                
                if (!jogadas.jogadas.ContainsKey(label.Name))
                {
                    label.Text = "";
                    label.BackColor = Color.Transparent;
                }    
            }
        }
    }
}
