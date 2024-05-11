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
            lblTextoLua.AutoSize = true;
            lblTextoLua.BackColor = Color.Transparent;
            lblTextoLua.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTextoLua.ForeColor = SystemColors.Window;
            lblTextoLua.Location = new Point(14, 12);
            lblTextoLua.Name = "lblTextoLua";
            lblTextoLua.Size = new Size(676, 240);
            lblTextoLua.TabIndex = 0;
            lblTextoLua.Text = resources.GetString("lblTextoLua.Text");
            lblTextoLua.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnVoltarLua
            // 
            btnVoltarLua.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVoltarLua.Location = new Point(619, 403);
            btnVoltarLua.Margin = new Padding(3, 4, 3, 4);
            btnVoltarLua.Name = "btnVoltarLua";
            btnVoltarLua.Size = new Size(97, 49);
            btnVoltarLua.TabIndex = 3;
            btnVoltarLua.Text = "VOLTAR";
            btnVoltarLua.UseVisualStyleBackColor = true;
            btnVoltarLua.Click += btnVoltarLua_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(344, 280);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(203, 171);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Location = new Point(134, 280);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(203, 171);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // F_Lua
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(730, 468);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnVoltarLua);
            Controls.Add(lblTextoLua);
            Margin = new Padding(3, 4, 3, 4);
            Name = "F_Lua";
            Text = "F_Lua";
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