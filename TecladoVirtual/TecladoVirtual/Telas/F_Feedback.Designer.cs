namespace TecladoVirtual.Telas
{
    partial class F_Feedback
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Feedback));
            lblTextoFeedback = new Label();
            btnAvancarFeedbackGeral = new Button();
            lblMediaDeAcerto = new Label();
            lblNumeroDeAcertos = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblTextoFeedback
            // 
            lblTextoFeedback.Anchor = AnchorStyles.None;
            lblTextoFeedback.AutoSize = true;
            lblTextoFeedback.BackColor = Color.Transparent;
            lblTextoFeedback.Font = new Font("Roboto Bk", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTextoFeedback.ForeColor = SystemColors.Window;
            lblTextoFeedback.Location = new Point(30, 136);
            lblTextoFeedback.Name = "lblTextoFeedback";
            lblTextoFeedback.Size = new Size(721, 44);
            lblTextoFeedback.TabIndex = 0;
            lblTextoFeedback.Text = "Parabéns por concluir nosso questionário!";
            lblTextoFeedback.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAvancarFeedbackGeral
            // 
            btnAvancarFeedbackGeral.Anchor = AnchorStyles.None;
            btnAvancarFeedbackGeral.BackColor = Color.Transparent;
            btnAvancarFeedbackGeral.FlatAppearance.BorderSize = 3;
            btnAvancarFeedbackGeral.FlatStyle = FlatStyle.Flat;
            btnAvancarFeedbackGeral.Font = new Font("Roboto Bk", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAvancarFeedbackGeral.ForeColor = SystemColors.Window;
            btnAvancarFeedbackGeral.Location = new Point(601, 361);
            btnAvancarFeedbackGeral.Margin = new Padding(3, 2, 3, 2);
            btnAvancarFeedbackGeral.Name = "btnAvancarFeedbackGeral";
            btnAvancarFeedbackGeral.Size = new Size(150, 80);
            btnAvancarFeedbackGeral.TabIndex = 11;
            btnAvancarFeedbackGeral.Text = "AVANÇAR";
            btnAvancarFeedbackGeral.UseVisualStyleBackColor = false;
            btnAvancarFeedbackGeral.Click += btnAvancarFeedbackGeral_Click;
            // 
            // lblMediaDeAcerto
            // 
            lblMediaDeAcerto.Anchor = AnchorStyles.None;
            lblMediaDeAcerto.BackColor = Color.Transparent;
            lblMediaDeAcerto.Font = new Font("Roboto Bk", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMediaDeAcerto.ForeColor = SystemColors.Window;
            lblMediaDeAcerto.Location = new Point(431, 260);
            lblMediaDeAcerto.Name = "lblMediaDeAcerto";
            lblMediaDeAcerto.Size = new Size(88, 47);
            lblMediaDeAcerto.TabIndex = 14;
            // 
            // lblNumeroDeAcertos
            // 
            lblNumeroDeAcertos.Anchor = AnchorStyles.None;
            lblNumeroDeAcertos.AutoSize = true;
            lblNumeroDeAcertos.BackColor = Color.Transparent;
            lblNumeroDeAcertos.Font = new Font("Roboto Bk", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumeroDeAcertos.ForeColor = SystemColors.Window;
            lblNumeroDeAcertos.Location = new Point(30, 71);
            lblNumeroDeAcertos.Name = "lblNumeroDeAcertos";
            lblNumeroDeAcertos.Size = new Size(314, 42);
            lblNumeroDeAcertos.TabIndex = 13;
            lblNumeroDeAcertos.Text = "numero De acertos";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Roboto Bk", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(119, 260);
            label1.Name = "label1";
            label1.Size = new Size(248, 44);
            label1.TabIndex = 15;
            label1.Text = "Você acertou:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // F_Feedback
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 480);
            ControlBox = false;
            Controls.Add(label1);
            Controls.Add(lblNumeroDeAcertos);
            Controls.Add(lblMediaDeAcerto);
            Controls.Add(btnAvancarFeedbackGeral);
            Controls.Add(lblTextoFeedback);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "F_Feedback";
            Text = "F_Feedback";
            Load += F_Feedback_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTextoFeedback;
        private Button btnAvancarFeedbackGeral;
        private Label lblMediaDeAcerto;
        public Label lblNumeroDeAcertos;
        private Label label1;
    }
}