﻿namespace TecladoVirtual.Telas
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
            SuspendLayout();
            // 
            // lblPergunta3
            // 
            lblPergunta3.AutoSize = true;
            lblPergunta3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPergunta3.Location = new Point(101, 165);
            lblPergunta3.Name = "lblPergunta3";
            lblPergunta3.Size = new Size(615, 58);
            lblPergunta3.TabIndex = 2;
            lblPergunta3.Text = "O nome da missão Apollo 11 se deu por meio da figura \r\ndo deus grego Apolo como símbolo da missão espacial.";
            lblPergunta3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnFinalizarPerguntas
            // 
            btnFinalizarPerguntas.BackColor = Color.FromArgb(64, 64, 64);
            btnFinalizarPerguntas.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFinalizarPerguntas.ForeColor = SystemColors.Window;
            btnFinalizarPerguntas.Location = new Point(318, 403);
            btnFinalizarPerguntas.Margin = new Padding(3, 4, 3, 4);
            btnFinalizarPerguntas.Name = "btnFinalizarPerguntas";
            btnFinalizarPerguntas.Size = new Size(97, 49);
            btnFinalizarPerguntas.TabIndex = 11;
            btnFinalizarPerguntas.Text = "FINALIZAR";
            btnFinalizarPerguntas.UseVisualStyleBackColor = false;
            btnFinalizarPerguntas.Click += btnFinalizarPerguntas_Click;
            // 
            // btnVerdadeiro5
            // 
            btnVerdadeiro5.BackColor = Color.DimGray;
            btnVerdadeiro5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVerdadeiro5.ForeColor = Color.PaleGreen;
            btnVerdadeiro5.Location = new Point(142, 299);
            btnVerdadeiro5.Margin = new Padding(3, 4, 3, 4);
            btnVerdadeiro5.Name = "btnVerdadeiro5";
            btnVerdadeiro5.Size = new Size(97, 49);
            btnVerdadeiro5.TabIndex = 12;
            btnVerdadeiro5.Text = "Verdadeiro";
            btnVerdadeiro5.UseVisualStyleBackColor = false;
            // 
            // btnFalso5
            // 
            btnFalso5.BackColor = Color.DimGray;
            btnFalso5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFalso5.ForeColor = Color.LightCoral;
            btnFalso5.Location = new Point(507, 299);
            btnFalso5.Margin = new Padding(3, 4, 3, 4);
            btnFalso5.Name = "btnFalso5";
            btnFalso5.Size = new Size(97, 49);
            btnFalso5.TabIndex = 13;
            btnFalso5.Text = "Falso";
            btnFalso5.UseVisualStyleBackColor = false;
            // 
            // F_Perguntas3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(730, 468);
            Controls.Add(btnFalso5);
            Controls.Add(btnVerdadeiro5);
            Controls.Add(btnFinalizarPerguntas);
            Controls.Add(lblPergunta3);
            Margin = new Padding(3, 4, 3, 4);
            Name = "F_Perguntas3";
            Text = "F_Perguntas3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPergunta3;
        private Button btnFinalizarPerguntas;
        private Button btnVerdadeiro5;
        private Button btnFalso5;
    }
}