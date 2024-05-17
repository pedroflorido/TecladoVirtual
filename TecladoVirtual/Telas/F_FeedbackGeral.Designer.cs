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
            lblNumeroVisitante = new Label();
            lblNumeroAcertos = new Label();
            SuspendLayout();
            // 
            // btnRetornar
            // 
            btnRetornar.Anchor = AnchorStyles.None;
            btnRetornar.BackColor = Color.FromArgb(64, 64, 64);
            btnRetornar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRetornar.ForeColor = SystemColors.Window;
            btnRetornar.Location = new Point(405, 440);
            btnRetornar.Margin = new Padding(3, 4, 3, 4);
            btnRetornar.Name = "btnRetornar";
            btnRetornar.Size = new Size(97, 49);
            btnRetornar.TabIndex = 11;
            btnRetornar.Text = "RETORNAR";
            btnRetornar.UseVisualStyleBackColor = false;
            btnRetornar.Click += btnRetornar_Click;
            // 
            // lblTextoFeedbackGeral
            // 
            lblTextoFeedbackGeral.Anchor = AnchorStyles.None;
            lblTextoFeedbackGeral.AutoSize = true;
            lblTextoFeedbackGeral.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTextoFeedbackGeral.Location = new Point(290, 52);
            lblTextoFeedbackGeral.Name = "lblTextoFeedbackGeral";
            lblTextoFeedbackGeral.Size = new Size(390, 31);
            lblTextoFeedbackGeral.TabIndex = 12;
            lblTextoFeedbackGeral.Text = "RELATÓRIO DE RESPOSTAS";
            lblTextoFeedbackGeral.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblVisitantes
            // 
            lblVisitantes.Anchor = AnchorStyles.None;
            lblVisitantes.AutoSize = true;
            lblVisitantes.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVisitantes.Location = new Point(176, 108);
            lblVisitantes.Name = "lblVisitantes";
            lblVisitantes.Size = new Size(133, 31);
            lblVisitantes.TabIndex = 13;
            lblVisitantes.Text = "Visitantes";
            lblVisitantes.TextAlign = ContentAlignment.MiddleCenter;
            lblVisitantes.Click += label1_Click;
            // 
            // lblAcertos
            // 
            lblAcertos.Anchor = AnchorStyles.None;
            lblAcertos.AutoSize = true;
            lblAcertos.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAcertos.Location = new Point(605, 108);
            lblAcertos.Name = "lblAcertos";
            lblAcertos.Size = new Size(149, 31);
            lblAcertos.TabIndex = 14;
            lblAcertos.Text = "Acertos(%)";
            lblAcertos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNumeroVisitante
            // 
            lblNumeroVisitante.AutoSize = true;
            lblNumeroVisitante.Location = new Point(223, 198);
            lblNumeroVisitante.Name = "lblNumeroVisitante";
            lblNumeroVisitante.Size = new Size(17, 20);
            lblNumeroVisitante.TabIndex = 15;
            lblNumeroVisitante.Text = "0";
            // 
            // lblNumeroAcertos
            // 
            lblNumeroAcertos.AutoSize = true;
            lblNumeroAcertos.Location = new Point(658, 198);
            lblNumeroAcertos.Name = "lblNumeroAcertos";
            lblNumeroAcertos.Size = new Size(17, 20);
            lblNumeroAcertos.TabIndex = 16;
            lblNumeroAcertos.Text = "0";
            // 
            // F_FeedbackGeral
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;

            ClientSize = new Size(784, 441);
            ControlBox = false;

            
            Controls.Add(lblNumeroAcertos);
            Controls.Add(lblNumeroVisitante);

            Controls.Add(lblAcertos);
            Controls.Add(lblVisitantes);
            Controls.Add(lblTextoFeedbackGeral);
            Controls.Add(btnRetornar);
            Margin = new Padding(3, 4, 3, 4);
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
        private Label lblNumeroVisitante;
        private Label lblNumeroAcertos;
    }
}