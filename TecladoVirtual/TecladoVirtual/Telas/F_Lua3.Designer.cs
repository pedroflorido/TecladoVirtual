namespace TecladoVirtual.Telas
{
    partial class F_Lua3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Lua3));
            label1 = new Label();
            btnVoltarLua1 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Roboto Bk", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(575, 190);
            label1.TabIndex = 0;
            label1.Text = "A Lua é o quinto maior satélite natural \r\ndo Sistema Solar e é o satélite natural \r\nmais próximo da Terra. Sua distância \r\nmédia da Terra é de aproximadamente \r\n384.400 quilômetros.";
            // 
            // btnVoltarLua1
            // 
            btnVoltarLua1.Anchor = AnchorStyles.Right;
            btnVoltarLua1.BackColor = Color.Transparent;
            btnVoltarLua1.FlatAppearance.BorderSize = 3;
            btnVoltarLua1.FlatStyle = FlatStyle.Flat;
            btnVoltarLua1.Font = new Font("Roboto Bk", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVoltarLua1.ForeColor = SystemColors.Window;
            btnVoltarLua1.Location = new Point(567, 348);
            btnVoltarLua1.Name = "btnVoltarLua1";
            btnVoltarLua1.Size = new Size(150, 80);
            btnVoltarLua1.TabIndex = 5;
            btnVoltarLua1.Text = "VOLTAR";
            btnVoltarLua1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Roboto Bk", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(12, 229);
            label2.Name = "label2";
            label2.Size = new Size(705, 228);
            label2.TabIndex = 6;
            label2.Text = resources.GetString("label2.Text");
            // 
            // F_Lua3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 480);
            ControlBox = false;
            Controls.Add(btnVoltarLua1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "F_Lua3";
            Text = "F_Lua3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnVoltarLua1;
        private Label label2;
    }
}