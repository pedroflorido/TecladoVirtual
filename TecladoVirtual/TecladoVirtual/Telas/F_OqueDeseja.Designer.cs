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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // lblTexto2
            // 
            lblTexto2.Anchor = AnchorStyles.None;
            lblTexto2.AutoSize = true;
            lblTexto2.BackColor = Color.Transparent;
            lblTexto2.Font = new Font("Roboto Bk", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTexto2.ForeColor = SystemColors.Window;
            lblTexto2.Location = new Point(215, 65);
            lblTexto2.Name = "lblTexto2";
            lblTexto2.Size = new Size(373, 58);
            lblTexto2.TabIndex = 0;
            lblTexto2.Text = "O QUE DESEJA?";
            lblTexto2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnMuseu
            // 
            btnMuseu.Anchor = AnchorStyles.Bottom;
            btnMuseu.BackColor = Color.Transparent;
            btnMuseu.BackgroundImage = (Image)resources.GetObject("btnMuseu.BackgroundImage");
            btnMuseu.FlatAppearance.BorderSize = 3;
            btnMuseu.FlatStyle = FlatStyle.Flat;
            btnMuseu.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMuseu.ForeColor = SystemColors.Window;
            btnMuseu.Location = new Point(89, 244);
            btnMuseu.Name = "btnMuseu";
            btnMuseu.Size = new Size(180, 170);
            btnMuseu.TabIndex = 1;
            btnMuseu.UseVisualStyleBackColor = false;
            btnMuseu.Click += btnMuseu_Click;
            // 
            // btnVoltar1
            // 
            btnVoltar1.BackColor = Color.Transparent;
            btnVoltar1.FlatAppearance.BorderSize = 3;
            btnVoltar1.FlatStyle = FlatStyle.Flat;
            btnVoltar1.Font = new Font("Roboto Bk", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVoltar1.ForeColor = SystemColors.Window;
            btnVoltar1.Location = new Point(85, 45);
            btnVoltar1.Name = "btnVoltar1";
            btnVoltar1.Size = new Size(150, 80);
            btnVoltar1.TabIndex = 4;
            btnVoltar1.Text = "VOLTAR";
            btnVoltar1.UseVisualStyleBackColor = false;
            btnVoltar1.Click += btnVoltar1_Click;
            // 
            // btnLua
            // 
            btnLua.Anchor = AnchorStyles.Bottom;
            btnLua.BackColor = Color.Transparent;
            btnLua.BackgroundImage = (Image)resources.GetObject("btnLua.BackgroundImage");
            btnLua.BackgroundImageLayout = ImageLayout.Center;
            btnLua.FlatAppearance.BorderSize = 3;
            btnLua.FlatStyle = FlatStyle.Flat;
            btnLua.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLua.ForeColor = SystemColors.Window;
            btnLua.Location = new Point(311, 244);
            btnLua.Name = "btnLua";
            btnLua.Size = new Size(180, 170);
            btnLua.TabIndex = 5;
            btnLua.UseVisualStyleBackColor = false;
            btnLua.Click += btnLua_Click;
            // 
            // btnQuestionario
            // 
            btnQuestionario.Anchor = AnchorStyles.Bottom;
            btnQuestionario.BackColor = Color.Transparent;
            btnQuestionario.BackgroundImage = (Image)resources.GetObject("btnQuestionario.BackgroundImage");
            btnQuestionario.FlatAppearance.BorderSize = 3;
            btnQuestionario.FlatStyle = FlatStyle.Flat;
            btnQuestionario.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnQuestionario.ForeColor = SystemColors.Window;
            btnQuestionario.Location = new Point(532, 244);
            btnQuestionario.Name = "btnQuestionario";
            btnQuestionario.Size = new Size(180, 170);
            btnQuestionario.TabIndex = 6;
            btnQuestionario.UseVisualStyleBackColor = false;
            btnQuestionario.Click += btnQuestionario_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Roboto Bk", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(122, 208);
            label1.Name = "label1";
            label1.Size = new Size(114, 35);
            label1.TabIndex = 7;
            label1.Text = "MUSEU";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Roboto Bk", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(366, 208);
            label2.Name = "label2";
            label2.Size = new Size(70, 35);
            label2.TabIndex = 8;
            label2.Text = "LUA";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Roboto Bk", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Window;
            label3.Location = new Point(512, 208);
            label3.Name = "label3";
            label3.Size = new Size(220, 35);
            label3.TabIndex = 9;
            label3.Text = "QUESTIONÁRIO";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // F_OqueDeseja
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 480);
            ControlBox = false;
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnQuestionario);
            Controls.Add(btnLua);
            Controls.Add(btnVoltar1);
            Controls.Add(btnMuseu);
            Controls.Add(lblTexto2);
            Font = new Font("Microsoft Sans Serif", 8.25F);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
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
        private Label label1;
        private Label label2;
        private Label label3;
    }
}