namespace TecladoVirtual.Telas
{
    partial class F_OqueDeseja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_OqueDeseja));
            lblTexto2 = new Label();
            btnMuseu = new Button();
            btnVoltar1 = new Button();
            btnLua = new Button();
            btnQuestionario = new Button();
            SuspendLayout();
            // 
            // lblTexto2
            // 
            lblTexto2.Anchor = AnchorStyles.None;
            lblTexto2.AutoSize = true;
            lblTexto2.BackColor = SystemColors.Desktop;
            lblTexto2.Font = new Font("Roboto Bk", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTexto2.ForeColor = SystemColors.Window;
            lblTexto2.Location = new Point(232, 117);
            lblTexto2.Name = "lblTexto2";
            lblTexto2.Size = new Size(325, 58);
            lblTexto2.TabIndex = 0;
            lblTexto2.Text = "O que deseja?";
            lblTexto2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnMuseu
            // 
            btnMuseu.Anchor = AnchorStyles.Bottom;
            btnMuseu.BackgroundImage = (Image)resources.GetObject("btnMuseu.BackgroundImage");
            btnMuseu.Font = new Font("Roboto Bk", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMuseu.ForeColor = Color.Black;
            btnMuseu.Location = new Point(85, 205);
            btnMuseu.Name = "btnMuseu";
            btnMuseu.Size = new Size(180, 170);
            btnMuseu.TabIndex = 1;
            btnMuseu.Text = "Conheça o\r\nMuseu";
            btnMuseu.UseVisualStyleBackColor = true;
            btnMuseu.Click += btnMuseu_Click;
            // 
            // btnVoltar1
            // 
            btnVoltar1.Font = new Font("Roboto Bk", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVoltar1.Location = new Point(85, 45);
            btnVoltar1.Name = "btnVoltar1";
            btnVoltar1.Size = new Size(73, 32);
            btnVoltar1.TabIndex = 4;
            btnVoltar1.Text = "VOLTAR";
            btnVoltar1.UseVisualStyleBackColor = true;
            btnVoltar1.Click += btnVoltar1_Click;
            // 
            // btnLua
            // 
            btnLua.Anchor = AnchorStyles.Bottom;
            btnLua.BackgroundImage = (Image)resources.GetObject("btnLua.BackgroundImage");
            btnLua.Font = new Font("Roboto Bk", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLua.ForeColor = Color.Black;
            btnLua.Location = new Point(304, 205);
            btnLua.Name = "btnLua";
            btnLua.Size = new Size(180, 170);
            btnLua.TabIndex = 5;
            btnLua.Text = "Viagem do \r\nHomem à Lua";
            btnLua.UseVisualStyleBackColor = true;
            btnLua.Click += btnLua_Click;
            // 
            // btnQuestionario
            // 
            btnQuestionario.Anchor = AnchorStyles.Bottom;
            btnQuestionario.Font = new Font("Roboto Bk", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnQuestionario.ForeColor = Color.Black;
            btnQuestionario.Image = (Image)resources.GetObject("btnQuestionario.Image");
            btnQuestionario.Location = new Point(520, 205);
            btnQuestionario.Name = "btnQuestionario";
            btnQuestionario.Size = new Size(180, 170);
            btnQuestionario.TabIndex = 6;
            btnQuestionario.Text = "Questionário";
            btnQuestionario.UseVisualStyleBackColor = true;
            btnQuestionario.Click += btnQuestionario_Click;
            // 
            // F_OqueDeseja
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(784, 441);
            ControlBox = false;
            Controls.Add(btnQuestionario);
            Controls.Add(btnLua);
            Controls.Add(btnVoltar1);
            Controls.Add(btnMuseu);
            Controls.Add(lblTexto2);
            Font = new Font("Microsoft Sans Serif", 8.25F);
            ForeColor = SystemColors.ControlText;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "F_OqueDeseja";
            Text = "OqueDeseja";
            Load += F_OqueDeseja_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTexto2;
        private Button btnMuseu;
        private Button btnVoltar1;
        private Button btnLua;
        private Button btnQuestionario;
    }
}