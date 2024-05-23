﻿namespace TecladoVirtual.Telas
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
            lblTextoFeedback.Font = new Font("Roboto Bk", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTextoFeedback.Location = new Point(147, 144);
            lblTextoFeedback.Name = "lblTextoFeedback";
            lblTextoFeedback.Size = new Size(524, 99);
            lblTextoFeedback.TabIndex = 0;
            lblTextoFeedback.Text = "Parabéns por concluir nosso questionário!\r\n\r\nVocê acertou:";
            lblTextoFeedback.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAvancarFeedbackGeral
            // 
            btnAvancarFeedbackGeral.Anchor = AnchorStyles.None;
            btnAvancarFeedbackGeral.BackColor = Color.FromArgb(64, 64, 64);
            btnAvancarFeedbackGeral.FlatStyle = FlatStyle.Flat;
            btnAvancarFeedbackGeral.Font = new Font("Roboto Bk", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAvancarFeedbackGeral.ForeColor = SystemColors.Window;
            btnAvancarFeedbackGeral.Location = new Point(344, 319);
            btnAvancarFeedbackGeral.Margin = new Padding(3, 2, 3, 2);
            btnAvancarFeedbackGeral.Name = "btnAvancarFeedbackGeral";
            btnAvancarFeedbackGeral.Size = new Size(131, 60);
            btnAvancarFeedbackGeral.TabIndex = 11;
            btnAvancarFeedbackGeral.Text = "AVANÇAR";
            btnAvancarFeedbackGeral.UseVisualStyleBackColor = false;
            btnAvancarFeedbackGeral.Click += btnAvancarFeedbackGeral_Click;
            // 
            // lblMediaDeAcerto
            // 
            lblMediaDeAcerto.Anchor = AnchorStyles.None;
            lblMediaDeAcerto.Font = new Font("Roboto Bk", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMediaDeAcerto.Location = new Point(367, 270);
            lblMediaDeAcerto.Name = "lblMediaDeAcerto";
            lblMediaDeAcerto.Size = new Size(88, 17);
            lblMediaDeAcerto.TabIndex = 14;
            // 
            // lblNumeroDeAcertos
            // 
            lblNumeroDeAcertos.Anchor = AnchorStyles.None;
            lblNumeroDeAcertos.AutoSize = true;
            lblNumeroDeAcertos.Font = new Font("Roboto Bk", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumeroDeAcertos.Location = new Point(231, 73);
            lblNumeroDeAcertos.Name = "lblNumeroDeAcertos";
            lblNumeroDeAcertos.Size = new Size(244, 33);
            lblNumeroDeAcertos.TabIndex = 13;
            lblNumeroDeAcertos.Text = "numero De acertos";
            // 
            // F_Feedback
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 480);
            ControlBox = false;
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
    }
}