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
            lblTextoFeedback = new Label();
            btnAvancarFeedbackGeral = new Button();
            lblMediaDeAcerto = new Label();
            lblNumeroDeAcertos = new Label();
            SuspendLayout();
            // 
            // lblTextoFeedback
            // 
            lblTextoFeedback.Anchor = AnchorStyles.None;
            lblTextoFeedback.AutoSize = true;
            lblTextoFeedback.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTextoFeedback.Location = new Point(221, 48);
            lblTextoFeedback.Name = "lblTextoFeedback";
            lblTextoFeedback.Size = new Size(520, 93);
            lblTextoFeedback.TabIndex = 0;
            lblTextoFeedback.Text = "Parabéns por concluir nosso questionário!\r\n\r\nVocê acertou:";
            lblTextoFeedback.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAvancarFeedbackGeral
            // 
            btnAvancarFeedbackGeral.Anchor = AnchorStyles.None;
            btnAvancarFeedbackGeral.BackColor = Color.FromArgb(64, 64, 64);
            btnAvancarFeedbackGeral.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAvancarFeedbackGeral.ForeColor = SystemColors.Window;
            btnAvancarFeedbackGeral.Location = new Point(427, 411);
            btnAvancarFeedbackGeral.Margin = new Padding(3, 4, 3, 4);
            btnAvancarFeedbackGeral.Name = "btnAvancarFeedbackGeral";
            btnAvancarFeedbackGeral.Size = new Size(97, 49);
            btnAvancarFeedbackGeral.TabIndex = 11;
            btnAvancarFeedbackGeral.Text = "AVANÇAR";
            btnAvancarFeedbackGeral.UseVisualStyleBackColor = false;
            btnAvancarFeedbackGeral.Click += btnAvancarFeedbackGeral_Click;
            // 
            // lblMediaDeAcerto
            // 
            lblMediaDeAcerto.Anchor = AnchorStyles.None;
            lblMediaDeAcerto.AutoSize = true;
            lblMediaDeAcerto.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMediaDeAcerto.Location = new Point(469, 279);
            lblMediaDeAcerto.Name = "lblMediaDeAcerto";
            lblMediaDeAcerto.Size = new Size(38, 46);
            lblMediaDeAcerto.TabIndex = 12;
            lblMediaDeAcerto.Text = "0";
            lblMediaDeAcerto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNumeroDeAcertos
            // 
            lblNumeroDeAcertos.AutoSize = true;
            lblNumeroDeAcertos.Location = new Point(221, 202);
            lblNumeroDeAcertos.Name = "lblNumeroDeAcertos";
            lblNumeroDeAcertos.Size = new Size(135, 20);
            lblNumeroDeAcertos.TabIndex = 13;
            lblNumeroDeAcertos.Text = "numero De acertos";
            // 
            // F_Feedback
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 441);
            ControlBox = false;
            Controls.Add(lblNumeroDeAcertos);
            Controls.Add(lblMediaDeAcerto);
            Controls.Add(btnAvancarFeedbackGeral);
            Controls.Add(lblTextoFeedback);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
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
    }
}