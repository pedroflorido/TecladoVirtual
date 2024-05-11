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
            lblTextoFeedback.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTextoFeedback.Location = new Point(145, 135);
            lblTextoFeedback.Name = "lblTextoFeedback";
            lblTextoFeedback.Size = new Size(520, 93);
            lblTextoFeedback.TabIndex = 0;
            lblTextoFeedback.Text = "Parabéns por concluir nosso questionário!\r\n\r\nVocê acertou:";
            lblTextoFeedback.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAvancarFeedbackGeral
            // 
            btnAvancarFeedbackGeral.BackColor = Color.FromArgb(64, 64, 64);
            btnAvancarFeedbackGeral.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAvancarFeedbackGeral.ForeColor = SystemColors.Window;
            btnAvancarFeedbackGeral.Location = new Point(328, 403);
            btnAvancarFeedbackGeral.Margin = new Padding(3, 4, 3, 4);
            btnAvancarFeedbackGeral.Name = "btnAvancarFeedbackGeral";
            btnAvancarFeedbackGeral.Size = new Size(97, 49);
            btnAvancarFeedbackGeral.TabIndex = 11;
            btnAvancarFeedbackGeral.Text = "AVANÇAR";
            btnAvancarFeedbackGeral.UseVisualStyleBackColor = false;
            btnAvancarFeedbackGeral.Click += btnAvancarFeedbackGeral_Click;
            // 
            // F_Feedback
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(730, 468);
            Controls.Add(btnAvancarFeedbackGeral);
            Controls.Add(lblTextoFeedback);
            Margin = new Padding(3, 4, 3, 4);
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