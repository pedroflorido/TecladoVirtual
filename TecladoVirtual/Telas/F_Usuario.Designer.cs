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
            textBox1 = new TextBox();
            label1 = new Label();
            textBox3 = new TextBox();
            btnVoltarInstrucao = new Button();
            btnAvancarInstrucao = new Button();
            SuspendLayout();
            // 
            // lblTextoUsuario
            // 
            lblTextoUsuario.AutoSize = true;
            lblTextoUsuario.BackColor = Color.Transparent;
            lblTextoUsuario.Font = new Font("Roboto Bk", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTextoUsuario.ForeColor = SystemColors.Window;
            lblTextoUsuario.Location = new Point(216, 32);
            lblTextoUsuario.Name = "lblTextoUsuario";
            lblTextoUsuario.Size = new Size(228, 38);
            lblTextoUsuario.TabIndex = 0;
            lblTextoUsuario.Text = "Para salvar suas respostas, \r\ninforme-nos seu Nome e Idade";
            lblTextoUsuario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNomeUsuario
            // 
            lblNomeUsuario.AutoSize = true;
            lblNomeUsuario.BackColor = Color.Transparent;
            lblNomeUsuario.Font = new Font("Roboto Bk", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNomeUsuario.ForeColor = SystemColors.Window;
            lblNomeUsuario.Location = new Point(154, 108);
            lblNomeUsuario.Name = "lblNomeUsuario";
            lblNomeUsuario.Size = new Size(56, 19);
            lblNomeUsuario.TabIndex = 1;
            lblNomeUsuario.Text = "Nome:";
            lblNomeUsuario.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(216, 104);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(228, 23);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Roboto Bk", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(157, 142);
            label1.Name = "label1";
            label1.Size = new Size(53, 19);
            label1.TabIndex = 5;
            label1.Text = "Idade:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(216, 142);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(228, 23);
            textBox3.TabIndex = 6;
            // 
            // btnVoltarInstrucao
            // 
            btnVoltarInstrucao.Font = new Font("Roboto Bk", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVoltarInstrucao.Location = new Point(12, 302);
            btnVoltarInstrucao.Name = "btnVoltarInstrucao";
            btnVoltarInstrucao.Size = new Size(85, 37);
            btnVoltarInstrucao.TabIndex = 7;
            btnVoltarInstrucao.Text = "VOLTAR";
            btnVoltarInstrucao.UseVisualStyleBackColor = true;
            // 
            // btnAvancarInstrucao
            // 
            btnAvancarInstrucao.Font = new Font("Roboto Bk", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAvancarInstrucao.Location = new Point(542, 302);
            btnAvancarInstrucao.Name = "btnAvancarInstrucao";
            btnAvancarInstrucao.Size = new Size(85, 37);
            btnAvancarInstrucao.TabIndex = 8;
            btnAvancarInstrucao.Text = "AVANÇAR";
            btnAvancarInstrucao.UseVisualStyleBackColor = true;
            // 
            // F_Usuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(639, 351);
            Controls.Add(btnAvancarInstrucao);
            Controls.Add(btnVoltarInstrucao);
            Controls.Add(textBox3);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(lblNomeUsuario);
            Controls.Add(lblTextoUsuario);
            Name = "F_Usuario";
            Text = "F_Usuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTextoUsuario;
        private Label lblNomeUsuario;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox3;
        private Button btnVoltarInstrucao;
        private Button btnAvancarInstrucao;
    }
}