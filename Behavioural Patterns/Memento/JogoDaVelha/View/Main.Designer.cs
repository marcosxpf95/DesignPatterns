namespace JogoDaVelha
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelTabuleiro = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelBotoes = new System.Windows.Forms.TableLayoutPanel();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonDesfazerJogada = new System.Windows.Forms.Button();
            this.labelPlacar = new System.Windows.Forms.Label();
            this.tableLayoutPanelMain.SuspendLayout();
            this.tableLayoutPanelBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelTabuleiro, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelBotoes, 0, 1);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 2;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.89796F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.10204F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(942, 490);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // tableLayoutPanelTabuleiro
            // 
            this.tableLayoutPanelTabuleiro.ColumnCount = 1;
            this.tableLayoutPanelTabuleiro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelTabuleiro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelTabuleiro.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelTabuleiro.Name = "tableLayoutPanelTabuleiro";
            this.tableLayoutPanelTabuleiro.RowCount = 1;
            this.tableLayoutPanelTabuleiro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelTabuleiro.Size = new System.Drawing.Size(936, 360);
            this.tableLayoutPanelTabuleiro.TabIndex = 0;
            // 
            // tableLayoutPanelBotoes
            // 
            this.tableLayoutPanelBotoes.ColumnCount = 3;
            this.tableLayoutPanelBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelBotoes.Controls.Add(this.buttonReset, 1, 0);
            this.tableLayoutPanelBotoes.Controls.Add(this.buttonDesfazerJogada, 0, 0);
            this.tableLayoutPanelBotoes.Controls.Add(this.labelPlacar, 2, 0);
            this.tableLayoutPanelBotoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelBotoes.Location = new System.Drawing.Point(3, 369);
            this.tableLayoutPanelBotoes.Name = "tableLayoutPanelBotoes";
            this.tableLayoutPanelBotoes.RowCount = 1;
            this.tableLayoutPanelBotoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelBotoes.Size = new System.Drawing.Size(936, 118);
            this.tableLayoutPanelBotoes.TabIndex = 1;
            // 
            // buttonDesfazerJogada
            // 
            this.buttonReset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonReset.Image = global::JogoDaVelha.Properties.Resources.iconfinder_arrow_left_2555166__1_;
            this.buttonReset.Location = new System.Drawing.Point(315, 3);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(306, 112);
            this.buttonReset.TabIndex = 1;
            this.buttonReset.Text = "Desfazer Jogada";
            this.buttonReset.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.desfazerJogada);
            // 
            // buttonReset
            // 
            this.buttonDesfazerJogada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDesfazerJogada.Image = global::JogoDaVelha.Properties.Resources.iconfinder_941_07_4619675;
            this.buttonDesfazerJogada.Location = new System.Drawing.Point(3, 3);
            this.buttonDesfazerJogada.Name = "buttonDesfazerJogada";
            this.buttonDesfazerJogada.Size = new System.Drawing.Size(306, 112);
            this.buttonDesfazerJogada.TabIndex = 0;
            this.buttonDesfazerJogada.Text = "Reset";
            this.buttonDesfazerJogada.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonDesfazerJogada.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonDesfazerJogada.UseVisualStyleBackColor = true;
            this.buttonDesfazerJogada.Click += new System.EventHandler(this.reset);
            // 
            // labelPlacar
            // 
            this.labelPlacar.AutoSize = true;
            this.labelPlacar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPlacar.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlacar.Location = new System.Drawing.Point(627, 0);
            this.labelPlacar.Name = "labelPlacar";
            this.labelPlacar.Size = new System.Drawing.Size(306, 118);
            this.labelPlacar.TabIndex = 2;
            this.labelPlacar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 490);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Name = "Form1";
            this.Text = "Jogo da Velha";
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelBotoes.ResumeLayout(false);
            this.tableLayoutPanelBotoes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTabuleiro;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBotoes;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonDesfazerJogada;
        private System.Windows.Forms.Label labelPlacar;
    }
}

