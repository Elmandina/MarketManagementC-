namespace marketManagement
{
    partial class ManageCustomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageCustomers));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            HBtn = new Button();
            EditBtn = new Button();
            DeleteBtn = new Button();
            QtyPnl = new Panel();
            CustPhone = new TextBox();
            PrdPricePnl = new Panel();
            CustEmail = new TextBox();
            PrdNamePnl = new Panel();
            CustName = new TextBox();
            CustGrid = new DataGridView();
            panel3 = new Panel();
            gender = new TextBox();
            label3 = new Label();
            panel4 = new Panel();
            OrdersLbl = new Label();
            label4 = new Label();
            OrdersAmount = new Panel();
            OrdersAmt = new Label();
            label7 = new Label();
            panel6 = new Panel();
            DateLbl = new Label();
            label9 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            QtyPnl.SuspendLayout();
            PrdPricePnl.SuspendLayout();
            PrdNamePnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CustGrid).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            OrdersAmount.SuspendLayout();
            panel6.SuspendLayout();
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
            panel1.Size = new Size(1247, 125);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1213, 0);
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
            label1.Size = new Size(357, 48);
            label1.TabIndex = 0;
            label1.Text = "Manage Customers";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 128, 0);
            panel2.Controls.Add(HBtn);
            panel2.Controls.Add(EditBtn);
            panel2.Controls.Add(DeleteBtn);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 125);
            panel2.Name = "panel2";
            panel2.Size = new Size(198, 696);
            panel2.TabIndex = 2;
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
            HBtn.Click += HBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.BackColor = Color.FromArgb(255, 128, 0);
            EditBtn.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            EditBtn.ForeColor = Color.FromArgb(255, 224, 192);
            EditBtn.Location = new Point(36, 109);
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
            DeleteBtn.Location = new Point(36, 221);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Padding = new Padding(1);
            DeleteBtn.Size = new Size(108, 46);
            DeleteBtn.TabIndex = 1;
            DeleteBtn.Text = "DELETE";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // QtyPnl
            // 
            QtyPnl.BackColor = Color.FromArgb(255, 128, 0);
            QtyPnl.Controls.Add(CustPhone);
            QtyPnl.Location = new Point(213, 234);
            QtyPnl.Name = "QtyPnl";
            QtyPnl.Padding = new Padding(0, 0, 0, 5);
            QtyPnl.Size = new Size(250, 30);
            QtyPnl.TabIndex = 9;
            // 
            // CustPhone
            // 
            CustPhone.BorderStyle = BorderStyle.None;
            CustPhone.Dock = DockStyle.Fill;
            CustPhone.Location = new Point(0, 0);
            CustPhone.Multiline = true;
            CustPhone.Name = "CustPhone";
            CustPhone.PlaceholderText = "Phone";
            CustPhone.Size = new Size(250, 25);
            CustPhone.TabIndex = 0;
            // 
            // PrdPricePnl
            // 
            PrdPricePnl.BackColor = Color.FromArgb(255, 128, 0);
            PrdPricePnl.Controls.Add(CustEmail);
            PrdPricePnl.Location = new Point(213, 302);
            PrdPricePnl.Name = "PrdPricePnl";
            PrdPricePnl.Padding = new Padding(0, 0, 0, 5);
            PrdPricePnl.Size = new Size(250, 30);
            PrdPricePnl.TabIndex = 8;
            // 
            // CustEmail
            // 
            CustEmail.BorderStyle = BorderStyle.None;
            CustEmail.Dock = DockStyle.Fill;
            CustEmail.Location = new Point(0, 0);
            CustEmail.Multiline = true;
            CustEmail.Name = "CustEmail";
            CustEmail.PlaceholderText = "Email";
            CustEmail.Size = new Size(250, 25);
            CustEmail.TabIndex = 0;
            // 
            // PrdNamePnl
            // 
            PrdNamePnl.BackColor = Color.FromArgb(255, 128, 0);
            PrdNamePnl.Controls.Add(CustName);
            PrdNamePnl.Location = new Point(213, 164);
            PrdNamePnl.Name = "PrdNamePnl";
            PrdNamePnl.Padding = new Padding(0, 0, 0, 5);
            PrdNamePnl.Size = new Size(250, 30);
            PrdNamePnl.TabIndex = 7;
            // 
            // CustName
            // 
            CustName.BorderStyle = BorderStyle.None;
            CustName.Dock = DockStyle.Fill;
            CustName.Location = new Point(0, 0);
            CustName.Multiline = true;
            CustName.Name = "CustName";
            CustName.PlaceholderText = "Customer Name";
            CustName.Size = new Size(250, 25);
            CustName.TabIndex = 0;
            // 
            // CustGrid
            // 
            CustGrid.BackgroundColor = SystemColors.Control;
            CustGrid.CellBorderStyle = DataGridViewCellBorderStyle.None;
            CustGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustGrid.GridColor = SystemColors.Control;
            CustGrid.Location = new Point(561, 205);
            CustGrid.Name = "CustGrid";
            CustGrid.RowHeadersWidth = 51;
            CustGrid.RowTemplate.Height = 29;
            CustGrid.Size = new Size(686, 425);
            CustGrid.TabIndex = 10;
            CustGrid.CellContentClick += CustGrid_CellContentClick;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 128, 0);
            panel3.Controls.Add(gender);
            panel3.Location = new Point(213, 367);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(0, 0, 0, 5);
            panel3.Size = new Size(250, 30);
            panel3.TabIndex = 11;
            // 
            // gender
            // 
            gender.BorderStyle = BorderStyle.None;
            gender.Dock = DockStyle.Fill;
            gender.Location = new Point(0, 0);
            gender.Multiline = true;
            gender.Name = "gender";
            gender.PlaceholderText = "Gender";
            gender.Size = new Size(250, 25);
            gender.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(255, 192, 128);
            label3.Location = new Point(795, 140);
            label3.Name = "label3";
            label3.Size = new Size(279, 48);
            label3.TabIndex = 12;
            label3.Text = "Customers List";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(255, 192, 128);
            panel4.Controls.Add(OrdersLbl);
            panel4.Controls.Add(label4);
            panel4.ForeColor = Color.FromArgb(255, 192, 128);
            panel4.Location = new Point(250, 684);
            panel4.Name = "panel4";
            panel4.Size = new Size(250, 125);
            panel4.TabIndex = 13;
            // 
            // OrdersLbl
            // 
            OrdersLbl.AutoSize = true;
            OrdersLbl.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            OrdersLbl.ForeColor = Color.MistyRose;
            OrdersLbl.Location = new Point(75, 50);
            OrdersLbl.Name = "OrdersLbl";
            OrdersLbl.Size = new Size(98, 34);
            OrdersLbl.TabIndex = 2;
            OrdersLbl.Text = "Orders";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(143, 24);
            label4.TabIndex = 1;
            label4.Text = "Orders Count";
            // 
            // OrdersAmount
            // 
            OrdersAmount.BackColor = Color.DarkSalmon;
            OrdersAmount.Controls.Add(OrdersAmt);
            OrdersAmount.Controls.Add(label7);
            OrdersAmount.ForeColor = Color.FromArgb(255, 192, 128);
            OrdersAmount.Location = new Point(587, 684);
            OrdersAmount.Name = "OrdersAmount";
            OrdersAmount.Size = new Size(250, 125);
            OrdersAmount.TabIndex = 14;
            // 
            // OrdersAmt
            // 
            OrdersAmt.AutoSize = true;
            OrdersAmt.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            OrdersAmt.ForeColor = Color.MistyRose;
            OrdersAmt.Location = new Point(75, 50);
            OrdersAmt.Name = "OrdersAmt";
            OrdersAmt.Size = new Size(112, 34);
            OrdersAmt.TabIndex = 2;
            OrdersAmt.Text = "Amount";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(163, 24);
            label7.TabIndex = 1;
            label7.Text = "Orders Amount";
            // 
            // panel6
            // 
            panel6.BackColor = Color.RosyBrown;
            panel6.Controls.Add(DateLbl);
            panel6.Controls.Add(label9);
            panel6.ForeColor = Color.FromArgb(255, 192, 128);
            panel6.Location = new Point(918, 684);
            panel6.Name = "panel6";
            panel6.Size = new Size(221, 125);
            panel6.TabIndex = 15;
            // 
            // DateLbl
            // 
            DateLbl.AutoSize = true;
            DateLbl.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            DateLbl.ForeColor = Color.MistyRose;
            DateLbl.Location = new Point(68, 50);
            DateLbl.Name = "DateLbl";
            DateLbl.Size = new Size(73, 34);
            DateLbl.TabIndex = 2;
            DateLbl.Text = "Date";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(0, 0);
            label9.Name = "label9";
            label9.Size = new Size(168, 24);
            label9.TabIndex = 1;
            label9.Text = "Last Order Date";
            // 
            // ManageCustomers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1247, 821);
            Controls.Add(panel6);
            Controls.Add(OrdersAmount);
            Controls.Add(panel4);
            Controls.Add(label3);
            Controls.Add(panel3);
            Controls.Add(CustGrid);
            Controls.Add(QtyPnl);
            Controls.Add(PrdPricePnl);
            Controls.Add(PrdNamePnl);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageCustomers";
            Text = "ManageCustomers";
            Load += ManageCustomers_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            QtyPnl.ResumeLayout(false);
            QtyPnl.PerformLayout();
            PrdPricePnl.ResumeLayout(false);
            PrdPricePnl.PerformLayout();
            PrdNamePnl.ResumeLayout(false);
            PrdNamePnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CustGrid).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            OrdersAmount.ResumeLayout(false);
            OrdersAmount.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Button HBtn;
        private Button EditBtn;
        private Button DeleteBtn;
        private Panel QtyPnl;
        private TextBox CustPhone;
        private Panel PrdPricePnl;
        private TextBox CustEmail;
        private Panel PrdNamePnl;
        private TextBox CustName;
        private DataGridView CustGrid;
        private Panel panel3;
        private TextBox gender;
        private Label label3;
        private Panel panel4;
        private Label OrdersLbl;
        private Label label4;
        private Panel OrdersAmount;
        private Label OrdersAmt;
        private Label label7;
        private Panel panel6;
        private Label DateLbl;
        private Label label9;
    }
}