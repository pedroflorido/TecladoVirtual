namespace TecladoVirtual.Telas
{
    partial class F_FeedbackGeral
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
            btnRetornar = new Button();
            lblTextoFeedbackGeral = new Label();
            lblVisitantes = new Label();
            lblAcertos = new Label();
            SuspendLayout();
            // 
            // btnRetornar
            // 
            btnRetornar.BackColor = Color.FromArgb(64, 64, 64);
            btnRetornar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRetornar.ForeColor = SystemColors.Window;
            btnRetornar.Location = new Point(282, 302);
            btnRetornar.Name = "btnRetornar";
            btnRetornar.Size = new Size(85, 37);
            btnRetornar.TabIndex = 11;
            btnRetornar.Text = "RETORNAR";
            btnRetornar.UseVisualStyleBackColor = false;
            btnRetornar.Click += btnRetornar_Click;
            // 
            // lblTextoFeedbackGeral
            // 
            lblTextoFeedbackGeral.AutoSize = true;
            lblTextoFeedbackGeral.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTextoFeedbackGeral.Location = new Point(192, 9);
            lblTextoFeedbackGeral.Name = "lblTextoFeedbackGeral";
            lblTextoFeedbackGeral.Size = new Size(301, 25);
            lblTextoFeedbackGeral.TabIndex = 12;
            lblTextoFeedbackGeral.Text = "RELATÓRIO DE RESPOSTAS";
            lblTextoFeedbackGeral.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblVisitantes
            // 
            lblVisitantes.AutoSize = true;
            lblVisitantes.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVisitantes.Location = new Point(92, 51);
            lblVisitantes.Name = "lblVisitantes";
            lblVisitantes.Size = new Size(106, 25);
            lblVisitantes.TabIndex = 13;
            lblVisitantes.Text = "Visitantes";
            lblVisitantes.TextAlign = ContentAlignment.MiddleCenter;
            lblVisitantes.Click += label1_Click;
            // 
            // lblAcertos
            // 
            lblAcertos.AutoSize = true;
            lblAcertos.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAcertos.Location = new Point(445, 51);
            lblAcertos.Name = "lblAcertos";
            lblAcertos.Size = new Size(118, 25);
            lblAcertos.TabIndex = 14;
            lblAcertos.Text = "Acertos(%)";
            lblAcertos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // F_FeedbackGeral
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 351);
            Controls.Add(lblAcertos);
            Controls.Add(lblVisitantes);
            Controls.Add(lblTextoFeedbackGeral);
            Controls.Add(btnRetornar);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "F_FeedbackGeral";
            Text = "F_FeedbackGeral";
            Load += F_FeedbackGeral_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRetornar;
        private Label lblTextoFeedbackGeral;
        private Label lblVisitantes;
        private Label lblAcertos;
    }
}