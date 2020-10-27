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
        private bool _jogadaPar = true;
        private int _vitoriasX = 0;
        private int _vitoriasO = 0;
        private Jogadas _jogadas;
        private CareTakerJogadas _careTakerJogadas;
        private int _quantidadeJogadas = 1;

        public delegate void AlterarPlacar(string placar);
        AlterarPlacar alterarPlacar;
        public Tabuleiro(AlterarPlacar alterarPlacar)
        {
            _jogadas = new Jogadas();
            _careTakerJogadas = new CareTakerJogadas();
            this.alterarPlacar = alterarPlacar;
            InitializeComponent();
        }

        private void selectCell(object sender, EventArgs e)
        {
            Label position = (Label)sender;

            if (string.IsNullOrEmpty(position.Text) && _jogadaPar)
            {
                position.Text = "X";
                _jogadaPar = false;
                _jogadas.SetJogadas(position.Name, "X");
                _careTakerJogadas.Add(_jogadas.CreateMementoJogadas());
                this.Refresh();
                verificarResultado();
            }
            else if (string.IsNullOrEmpty(position.Text) && !_jogadaPar)
            {
                position.Text = "O";
                _jogadaPar = true;
                _jogadas.SetJogadas(position.Name, "O");
                _careTakerJogadas.Add(_jogadas.CreateMementoJogadas());
                this.Refresh();
                verificarResultado();
            }

            _quantidadeJogadas++;
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

        private void VerificarVertical()
        {
            for (int contColumn = 0; contColumn <= 2; contColumn++)
            {
                if (tableLayoutPanel1.GetControlFromPosition(contColumn, 0).Text.Equals("X") &&
                    tableLayoutPanel1.GetControlFromPosition(contColumn, 1).Text.Equals("X") &&
                    tableLayoutPanel1.GetControlFromPosition(contColumn, 2).Text.Equals("X"))
                {
                    marcarVetorVencedor(contColumn, 0, contColumn, 1, contColumn, 2);
                    if (showWinMessage("X"))
                        ResetTabuleiro();
                    else
                        this.Enabled = false;

                    contabilizarVitoria("X");
                }
                else 
                if (tableLayoutPanel1.GetControlFromPosition(contColumn, 0).Text.Equals("O") &&
                    tableLayoutPanel1.GetControlFromPosition(contColumn, 1).Text.Equals("O") &&
                    tableLayoutPanel1.GetControlFromPosition(contColumn, 2).Text.Equals("O"))

                {
                    marcarVetorVencedor(contColumn, 0, contColumn, 1, contColumn, 2);

                    if (showWinMessage("O"))
                        ResetTabuleiro();
                    else
                        this.Enabled = false;

                    contabilizarVitoria("O");
                }
            }
        }

        private void contabilizarVitoria(string jogador)
        {
            if (jogador.Equals("X"))
                _vitoriasX++;
            else
                _vitoriasO++;

            alterarPlacar.Invoke($"JOGADOR X: {_vitoriasX}\n\nJOGADOR O: {_vitoriasO}");
        }   

        private void verificarHorizontal()
        {
            for (int contRow = 0; contRow <= 2; contRow++)
            {
                if (tableLayoutPanel1.GetControlFromPosition(0, contRow).Text.Equals("X") &&
                    tableLayoutPanel1.GetControlFromPosition(1, contRow).Text.Equals("X") &&
                    tableLayoutPanel1.GetControlFromPosition(2, contRow).Text.Equals("X"))
                {
                    marcarVetorVencedor(0, contRow, 1, contRow, 2, contRow);

                    if (showWinMessage("X"))
                        ResetTabuleiro();
                    else
                    {
                        this.Enabled = false;
                    }

                    contabilizarVitoria("X");
                }
                else
                if (tableLayoutPanel1.GetControlFromPosition(0, contRow).Text.Equals("O") &&
                    tableLayoutPanel1.GetControlFromPosition(1, contRow).Text.Equals("O") &&
                    tableLayoutPanel1.GetControlFromPosition(2, contRow).Text.Equals("O"))
                {
                    marcarVetorVencedor(0, contRow, 1, contRow, 2, contRow);

                    if (showWinMessage("O"))
                        ResetTabuleiro();
                    else
                    {
                        this.Enabled = false;
                    }

                    contabilizarVitoria("O");
                }
            }
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
            _vitoriasO = 0;
            _vitoriasX = 0;

            alterarPlacar.Invoke($"JOGADOR X: {_vitoriasX}\n\nJOGADOR O: {_vitoriasO}");
        }

        public void desfazerJogada()
        {
            if (_quantidadeJogadas > 0)
            {
                _quantidadeJogadas--;
                if (_quantidadeJogadas > 0)
                    _jogadas.SetMemento(_careTakerJogadas.Get(_quantidadeJogadas - 1));
                else
                    _jogadas.SetMemento(_careTakerJogadas.Get(_quantidadeJogadas));
                
                atualizarMarcacoes();
            }
        }

        public void atualizarMarcacoes()
        {
            foreach (Control item in tableLayoutPanel1.Controls)
            {
                Label label = (Label)item;
                
                if (!_jogadas._jogadas.ContainsKey(label.Name))
                {
                    label.Text = "";
                    label.BackColor = Color.Transparent;
                }    
            }
        }
    }
}
