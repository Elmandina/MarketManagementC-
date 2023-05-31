namespace marketManagement
{
    partial class ManageCategories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageCategories));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            HBtn = new Button();
            DeleteBtn = new Button();
            EditBtn = new Button();
            AddBtn = new Button();
            CatId = new Panel();
            CatIdTxt = new TextBox();
            CatName = new Panel();
            CatNameTxt = new TextBox();
            CatGrid = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            CatId.SuspendLayout();
            CatName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CatGrid).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1027, 128);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(993, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(34, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.SandyBrown;
            label1.Location = new Point(359, 80);
            label1.Name = "label1";
            label1.Size = new Size(322, 48);
            label1.TabIndex = 3;
            label1.Text = "Manage Products";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.PeachPuff;
            label2.Location = new Point(207, 9);
            label2.Name = "label2";
            label2.Size = new Size(616, 57);
            label2.TabIndex = 2;
            label2.Text = "Market Management System";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(HBtn);
            panel2.Controls.Add(DeleteBtn);
            panel2.Controls.Add(EditBtn);
            panel2.Controls.Add(AddBtn);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 128);
            panel2.Name = "panel2";
            panel2.Size = new Size(163, 522);
            panel2.TabIndex = 1;
            // 
            // HBtn
            // 
            HBtn.BackColor = SystemColors.Control;
            HBtn.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            HBtn.ForeColor = Color.FromArgb(255, 128, 0);
            HBtn.Location = new Point(35, 454);
            HBtn.Name = "HBtn";
            HBtn.Padding = new Padding(1);
            HBtn.Size = new Size(108, 46);
            HBtn.TabIndex = 5;
            HBtn.Text = "HOME";
            HBtn.UseVisualStyleBackColor = false;
            HBtn.Click += HBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = SystemColors.Control;
            DeleteBtn.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteBtn.ForeColor = Color.FromArgb(255, 128, 0);
            DeleteBtn.Location = new Point(35, 242);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Padding = new Padding(1);
            DeleteBtn.Size = new Size(108, 46);
            DeleteBtn.TabIndex = 4;
            DeleteBtn.Text = "DELETE";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.BackColor = SystemColors.Control;
            EditBtn.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            EditBtn.ForeColor = Color.FromArgb(255, 128, 0);
            EditBtn.Location = new Point(35, 167);
            EditBtn.Name = "EditBtn";
            EditBtn.Padding = new Padding(1);
            EditBtn.Size = new Size(108, 46);
            EditBtn.TabIndex = 3;
            EditBtn.Text = "EDIT";
            EditBtn.UseVisualStyleBackColor = false;
            EditBtn.Click += EditBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = SystemColors.Control;
            AddBtn.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            AddBtn.ForeColor = Color.FromArgb(255, 128, 0);
            AddBtn.Location = new Point(35, 96);
            AddBtn.Name = "AddBtn";
            AddBtn.Padding = new Padding(1);
            AddBtn.Size = new Size(108, 46);
            AddBtn.TabIndex = 1;
            AddBtn.Text = "ADD";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // CatId
            // 
            CatId.BackColor = Color.White;
            CatId.Controls.Add(CatIdTxt);
            CatId.Location = new Point(193, 224);
            CatId.Name = "CatId";
            CatId.Padding = new Padding(0, 0, 0, 5);
            CatId.Size = new Size(250, 36);
            CatId.TabIndex = 2;
            // 
            // CatIdTxt
            // 
            CatIdTxt.BackColor = Color.FromArgb(255, 128, 0);
            CatIdTxt.BorderStyle = BorderStyle.None;
            CatIdTxt.Dock = DockStyle.Fill;
            CatIdTxt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CatIdTxt.ForeColor = Color.Black;
            CatIdTxt.Location = new Point(0, 0);
            CatIdTxt.Multiline = true;
            CatIdTxt.Name = "CatIdTxt";
            CatIdTxt.PlaceholderText = "Category Id";
            CatIdTxt.Size = new Size(250, 31);
            CatIdTxt.TabIndex = 0;
            // 
            // CatName
            // 
            CatName.BackColor = Color.White;
            CatName.Controls.Add(CatNameTxt);
            CatName.Location = new Point(193, 295);
            CatName.Name = "CatName";
            CatName.Padding = new Padding(0, 0, 0, 5);
            CatName.Size = new Size(250, 38);
            CatName.TabIndex = 3;
            // 
            // CatNameTxt
            // 
            CatNameTxt.BackColor = Color.FromArgb(255, 128, 0);
            CatNameTxt.BorderStyle = BorderStyle.None;
            CatNameTxt.Dock = DockStyle.Fill;
            CatNameTxt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CatNameTxt.ForeColor = Color.Black;
            CatNameTxt.Location = new Point(0, 0);
            CatNameTxt.Multiline = true;
            CatNameTxt.Name = "CatNameTxt";
            CatNameTxt.PlaceholderText = "Category Name";
            CatNameTxt.Size = new Size(250, 33);
            CatNameTxt.TabIndex = 0;
            // 
            // CatGrid
            // 
            CatGrid.BackgroundColor = SystemColors.Control;
            CatGrid.CellBorderStyle = DataGridViewCellBorderStyle.None;
            CatGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CatGrid.GridColor = SystemColors.Control;
            CatGrid.Location = new Point(480, 220);
            CatGrid.Name = "CatGrid";
            CatGrid.RowHeadersWidth = 51;
            CatGrid.RowTemplate.Height = 29;
            CatGrid.Size = new Size(547, 430);
            CatGrid.TabIndex = 8;
            CatGrid.CellContentClick += CatGrid_CellContentClick;
            // 
            // ManageCategories
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(1027, 650);
            Controls.Add(CatGrid);
            Controls.Add(CatName);
            Controls.Add(CatId);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageCategories";
            Text = "ManageCategories";
            Load += ManageCategories_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            CatId.ResumeLayout(false);
            CatId.PerformLayout();
            CatName.ResumeLayout(false);
            CatName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CatGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button AddBtn;
        private Button EditBtn;
        private Button DeleteBtn;
        private Button HBtn;
        private Label label2;
        private Label label1;
        private Panel CatId;
        private TextBox CatIdTxt;
        private Panel CatName;
        private TextBox CatNameTxt;
        private PictureBox pictureBox1;
        private DataGridView CatGrid;
    }
}