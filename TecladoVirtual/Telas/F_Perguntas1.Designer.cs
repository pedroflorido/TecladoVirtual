namespace TecladoVirtual.Telas
{
    partial class F_Perguntas1
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
            lblPergunta1 = new Label();
            lblPergunta2 = new Label();
            btnAvancarPerguntas1 = new Button();
            btnVerdadeiro2 = new Button();
            btnVerdadeiro1 = new Button();
            btnFalso1 = new Button();
            btnFalso2 = new Button();
            SuspendLayout();
            // 
            // lblPergunta1
            // 
            lblPergunta1.AutoSize = true;
            lblPergunta1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPergunta1.Location = new Point(86, 34);
            lblPergunta1.Name = "lblPergunta1";
            lblPergunta1.Size = new Size(479, 48);
            lblPergunta1.TabIndex = 0;
            lblPergunta1.Text = "O ano em que o homem pisou na Lua pela primeira vez\r\nfoi em 1969.";
            lblPergunta1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPergunta2
            // 
            lblPergunta2.AutoSize = true;
            lblPergunta2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPergunta2.Location = new Point(123, 177);
            lblPergunta2.Name = "lblPergunta2";
            lblPergunta2.Size = new Size(406, 48);
            lblPergunta2.TabIndex = 1;
            lblPergunta2.Text = "O nome da missão espacial dos Estado Unidos\r\nse chamava Luna 24.";
            lblPergunta2.TextAlign = ContentAlignment.MiddleCenter;
            lblPergunta2.Click += label1_Click;
            // 
            // btnAvancarPerguntas1
            // 
            btnAvancarPerguntas1.BackColor = Color.FromArgb(64, 64, 64);
            btnAvancarPerguntas1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAvancarPerguntas1.ForeColor = SystemColors.Window;
            btnAvancarPerguntas1.Location = new Point(284, 302);
            btnAvancarPerguntas1.Name = "btnAvancarPerguntas1";
            btnAvancarPerguntas1.Size = new Size(85, 37);
            btnAvancarPerguntas1.TabIndex = 3;
            btnAvancarPerguntas1.Text = "AVANÇAR";
            btnAvancarPerguntas1.UseVisualStyleBackColor = false;
            btnAvancarPerguntas1.Click += btnAvancarPerguntas1_Click;
            // 
            // btnVerdadeiro2
            // 
            btnVerdadeiro2.BackColor = Color.DimGray;
            btnVerdadeiro2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVerdadeiro2.ForeColor = Color.PaleGreen;
            btnVerdadeiro2.Location = new Point(123, 226);
            btnVerdadeiro2.Name = "btnVerdadeiro2";
            btnVerdadeiro2.Size = new Size(85, 37);
            btnVerdadeiro2.TabIndex = 4;
            btnVerdadeiro2.Text = "Verdadeiro";
            btnVerdadeiro2.UseVisualStyleBackColor = false;
            // 
            // btnVerdadeiro1
            // 
            btnVerdadeiro1.BackColor = Color.DimGray;
            btnVerdadeiro1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVerdadeiro1.ForeColor = Color.PaleGreen;
            btnVerdadeiro1.Location = new Point(123, 83);
            btnVerdadeiro1.Name = "btnVerdadeiro1";
            btnVerdadeiro1.Size = new Size(85, 37);
            btnVerdadeiro1.TabIndex = 5;
            btnVerdadeiro1.Text = "Verdadeiro";
            btnVerdadeiro1.UseVisualStyleBackColor = false;
            // 
            // btnFalso1
            // 
            btnFalso1.BackColor = Color.DimGray;
            btnFalso1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFalso1.ForeColor = Color.LightCoral;
            btnFalso1.Location = new Point(451, 83);
            btnFalso1.Name = "btnFalso1";
            btnFalso1.Size = new Size(85, 37);
            btnFalso1.TabIndex = 6;
            btnFalso1.Text = "Falso";
            btnFalso1.UseVisualStyleBackColor = false;
            // 
            // btnFalso2
            // 
            btnFalso2.BackColor = Color.DimGray;
            btnFalso2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFalso2.ForeColor = Color.LightCoral;
            btnFalso2.Location = new Point(451, 226);
            btnFalso2.Name = "btnFalso2";
            btnFalso2.Size = new Size(85, 37);
            btnFalso2.TabIndex = 7;
            btnFalso2.Text = "Falso";
            btnFalso2.UseVisualStyleBackColor = false;
            // 
            // F_Perguntas1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 351);
            Controls.Add(btnFalso2);
            Controls.Add(btnFalso1);
            Controls.Add(btnVerdadeiro1);
            Controls.Add(btnVerdadeiro2);
            Controls.Add(btnAvancarPerguntas1);
            Controls.Add(lblPergunta2);
            Controls.Add(lblPergunta1);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "F_Perguntas1";
            Text = "F_Perguntas1";
            Load += F_Perguntas1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPergunta1;
        private Label lblPergunta2;
        private Button btnAvancarPerguntas1;
        private Button btnVerdadeiro2;
        private Button btnVerdadeiro1;
        private Button btnFalso1;
        private Button btnFalso2;
    }
}