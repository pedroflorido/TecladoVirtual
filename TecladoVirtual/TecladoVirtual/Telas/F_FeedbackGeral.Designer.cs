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
            lblNome = new Label();
            lblIdade = new Label();
            lblMedia = new Label();
            lblPolíticadeRespeito = new Label();
            lblMediaDasPerguntas = new Label();
            SuspendLayout();
            // 
            // btnRetornar
            // 
            btnRetornar.Anchor = AnchorStyles.Bottom;
            btnRetornar.BackColor = Color.FromArgb(64, 64, 64);
            btnRetornar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRetornar.ForeColor = SystemColors.Window;
            btnRetornar.Location = new Point(379, 330);
            btnRetornar.Name = "btnRetornar";
            btnRetornar.Size = new Size(85, 37);
            btnRetornar.TabIndex = 11;
            btnRetornar.Text = "RETORNAR";
            btnRetornar.UseVisualStyleBackColor = false;
            btnRetornar.Click += btnRetornar_Click;
            // 
            // lblTextoFeedbackGeral
            // 
            lblTextoFeedbackGeral.Anchor = AnchorStyles.None;
            lblTextoFeedbackGeral.AutoSize = true;
            lblTextoFeedbackGeral.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTextoFeedbackGeral.Location = new Point(214, 39);
            lblTextoFeedbackGeral.Name = "lblTextoFeedbackGeral";
            lblTextoFeedbackGeral.Size = new Size(415, 33);
            lblTextoFeedbackGeral.TabIndex = 12;
            lblTextoFeedbackGeral.Text = "RELATÓRIO DE RESPOSTAS";
            lblTextoFeedbackGeral.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblVisitantes
            // 
            lblVisitantes.Anchor = AnchorStyles.None;
            lblVisitantes.AutoSize = true;
            lblVisitantes.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVisitantes.Location = new Point(214, 166);
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
            lblAcertos.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAcertos.Location = new Point(480, 166);
            lblAcertos.Name = "lblAcertos";
            lblAcertos.Size = new Size(149, 31);
            lblAcertos.TabIndex = 14;
            lblAcertos.Text = "Acertos(%)";
            lblAcertos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNumeroVisitante
            // 
            lblNumeroVisitante.Anchor = AnchorStyles.None;
            lblNumeroVisitante.AutoSize = true;
            lblNumeroVisitante.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumeroVisitante.Location = new Point(252, 209);
            lblNumeroVisitante.Name = "lblNumeroVisitante";
            lblNumeroVisitante.Size = new Size(32, 37);
            lblNumeroVisitante.TabIndex = 15;
            lblNumeroVisitante.Text = "0";
            lblNumeroVisitante.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNumeroAcertos
            // 
            lblNumeroAcertos.Anchor = AnchorStyles.None;
            lblNumeroAcertos.AutoSize = true;
            lblNumeroAcertos.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumeroAcertos.Location = new Point(558, 209);
            lblNumeroAcertos.Name = "lblNumeroAcertos";
            lblNumeroAcertos.Size = new Size(32, 37);
            lblNumeroAcertos.TabIndex = 16;
            lblNumeroAcertos.Text = "0";
            lblNumeroAcertos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNome
            // 
            lblNome.Anchor = AnchorStyles.None;
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(214, 104);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(70, 30);
            lblNome.TabIndex = 17;
            lblNome.Text = "Nome";
            lblNome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblIdade
            // 
            lblIdade.Anchor = AnchorStyles.None;
            lblIdade.AutoSize = true;
            lblIdade.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIdade.Location = new Point(389, 104);
            lblIdade.Name = "lblIdade";
            lblIdade.Size = new Size(64, 30);
            lblIdade.TabIndex = 18;
            lblIdade.Text = "idade";
            lblIdade.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMedia
            // 
            lblMedia.Anchor = AnchorStyles.None;
            lblMedia.AutoSize = true;
            lblMedia.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMedia.Location = new Point(558, 104);
            lblMedia.Name = "lblMedia";
            lblMedia.Size = new Size(71, 30);
            lblMedia.TabIndex = 19;
            lblMedia.Text = "Media";
            lblMedia.TextAlign = ContentAlignment.MiddleCenter;
            lblMedia.Click += label3_Click;
            // 
            // lblPolíticadeRespeito
            // 
            lblPolíticadeRespeito.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblPolíticadeRespeito.AutoSize = true;
            lblPolíticadeRespeito.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPolíticadeRespeito.Location = new Point(65, 283);
            lblPolíticadeRespeito.Name = "lblPolíticadeRespeito";
            lblPolíticadeRespeito.Size = new Size(308, 84);
            lblPolíticadeRespeito.TabIndex = 20;
            lblPolíticadeRespeito.Text = "Não esqueça de selecionar o botão\r\nretornar, por favor! \r\nNossa política preza que todos \r\ncolaborem com os próximos visitantes!";
            lblPolíticadeRespeito.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblMediaDasPerguntas
            // 
            lblMediaDasPerguntas.Anchor = AnchorStyles.None;
            lblMediaDasPerguntas.AutoSize = true;
            lblMediaDasPerguntas.Location = new Point(252, 310);
            lblMediaDasPerguntas.Name = "lblMediaDasPerguntas";
            lblMediaDasPerguntas.Size = new Size(117, 15);
            lblMediaDasPerguntas.TabIndex = 21;
            lblMediaDasPerguntas.Text = "media das perguntas";
            // 
            // F_FeedbackGeral
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 441);
            ControlBox = false;
            Controls.Add(lblMediaDasPerguntas);
            Controls.Add(lblPolíticadeRespeito);
            Controls.Add(lblMedia);
            Controls.Add(lblIdade);
            Controls.Add(lblNome);
            Controls.Add(lblNumeroAcertos);
            Controls.Add(lblNumeroVisitante);
            Controls.Add(lblAcertos);
            Controls.Add(lblVisitantes);
            Controls.Add(lblTextoFeedbackGeral);
            Controls.Add(btnRetornar);
            FormBorderStyle = FormBorderStyle.None;
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
        public Label lblNome;
        public Label lblIdade;
        public Label lblMedia;
        private Label lblPolíticadeRespeito;
        private Label lblMediaDasPerguntas;
    }
}