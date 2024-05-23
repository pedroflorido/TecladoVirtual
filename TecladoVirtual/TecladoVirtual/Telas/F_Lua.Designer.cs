namespace TecladoVirtual.Telas
{
    partial class F_Lua
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Lua));
            lblTextoLua = new Label();
            btnVoltarLua = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnAvancarLua2 = new Button();
            lblInfo2Lua1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblTextoLua
            // 
            lblTextoLua.AutoSize = true;
            lblTextoLua.BackColor = Color.Transparent;
            lblTextoLua.Font = new Font("Roboto Bk", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTextoLua.ForeColor = SystemColors.Window;
            lblTextoLua.Location = new Point(55, 9);
            lblTextoLua.Name = "lblTextoLua";
            lblTextoLua.Size = new Size(932, 336);
            lblTextoLua.TabIndex = 0;
            lblTextoLua.Text = resources.GetString("lblTextoLua.Text");
            lblTextoLua.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnVoltarLua
            // 
            btnVoltarLua.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnVoltarLua.BackColor = Color.Transparent;
            btnVoltarLua.FlatAppearance.BorderSize = 3;
            btnVoltarLua.FlatStyle = FlatStyle.Flat;
            btnVoltarLua.Font = new Font("Roboto Bk", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVoltarLua.ForeColor = SystemColors.Window;
            btnVoltarLua.Location = new Point(88, 372);
            btnVoltarLua.Name = "btnVoltarLua";
            btnVoltarLua.Size = new Size(150, 80);
            btnVoltarLua.TabIndex = 3;
            btnVoltarLua.Text = "VOLTAR";
            btnVoltarLua.UseVisualStyleBackColor = false;
            btnVoltarLua.Click += btnVoltarLua_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Left;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(88, 232);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(290, 220);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.ErrorImage = null;
            pictureBox2.InitialImage = null;
            pictureBox2.Location = new Point(433, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(300, 210);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // btnAvancarLua2
            // 
            btnAvancarLua2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAvancarLua2.BackColor = Color.Transparent;
            btnAvancarLua2.FlatAppearance.BorderSize = 3;
            btnAvancarLua2.FlatStyle = FlatStyle.Flat;
            btnAvancarLua2.Font = new Font("Roboto Bk", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAvancarLua2.ForeColor = SystemColors.Window;
            btnAvancarLua2.Location = new Point(583, 372);
            btnAvancarLua2.Name = "btnAvancarLua2";
            btnAvancarLua2.Size = new Size(150, 80);
            btnAvancarLua2.TabIndex = 6;
            btnAvancarLua2.Text = "AVANÇAR";
            btnAvancarLua2.UseVisualStyleBackColor = false;
            btnAvancarLua2.Click += btnAvancarLua2_Click;
            // 
            // lblInfo2Lua1
            // 
            lblInfo2Lua1.Anchor = AnchorStyles.None;
            lblInfo2Lua1.AutoSize = true;
            lblInfo2Lua1.BackColor = Color.Transparent;
            lblInfo2Lua1.Font = new Font("Roboto Bk", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInfo2Lua1.ForeColor = SystemColors.Window;
            lblInfo2Lua1.Location = new Point(157, 245);
            lblInfo2Lua1.Name = "lblInfo2Lua1";
            lblInfo2Lua1.Size = new Size(839, 294);
            lblInfo2Lua1.TabIndex = 7;
            lblInfo2Lua1.Text = resources.GetString("lblInfo2Lua1.Text");
            lblInfo2Lua1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // F_Lua
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 480);
            ControlBox = false;
            Controls.Add(btnAvancarLua2);
            Controls.Add(pictureBox2);
            Controls.Add(btnVoltarLua);
            Controls.Add(lblTextoLua);
            Controls.Add(pictureBox1);
            Controls.Add(lblInfo2Lua1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "F_Lua";
            Text = "F_Lua";
            Load += F_Lua_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTextoLua;
        private Button btnVoltarLua;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnAvancarLua2;
        private Label lblInfo2Lua1;
    }
}