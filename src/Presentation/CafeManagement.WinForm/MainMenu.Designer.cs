namespace CafeManagement.WinForm
{
    partial class MainMenu
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuToolStripMenuItem = new ToolStripMenuItem();
            menuToolStripMenuItem1 = new ToolStripMenuItem();
            menüToolStripMenuItem = new ToolStripMenuItem();
            masalarToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            tablesPanel = new Panel();
            orderControlPanel = new Panel();
            btnShowTotalPrice = new Button();
            lblTotalPrice = new Label();
            btnRefresh = new Button();
            lblTableId = new Label();
            lblOpenDateValue = new Label();
            lblLastOrderDateValue = new Label();
            lblOrders = new Label();
            lblLastOrderDate = new Label();
            lblOpenDate = new Label();
            orderListBox = new ListBox();
            btnAddOrder = new Button();
            btnHesapAl = new Button();
            orderControlPanel.SuspendLayout();
            SuspendLayout();
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(32, 19);
            // 
            // menuToolStripMenuItem1
            // 
            menuToolStripMenuItem1.Name = "menuToolStripMenuItem1";
            menuToolStripMenuItem1.Size = new Size(32, 19);
            // 
            // menüToolStripMenuItem
            // 
            menüToolStripMenuItem.Name = "menüToolStripMenuItem";
            menüToolStripMenuItem.Size = new Size(32, 19);
            // 
            // masalarToolStripMenuItem
            // 
            masalarToolStripMenuItem.Name = "masalarToolStripMenuItem";
            masalarToolStripMenuItem.Size = new Size(32, 19);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(507, 9);
            label1.Name = "label1";
            label1.Size = new Size(218, 48);
            label1.TabIndex = 0;
            label1.Text = "Cafe De Casa";
            // 
            // tablesPanel
            // 
            tablesPanel.Location = new Point(30, 78);
            tablesPanel.Name = "tablesPanel";
            tablesPanel.Size = new Size(849, 702);
            tablesPanel.TabIndex = 1;
            // 
            // orderControlPanel
            // 
            orderControlPanel.BorderStyle = BorderStyle.FixedSingle;
            orderControlPanel.Controls.Add(btnShowTotalPrice);
            orderControlPanel.Controls.Add(lblTotalPrice);
            orderControlPanel.Controls.Add(btnRefresh);
            orderControlPanel.Controls.Add(lblTableId);
            orderControlPanel.Controls.Add(lblOpenDateValue);
            orderControlPanel.Controls.Add(lblLastOrderDateValue);
            orderControlPanel.Controls.Add(lblOrders);
            orderControlPanel.Controls.Add(lblLastOrderDate);
            orderControlPanel.Controls.Add(lblOpenDate);
            orderControlPanel.Controls.Add(orderListBox);
            orderControlPanel.Controls.Add(btnAddOrder);
            orderControlPanel.Controls.Add(btnHesapAl);
            orderControlPanel.Location = new Point(902, 74);
            orderControlPanel.Name = "orderControlPanel";
            orderControlPanel.Size = new Size(465, 706);
            orderControlPanel.TabIndex = 2;
            // 
            // btnShowTotalPrice
            // 
            btnShowTotalPrice.Enabled = false;
            btnShowTotalPrice.Location = new Point(164, 545);
            btnShowTotalPrice.Name = "btnShowTotalPrice";
            btnShowTotalPrice.Size = new Size(128, 51);
            btnShowTotalPrice.TabIndex = 11;
            btnShowTotalPrice.Text = "0";
            btnShowTotalPrice.UseVisualStyleBackColor = true;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalPrice.Location = new Point(16, 545);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(120, 25);
            lblTotalPrice.TabIndex = 10;
            lblTotalPrice.Text = "Toplam Tutar";
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(296, 87);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(128, 51);
            btnRefresh.TabIndex = 9;
            btnRefresh.Text = "Yenile";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // lblTableId
            // 
            lblTableId.AutoSize = true;
            lblTableId.Cursor = Cursors.No;
            lblTableId.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            lblTableId.Location = new Point(136, 22);
            lblTableId.Name = "lblTableId";
            lblTableId.Size = new Size(135, 31);
            lblTableId.TabIndex = 8;
            lblTableId.Text = "Masa No : -";
            // 
            // lblOpenDateValue
            // 
            lblOpenDateValue.AutoSize = true;
            lblOpenDateValue.Location = new Point(203, 158);
            lblOpenDateValue.Name = "lblOpenDateValue";
            lblOpenDateValue.Size = new Size(15, 20);
            lblOpenDateValue.TabIndex = 7;
            lblOpenDateValue.Text = "-";
            // 
            // lblLastOrderDateValue
            // 
            lblLastOrderDateValue.AutoSize = true;
            lblLastOrderDateValue.Location = new Point(203, 192);
            lblLastOrderDateValue.Name = "lblLastOrderDateValue";
            lblLastOrderDateValue.Size = new Size(15, 20);
            lblLastOrderDateValue.TabIndex = 6;
            lblLastOrderDateValue.Text = "-";
            // 
            // lblOrders
            // 
            lblOrders.AutoSize = true;
            lblOrders.Cursor = Cursors.No;
            lblOrders.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            lblOrders.Location = new Point(15, 264);
            lblOrders.Name = "lblOrders";
            lblOrders.Size = new Size(114, 31);
            lblOrders.TabIndex = 5;
            lblOrders.Text = "Siparişler";
            // 
            // lblLastOrderDate
            // 
            lblLastOrderDate.AutoSize = true;
            lblLastOrderDate.Location = new Point(16, 192);
            lblLastOrderDate.Name = "lblLastOrderDate";
            lblLastOrderDate.Size = new Size(126, 20);
            lblLastOrderDate.TabIndex = 4;
            lblLastOrderDate.Text = "Son Sipariş Saati :";
            // 
            // lblOpenDate
            // 
            lblOpenDate.AutoSize = true;
            lblOpenDate.Location = new Point(15, 158);
            lblOpenDate.Name = "lblOpenDate";
            lblOpenDate.Size = new Size(127, 20);
            lblOpenDate.TabIndex = 3;
            lblOpenDate.Text = "Masa Açılış Saati :";
            // 
            // orderListBox
            // 
            orderListBox.FormattingEnabled = true;
            orderListBox.ItemHeight = 20;
            orderListBox.Location = new Point(14, 307);
            orderListBox.Name = "orderListBox";
            orderListBox.Size = new Size(437, 204);
            orderListBox.TabIndex = 2;
            // 
            // btnAddOrder
            // 
            btnAddOrder.Location = new Point(15, 87);
            btnAddOrder.Name = "btnAddOrder";
            btnAddOrder.Size = new Size(128, 51);
            btnAddOrder.TabIndex = 1;
            btnAddOrder.Text = "Sipariş Ekle";
            btnAddOrder.UseVisualStyleBackColor = true;
            btnAddOrder.Click += btnAddOrder_Click;
            // 
            // btnHesapAl
            // 
            btnHesapAl.Location = new Point(323, 545);
            btnHesapAl.Name = "btnHesapAl";
            btnHesapAl.Size = new Size(128, 51);
            btnHesapAl.TabIndex = 0;
            btnHesapAl.Text = "Hesap Al";
            btnHesapAl.UseVisualStyleBackColor = true;
            btnHesapAl.Click += btnHesapAl_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1388, 817);
            Controls.Add(orderControlPanel);
            Controls.Add(tablesPanel);
            Controls.Add(label1);
            Name = "MainMenu";
            Text = "Ana Menü";
            WindowState = FormWindowState.Maximized;
            orderControlPanel.ResumeLayout(false);
            orderControlPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem menuToolStripMenuItem1;
        private ToolStripMenuItem menüToolStripMenuItem;
        private ToolStripMenuItem masalarToolStripMenuItem;
        private Label label1;
        private Panel tablesPanel;
        private Panel orderControlPanel;
        private Button btnAddOrder;
        private Button btnHesapAl;
        private Label lblOrders;
        private Label lblLastOrderDate;
        private Label lblOpenDate;
        private ListBox orderListBox;
        private Label lblOpenDateValue;
        private Label lblLastOrderDateValue;
        private Label lblTableId;
        private Button btnRefresh;
        private Button btnShowTotalPrice;
        private Label lblTotalPrice;
    }
}