namespace TecladoVirtual.Telas
{
    partial class F_Lua2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Lua2));
            lblSaturnV = new Label();
            lblTextoLua2 = new Label();
            label1 = new Label();
            btnVoltarLua1 = new Button();
            btnAvancarLua3 = new Button();
            SuspendLayout();
            // 
            // lblSaturnV
            // 
            lblSaturnV.Anchor = AnchorStyles.None;
            lblSaturnV.AutoSize = true;
            lblSaturnV.BackColor = Color.Transparent;
            lblSaturnV.Font = new Font("Roboto Bk", 27.75F);
            lblSaturnV.ForeColor = SystemColors.Window;
            lblSaturnV.Location = new Point(82, -54);
            lblSaturnV.Name = "lblSaturnV";
            lblSaturnV.Size = new Size(163, 44);
            lblSaturnV.TabIndex = 0;
            lblSaturnV.Text = "Saturn V";
            lblSaturnV.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTextoLua2
            // 
            lblTextoLua2.Anchor = AnchorStyles.None;
            lblTextoLua2.AutoSize = true;
            lblTextoLua2.BackColor = Color.Transparent;
            lblTextoLua2.Font = new Font("Roboto Bk", 27.75F);
            lblTextoLua2.ForeColor = SystemColors.Window;
            lblTextoLua2.Location = new Point(-205, -10);
            lblTextoLua2.Name = "lblTextoLua2";
            lblTextoLua2.Size = new Size(739, 176);
            lblTextoLua2.TabIndex = 1;
            lblTextoLua2.Text = "O foguete espacial utilizado na missão \r\nApollo 11 foi o Saturn V, uma das maiores \r\ne mais poderosas máquinas já construídas \r\npelo homem.";
            lblTextoLua2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Roboto Bk", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(-181, 182);
            label1.Name = "label1";
            label1.Size = new Size(690, 264);
            label1.TabIndex = 2;
            label1.Text = resources.GetString("label1.Text");
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnVoltarLua1
            // 
            btnVoltarLua1.Anchor = AnchorStyles.Right;
            btnVoltarLua1.BackColor = Color.Transparent;
            btnVoltarLua1.FlatAppearance.BorderSize = 3;
            btnVoltarLua1.FlatStyle = FlatStyle.Flat;
            btnVoltarLua1.Font = new Font("Roboto Bk", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVoltarLua1.ForeColor = SystemColors.Window;
            btnVoltarLua1.Location = new Point(496, 42);
            btnVoltarLua1.Name = "btnVoltarLua1";
            btnVoltarLua1.Size = new Size(150, 80);
            btnVoltarLua1.TabIndex = 4;
            btnVoltarLua1.Text = "VOLTAR";
            btnVoltarLua1.UseVisualStyleBackColor = false;
            btnVoltarLua1.Click += btnVoltarLua1_Click;
            // 
            // btnAvancarLua3
            // 
            btnAvancarLua3.Anchor = AnchorStyles.Right;
            btnAvancarLua3.BackColor = Color.Transparent;
            btnAvancarLua3.FlatAppearance.BorderSize = 3;
            btnAvancarLua3.FlatStyle = FlatStyle.Flat;
            btnAvancarLua3.Font = new Font("Roboto Bk", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAvancarLua3.ForeColor = SystemColors.Window;
            btnAvancarLua3.Location = new Point(496, 234);
            btnAvancarLua3.Name = "btnAvancarLua3";
            btnAvancarLua3.Size = new Size(150, 80);
            btnAvancarLua3.TabIndex = 5;
            btnAvancarLua3.Text = "AVANÇAR";
            btnAvancarLua3.UseVisualStyleBackColor = false;
            // 
            // F_Lua2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(784, 441);
            ControlBox = false;
            Controls.Add(btnAvancarLua3);
            Controls.Add(btnVoltarLua1);
            Controls.Add(label1);
            Controls.Add(lblTextoLua2);
            Controls.Add(lblSaturnV);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "F_Lua2";
            Text = "F_Lua2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSaturnV;
        private Label lblTextoLua2;
        private Label label1;
        private Button btnVoltarLua1;
        private Button btnAvancarLua3;
    }
}