namespace WinFormsApp1
{
    partial class BlankDate
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
            this.blankLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // blankLabel
            // 
            this.blankLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.blankLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.blankLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.blankLabel.Location = new System.Drawing.Point(0, 0);
            this.blankLabel.Name = "blankLabel";
            this.blankLabel.Size = new System.Drawing.Size(41, 41);
            this.blankLabel.TabIndex = 0;
            this.blankLabel.Text = "00";
            this.blankLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BlankDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.blankLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BlankDate";
            this.Size = new System.Drawing.Size(41, 41);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label blankLabel;
    }
}
