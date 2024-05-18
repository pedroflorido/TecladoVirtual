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
            lblTextoFeedback.Location = new Point(208, 107);
            lblTextoFeedback.Name = "lblTextoFeedback";
            lblTextoFeedback.Size = new Size(416, 75);
            lblTextoFeedback.TabIndex = 0;
            lblTextoFeedback.Text = "Parabéns por concluir nosso questionário!\r\n\r\nVocê acertou:";
            lblTextoFeedback.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAvancarFeedbackGeral
            // 
            btnAvancarFeedbackGeral.Anchor = AnchorStyles.None;
            btnAvancarFeedbackGeral.BackColor = Color.FromArgb(64, 64, 64);
            btnAvancarFeedbackGeral.Font = new Font("Roboto Bk", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAvancarFeedbackGeral.ForeColor = SystemColors.Window;
            btnAvancarFeedbackGeral.Location = new Point(374, 308);
            btnAvancarFeedbackGeral.Name = "btnAvancarFeedbackGeral";
            btnAvancarFeedbackGeral.Size = new Size(85, 37);
            btnAvancarFeedbackGeral.TabIndex = 11;
            btnAvancarFeedbackGeral.Text = "AVANÇAR";
            btnAvancarFeedbackGeral.UseVisualStyleBackColor = false;
            btnAvancarFeedbackGeral.Click += btnAvancarFeedbackGeral_Click;
            // 
            // lblNumeroAcerto
            // 
            lblNumeroAcerto.Anchor = AnchorStyles.None;
            lblNumeroAcerto.AutoSize = true;
            lblNumeroAcerto.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumeroAcerto.Location = new Point(410, 209);
            lblNumeroAcerto.Name = "lblNumeroAcerto";
            lblNumeroAcerto.Size = new Size(32, 37);
            lblNumeroAcerto.TabIndex = 12;
            lblNumeroAcerto.Text = "0";
            lblNumeroAcerto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // F_Feedback
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(686, 331);
            ControlBox = false;
            Controls.Add(lblNumeroAcerto);
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
        private Label lblNumeroAcerto;
        
    }
}