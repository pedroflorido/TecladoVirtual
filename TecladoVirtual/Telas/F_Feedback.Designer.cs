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
            SuspendLayout();
            // 
            // lblTextoFeedback
            // 
            lblTextoFeedback.AutoSize = true;
            lblTextoFeedback.Font = new Font("Roboto Bk", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTextoFeedback.Location = new Point(127, 101);
            lblTextoFeedback.Name = "lblTextoFeedback";
            lblTextoFeedback.Size = new Size(411, 75);
            lblTextoFeedback.TabIndex = 0;
            lblTextoFeedback.Text = "Parabéns por concluir nosso questionário!\r\n\r\nVocê acertou:";
            lblTextoFeedback.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAvancarFeedbackGeral
            // 
            btnAvancarFeedbackGeral.BackColor = Color.FromArgb(64, 64, 64);
            btnAvancarFeedbackGeral.Font = new Font("Roboto Bk", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAvancarFeedbackGeral.ForeColor = SystemColors.Window;
            btnAvancarFeedbackGeral.Location = new Point(287, 302);
            btnAvancarFeedbackGeral.Name = "btnAvancarFeedbackGeral";
            btnAvancarFeedbackGeral.Size = new Size(85, 37);
            btnAvancarFeedbackGeral.TabIndex = 11;
            btnAvancarFeedbackGeral.Text = "AVANÇAR";
            btnAvancarFeedbackGeral.UseVisualStyleBackColor = false;
            // 
            // F_Feedback
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 351);
            Controls.Add(btnAvancarFeedbackGeral);
            Controls.Add(lblTextoFeedback);
            Name = "F_Feedback";
            Text = "F_Feedback";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTextoFeedback;
        private Button btnAvancarFeedbackGeral;
    }
}