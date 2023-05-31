namespace marketManagement
{
    partial class ViewOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewOrders));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            ProdGrid = new DataGridView();
            bckbtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProdGrid).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 192);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(862, 125);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(827, 0);
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
            label2.Location = new Point(108, 9);
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
            label1.Location = new Point(291, 77);
            label1.Name = "label1";
            label1.Size = new Size(234, 48);
            label1.TabIndex = 0;
            label1.Text = "View Orders";
            // 
            // ProdGrid
            // 
            ProdGrid.BackgroundColor = SystemColors.Control;
            ProdGrid.CellBorderStyle = DataGridViewCellBorderStyle.None;
            ProdGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProdGrid.GridColor = SystemColors.Control;
            ProdGrid.Location = new Point(138, 196);
            ProdGrid.Name = "ProdGrid";
            ProdGrid.RowHeadersWidth = 51;
            ProdGrid.RowTemplate.Height = 29;
            ProdGrid.Size = new Size(542, 412);
            ProdGrid.TabIndex = 19;
            ProdGrid.CellContentClick += ProdGrid_CellContentClick;
            // 
            // bckbtn
            // 
            bckbtn.BackColor = Color.FromArgb(255, 192, 192);
            bckbtn.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            bckbtn.ForeColor = Color.FromArgb(255, 128, 128);
            bckbtn.Location = new Point(318, 632);
            bckbtn.Name = "bckbtn";
            bckbtn.Size = new Size(121, 38);
            bckbtn.TabIndex = 20;
            bckbtn.Text = "Back";
            bckbtn.UseVisualStyleBackColor = false;
            bckbtn.Click += bckbtn_Click;
            // 
            // ViewOrders
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 682);
            Controls.Add(bckbtn);
            Controls.Add(ProdGrid);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewOrders";
            Text = "ViewOrders";
            Load += ViewOrders_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProdGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private DataGridView ProdGrid;
        private Button bckbtn;
    }
}