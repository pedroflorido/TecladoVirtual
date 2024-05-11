namespace TecladoVirtual.Telas
{
    partial class F_Perguntas2
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
            lblPergunta3 = new Label();
            lblPergunta4 = new Label();
            btnVerdadeiro3 = new Button();
            btnVerdadeiro4 = new Button();
            btnFalso3 = new Button();
            btnFalso4 = new Button();
            btnAvancarPerguntas2 = new Button();
            SuspendLayout();
            // 
            // lblPergunta3
            // 
            lblPergunta3.AutoSize = true;
            lblPergunta3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPergunta3.Location = new Point(137, 34);
            lblPergunta3.Name = "lblPergunta3";
            lblPergunta3.Size = new Size(388, 48);
            lblPergunta3.TabIndex = 1;
            lblPergunta3.Text = "Os três integrantes da missão espacial eram:\r\nNeil Armstrong, Buzz Aldrin e Michael Collins";
            lblPergunta3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPergunta4
            // 
            lblPergunta4.AutoSize = true;
            lblPergunta4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPergunta4.Location = new Point(89, 169);
            lblPergunta4.Name = "lblPergunta4";
            lblPergunta4.Size = new Size(466, 48);
            lblPergunta4.TabIndex = 2;
            lblPergunta4.Text = "“Um pequeno passo para o homem, um salto gigante \r\npara a humanidade”, esta frase foi dita por Buzz Aldrin.";
            lblPergunta4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnVerdadeiro3
            // 
            btnVerdadeiro3.BackColor = Color.DimGray;
            btnVerdadeiro3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVerdadeiro3.ForeColor = Color.PaleGreen;
            btnVerdadeiro3.Location = new Point(123, 92);
            btnVerdadeiro3.Name = "btnVerdadeiro3";
            btnVerdadeiro3.Size = new Size(85, 37);
            btnVerdadeiro3.TabIndex = 6;
            btnVerdadeiro3.Text = "Verdadeiro";
            btnVerdadeiro3.UseVisualStyleBackColor = false;
            // 
            // btnVerdadeiro4
            // 
            btnVerdadeiro4.BackColor = Color.DimGray;
            btnVerdadeiro4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVerdadeiro4.ForeColor = Color.PaleGreen;
            btnVerdadeiro4.Location = new Point(123, 232);
            btnVerdadeiro4.Name = "btnVerdadeiro4";
            btnVerdadeiro4.Size = new Size(85, 37);
            btnVerdadeiro4.TabIndex = 7;
            btnVerdadeiro4.Text = "Verdadeiro";
            btnVerdadeiro4.UseVisualStyleBackColor = false;
            // 
            // btnFalso3
            // 
            btnFalso3.BackColor = Color.DimGray;
            btnFalso3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFalso3.ForeColor = Color.LightCoral;
            btnFalso3.Location = new Point(453, 92);
            btnFalso3.Name = "btnFalso3";
            btnFalso3.Size = new Size(85, 37);
            btnFalso3.TabIndex = 8;
            btnFalso3.Text = "Falso";
            btnFalso3.UseVisualStyleBackColor = false;
            // 
            // btnFalso4
            // 
            btnFalso4.BackColor = Color.DimGray;
            btnFalso4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFalso4.ForeColor = Color.LightCoral;
            btnFalso4.Location = new Point(453, 232);
            btnFalso4.Name = "btnFalso4";
            btnFalso4.Size = new Size(85, 37);
            btnFalso4.TabIndex = 9;
            btnFalso4.Text = "Falso";
            btnFalso4.UseVisualStyleBackColor = false;
            // 
            // btnAvancarPerguntas2
            // 
            btnAvancarPerguntas2.BackColor = Color.FromArgb(64, 64, 64);
            btnAvancarPerguntas2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAvancarPerguntas2.ForeColor = SystemColors.Window;
            btnAvancarPerguntas2.Location = new Point(286, 302);
            btnAvancarPerguntas2.Name = "btnAvancarPerguntas2";
            btnAvancarPerguntas2.Size = new Size(85, 37);
            btnAvancarPerguntas2.TabIndex = 10;
            btnAvancarPerguntas2.Text = "AVANÇAR";
            btnAvancarPerguntas2.UseVisualStyleBackColor = false;
            btnAvancarPerguntas2.Click += btnAvancarPerguntas2_Click;
            // 
            // F_Perguntas2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 351);
            Controls.Add(btnAvancarPerguntas2);
            Controls.Add(btnFalso4);
            Controls.Add(btnFalso3);
            Controls.Add(btnVerdadeiro4);
            Controls.Add(btnVerdadeiro3);
            Controls.Add(lblPergunta4);
            Controls.Add(lblPergunta3);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "F_Perguntas2";
            Text = "F_Perguntas2";
            Load += F_Perguntas2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPergunta3;
        private Label lblPergunta4;
        private Button btnVerdadeiro3;
        private Button btnVerdadeiro4;
        private Button btnFalso3;
        private Button btnFalso4;
        private Button btnAvancarPerguntas2;
    }
}