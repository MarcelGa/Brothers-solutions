namespace Kasa
{
	partial class FormMain
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dataGridViewOrder = new System.Windows.Forms.DataGridView();
			this.ColumnTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnRemove = new System.Windows.Forms.DataGridViewButtonColumn();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.textBoxPrice = new System.Windows.Forms.TextBox();
			this.tabControlMain = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.itemsCatalog = new Kasa.ItemsCatalog();
			this.blinkButtonSaveOrder = new Kasa.BlinkButton();
			this.calculatorMain = new Kasa.Calculator();
			this.clockToolStripStatusLabel1 = new WindowsFormsControlLib.ClockToolStripStatusLabel();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			this.tabControlMain.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridViewOrder
			// 
			this.dataGridViewOrder.AllowUserToAddRows = false;
			this.dataGridViewOrder.AllowUserToDeleteRows = false;
			this.dataGridViewOrder.AllowUserToResizeRows = false;
			this.dataGridViewOrder.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
			this.dataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewOrder.ColumnHeadersVisible = false;
			this.dataGridViewOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnTitle,
            this.ColumnPrice,
            this.ColumnRemove});
			this.dataGridViewOrder.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewOrder.Location = new System.Drawing.Point(0, 0);
			this.dataGridViewOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dataGridViewOrder.Name = "dataGridViewOrder";
			this.dataGridViewOrder.RowHeadersVisible = false;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.dataGridViewOrder.RowsDefaultCellStyle = dataGridViewCellStyle6;
			this.dataGridViewOrder.RowTemplate.Height = 50;
			this.dataGridViewOrder.Size = new System.Drawing.Size(233, 332);
			this.dataGridViewOrder.TabIndex = 1;
			this.dataGridViewOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrder_CellClick);
			// 
			// ColumnTitle
			// 
			this.ColumnTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.ColumnTitle.HeaderText = "Title";
			this.ColumnTitle.Name = "ColumnTitle";
			this.ColumnTitle.ReadOnly = true;
			// 
			// ColumnPrice
			// 
			this.ColumnPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.ColumnPrice.HeaderText = "Price";
			this.ColumnPrice.Name = "ColumnPrice";
			this.ColumnPrice.ReadOnly = true;
			this.ColumnPrice.Width = 5;
			// 
			// ColumnRemove
			// 
			this.ColumnRemove.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.Red;
			this.ColumnRemove.DefaultCellStyle = dataGridViewCellStyle5;
			this.ColumnRemove.HeaderText = "Remove";
			this.ColumnRemove.Name = "ColumnRemove";
			this.ColumnRemove.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.ColumnRemove.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.ColumnRemove.Width = 50;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.splitContainer1.Location = new System.Drawing.Point(3, 2);
			this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.itemsCatalog);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
			this.splitContainer1.Size = new System.Drawing.Size(880, 511);
			this.splitContainer1.SplitterDistance = 227;
			this.splitContainer1.TabIndex = 3;
			// 
			// splitContainer2
			// 
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.splitContainer2.Location = new System.Drawing.Point(0, 0);
			this.splitContainer2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.splitContainer2.Name = "splitContainer2";
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.dataGridViewOrder);
			this.splitContainer2.Panel1.Controls.Add(this.textBoxPrice);
			this.splitContainer2.Panel1.Controls.Add(this.blinkButtonSaveOrder);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.BackColor = System.Drawing.Color.Black;
			this.splitContainer2.Panel2.Controls.Add(this.calculatorMain);
			this.splitContainer2.Size = new System.Drawing.Size(649, 511);
			this.splitContainer2.SplitterDistance = 233;
			this.splitContainer2.TabIndex = 4;
			// 
			// textBoxPrice
			// 
			this.textBoxPrice.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.textBoxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.textBoxPrice.Location = new System.Drawing.Point(0, 332);
			this.textBoxPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBoxPrice.Name = "textBoxPrice";
			this.textBoxPrice.ReadOnly = true;
			this.textBoxPrice.Size = new System.Drawing.Size(233, 83);
			this.textBoxPrice.TabIndex = 3;
			this.textBoxPrice.Text = "0";
			this.textBoxPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// tabControlMain
			// 
			this.tabControlMain.Alignment = System.Windows.Forms.TabAlignment.Bottom;
			this.tabControlMain.Controls.Add(this.tabPage1);
			this.tabControlMain.Controls.Add(this.tabPage2);
			this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControlMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.tabControlMain.Location = new System.Drawing.Point(0, 0);
			this.tabControlMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tabControlMain.Name = "tabControlMain";
			this.tabControlMain.SelectedIndex = 0;
			this.tabControlMain.Size = new System.Drawing.Size(894, 553);
			this.tabControlMain.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.splitContainer1);
			this.tabPage1.Location = new System.Drawing.Point(4, 4);
			this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tabPage1.Size = new System.Drawing.Size(886, 515);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Položky";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.BackColor = System.Drawing.Color.Black;
			this.tabPage2.Location = new System.Drawing.Point(4, 4);
			this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tabPage2.Size = new System.Drawing.Size(886, 515);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Uzávierka";
			// 
			// statusStrip1
			// 
			this.statusStrip1.AutoSize = false;
			this.statusStrip1.BackColor = System.Drawing.Color.Black;
			this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.clockToolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 553);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(894, 25);
			this.statusStrip1.SizingGrip = false;
			this.statusStrip1.TabIndex = 4;
			this.statusStrip1.Text = "statusStripMain";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(785, 20);
			this.toolStripStatusLabel1.Spring = true;
			// 
			// itemsCatalog
			// 
			this.itemsCatalog.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.itemsCatalog.ColumnCount = 2;
			this.itemsCatalog.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.itemsCatalog.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.itemsCatalog.Dock = System.Windows.Forms.DockStyle.Fill;
			this.itemsCatalog.Location = new System.Drawing.Point(0, 0);
			this.itemsCatalog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.itemsCatalog.Name = "itemsCatalog";
			this.itemsCatalog.RowCount = 2;
			this.itemsCatalog.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.itemsCatalog.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.itemsCatalog.Size = new System.Drawing.Size(227, 511);
			this.itemsCatalog.TabIndex = 2;
			// 
			// blinkButtonSaveOrder
			// 
			this.blinkButtonSaveOrder.BackColor = System.Drawing.Color.Lime;
			this.blinkButtonSaveOrder.BlinkColor = System.Drawing.Color.Blue;
			this.blinkButtonSaveOrder.BlinkInterval = 100D;
			this.blinkButtonSaveOrder.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.blinkButtonSaveOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.blinkButtonSaveOrder.Location = new System.Drawing.Point(0, 415);
			this.blinkButtonSaveOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.blinkButtonSaveOrder.Name = "blinkButtonSaveOrder";
			this.blinkButtonSaveOrder.Size = new System.Drawing.Size(233, 96);
			this.blinkButtonSaveOrder.TabIndex = 2;
			this.blinkButtonSaveOrder.Text = "Započítaj";
			this.blinkButtonSaveOrder.UseVisualStyleBackColor = false;
			this.blinkButtonSaveOrder.Click += new System.EventHandler(this.blinkButtonSaveOrder_Click);
			// 
			// calculatorMain
			// 
			this.calculatorMain.ColumnCount = 3;
			this.calculatorMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
			this.calculatorMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
			this.calculatorMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
			this.calculatorMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
			this.calculatorMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
			this.calculatorMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
			this.calculatorMain.ComparedValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.calculatorMain.CustomDigitsColor = System.Drawing.Color.LightSkyBlue;
			this.calculatorMain.DigitsColor = System.Drawing.Color.PowderBlue;
			this.calculatorMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.calculatorMain.Location = new System.Drawing.Point(0, 0);
			this.calculatorMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.calculatorMain.Name = "calculatorMain";
			this.calculatorMain.RowCount = 6;
			this.calculatorMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.calculatorMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
			this.calculatorMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
			this.calculatorMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
			this.calculatorMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
			this.calculatorMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
			this.calculatorMain.Size = new System.Drawing.Size(412, 511);
			this.calculatorMain.TabIndex = 0;
			// 
			// clockToolStripStatusLabel1
			// 
			this.clockToolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.clockToolStripStatusLabel1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
			this.clockToolStripStatusLabel1.Name = "clockToolStripStatusLabel1";
			this.clockToolStripStatusLabel1.ShowSeconds = true;
			this.clockToolStripStatusLabel1.Size = new System.Drawing.Size(55, 20);
			this.clockToolStripStatusLabel1.Text = "15:01";
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(894, 578);
			this.Controls.Add(this.tabControlMain);
			this.Controls.Add(this.statusStrip1);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.MinimumSize = new System.Drawing.Size(912, 623);
			this.Name = "FormMain";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Kasa";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).EndInit();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel1.PerformLayout();
			this.splitContainer2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			this.tabControlMain.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.DataGridView dataGridViewOrder;
		private ItemsCatalog itemsCatalog;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.TextBox textBoxPrice;
		private BlinkButton blinkButtonSaveOrder;
		private System.Windows.Forms.TabControl tabControlMain;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private Calculator calculatorMain;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTitle;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrice;
		private System.Windows.Forms.DataGridViewButtonColumn ColumnRemove;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private WindowsFormsControlLib.ClockToolStripStatusLabel clockToolStripStatusLabel1;
	}
}

