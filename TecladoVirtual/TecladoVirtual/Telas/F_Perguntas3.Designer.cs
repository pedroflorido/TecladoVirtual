namespace TecladoVirtual.Telas
{
    partial class F_Perguntas3
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
            btnFinalizarPerguntas = new Button();
            btnVerdadeiro5 = new Button();
            btnFalso5 = new Button();
            panel1 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblPergunta3
            // 
            lblPergunta3.Anchor = AnchorStyles.None;
            lblPergunta3.AutoSize = true;
            lblPergunta3.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPergunta3.Location = new Point(55, 94);
            lblPergunta3.Name = "lblPergunta3";
            lblPergunta3.Size = new Size(615, 58);
            lblPergunta3.TabIndex = 2;
            lblPergunta3.Text = "O nome da missão Apollo 11 se deu por meio da figura \r\ndo deus grego Apolo como símbolo da missão espacial.";
            lblPergunta3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnFinalizarPerguntas
            // 
            btnFinalizarPerguntas.Anchor = AnchorStyles.None;
            btnFinalizarPerguntas.BackColor = Color.FromArgb(64, 64, 64);
            btnFinalizarPerguntas.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFinalizarPerguntas.ForeColor = SystemColors.Window;
            btnFinalizarPerguntas.Location = new Point(320, 227);
            btnFinalizarPerguntas.Name = "btnFinalizarPerguntas";
            btnFinalizarPerguntas.Size = new Size(85, 37);
            btnFinalizarPerguntas.TabIndex = 11;
            btnFinalizarPerguntas.Text = "FINALIZAR";
            btnFinalizarPerguntas.UseVisualStyleBackColor = false;
            btnFinalizarPerguntas.Click += btnFinalizarPerguntas_Click;
            // 
            // btnVerdadeiro5
            // 
            btnVerdadeiro5.Anchor = AnchorStyles.None;
            btnVerdadeiro5.BackColor = Color.DimGray;
            btnVerdadeiro5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVerdadeiro5.ForeColor = Color.PaleGreen;
            btnVerdadeiro5.Location = new Point(178, 169);
            btnVerdadeiro5.Name = "btnVerdadeiro5";
            btnVerdadeiro5.Size = new Size(85, 37);
            btnVerdadeiro5.TabIndex = 12;
            btnVerdadeiro5.Text = "Verdadeiro";
            btnVerdadeiro5.UseVisualStyleBackColor = false;
            btnVerdadeiro5.Click += btnVerdadeiro5_Click;
            // 
            // btnFalso5
            // 
            btnFalso5.Anchor = AnchorStyles.None;
            btnFalso5.BackColor = Color.DimGray;
            btnFalso5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFalso5.ForeColor = Color.LightCoral;
            btnFalso5.Location = new Point(458, 169);
            btnFalso5.Name = "btnFalso5";
            btnFalso5.Size = new Size(85, 37);
            btnFalso5.TabIndex = 13;
            btnFalso5.Text = "Falso";
            btnFalso5.UseVisualStyleBackColor = false;
            btnFalso5.Click += btnFalso5_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(520, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(202, 107);
            panel1.TabIndex = 14;
            panel1.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(3, 19);
            label1.Name = "label1";
            label1.Size = new Size(164, 50);
            label1.TabIndex = 0;
            label1.Text = "Responda Todas\r\n as perguntas!";
            // 
            // F_Perguntas3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(686, 331);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(btnFalso5);
            Controls.Add(btnVerdadeiro5);
            Controls.Add(btnFinalizarPerguntas);
            Controls.Add(lblPergunta3);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "F_Perguntas3";
            Text = "F_Perguntas3";
            Load += F_Perguntas3_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPergunta3;
        private Button btnFinalizarPerguntas;
        private Button btnVerdadeiro5;
        private Button btnFalso5;
        private Panel panel1;
        private Label label1;
    }
}