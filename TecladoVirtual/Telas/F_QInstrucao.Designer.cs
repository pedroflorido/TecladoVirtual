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
            lblTextoInstrucao.Location = new Point(12, 31);
            lblTextoInstrucao.Name = "lblTextoInstrucao";
            lblTextoInstrucao.Size = new Size(645, 225);
            lblTextoInstrucao.TabIndex = 0;
            lblTextoInstrucao.Text = resources.GetString("lblTextoInstrucao.Text");
            lblTextoInstrucao.TextAlign = ContentAlignment.MiddleCenter;
            lblTextoInstrucao.Click += lblTextoInstrucao_Click;
            // 
            // btnVoltarInstrucao
            // 
            btnVoltarInstrucao.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVoltarInstrucao.Location = new Point(12, 302);
            btnVoltarInstrucao.Name = "btnVoltarInstrucao";
            btnVoltarInstrucao.Size = new Size(85, 37);
            btnVoltarInstrucao.TabIndex = 1;
            btnVoltarInstrucao.Text = "VOLTAR";
            btnVoltarInstrucao.UseVisualStyleBackColor = true;
            btnVoltarInstrucao.Click += btnVoltarInstrucao_Click;
            // 
            // btnAvancarInstrucao
            // 
            btnAvancarInstrucao.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAvancarInstrucao.Location = new Point(542, 302);
            btnAvancarInstrucao.Name = "btnAvancarInstrucao";
            btnAvancarInstrucao.Size = new Size(85, 37);
            btnAvancarInstrucao.TabIndex = 2;
            btnAvancarInstrucao.Text = "AVANÇAR";
            btnAvancarInstrucao.UseVisualStyleBackColor = true;
            btnAvancarInstrucao.Click += btnAvancarInstrucao_Click;
            // 
            // F_QInstrucao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(639, 351);
            Controls.Add(btnAvancarInstrucao);
            Controls.Add(btnVoltarInstrucao);
            Controls.Add(lblTextoInstrucao);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "F_QInstrucao";
            Text = "F_QInstrucao";
            Load += F_QInstrucao_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTextoInstrucao;
        private Button btnVoltarInstrucao;
        private Button btnAvancarInstrucao;
    }
}