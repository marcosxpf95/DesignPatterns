using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaVelha
{
    public partial class Form1 : Form
    {
        Tabuleiro tabuleiro = null;

        public Form1()
        {
            InitializeComponent();
            carregarVisual();
        }

        private void carregarVisual()
        {
            Tabuleiro.AlterarPlacar alterarPlacar = new Tabuleiro.AlterarPlacar(AlterarPlacar);
            tabuleiro = new Tabuleiro(alterarPlacar);
            this.tableLayoutPanelTabuleiro.Controls.Add(tabuleiro);
            tabuleiro.Dock = DockStyle.Fill;
            labelPlacar.Text = "JOGADOR X: 0\n\nJOGADOR O: 0";
        }

        private void reset(object sender, EventArgs e)
        {
            tabuleiro.ResetTabuleiro();
        }

        public void AlterarPlacar(string placar)
        {
            labelPlacar.Text = placar;
        }

        private void desfazerJogada(object sender, EventArgs e)
        {
            tabuleiro.desfazerJogada();
        }
    }
}
