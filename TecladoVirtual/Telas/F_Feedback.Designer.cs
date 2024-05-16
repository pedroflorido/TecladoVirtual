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
            lblNumeroAcerto = new Label();
            SuspendLayout();
            // 
            // lblTextoFeedback
            // 
            lblTextoFeedback.Anchor = AnchorStyles.None;
            lblTextoFeedback.AutoSize = true;
            lblTextoFeedback.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTextoFeedback.Location = new Point(227, 143);
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
            btnAvancarFeedbackGeral.Location = new Point(410, 411);
            btnAvancarFeedbackGeral.Margin = new Padding(3, 4, 3, 4);
            btnAvancarFeedbackGeral.Name = "btnAvancarFeedbackGeral";
            btnAvancarFeedbackGeral.Size = new Size(97, 49);
            btnAvancarFeedbackGeral.TabIndex = 11;
            btnAvancarFeedbackGeral.Text = "AVANÇAR";
            btnAvancarFeedbackGeral.UseVisualStyleBackColor = false;
            btnAvancarFeedbackGeral.Click += btnAvancarFeedbackGeral_Click;
            // 
            // lblNumeroAcerto
            // 
            lblNumeroAcerto.AutoSize = true;
            lblNumeroAcerto.Location = new Point(468, 279);
            lblNumeroAcerto.Name = "lblNumeroAcerto";
            lblNumeroAcerto.Size = new Size(17, 20);
            lblNumeroAcerto.TabIndex = 12;
            lblNumeroAcerto.Text = "0";
            // 
            // F_Feedback
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
<<<<<<< HEAD
            ClientSize = new Size(784, 441);
            ControlBox = false;
=======
            ClientSize = new Size(896, 588);
            Controls.Add(lblNumeroAcerto);
>>>>>>> 1a5b3fbd2a010c3673e7c63120654ea7746c5b6d
            Controls.Add(btnAvancarFeedbackGeral);
            Controls.Add(lblTextoFeedback);
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
        private Label lblNumeroAcerto;
        
    }
}