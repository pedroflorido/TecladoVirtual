namespace TecladoVirtual.Telas
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
            btnLIMPARnome = new Button();
            btnLIMPARidade = new Button();
            SuspendLayout();
            // 
            // lblTextoUsuario
            // 
            lblTextoUsuario.Anchor = AnchorStyles.None;
            lblTextoUsuario.AutoSize = true;
            lblTextoUsuario.BackColor = Color.Transparent;
            lblTextoUsuario.Font = new Font("Roboto Bk", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTextoUsuario.ForeColor = SystemColors.Window;
            lblTextoUsuario.Location = new Point(251, 88);
            lblTextoUsuario.Name = "lblTextoUsuario";
            lblTextoUsuario.Size = new Size(303, 50);
            lblTextoUsuario.TabIndex = 0;
            lblTextoUsuario.Text = "Para salvar suas respostas, \r\ninforme-nos seu Nome e Idade";
            lblTextoUsuario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNomeUsuario
            // 
            lblNomeUsuario.Anchor = AnchorStyles.None;
            lblNomeUsuario.AutoSize = true;
            lblNomeUsuario.BackColor = Color.Transparent;
            lblNomeUsuario.Font = new Font("Roboto Bk", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNomeUsuario.ForeColor = SystemColors.Window;
            lblNomeUsuario.Location = new Point(238, 190);
            lblNomeUsuario.Name = "lblNomeUsuario";
            lblNomeUsuario.Size = new Size(56, 19);
            lblNomeUsuario.TabIndex = 1;
            lblNomeUsuario.Text = "Nome:";
            lblNomeUsuario.Click += label1_Click;
            // 
            // tbxNome
            // 
            tbxNome.Anchor = AnchorStyles.None;
            tbxNome.Location = new Point(300, 186);
            tbxNome.Name = "tbxNome";
            tbxNome.Size = new Size(228, 23);
            tbxNome.TabIndex = 2;
            tbxNome.Click += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Roboto Bk", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(241, 224);
            label1.Name = "label1";
            label1.Size = new Size(53, 19);
            label1.TabIndex = 5;
            label1.Text = "Idade:";
            // 
            // tbxIdade
            // 
            tbxIdade.Anchor = AnchorStyles.None;
            tbxIdade.Location = new Point(300, 221);
            tbxIdade.Margin = new Padding(3, 4, 3, 4);
            tbxIdade.MaxLength = 3;
            tbxIdade.Name = "tbxIdade";
            tbxIdade.Size = new Size(228, 23);
            tbxIdade.TabIndex = 6;
            tbxIdade.Click += textBox1_TextChanged;
            // 
            // btnVoltarInstrucao
            // 
            btnVoltarInstrucao.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnVoltarInstrucao.Font = new Font("Roboto Bk", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVoltarInstrucao.Location = new Point(68, 344);
            btnVoltarInstrucao.Name = "btnVoltarInstrucao";
            btnVoltarInstrucao.Size = new Size(85, 37);
            btnVoltarInstrucao.TabIndex = 7;
            btnVoltarInstrucao.Text = "VOLTAR";
            btnVoltarInstrucao.UseVisualStyleBackColor = true;
            btnVoltarInstrucao.Click += btnVoltarInstrucao_Click;
            // 
            // btnAvancarInstrucao
            // 
            btnAvancarInstrucao.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAvancarInstrucao.Font = new Font("Roboto Bk", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAvancarInstrucao.Location = new Point(631, 344);
            btnAvancarInstrucao.Name = "btnAvancarInstrucao";
            btnAvancarInstrucao.Size = new Size(85, 37);
            btnAvancarInstrucao.TabIndex = 8;
            btnAvancarInstrucao.Text = "AVANÇAR";
            btnAvancarInstrucao.UseVisualStyleBackColor = true;
            btnAvancarInstrucao.Click += btnAvancarInstrucao_Click;
            // 
            // btnLIMPARnome
            // 
            btnLIMPARnome.Anchor = AnchorStyles.None;
            btnLIMPARnome.BackColor = SystemColors.Info;
            btnLIMPARnome.Font = new Font("Roboto Bk", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLIMPARnome.Location = new Point(543, 185);
            btnLIMPARnome.Name = "btnLIMPARnome";
            btnLIMPARnome.Size = new Size(75, 23);
            btnLIMPARnome.TabIndex = 9;
            btnLIMPARnome.Text = "LIMPAR";
            btnLIMPARnome.UseVisualStyleBackColor = false;
            // 
            // btnLIMPARidade
            // 
            btnLIMPARidade.Anchor = AnchorStyles.None;
            btnLIMPARidade.BackColor = SystemColors.Info;
            btnLIMPARidade.Font = new Font("Roboto Bk", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLIMPARidade.Location = new Point(543, 220);
            btnLIMPARidade.Name = "btnLIMPARidade";
            btnLIMPARidade.Size = new Size(75, 23);
            btnLIMPARidade.TabIndex = 10;
            btnLIMPARidade.Text = "LIMPAR";
            btnLIMPARidade.UseVisualStyleBackColor = false;
            // 
            // F_Usuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(784, 441);
            Controls.Add(btnLIMPARidade);
            Controls.Add(btnLIMPARnome);
            Controls.Add(btnAvancarInstrucao);
            Controls.Add(btnVoltarInstrucao);
            Controls.Add(tbxIdade);
            Controls.Add(label1);
            Controls.Add(tbxNome);
            Controls.Add(lblNomeUsuario);
            Controls.Add(lblTextoUsuario);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "F_Usuario";
            Text = "F_Usuario";
            Load += F_Usuario_Load;
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
        private Button btnLIMPARnome;
        private Button btnLIMPARidade;
    }
}