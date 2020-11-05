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
    public partial class JogoDaVelha : Form
    {
        Tabuleiro tabuleiro = null;

        public JogoDaVelha()
        {
            InitializeComponent();
            carregarVisual();
        }

        private void carregarVisual()
        {
            Tabuleiro.AtualizarPlacar atualizarPlacar = new Tabuleiro.AtualizarPlacar(setPlacar);
            tabuleiro = new Tabuleiro(atualizarPlacar);
            this.tableLayoutPanelTabuleiro.Controls.Add(tabuleiro);
            tabuleiro.Dock = DockStyle.Fill;
            labelPlacar.Text = "JOGADOR X: 0\n\nJOGADOR O: 0";
        }

        private void resetarJogo(object sender, EventArgs e)
        {
            tabuleiro.ResetarTabuleiro();
        }

        public void setPlacar(string placar)
        {
            labelPlacar.Text = placar;
        }

        private void desfazerJogada(object sender, EventArgs e)
        {
            tabuleiro.DesfazerJogada();
        }
    }
}
