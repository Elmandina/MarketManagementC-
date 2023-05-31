namespace marketManagement
{
    partial class ManageProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageProducts));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            HBtn = new Button();
            EditBtn = new Button();
            DeleteBtn = new Button();
            AddBtn = new Button();
            IdPnl = new Panel();
            IdTxt = new TextBox();
            PrdNamePnl = new Panel();
            PrdNameTxt = new TextBox();
            PrdPricePnl = new Panel();
            PrdPriceTxt = new TextBox();
            QtyPnl = new Panel();
            QtyTxt = new TextBox();
            ProdGrid = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            IdPnl.SuspendLayout();
            PrdNamePnl.SuspendLayout();
            PrdPricePnl.SuspendLayout();
            QtyPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProdGrid).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1070, 125);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1036, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(34, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.LightSalmon;
            label2.Location = new Point(237, 15);
            label2.Name = "label2";
            label2.Size = new Size(616, 57);
            label2.TabIndex = 1;
            label2.Text = "Market Management System";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(357, 77);
            label1.Name = "label1";
            label1.Size = new Size(322, 48);
            label1.TabIndex = 0;
            label1.Text = "Manage Products";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 128, 0);
            panel2.Controls.Add(HBtn);
            panel2.Controls.Add(EditBtn);
            panel2.Controls.Add(DeleteBtn);
            panel2.Controls.Add(AddBtn);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 125);
            panel2.Name = "panel2";
            panel2.Size = new Size(198, 606);
            panel2.TabIndex = 1;
            // 
            // HBtn
            // 
            HBtn.BackColor = Color.FromArgb(255, 128, 0);
            HBtn.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            HBtn.ForeColor = Color.FromArgb(255, 224, 192);
            HBtn.Location = new Point(36, 490);
            HBtn.Name = "HBtn";
            HBtn.Padding = new Padding(1);
            HBtn.Size = new Size(108, 46);
            HBtn.TabIndex = 3;
            HBtn.Text = "HOME";
            HBtn.UseVisualStyleBackColor = false;
            HBtn.Click += button3_Click;
            // 
            // EditBtn
            // 
            EditBtn.BackColor = Color.FromArgb(255, 128, 0);
            EditBtn.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            EditBtn.ForeColor = Color.FromArgb(255, 224, 192);
            EditBtn.Location = new Point(36, 166);
            EditBtn.Name = "EditBtn";
            EditBtn.Padding = new Padding(1);
            EditBtn.Size = new Size(108, 46);
            EditBtn.TabIndex = 2;
            EditBtn.Text = "EDIT";
            EditBtn.UseVisualStyleBackColor = false;
            EditBtn.Click += EditBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.FromArgb(255, 128, 0);
            DeleteBtn.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteBtn.ForeColor = Color.FromArgb(255, 224, 192);
            DeleteBtn.Location = new Point(36, 234);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Padding = new Padding(1);
            DeleteBtn.Size = new Size(108, 46);
            DeleteBtn.TabIndex = 1;
            DeleteBtn.Text = "DELETE";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.FromArgb(255, 128, 0);
            AddBtn.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            AddBtn.ForeColor = Color.FromArgb(255, 224, 192);
            AddBtn.Location = new Point(36, 98);
            AddBtn.Name = "AddBtn";
            AddBtn.Padding = new Padding(1);
            AddBtn.Size = new Size(108, 46);
            AddBtn.TabIndex = 0;
            AddBtn.Text = "ADD";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // IdPnl
            // 
            IdPnl.BackColor = Color.FromArgb(255, 128, 0);
            IdPnl.Controls.Add(IdTxt);
            IdPnl.Location = new Point(220, 158);
            IdPnl.Name = "IdPnl";
            IdPnl.Padding = new Padding(0, 0, 0, 5);
            IdPnl.Size = new Size(250, 30);
            IdPnl.TabIndex = 2;
            // 
            // IdTxt
            // 
            IdTxt.BorderStyle = BorderStyle.None;
            IdTxt.Dock = DockStyle.Fill;
            IdTxt.Location = new Point(0, 0);
            IdTxt.Multiline = true;
            IdTxt.Name = "IdTxt";
            IdTxt.PlaceholderText = "Order Id";
            IdTxt.Size = new Size(250, 25);
            IdTxt.TabIndex = 0;
            // 
            // PrdNamePnl
            // 
            PrdNamePnl.BackColor = Color.FromArgb(255, 128, 0);
            PrdNamePnl.Controls.Add(PrdNameTxt);
            PrdNamePnl.Location = new Point(220, 221);
            PrdNamePnl.Name = "PrdNamePnl";
            PrdNamePnl.Padding = new Padding(0, 0, 0, 5);
            PrdNamePnl.Size = new Size(250, 30);
            PrdNamePnl.TabIndex = 3;
            // 
            // PrdNameTxt
            // 
            PrdNameTxt.BorderStyle = BorderStyle.None;
            PrdNameTxt.Dock = DockStyle.Fill;
            PrdNameTxt.Location = new Point(0, 0);
            PrdNameTxt.Multiline = true;
            PrdNameTxt.Name = "PrdNameTxt";
            PrdNameTxt.PlaceholderText = "Product Name";
            PrdNameTxt.Size = new Size(250, 25);
            PrdNameTxt.TabIndex = 0;
            // 
            // PrdPricePnl
            // 
            PrdPricePnl.BackColor = Color.FromArgb(255, 128, 0);
            PrdPricePnl.Controls.Add(PrdPriceTxt);
            PrdPricePnl.Location = new Point(220, 359);
            PrdPricePnl.Name = "PrdPricePnl";
            PrdPricePnl.Padding = new Padding(0, 0, 0, 5);
            PrdPricePnl.Size = new Size(250, 30);
            PrdPricePnl.TabIndex = 4;
            // 
            // PrdPriceTxt
            // 
            PrdPriceTxt.BorderStyle = BorderStyle.None;
            PrdPriceTxt.Dock = DockStyle.Fill;
            PrdPriceTxt.Location = new Point(0, 0);
            PrdPriceTxt.Multiline = true;
            PrdPriceTxt.Name = "PrdPriceTxt";
            PrdPriceTxt.PlaceholderText = "Product Price";
            PrdPriceTxt.Size = new Size(250, 25);
            PrdPriceTxt.TabIndex = 0;
            // 
            // QtyPnl
            // 
            QtyPnl.BackColor = Color.FromArgb(255, 128, 0);
            QtyPnl.Controls.Add(QtyTxt);
            QtyPnl.Location = new Point(220, 291);
            QtyPnl.Name = "QtyPnl";
            QtyPnl.Padding = new Padding(0, 0, 0, 5);
            QtyPnl.Size = new Size(250, 30);
            QtyPnl.TabIndex = 5;
            // 
            // QtyTxt
            // 
            QtyTxt.BorderStyle = BorderStyle.None;
            QtyTxt.Dock = DockStyle.Fill;
            QtyTxt.Location = new Point(0, 0);
            QtyTxt.Multiline = true;
            QtyTxt.Name = "QtyTxt";
            QtyTxt.PlaceholderText = "Product Quantity";
            QtyTxt.Size = new Size(250, 25);
            QtyTxt.TabIndex = 0;
            // 
            // ProdGrid
            // 
            ProdGrid.BackgroundColor = SystemColors.Control;
            ProdGrid.CellBorderStyle = DataGridViewCellBorderStyle.None;
            ProdGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProdGrid.GridColor = SystemColors.Control;
            ProdGrid.Location = new Point(511, 270);
            ProdGrid.Name = "ProdGrid";
            ProdGrid.RowHeadersWidth = 51;
            ProdGrid.RowTemplate.Height = 29;
            ProdGrid.Size = new Size(547, 430);
            ProdGrid.TabIndex = 7;
            ProdGrid.CellContentClick += ProdGrid_CellContentClick;
            // 
            // ManageProducts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1070, 731);
            Controls.Add(ProdGrid);
            Controls.Add(QtyPnl);
            Controls.Add(PrdPricePnl);
            Controls.Add(PrdNamePnl);
            Controls.Add(IdPnl);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageProducts";
            Text = "ManageUsers";
            Load += ManageProducts_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            IdPnl.ResumeLayout(false);
            IdPnl.PerformLayout();
            PrdNamePnl.ResumeLayout(false);
            PrdNamePnl.PerformLayout();
            PrdPricePnl.ResumeLayout(false);
            PrdPricePnl.PerformLayout();
            QtyPnl.ResumeLayout(false);
            QtyPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ProdGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Panel IdPnl;
        private TextBox IdTxt;
        private Panel PrdNamePnl;
        private TextBox PrdNameTxt;
        private Panel PrdPricePnl;
        private TextBox PrdPriceTxt;
        private Panel QtyPnl;
        private TextBox QtyTxt;
        private Button AddBtn;
        private Button HBtn;
        private Button EditBtn;
        private Button DeleteBtn;
        private PictureBox pictureBox1;
        private DataGridView ProdV;
        private Panel panelTb;
        private DataGridView dataGridView1;
        private DataGridView ProdGrid;
    }
}