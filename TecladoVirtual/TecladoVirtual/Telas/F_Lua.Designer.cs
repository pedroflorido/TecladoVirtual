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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblTextoLua
            // 
            lblTextoLua.Anchor = AnchorStyles.None;
            lblTextoLua.AutoSize = true;
            lblTextoLua.BackColor = Color.Transparent;
            lblTextoLua.Font = new Font("Roboto Bk", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTextoLua.ForeColor = SystemColors.Window;
            lblTextoLua.Location = new Point(-92, 9);
            lblTextoLua.Name = "lblTextoLua";
            lblTextoLua.Size = new Size(968, 330);
            lblTextoLua.TabIndex = 0;
            lblTextoLua.Text = resources.GetString("lblTextoLua.Text");
            lblTextoLua.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnVoltarLua
            // 
            btnVoltarLua.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnVoltarLua.Font = new Font("Roboto Bk", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVoltarLua.Location = new Point(631, 344);
            btnVoltarLua.Name = "btnVoltarLua";
            btnVoltarLua.Size = new Size(85, 37);
            btnVoltarLua.TabIndex = 3;
            btnVoltarLua.Text = "VOLTAR";
            btnVoltarLua.UseVisualStyleBackColor = true;
            btnVoltarLua.Click += btnVoltarLua_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(386, 210);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 190);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Bottom;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Location = new Point(130, 210);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(250, 190);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // F_Lua
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(784, 441);
            ControlBox = false;
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnVoltarLua);
            Controls.Add(lblTextoLua);
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
    }
}