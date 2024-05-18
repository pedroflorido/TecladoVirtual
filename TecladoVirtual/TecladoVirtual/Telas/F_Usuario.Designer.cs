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
            resources.ApplyResources(lblTextoUsuario, "lblTextoUsuario");
            lblTextoUsuario.BackColor = Color.Transparent;
            lblTextoUsuario.ForeColor = SystemColors.Window;
            lblTextoUsuario.Name = "lblTextoUsuario";
            // 
            // lblNomeUsuario
            // 
            resources.ApplyResources(lblNomeUsuario, "lblNomeUsuario");
            lblNomeUsuario.BackColor = Color.Transparent;
            lblNomeUsuario.ForeColor = SystemColors.Window;
            lblNomeUsuario.Name = "lblNomeUsuario";
            lblNomeUsuario.Click += label1_Click;
            // 
            // tbxNome
            // 
            resources.ApplyResources(tbxNome, "tbxNome");
            tbxNome.Name = "tbxNome";
            tbxNome.Click += textBox1_TextChanged;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.Window;
            label1.Name = "label1";
            // 
            // tbxIdade
            // 
            resources.ApplyResources(tbxIdade, "tbxIdade");
            tbxIdade.Name = "tbxIdade";
            tbxIdade.Click += textBox1_TextChanged;
            // 
            // btnVoltarInstrucao
            // 
            resources.ApplyResources(btnVoltarInstrucao, "btnVoltarInstrucao");
            btnVoltarInstrucao.Name = "btnVoltarInstrucao";
            btnVoltarInstrucao.UseVisualStyleBackColor = true;
            btnVoltarInstrucao.Click += btnVoltarInstrucao_Click;
            // 
            // btnAvancarInstrucao
            // 
            resources.ApplyResources(btnAvancarInstrucao, "btnAvancarInstrucao");
            btnAvancarInstrucao.Name = "btnAvancarInstrucao";
            btnAvancarInstrucao.UseVisualStyleBackColor = true;
            btnAvancarInstrucao.Click += btnAvancarInstrucao_Click;
            // 
            // btnLIMPARnome
            // 
            resources.ApplyResources(btnLIMPARnome, "btnLIMPARnome");
            btnLIMPARnome.BackColor = SystemColors.Info;
            btnLIMPARnome.Name = "btnLIMPARnome";
            btnLIMPARnome.UseVisualStyleBackColor = false;
            btnLIMPARnome.Click += btnLIMPARnome_Click;
            // 
            // btnLIMPARidade
            // 
            resources.ApplyResources(btnLIMPARidade, "btnLIMPARidade");
            btnLIMPARidade.BackColor = SystemColors.Info;
            btnLIMPARidade.Name = "btnLIMPARidade";
            btnLIMPARidade.UseVisualStyleBackColor = false;
            btnLIMPARidade.Click += btnLIMPARidade_Click;
            // 
            // alertaPainel
            // 
            alertaPainel.BackColor = SystemColors.Info;
            alertaPainel.Controls.Add(label2);
            resources.ApplyResources(alertaPainel, "alertaPainel");
            alertaPainel.Name = "alertaPainel";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.BackColor = SystemColors.Info;
            label2.Name = "label2";
            label2.Click += label2_Click;
            // 
            // F_Usuario
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowText;
            ControlBox = false;
            Controls.Add(btnAvancarInstrucao);
            Controls.Add(btnLIMPARidade);
            Controls.Add(btnLIMPARnome);
            Controls.Add(btnVoltarInstrucao);
            Controls.Add(tbxIdade);
            Controls.Add(label1);
            Controls.Add(tbxNome);
            Controls.Add(lblNomeUsuario);
            Controls.Add(lblTextoUsuario);
            Controls.Add(alertaPainel);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "F_Usuario";
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