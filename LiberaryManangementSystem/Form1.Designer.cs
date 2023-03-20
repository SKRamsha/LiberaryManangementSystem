namespace LiberaryManangementSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            userControl11 = new UserControl1();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.NavajoWhite;
            button1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(128, 64, 0);
            button1.Location = new Point(290, 104);
            button1.Margin = new Padding(8, 9, 8, 9);
            button1.Name = "button1";
            button1.Size = new Size(129, 45);
            button1.TabIndex = 0;
            button1.Text = "Admin\r\n";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(-4, 9);
            label1.Margin = new Padding(8, 0, 8, 0);
            label1.Name = "label1";
            label1.Size = new Size(423, 45);
            label1.TabIndex = 1;
            label1.Text = "Library Management System\r\n";
            // 
            // button2
            // 
            button2.BackColor = Color.NavajoWhite;
            button2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(128, 64, 0);
            button2.Location = new Point(113, 104);
            button2.Margin = new Padding(8, 9, 8, 9);
            button2.Name = "button2";
            button2.Size = new Size(148, 45);
            button2.TabIndex = 3;
            button2.Text = "Student\r\n";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // userControl11
            // 
            userControl11.BackColor = Color.PeachPuff;
            userControl11.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            userControl11.Location = new Point(142, 180);
            userControl11.Name = "userControl11";
            userControl11.Size = new Size(250, 280);
            userControl11.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(19F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1370, 749);
            Controls.Add(userControl11);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(255, 192, 128);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(8, 9, 8, 9);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Button button2;
        private UserControl1 userControl11;
    }
}