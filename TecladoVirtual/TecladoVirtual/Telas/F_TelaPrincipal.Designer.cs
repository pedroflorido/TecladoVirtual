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
            lblTextoPrincipal.Anchor = AnchorStyles.None;
            lblTextoPrincipal.AutoSize = true;
            lblTextoPrincipal.BackColor = Color.Transparent;
            lblTextoPrincipal.Font = new Font("Roboto Bk", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTextoPrincipal.ForeColor = SystemColors.Window;
            lblTextoPrincipal.Location = new Point(-10, 53);
            lblTextoPrincipal.Name = "lblTextoPrincipal";
            lblTextoPrincipal.Size = new Size(826, 290);
            lblTextoPrincipal.TabIndex = 0;
            lblTextoPrincipal.Text = "Seja bem vindo(a) ao nosso Museu\r\nMultitemático!\r\n\r\nApresentaremos para você a primeira\r\nViagem do Homem à Lua";
            lblTextoPrincipal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAvancar1
            // 
            btnAvancar1.Anchor = AnchorStyles.Bottom;
            btnAvancar1.BackColor = Color.Transparent;
            btnAvancar1.FlatAppearance.BorderColor = SystemColors.Window;
            btnAvancar1.FlatAppearance.BorderSize = 3;
            btnAvancar1.FlatStyle = FlatStyle.Flat;
            btnAvancar1.Font = new Font("Roboto Bk", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAvancar1.ForeColor = SystemColors.Window;
            btnAvancar1.Location = new Point(328, 373);
            btnAvancar1.Margin = new Padding(3, 2, 3, 2);
            btnAvancar1.Name = "btnAvancar1";
            btnAvancar1.Size = new Size(150, 80);
            btnAvancar1.TabIndex = 1;
            btnAvancar1.Text = "AVANÇAR";
            btnAvancar1.UseVisualStyleBackColor = false;
            btnAvancar1.Click += btn1_Click;
            // 
            // F_TelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 480);
            Controls.Add(btnAvancar1);
            Controls.Add(lblTextoPrincipal);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "F_TelaPrincipal";
            RightToLeft = RightToLeft.No;
            Text = "Totem Museu";
            Load += F_TelaPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label lblTextoPrincipal;
        private Button btnAvancar1;
    }
}
