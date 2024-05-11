namespace TecladoVirtual.Telas
{
    partial class F_QInstrucao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_QInstrucao));
            lblTextoInstrucao = new Label();
            btnVoltarInstrucao = new Button();
            btnAvancarInstrucao = new Button();
            SuspendLayout();
            // 
            // lblTextoInstrucao
            // 
            lblTextoInstrucao.AutoSize = true;
            lblTextoInstrucao.BackColor = Color.Transparent;
            lblTextoInstrucao.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTextoInstrucao.ForeColor = SystemColors.Window;
            lblTextoInstrucao.Location = new Point(14, 41);
            lblTextoInstrucao.Name = "lblTextoInstrucao";
            lblTextoInstrucao.Size = new Size(808, 279);
            lblTextoInstrucao.TabIndex = 0;
            lblTextoInstrucao.Text = resources.GetString("lblTextoInstrucao.Text");
            lblTextoInstrucao.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnVoltarInstrucao
            // 
            btnVoltarInstrucao.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVoltarInstrucao.Location = new Point(14, 403);
            btnVoltarInstrucao.Margin = new Padding(3, 4, 3, 4);
            btnVoltarInstrucao.Name = "btnVoltarInstrucao";
            btnVoltarInstrucao.Size = new Size(97, 49);
            btnVoltarInstrucao.TabIndex = 1;
            btnVoltarInstrucao.Text = "VOLTAR";
            btnVoltarInstrucao.UseVisualStyleBackColor = true;
            btnVoltarInstrucao.Click += btnVoltarInstrucao_Click;
            // 
            // btnAvancarInstrucao
            // 
            btnAvancarInstrucao.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAvancarInstrucao.Location = new Point(619, 403);
            btnAvancarInstrucao.Margin = new Padding(3, 4, 3, 4);
            btnAvancarInstrucao.Name = "btnAvancarInstrucao";
            btnAvancarInstrucao.Size = new Size(97, 49);
            btnAvancarInstrucao.TabIndex = 2;
            btnAvancarInstrucao.Text = "AVANÇAR";
            btnAvancarInstrucao.UseVisualStyleBackColor = true;
            btnAvancarInstrucao.Click += btnAvancarInstrucao_Click;
            // 
            // F_QInstrucao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(730, 468);
            Controls.Add(btnAvancarInstrucao);
            Controls.Add(btnVoltarInstrucao);
            Controls.Add(lblTextoInstrucao);
            Margin = new Padding(3, 4, 3, 4);
            Name = "F_QInstrucao";
            Text = "F_QInstrucao";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTextoInstrucao;
        private Button btnVoltarInstrucao;
        private Button btnAvancarInstrucao;
    }
}