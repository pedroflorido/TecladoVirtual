namespace TecladoVirtual.Telas
{
    partial class F_TelaMuseu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_TelaMuseu));
            lblTextoMuseu1 = new Label();
            lblTextoMuseu2 = new Label();
            btnVoltarMuseu = new Button();
            SuspendLayout();
            // 
            // lblTextoMuseu1
            // 
            lblTextoMuseu1.AutoSize = true;
            lblTextoMuseu1.BackColor = Color.Transparent;
            lblTextoMuseu1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTextoMuseu1.ForeColor = SystemColors.Window;
            lblTextoMuseu1.Location = new Point(14, 12);
            lblTextoMuseu1.Name = "lblTextoMuseu1";
            lblTextoMuseu1.Size = new Size(533, 96);
            lblTextoMuseu1.TabIndex = 0;
            lblTextoMuseu1.Text = resources.GetString("lblTextoMuseu1.Text");
            lblTextoMuseu1.Click += lblTextoMuseu1_Click;
            // 
            // lblTextoMuseu2
            // 
            lblTextoMuseu2.AutoSize = true;
            lblTextoMuseu2.BackColor = Color.Transparent;
            lblTextoMuseu2.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTextoMuseu2.ForeColor = SystemColors.Window;
            lblTextoMuseu2.Location = new Point(14, 131);
            lblTextoMuseu2.Name = "lblTextoMuseu2";
            lblTextoMuseu2.Size = new Size(607, 207);
            lblTextoMuseu2.TabIndex = 1;
            lblTextoMuseu2.Text = resources.GetString("lblTextoMuseu2.Text");
            lblTextoMuseu2.Click += lblTextoMuseu2_Click;
            // 
            // btnVoltarMuseu
            // 
            btnVoltarMuseu.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVoltarMuseu.Location = new Point(619, 403);
            btnVoltarMuseu.Margin = new Padding(3, 4, 3, 4);
            btnVoltarMuseu.Name = "btnVoltarMuseu";
            btnVoltarMuseu.Size = new Size(97, 49);
            btnVoltarMuseu.TabIndex = 2;
            btnVoltarMuseu.Text = "VOLTAR";
            btnVoltarMuseu.UseVisualStyleBackColor = true;
            btnVoltarMuseu.Click += btnVoltarMuseu_Click;
            // 
            // F_TelaMuseu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(730, 468);
            Controls.Add(btnVoltarMuseu);
            Controls.Add(lblTextoMuseu2);
            Controls.Add(lblTextoMuseu1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "F_TelaMuseu";
            Text = "F_TelaMuseu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTextoMuseu1;
        private Label lblTextoMuseu2;
        private Button btnVoltarMuseu;
    }
}