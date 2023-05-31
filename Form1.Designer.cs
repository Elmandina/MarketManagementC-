namespace marketManagement
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
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            UserNamePnl = new Panel();
            UserNameTxt = new TextBox();
            PassPnl = new Panel();
            PassTxt = new TextBox();
            LoginBtn = new Button();
            label3 = new Label();
            checkBox1 = new CheckBox();
            btnClose = new PictureBox();
            linkLabel1 = new LinkLabel();
            comboBox1 = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            UserNamePnl.SuspendLayout();
            PassPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(371, 389);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Monotype Corsiva", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(108, 323);
            label1.Name = "label1";
            label1.Size = new Size(142, 24);
            label1.TabIndex = 1;
            label1.Text = "EGIB-A Market";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(14, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(342, 294);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(255, 192, 128);
            label2.Location = new Point(447, 40);
            label2.Name = "label2";
            label2.Size = new Size(89, 28);
            label2.TabIndex = 1;
            label2.Text = "LOGIN";
            // 
            // UserNamePnl
            // 
            UserNamePnl.BackColor = Color.FromArgb(255, 128, 0);
            UserNamePnl.Controls.Add(UserNameTxt);
            UserNamePnl.ForeColor = Color.FromArgb(255, 128, 0);
            UserNamePnl.Location = new Point(381, 141);
            UserNamePnl.Name = "UserNamePnl";
            UserNamePnl.Padding = new Padding(0, 0, 0, 5);
            UserNamePnl.Size = new Size(250, 30);
            UserNamePnl.TabIndex = 2;
            // 
            // UserNameTxt
            // 
            UserNameTxt.BackColor = Color.White;
            UserNameTxt.BorderStyle = BorderStyle.None;
            UserNameTxt.Dock = DockStyle.Fill;
            UserNameTxt.Location = new Point(0, 0);
            UserNameTxt.Multiline = true;
            UserNameTxt.Name = "UserNameTxt";
            UserNameTxt.PlaceholderText = "User Name";
            UserNameTxt.Size = new Size(250, 25);
            UserNameTxt.TabIndex = 0;
            UserNameTxt.TextChanged += UserNameTxt_TextChanged;
            // 
            // PassPnl
            // 
            PassPnl.BackColor = Color.FromArgb(255, 128, 0);
            PassPnl.Controls.Add(PassTxt);
            PassPnl.ForeColor = Color.FromArgb(255, 128, 0);
            PassPnl.Location = new Point(381, 219);
            PassPnl.Name = "PassPnl";
            PassPnl.Padding = new Padding(0, 0, 0, 5);
            PassPnl.Size = new Size(250, 30);
            PassPnl.TabIndex = 3;
            // 
            // PassTxt
            // 
            PassTxt.BackColor = Color.White;
            PassTxt.BorderStyle = BorderStyle.None;
            PassTxt.Dock = DockStyle.Fill;
            PassTxt.Location = new Point(0, 0);
            PassTxt.Multiline = true;
            PassTxt.Name = "PassTxt";
            PassTxt.PasswordChar = '*';
            PassTxt.PlaceholderText = "Password";
            PassTxt.Size = new Size(250, 25);
            PassTxt.TabIndex = 0;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.FromArgb(255, 128, 0);
            LoginBtn.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            LoginBtn.ForeColor = Color.Black;
            LoginBtn.Location = new Point(447, 281);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(94, 34);
            LoginBtn.TabIndex = 4;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(255, 128, 0);
            label3.Location = new Point(402, 353);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 5;
            label3.Text = "Clear";
            label3.Click += label3_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox1.ForeColor = Color.FromArgb(255, 128, 0);
            checkBox1.Location = new Point(492, 352);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(140, 24);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // btnClose
            // 
            btnClose.BackColor = SystemColors.Control;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(612, 1);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(30, 28);
            btnClose.SizeMode = PictureBoxSizeMode.StretchImage;
            btnClose.TabIndex = 7;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.ForeColor = Color.DarkOrange;
            linkLabel1.LinkColor = Color.DarkOrange;
            linkLabel1.Location = new Point(412, 318);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(184, 21);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Don't have an account?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.ForeColor = Color.FromArgb(255, 128, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Admin", "Customer" });
            comboBox1.Location = new Point(412, 71);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 26);
            comboBox1.TabIndex = 9;
            comboBox1.Text = "SELECT";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(643, 391);
            Controls.Add(comboBox1);
            Controls.Add(linkLabel1);
            Controls.Add(btnClose);
            Controls.Add(checkBox1);
            Controls.Add(label3);
            Controls.Add(LoginBtn);
            Controls.Add(PassPnl);
            Controls.Add(UserNamePnl);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            UserNamePnl.ResumeLayout(false);
            UserNamePnl.PerformLayout();
            PassPnl.ResumeLayout(false);
            PassPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Panel UserNamePnl;
        private TextBox UserNameTxt;
        private Panel PassPnl;
        private TextBox PassTxt;
        private Button LoginBtn;
        private Label label3;
        private CheckBox checkBox1;
        private PictureBox btnClose;
        private LinkLabel linkLabel1;
        private ComboBox comboBox1;
    }
}