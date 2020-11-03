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

        public delegate void AlterarPlacar(string placar);
        AlterarPlacar alterarPlacar;
        public Tabuleiro(AlterarPlacar alterarPlacar)
        {
            jogadas = new Jogadas();
            careTakerJogadas = new CareTakerJogadas();
            this.alterarPlacar = alterarPlacar;
            InitializeComponent();
        }

        private void selectCell(object sender, EventArgs e)
        {
            Label position = (Label)sender;

            if (string.IsNullOrEmpty(position.Text) && jogadas.jogadarPar)
            {
                position.Text = "X";
                careTakerJogadas.Add(jogadas.CreateMementoJogadas());
                jogadas.SetJogadas(position.Name, "X");
                this.Refresh();
                verificarResultado();
            }
            else if (string.IsNullOrEmpty(position.Text) && !jogadas.jogadarPar)
            {
                position.Text = "O";
                careTakerJogadas.Add(jogadas.CreateMementoJogadas());
                jogadas.SetJogadas(position.Name, "O");
                this.Refresh();
                verificarResultado();
            }

            quantidadeJogadas++;
        }

        private void verificarResultado()
        {
            verificarHorizontal();
            VerificarVertical();
            verificarDiagonal();
        }

        private void verificarDiagonal()
        {
            
        }

        /*
        private void Verificar(int rowStep, int columnStep)
        {
            string lastValue = null;

            for (var i = 0; i <= 2; i += rowStep)
            {
                for (var i = 0; i <= 2; i += columnStep)
                {
                    
                }
            }
            for (int contColumn = 0; contColumn <= 2; contColumn++)
            {
                var positionText = tableLayoutPanel1.GetControlFromPosition(contColumn, 0).Text;

                if (!string.IsNullOrEmpty(positionText) &&
                    positionText == tableLayoutPanel1.GetControlFromPosition(contColumn, 1).Text &&
                    positionText == tableLayoutPanel1.GetControlFromPosition(contColumn, 2).Text)
                {
                    marcarVetorVencedor(contColumn, 0, contColumn, 1, contColumn, 2);
                    if (showWinMessage(positionText))
                        ResetTabuleiro();
                    else
                        this.Enabled = false;

                    contabilizarVitoria(positionText);
                }
            }
        }
        */
        
        private void VerificarVertical()
        {
            for (int contColumn = 0; contColumn <= 2; contColumn++)
            {
                var positionText = tableLayoutPanel1.GetControlFromPosition(contColumn, 0).Text;
               
                if (!string.IsNullOrEmpty(positionText) && 
                    positionText == tableLayoutPanel1.GetControlFromPosition(contColumn, 1).Text &&
                    positionText == tableLayoutPanel1.GetControlFromPosition(contColumn, 2).Text)
                {
                    marcarVetorVencedor(contColumn, 0, contColumn, 1, contColumn, 2);
                    if (showWinMessage(positionText))
                        ResetTabuleiro();
                    else
                        this.Enabled = false;

                    contabilizarVitoria(positionText);
                }
            }
        }


        private void verificarHorizontal()
        {
            for (int contRow = 0; contRow <= 2; contRow++)
            {
                var positionText = tableLayoutPanel1.GetControlFromPosition(0, contRow).Text;

                if (!string.IsNullOrEmpty(positionText) &&
                    tableLayoutPanel1.GetControlFromPosition(1, contRow).Text.Equals(positionText) &&
                    tableLayoutPanel1.GetControlFromPosition(2, contRow).Text.Equals(positionText))
                {
                    marcarVetorVencedor(0, contRow, 1, contRow, 2, contRow);

                    if (showWinMessage(positionText))
                        ResetTabuleiro();
                    else
                    {
                        this.Enabled = false;
                    }

                    contabilizarVitoria(positionText);
                }
            }
        }

        private void contabilizarVitoria(string jogador)
        {
            if (jogador.Equals("X"))
                vitoriasX += 1;
            else
                vitoriasO += 1;

            alterarPlacar.Invoke($"JOGADOR X: {vitoriasX}\n\nJOGADOR O: {vitoriasO}");
        }   

        private bool showWinMessage(string jogador)
        {
            string message = $"Jogador {jogador} ganhou. Deseja jogar outra vez?";
            string caption = "Error Detected in Input";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);
            
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                // Closes the parent form.
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

        public void ResetTabuleiro()
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
            alterarPlacar.Invoke($"JOGADOR X: {vitoriasX}\n\nJOGADOR O: {vitoriasO}");
        }

        public void desfazerJogada()
        {
            if (quantidadeJogadas > 0)
            {
                quantidadeJogadas--;                   
                jogadas.SetMemento(careTakerJogadas.Get());
            }
            //else
            //    _jogadas.SetMemento(_careTakerJogadas.Get(_quantidadeJogadas));
                
            atualizarMarcacoes();
            
        }

        public void atualizarMarcacoes()
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
