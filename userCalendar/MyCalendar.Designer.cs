namespace WinFormsApp1
{
    partial class MyCalendar
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyCalendar));
            this.yearLabel = new System.Windows.Forms.Label();
            this.chooseYearBtn = new System.Windows.Forms.Button();
            this.yearPanel = new System.Windows.Forms.Panel();
            this.Mo = new System.Windows.Forms.Label();
            this.Tu = new System.Windows.Forms.Label();
            this.We = new System.Windows.Forms.Label();
            this.Th = new System.Windows.Forms.Label();
            this.Fr = new System.Windows.Forms.Label();
            this.Sa = new System.Windows.Forms.Label();
            this.Su = new System.Windows.Forms.Label();
            this.basePanel = new System.Windows.Forms.Panel();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.daysPanel = new System.Windows.Forms.TableLayoutPanel();
            this.weekPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.monthPanel = new System.Windows.Forms.TableLayoutPanel();
            this.leftBtn = new System.Windows.Forms.Button();
            this.monthLabel = new System.Windows.Forms.Label();
            this.rightBtn = new System.Windows.Forms.Button();
            this.yearPanel.SuspendLayout();
            this.basePanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.weekPanel.SuspendLayout();
            this.monthPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.yearLabel.ForeColor = System.Drawing.Color.White;
            this.yearLabel.Location = new System.Drawing.Point(120, 13);
            this.yearLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(60, 25);
            this.yearLabel.TabIndex = 0;
            this.yearLabel.Text = "2022";
            // 
            // chooseYearBtn
            // 
            this.chooseYearBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chooseYearBtn.BackColor = System.Drawing.Color.Transparent;
            this.chooseYearBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.chooseYearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chooseYearBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(191)))), ((int)(((byte)(212)))));
            this.chooseYearBtn.FlatAppearance.BorderSize = 0;
            this.chooseYearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.chooseYearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.chooseYearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chooseYearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chooseYearBtn.ForeColor = System.Drawing.Color.White;
            this.chooseYearBtn.Location = new System.Drawing.Point(175, 11);
            this.chooseYearBtn.Margin = new System.Windows.Forms.Padding(0);
            this.chooseYearBtn.Name = "chooseYearBtn";
            this.chooseYearBtn.Size = new System.Drawing.Size(33, 30);
            this.chooseYearBtn.TabIndex = 0;
            this.chooseYearBtn.Text = "▼";
            this.chooseYearBtn.UseVisualStyleBackColor = false;
            // 
            // yearPanel
            // 
            this.yearPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(191)))), ((int)(((byte)(212)))));
            this.yearPanel.Controls.Add(this.yearLabel);
            this.yearPanel.Controls.Add(this.chooseYearBtn);
            this.yearPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.yearPanel.Location = new System.Drawing.Point(0, 0);
            this.yearPanel.Margin = new System.Windows.Forms.Padding(0);
            this.yearPanel.Name = "yearPanel";
            this.yearPanel.Size = new System.Drawing.Size(324, 51);
            this.yearPanel.TabIndex = 0;
            // 
            // Mo
            // 
            this.Mo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Mo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.Mo.Location = new System.Drawing.Point(16, 0);
            this.Mo.Margin = new System.Windows.Forms.Padding(0);
            this.Mo.Name = "Mo";
            this.Mo.Size = new System.Drawing.Size(31, 30);
            this.Mo.TabIndex = 0;
            this.Mo.Text = "Mo";
            this.Mo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Tu
            // 
            this.Tu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Tu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.Tu.Location = new System.Drawing.Point(109, 0);
            this.Tu.Margin = new System.Windows.Forms.Padding(0);
            this.Tu.Name = "Tu";
            this.Tu.Size = new System.Drawing.Size(31, 30);
            this.Tu.TabIndex = 0;
            this.Tu.Text = "Tu";
            this.Tu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // We
            // 
            this.We.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.We.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.We.Location = new System.Drawing.Point(78, 0);
            this.We.Margin = new System.Windows.Forms.Padding(0);
            this.We.Name = "We";
            this.We.Size = new System.Drawing.Size(31, 30);
            this.We.TabIndex = 0;
            this.We.Text = "We";
            this.We.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Th
            // 
            this.Th.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Th.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.Th.Location = new System.Drawing.Point(47, 0);
            this.Th.Margin = new System.Windows.Forms.Padding(0);
            this.Th.Name = "Th";
            this.Th.Size = new System.Drawing.Size(31, 30);
            this.Th.TabIndex = 0;
            this.Th.Text = "Th";
            this.Th.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Fr
            // 
            this.Fr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Fr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.Fr.Location = new System.Drawing.Point(140, 0);
            this.Fr.Margin = new System.Windows.Forms.Padding(0);
            this.Fr.Name = "Fr";
            this.Fr.Size = new System.Drawing.Size(31, 30);
            this.Fr.TabIndex = 0;
            this.Fr.Text = "Fr";
            this.Fr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Sa
            // 
            this.Sa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Sa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.Sa.Location = new System.Drawing.Point(171, 0);
            this.Sa.Margin = new System.Windows.Forms.Padding(0);
            this.Sa.Name = "Sa";
            this.Sa.Size = new System.Drawing.Size(31, 30);
            this.Sa.TabIndex = 0;
            this.Sa.Text = "Sa";
            this.Sa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Su
            // 
            this.Su.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Su.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Su.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.Su.Location = new System.Drawing.Point(202, 0);
            this.Su.Margin = new System.Windows.Forms.Padding(0);
            this.Su.Name = "Su";
            this.Su.Size = new System.Drawing.Size(28, 30);
            this.Su.TabIndex = 0;
            this.Su.Text = "Su";
            this.Su.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // basePanel
            // 
            this.basePanel.BackColor = System.Drawing.Color.Transparent;
            this.basePanel.Controls.Add(this.bottomPanel);
            this.basePanel.Controls.Add(this.monthPanel);
            this.basePanel.Controls.Add(this.yearPanel);
            this.basePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.basePanel.Location = new System.Drawing.Point(0, 0);
            this.basePanel.Margin = new System.Windows.Forms.Padding(0);
            this.basePanel.Name = "basePanel";
            this.basePanel.Size = new System.Drawing.Size(324, 403);
            this.basePanel.TabIndex = 2;
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.daysPanel);
            this.bottomPanel.Controls.Add(this.weekPanel);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomPanel.Location = new System.Drawing.Point(0, 102);
            this.bottomPanel.Margin = new System.Windows.Forms.Padding(0);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Padding = new System.Windows.Forms.Padding(18, 0, 18, 18);
            this.bottomPanel.Size = new System.Drawing.Size(324, 301);
            this.bottomPanel.TabIndex = 2;
            // 
            // daysPanel
            // 
            this.daysPanel.ColumnCount = 7;
            this.daysPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.daysPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.daysPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.daysPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.daysPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.daysPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.daysPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.daysPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.daysPanel.Location = new System.Drawing.Point(18, 41);
            this.daysPanel.Margin = new System.Windows.Forms.Padding(4);
            this.daysPanel.Name = "daysPanel";
            this.daysPanel.RowCount = 6;
            this.daysPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.daysPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.daysPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.daysPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.daysPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.daysPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.daysPanel.Size = new System.Drawing.Size(288, 242);
            this.daysPanel.TabIndex = 1;
            // 
            // weekPanel
            // 
            this.weekPanel.ColumnCount = 7;
            this.weekPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.weekPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.weekPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.weekPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.weekPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.weekPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.weekPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.weekPanel.Controls.Add(this.label1, 0, 0);
            this.weekPanel.Controls.Add(this.label2, 1, 0);
            this.weekPanel.Controls.Add(this.label3, 2, 0);
            this.weekPanel.Controls.Add(this.label4, 3, 0);
            this.weekPanel.Controls.Add(this.label5, 4, 0);
            this.weekPanel.Controls.Add(this.label6, 5, 0);
            this.weekPanel.Controls.Add(this.label7, 6, 0);
            this.weekPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.weekPanel.Location = new System.Drawing.Point(18, 0);
            this.weekPanel.Margin = new System.Windows.Forms.Padding(0);
            this.weekPanel.Name = "weekPanel";
            this.weekPanel.RowCount = 1;
            this.weekPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.weekPanel.Size = new System.Drawing.Size(288, 41);
            this.weekPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.label2.Location = new System.Drawing.Point(41, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tu";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.label3.Location = new System.Drawing.Point(82, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 41);
            this.label3.TabIndex = 1;
            this.label3.Text = "We";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.label4.Location = new System.Drawing.Point(123, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 41);
            this.label4.TabIndex = 1;
            this.label4.Text = "Th";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.label5.Location = new System.Drawing.Point(164, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 41);
            this.label5.TabIndex = 1;
            this.label5.Text = "Fr";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.label6.Location = new System.Drawing.Point(205, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 41);
            this.label6.TabIndex = 1;
            this.label6.Text = "Sa";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.label7.Location = new System.Drawing.Point(246, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 41);
            this.label7.TabIndex = 1;
            this.label7.Text = "Su";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // monthPanel
            // 
            this.monthPanel.ColumnCount = 3;
            this.monthPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.monthPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 193F));
            this.monthPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.monthPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.monthPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.monthPanel.Controls.Add(this.leftBtn, 0, 0);
            this.monthPanel.Controls.Add(this.monthLabel, 1, 0);
            this.monthPanel.Controls.Add(this.rightBtn, 2, 0);
            this.monthPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.monthPanel.Location = new System.Drawing.Point(0, 51);
            this.monthPanel.Margin = new System.Windows.Forms.Padding(0);
            this.monthPanel.Name = "monthPanel";
            this.monthPanel.Padding = new System.Windows.Forms.Padding(18, 0, 18, 0);
            this.monthPanel.RowCount = 1;
            this.monthPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.monthPanel.Size = new System.Drawing.Size(324, 51);
            this.monthPanel.TabIndex = 1;
            // 
            // leftBtn
            // 
            this.leftBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("leftBtn.BackgroundImage")));
            this.leftBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.leftBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.leftBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.leftBtn.FlatAppearance.BorderSize = 0;
            this.leftBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.leftBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.leftBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leftBtn.Location = new System.Drawing.Point(22, 4);
            this.leftBtn.Margin = new System.Windows.Forms.Padding(4);
            this.leftBtn.Name = "leftBtn";
            this.leftBtn.Size = new System.Drawing.Size(34, 43);
            this.leftBtn.TabIndex = 1;
            this.leftBtn.TabStop = false;
            this.leftBtn.UseVisualStyleBackColor = true;
            this.leftBtn.Click += new System.EventHandler(this.leftBtn_Click);
            // 
            // monthLabel
            // 
            this.monthLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.monthLabel.AutoSize = true;
            this.monthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.monthLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(191)))), ((int)(((byte)(212)))));
            this.monthLabel.Location = new System.Drawing.Point(138, 13);
            this.monthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(46, 25);
            this.monthLabel.TabIndex = 0;
            this.monthLabel.Text = "Oct";
            this.monthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rightBtn
            // 
            this.rightBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rightBtn.BackgroundImage")));
            this.rightBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rightBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rightBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rightBtn.FlatAppearance.BorderSize = 0;
            this.rightBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.rightBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.rightBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rightBtn.Location = new System.Drawing.Point(262, 4);
            this.rightBtn.Margin = new System.Windows.Forms.Padding(4);
            this.rightBtn.Name = "rightBtn";
            this.rightBtn.Size = new System.Drawing.Size(35, 43);
            this.rightBtn.TabIndex = 2;
            this.rightBtn.TabStop = false;
            this.rightBtn.UseVisualStyleBackColor = true;
            this.rightBtn.Click += new System.EventHandler(this.RightBtn_Click);
            // 
            // MyCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.basePanel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "MyCalendar";
            this.Size = new System.Drawing.Size(324, 403);
            this.Load += new System.EventHandler(this.MyCalendar_Load);
            this.yearPanel.ResumeLayout(false);
            this.yearPanel.PerformLayout();
            this.basePanel.ResumeLayout(false);
            this.bottomPanel.ResumeLayout(false);
            this.weekPanel.ResumeLayout(false);
            this.weekPanel.PerformLayout();
            this.monthPanel.ResumeLayout(false);
            this.monthPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Button chooseYearBtn;
        private System.Windows.Forms.Panel yearPanel;
        private System.Windows.Forms.Label Mo;
        private System.Windows.Forms.Label Th;
        private System.Windows.Forms.Label Fr;
        private System.Windows.Forms.Label Tu;
        private System.Windows.Forms.Label Sa;
        private System.Windows.Forms.Label Su;
        private System.Windows.Forms.Label We;
        private System.Windows.Forms.Panel basePanel;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.TableLayoutPanel daysPanel;
        private System.Windows.Forms.TableLayoutPanel weekPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel monthPanel;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.Button leftBtn;
        private System.Windows.Forms.Button rightBtn;
    }
}
