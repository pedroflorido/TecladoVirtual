﻿namespace TecladoVirtual.Telas
{
    partial class F_Usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Usuario));
            lblTextoUsuario = new Label();
            lblNomeUsuario = new Label();
            tbxNome = new TextBox();
            label1 = new Label();
            tbxIdade = new TextBox();
            btnVoltarInstrucao = new Button();
            btnAvancarInstrucao = new Button();
            SuspendLayout();
            // 
            // lblTextoUsuario
            // 
            lblTextoUsuario.AutoSize = true;
            lblTextoUsuario.BackColor = Color.Transparent;
            lblTextoUsuario.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTextoUsuario.ForeColor = SystemColors.Window;
            lblTextoUsuario.Location = new Point(247, 43);
            lblTextoUsuario.Name = "lblTextoUsuario";
            lblTextoUsuario.Size = new Size(279, 50);
            lblTextoUsuario.TabIndex = 0;
            lblTextoUsuario.Text = "Para salvar suas respostas, \r\ninforme-nos seu Nome e Idade";
            lblTextoUsuario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNomeUsuario
            // 
            lblNomeUsuario.AutoSize = true;
            lblNomeUsuario.BackColor = Color.Transparent;
            lblNomeUsuario.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNomeUsuario.ForeColor = SystemColors.Window;
            lblNomeUsuario.Location = new Point(176, 144);
            lblNomeUsuario.Name = "lblNomeUsuario";
            lblNomeUsuario.Size = new Size(70, 25);
            lblNomeUsuario.TabIndex = 1;
            lblNomeUsuario.Text = "Nome:";
            lblNomeUsuario.Click += label1_Click;
            // 
            // tbxNome
            // 
            tbxNome.Location = new Point(247, 139);
            tbxNome.Margin = new Padding(3, 4, 3, 4);
            tbxNome.Name = "tbxNome";
            tbxNome.Size = new Size(260, 27);
            tbxNome.TabIndex = 2;
            tbxNome.Click += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(179, 189);
            label1.Name = "label1";
            label1.Size = new Size(67, 25);
            label1.TabIndex = 5;
            label1.Text = "Idade:";
            // 
            // tbxIdade
            // 
            tbxIdade.Location = new Point(247, 189);
            tbxIdade.Margin = new Padding(3, 4, 3, 4);
            tbxIdade.MaxLength = 3;
            tbxIdade.Name = "tbxIdade";
            tbxIdade.Size = new Size(260, 27);
            tbxIdade.TabIndex = 6;
            tbxIdade.Click += textBox1_TextChanged;
            // 
            // btnVoltarInstrucao
            // 
            btnVoltarInstrucao.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVoltarInstrucao.Location = new Point(14, 403);
            btnVoltarInstrucao.Margin = new Padding(3, 4, 3, 4);
            btnVoltarInstrucao.Name = "btnVoltarInstrucao";
            btnVoltarInstrucao.Size = new Size(97, 49);
            btnVoltarInstrucao.TabIndex = 7;
            btnVoltarInstrucao.Text = "VOLTAR";
            btnVoltarInstrucao.UseVisualStyleBackColor = true;
            btnVoltarInstrucao.Click += btnVoltarInstrucao_Click;
            // 
            // btnAvancarInstrucao
            // 
            btnAvancarInstrucao.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAvancarInstrucao.Location = new Point(619, 403);
            btnAvancarInstrucao.Margin = new Padding(3, 4, 3, 4);
            btnAvancarInstrucao.Name = "btnAvancarInstrucao";
            btnAvancarInstrucao.Size = new Size(97, 49);
            btnAvancarInstrucao.TabIndex = 8;
            btnAvancarInstrucao.Text = "AVANÇAR";
            btnAvancarInstrucao.UseVisualStyleBackColor = true;
            btnAvancarInstrucao.Click += btnAvancarInstrucao_Click;
            // 
            // F_Usuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(730, 468);
            Controls.Add(btnAvancarInstrucao);
            Controls.Add(btnVoltarInstrucao);
            Controls.Add(tbxIdade);
            Controls.Add(label1);
            Controls.Add(tbxNome);
            Controls.Add(lblNomeUsuario);
            Controls.Add(lblTextoUsuario);
            Margin = new Padding(3, 4, 3, 4);
            Name = "F_Usuario";
            Text = "F_Usuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label lblTextoUsuario;
        public Label lblNomeUsuario;
        public TextBox tbxNome;
        public Label label1;
        public TextBox tbxIdade;
        public Button btnVoltarInstrucao;
        public Button btnAvancarInstrucao;
    }
}