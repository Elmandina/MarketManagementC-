namespace marketManagement
{
    partial class ManageOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageOrders));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            HBtn = new Button();
            EditBtn = new Button();
            DeleteBtn = new Button();
            AddBtn = new Button();
            label3 = new Label();
            CustGrid = new DataGridView();
            QtyPnl = new Panel();
            CustName = new TextBox();
            PrdNamePnl = new Panel();
            OrderId = new TextBox();
            orderDate = new DateTimePicker();
            ProdGrid = new DataGridView();
            label4 = new Label();
            label5 = new Label();
            panel3 = new Panel();
            QtyTxt = new TextBox();
            label6 = new Label();
            addOrder = new Button();
            OrderGv = new DataGridView();
            Num = new DataGridViewTextBoxColumn();
            Product = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            UPrice = new DataGridViewTextBoxColumn();
            TotalPrice = new DataGridViewTextBoxColumn();
            label7 = new Label();
            shumTotale = new Label();
            InsertOrder = new Button();
            ViewOrder = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CustGrid).BeginInit();
            QtyPnl.SuspendLayout();
            PrdNamePnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProdGrid).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OrderGv).BeginInit();
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
            panel1.Size = new Size(1309, 125);
            panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1274, 0);
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
            label2.Location = new Point(357, 9);
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
            label1.Location = new Point(492, 77);
            label1.Name = "label1";
            label1.Size = new Size(288, 48);
            label1.TabIndex = 0;
            label1.Text = "Manage Orders";
            label1.Click += label1_Click;
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
            panel2.Size = new Size(198, 601);
            panel2.TabIndex = 3;
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
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(255, 192, 128);
            label3.Location = new Point(307, 161);
            label3.Name = "label3";
            label3.Size = new Size(279, 48);
            label3.TabIndex = 14;
            label3.Text = "Customers List";
            // 
            // CustGrid
            // 
            CustGrid.BackgroundColor = SystemColors.Control;
            CustGrid.CellBorderStyle = DataGridViewCellBorderStyle.None;
            CustGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustGrid.GridColor = SystemColors.Control;
            CustGrid.Location = new Point(198, 212);
            CustGrid.Name = "CustGrid";
            CustGrid.RowHeadersWidth = 51;
            CustGrid.RowTemplate.Height = 29;
            CustGrid.Size = new Size(550, 201);
            CustGrid.TabIndex = 13;
            CustGrid.CellContentClick += CustGrid_CellContentClick;
            // 
            // QtyPnl
            // 
            QtyPnl.BackColor = Color.FromArgb(255, 128, 0);
            QtyPnl.Controls.Add(CustName);
            QtyPnl.Location = new Point(290, 527);
            QtyPnl.Name = "QtyPnl";
            QtyPnl.Padding = new Padding(0, 0, 0, 5);
            QtyPnl.Size = new Size(250, 30);
            QtyPnl.TabIndex = 16;
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
            // PrdNamePnl
            // 
            PrdNamePnl.BackColor = Color.FromArgb(255, 128, 0);
            PrdNamePnl.Controls.Add(OrderId);
            PrdNamePnl.Location = new Point(290, 457);
            PrdNamePnl.Name = "PrdNamePnl";
            PrdNamePnl.Padding = new Padding(0, 0, 0, 5);
            PrdNamePnl.Size = new Size(250, 30);
            PrdNamePnl.TabIndex = 15;
            // 
            // OrderId
            // 
            OrderId.BorderStyle = BorderStyle.None;
            OrderId.Dock = DockStyle.Fill;
            OrderId.Location = new Point(0, 0);
            OrderId.Multiline = true;
            OrderId.Name = "OrderId";
            OrderId.PlaceholderText = "Order Id";
            OrderId.Size = new Size(250, 25);
            OrderId.TabIndex = 0;
            // 
            // orderDate
            // 
            orderDate.CalendarForeColor = Color.FromArgb(255, 192, 128);
            orderDate.CalendarMonthBackground = Color.White;
            orderDate.CustomFormat = "";
            orderDate.Location = new Point(363, 576);
            orderDate.Name = "orderDate";
            orderDate.Size = new Size(177, 27);
            orderDate.TabIndex = 17;
            orderDate.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // ProdGrid
            // 
            ProdGrid.BackgroundColor = SystemColors.Control;
            ProdGrid.CellBorderStyle = DataGridViewCellBorderStyle.None;
            ProdGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProdGrid.GridColor = SystemColors.Control;
            ProdGrid.Location = new Point(785, 212);
            ProdGrid.Name = "ProdGrid";
            ProdGrid.RowHeadersWidth = 51;
            ProdGrid.RowTemplate.Height = 29;
            ProdGrid.Size = new Size(511, 201);
            ProdGrid.TabIndex = 18;
            ProdGrid.CellContentClick += ProdGrid_CellContentClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(255, 192, 128);
            label4.Location = new Point(895, 161);
            label4.Name = "label4";
            label4.Size = new Size(244, 48);
            label4.TabIndex = 19;
            label4.Text = "Products List";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(255, 192, 128);
            label5.Location = new Point(221, 577);
            label5.Name = "label5";
            label5.Size = new Size(109, 24);
            label5.TabIndex = 20;
            label5.Text = "Order Date";
            label5.Click += label5_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 128, 0);
            panel3.Controls.Add(QtyTxt);
            panel3.Location = new Point(903, 429);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(0, 0, 0, 5);
            panel3.Size = new Size(250, 30);
            panel3.TabIndex = 21;
            // 
            // QtyTxt
            // 
            QtyTxt.BackColor = SystemColors.Control;
            QtyTxt.BorderStyle = BorderStyle.None;
            QtyTxt.Dock = DockStyle.Fill;
            QtyTxt.Location = new Point(0, 0);
            QtyTxt.Multiline = true;
            QtyTxt.Name = "QtyTxt";
            QtyTxt.Size = new Size(250, 25);
            QtyTxt.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(255, 192, 128);
            label6.Location = new Point(811, 435);
            label6.Name = "label6";
            label6.Size = new Size(86, 24);
            label6.TabIndex = 22;
            label6.Text = "Quantity";
            // 
            // addOrder
            // 
            addOrder.BackColor = Color.MistyRose;
            addOrder.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            addOrder.ForeColor = Color.FromArgb(255, 192, 128);
            addOrder.Location = new Point(1169, 422);
            addOrder.Name = "addOrder";
            addOrder.Size = new Size(97, 37);
            addOrder.TabIndex = 23;
            addOrder.Text = "Add Order";
            addOrder.UseVisualStyleBackColor = false;
            addOrder.Click += button1_Click;
            // 
            // OrderGv
            // 
            OrderGv.BackgroundColor = SystemColors.Control;
            OrderGv.CellBorderStyle = DataGridViewCellBorderStyle.None;
            OrderGv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrderGv.Columns.AddRange(new DataGridViewColumn[] { Num, Product, Quantity, UPrice, TotalPrice });
            OrderGv.GridColor = SystemColors.Control;
            OrderGv.Location = new Point(617, 482);
            OrderGv.Name = "OrderGv";
            OrderGv.RowHeadersWidth = 51;
            OrderGv.RowTemplate.Height = 29;
            OrderGv.Size = new Size(679, 201);
            OrderGv.TabIndex = 24;
            // 
            // Num
            // 
            Num.HeaderText = "Num";
            Num.MinimumWidth = 6;
            Num.Name = "Num";
            Num.Width = 125;
            // 
            // Product
            // 
            Product.HeaderText = "Product";
            Product.MinimumWidth = 6;
            Product.Name = "Product";
            Product.Width = 125;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            Quantity.Width = 125;
            // 
            // UPrice
            // 
            UPrice.HeaderText = "UPrice";
            UPrice.MinimumWidth = 6;
            UPrice.Name = "UPrice";
            UPrice.Width = 125;
            // 
            // TotalPrice
            // 
            TotalPrice.HeaderText = "TotalPrice";
            TotalPrice.MinimumWidth = 6;
            TotalPrice.Name = "TotalPrice";
            TotalPrice.Width = 125;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(255, 192, 128);
            label7.Location = new Point(710, 689);
            label7.Name = "label7";
            label7.Size = new Size(148, 28);
            label7.TabIndex = 25;
            label7.Text = "Total Amount";
            // 
            // shumTotale
            // 
            shumTotale.AutoSize = true;
            shumTotale.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            shumTotale.ForeColor = Color.FromArgb(255, 192, 128);
            shumTotale.Location = new Point(864, 689);
            shumTotale.Name = "shumTotale";
            shumTotale.Size = new Size(39, 28);
            shumTotale.TabIndex = 26;
            shumTotale.Text = "RS";
            // 
            // InsertOrder
            // 
            InsertOrder.BackColor = Color.MistyRose;
            InsertOrder.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            InsertOrder.ForeColor = Color.FromArgb(255, 192, 128);
            InsertOrder.Location = new Point(271, 646);
            InsertOrder.Name = "InsertOrder";
            InsertOrder.Size = new Size(127, 37);
            InsertOrder.TabIndex = 27;
            InsertOrder.Text = "Insert Order";
            InsertOrder.UseVisualStyleBackColor = false;
            InsertOrder.Click += InsertOrder_Click;
            // 
            // ViewOrder
            // 
            ViewOrder.BackColor = Color.MistyRose;
            ViewOrder.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ViewOrder.ForeColor = Color.FromArgb(255, 192, 128);
            ViewOrder.Location = new Point(443, 646);
            ViewOrder.Name = "ViewOrder";
            ViewOrder.Size = new Size(124, 37);
            ViewOrder.TabIndex = 28;
            ViewOrder.Text = "View Order";
            ViewOrder.UseVisualStyleBackColor = false;
            ViewOrder.Click += ViewOrder_Click;
            // 
            // ManageOrders
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1309, 726);
            Controls.Add(ViewOrder);
            Controls.Add(InsertOrder);
            Controls.Add(shumTotale);
            Controls.Add(label7);
            Controls.Add(OrderGv);
            Controls.Add(addOrder);
            Controls.Add(label6);
            Controls.Add(panel3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(ProdGrid);
            Controls.Add(orderDate);
            Controls.Add(QtyPnl);
            Controls.Add(PrdNamePnl);
            Controls.Add(label3);
            Controls.Add(CustGrid);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageOrders";
            Text = "ManageOrders";
            Load += ManageOrders_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)CustGrid).EndInit();
            QtyPnl.ResumeLayout(false);
            QtyPnl.PerformLayout();
            PrdNamePnl.ResumeLayout(false);
            PrdNamePnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ProdGrid).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)OrderGv).EndInit();
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
        private Button AddBtn;
        private Label label3;
        private DataGridView CustGrid;
        private Panel QtyPnl;
        private TextBox CustName;
        private Panel PrdNamePnl;
        private TextBox OrderId;
        private DateTimePicker orderDate;
        private DataGridView ProdGrid;
        private Label label4;
        private Label label5;
        private Panel panel3;
        private TextBox QtyTxt;
        private Label label6;
        private Button addOrder;
        private DataGridView OrderGv;
        private DataGridViewTextBoxColumn Num;
        private DataGridViewTextBoxColumn Product;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn UPrice;
        private DataGridViewTextBoxColumn TotalPrice;
        private Label label7;
        private Label shumTotale;
        private Button InsertOrder;
        private Button ViewOrder;
    }
}