namespace TecladoVirtual.Telas
{
    partial class F_RelatoriaSatisfacao
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
            lblRelatorio = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblRelatorio
            // 
            lblRelatorio.AutoSize = true;
            lblRelatorio.Location = new Point(109, 133);
            lblRelatorio.Name = "lblRelatorio";
            lblRelatorio.Size = new Size(161, 20);
            lblRelatorio.TabIndex = 0;
            lblRelatorio.Text = "Relatorio de satisfacao";
            // 
            // button1
            // 
            button1.Location = new Point(343, 315);
            button1.Name = "button1";
            button1.Size = new Size(82, 47);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // F_RelatoriaSatisfacao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 450);
            Controls.Add(button1);
            Controls.Add(lblRelatorio);
            FormBorderStyle = FormBorderStyle.None;
            Name = "F_RelatoriaSatisfacao";
            Text = "F_RelatoriaSatisfacao";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRelatorio;
        private Button button1;
    }
}