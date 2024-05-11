namespace TecladoVirtual
{
    partial class F_TelaPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_TelaPrincipal));
            lblTextoPrincipal = new Label();
            btnAvancar1 = new Button();
            SuspendLayout();
            // 
            // lblTextoPrincipal
            // 
            lblTextoPrincipal.AutoSize = true;
            lblTextoPrincipal.BackColor = Color.Transparent;
            lblTextoPrincipal.Font = new Font("Roboto Bk", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTextoPrincipal.ForeColor = SystemColors.Window;
            lblTextoPrincipal.Location = new Point(132, 90);
            lblTextoPrincipal.Name = "lblTextoPrincipal";
            lblTextoPrincipal.Size = new Size(361, 125);
            lblTextoPrincipal.TabIndex = 0;
            lblTextoPrincipal.Text = "Seja bem vindo(a) ao nosso Museu\r\nMultitemático!\r\n\r\nApresentaremos para você a primeira\r\nViagem do Homem à Lua";
            lblTextoPrincipal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAvancar1
            // 
            btnAvancar1.FlatAppearance.BorderColor = SystemColors.MenuText;
            btnAvancar1.Font = new Font("Roboto Bk", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAvancar1.ForeColor = SystemColors.ControlText;
            btnAvancar1.Location = new Point(273, 303);
            btnAvancar1.Margin = new Padding(3, 2, 3, 2);
            btnAvancar1.Name = "btnAvancar1";
            btnAvancar1.Size = new Size(85, 37);
            btnAvancar1.TabIndex = 1;
            btnAvancar1.Text = "AVANÇAR";
            btnAvancar1.UseVisualStyleBackColor = true;
            btnAvancar1.Click += btn1_Click;
            // 
            // F_TelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 74, 121);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(639, 351);
            Controls.Add(btnAvancar1);
            Controls.Add(lblTextoPrincipal);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "F_TelaPrincipal";
            Text = "Totem Museu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label lblTextoPrincipal;
        private Button btnAvancar1;
    }
}
