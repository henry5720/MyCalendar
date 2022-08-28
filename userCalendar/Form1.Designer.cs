namespace userCalendar
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
            this.myCalendar2 = new WinFormsApp1.MyCalendar();
            this.button1 = new System.Windows.Forms.Button();
            this.roundPanel1 = new CS_VPOS.RoundPanel();
            this.roundPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // myCalendar2
            // 
            this.myCalendar2.BackColor = System.Drawing.Color.White;
            this.myCalendar2.Location = new System.Drawing.Point(3, 3);
            this.myCalendar2.Margin = new System.Windows.Forms.Padding(0);
            this.myCalendar2.Name = "myCalendar2";
            this.myCalendar2.Size = new System.Drawing.Size(324, 403);
            this.myCalendar2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(330, 410);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // roundPanel1
            // 
            this.roundPanel1.AllRound = ((uint)(15u));
            this.roundPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.roundPanel1.BackImgColor = System.Drawing.Color.Empty;
            this.roundPanel1.BorderColor = System.Drawing.Color.BlanchedAlmond;
            this.roundPanel1.BorderWidth = 1;
            this.roundPanel1.BottomLeftRadius = ((uint)(15u));
            this.roundPanel1.BottomRightRadius = ((uint)(15u));
            this.roundPanel1.Controls.Add(this.myCalendar2);
            this.roundPanel1.Controls.Add(this.button1);
            this.roundPanel1.Location = new System.Drawing.Point(227, 32);
            this.roundPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.roundPanel1.Name = "roundPanel1";
            this.roundPanel1.Size = new System.Drawing.Size(330, 410);
            this.roundPanel1.TabIndex = 4;
            this.roundPanel1.TopLeftRadius = ((uint)(15u));
            this.roundPanel1.TopRightRadius = ((uint)(15u));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 570);
            this.Controls.Add(this.roundPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.roundPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private WinFormsApp1.MyCalendar myCalendar2;
        private System.Windows.Forms.Button button1;
        private CS_VPOS.RoundPanel roundPanel1;
    }
}
