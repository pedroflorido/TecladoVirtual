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
            alertaPainel = new Panel();
            label2 = new Label();
            alertaPainel.SuspendLayout();
            SuspendLayout();
            // 
            // lblTextoUsuario
            // 
            lblTextoUsuario.Anchor = AnchorStyles.None;
            lblTextoUsuario.AutoSize = true;
            lblTextoUsuario.BackColor = Color.Transparent;
            lblTextoUsuario.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTextoUsuario.ForeColor = SystemColors.Window;
            lblTextoUsuario.Location = new Point(287, 117);
            lblTextoUsuario.Name = "lblTextoUsuario";
            lblTextoUsuario.Size = new Size(384, 62);
            lblTextoUsuario.TabIndex = 0;
            lblTextoUsuario.Text = "Para salvar suas respostas, \r\ninforme-nos seu Nome e Idade";
            lblTextoUsuario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNomeUsuario
            // 
            lblNomeUsuario.Anchor = AnchorStyles.None;
            lblNomeUsuario.AutoSize = true;
            lblNomeUsuario.BackColor = Color.Transparent;
            lblNomeUsuario.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNomeUsuario.ForeColor = SystemColors.Window;
            lblNomeUsuario.Location = new Point(272, 253);
            lblNomeUsuario.Name = "lblNomeUsuario";
            lblNomeUsuario.Size = new Size(70, 25);
            lblNomeUsuario.TabIndex = 1;
            lblNomeUsuario.Text = "Nome:";
            lblNomeUsuario.Click += label1_Click;
            // 
            // tbxNome
            // 
            tbxNome.Anchor = AnchorStyles.None;
            tbxNome.Location = new Point(343, 248);
            tbxNome.Margin = new Padding(3, 4, 3, 4);
            tbxNome.Name = "tbxNome";
            tbxNome.Size = new Size(260, 27);
            tbxNome.TabIndex = 2;
            tbxNome.Click += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(275, 299);
            label1.Name = "label1";
            label1.Size = new Size(67, 25);
            label1.TabIndex = 5;
            label1.Text = "Idade:";
            // 
            // tbxIdade
            // 
            tbxIdade.Anchor = AnchorStyles.None;
            tbxIdade.Location = new Point(343, 295);
            tbxIdade.Margin = new Padding(3, 5, 3, 5);
            tbxIdade.MaxLength = 3;
            tbxIdade.Name = "tbxIdade";
            tbxIdade.Size = new Size(260, 27);
            tbxIdade.TabIndex = 6;
            tbxIdade.Click += textBox1_TextChanged;
            // 
            // btnVoltarInstrucao
            // 
            btnVoltarInstrucao.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnVoltarInstrucao.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVoltarInstrucao.Location = new Point(78, 459);
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
            btnAvancarInstrucao.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAvancarInstrucao.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAvancarInstrucao.Location = new Point(721, 459);
            btnAvancarInstrucao.Margin = new Padding(3, 4, 3, 4);
            btnAvancarInstrucao.Name = "btnAvancarInstrucao";
            btnAvancarInstrucao.Size = new Size(97, 49);
            btnAvancarInstrucao.TabIndex = 8;
            btnAvancarInstrucao.Text = "AVANÇAR";
            btnAvancarInstrucao.UseVisualStyleBackColor = true;
            btnAvancarInstrucao.Click += btnAvancarInstrucao_Click;
            // 
            // btnLIMPARnome
            // 
            btnLIMPARnome.Anchor = AnchorStyles.None;
            btnLIMPARnome.BackColor = SystemColors.Info;
            btnLIMPARnome.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLIMPARnome.Location = new Point(621, 247);
            btnLIMPARnome.Margin = new Padding(3, 4, 3, 4);
            btnLIMPARnome.Name = "btnLIMPARnome";
            btnLIMPARnome.Size = new Size(86, 31);
            btnLIMPARnome.TabIndex = 9;
            btnLIMPARnome.Text = "LIMPAR";
            btnLIMPARnome.UseVisualStyleBackColor = false;
            btnLIMPARnome.Click += btnLIMPARnome_Click;
            // 
            // btnLIMPARidade
            // 
            btnLIMPARidade.Anchor = AnchorStyles.None;
            btnLIMPARidade.BackColor = SystemColors.Info;
            btnLIMPARidade.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLIMPARidade.Location = new Point(621, 293);
            btnLIMPARidade.Margin = new Padding(3, 4, 3, 4);
            btnLIMPARidade.Name = "btnLIMPARidade";
            btnLIMPARidade.Size = new Size(86, 31);
            btnLIMPARidade.TabIndex = 10;
            btnLIMPARidade.Text = "LIMPAR";
            btnLIMPARidade.UseVisualStyleBackColor = false;
            btnLIMPARidade.Click += btnLIMPARidade_Click;
            // 
            // alertaPainel
            // 
            alertaPainel.BackColor = SystemColors.Info;
            alertaPainel.Controls.Add(label2);
            alertaPainel.Location = new Point(490, 28);
            alertaPainel.Name = "alertaPainel";
            alertaPainel.Size = new Size(263, 99);
            alertaPainel.TabIndex = 11;
            alertaPainel.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Info;
            label2.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(5, 24);
            label2.Name = "label2";
            label2.Size = new Size(255, 54);
            label2.TabIndex = 0;
            label2.Text = "Todos os campos devem \r\n        ser Preenchidos!";
            label2.Click += label2_Click;
            // 
            // F_Usuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
<<<<<<< HEAD:TecladoVirtual/Telas/F_Usuario.Designer.cs
            ClientSize = new Size(784, 441);
            ControlBox = false;
=======
            ClientSize = new Size(896, 588);
<<<<<<< HEAD
=======
            Controls.Add(alertaPainel);
>>>>>>> 6fa991fb5b921ad1ba1ca3b14363fe7ed0d50a5b:TecladoVirtual/TecladoVirtual/Telas/F_Usuario.Designer.cs
>>>>>>> fe898e3d2833d413c78df10a93396e4ed97e22eb
            Controls.Add(btnLIMPARidade);
            Controls.Add(btnLIMPARnome);
            Controls.Add(btnAvancarInstrucao);
            Controls.Add(btnVoltarInstrucao);
            Controls.Add(tbxIdade);
            Controls.Add(label1);
            Controls.Add(tbxNome);
            Controls.Add(lblNomeUsuario);
            Controls.Add(lblTextoUsuario);
            Controls.Add(alertaPainel);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "F_Usuario";
            Text = "F_Usuario";
            Load += F_Usuario_Load;
            alertaPainel.ResumeLayout(false);
            alertaPainel.PerformLayout();
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
        private Panel alertaPainel;
        private Label label2;
    }
}