using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Text;
using System.Windows.Forms;


namespace WinFormsApp1
{

    public partial class MyCalendar : UserControl
    {
        #region 設定變數
        // [變數] 主色
        public System.Drawing.Color mainColor = Color.FromArgb(87, 191, 212);
        public System.Drawing.Color dateColor = Color.FromArgb(67, 67, 67);

        // [當前時間]
        public DateTime now = DateTime.Now;
        public int year, month;

        // [上下月變數]
        public int lastMonthdays;
        public int nextMonthDays;

        #endregion

        public MyCalendar()
        {
            InitializeComponent();

            // [旋轉背景]
            this.rightBtn.BackgroundImage.RotateFlip(RotateFlipType.Rotate180FlipY);

            // [當前年, 月]
            year = now.Year;
            month = now.Month;

            Debug.WriteLine(now);
        }

        private void MyCalendar_Load(object sender, EventArgs e)
        {
            DisplayDays();
            DisplayMonths();
            DisplayYears();
            SetWindowRegion();
        }

        #region 圓角視窗
        /// <summary>
        /// 設置視窗 Region
        /// </summary>
        public void SetWindowRegion()
        {
            GraphicsPath FormPath;
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
            FormPath = GetRoundedRectPath(rect, 3);
            this.Region = new Region(FormPath);
            
        }
        /// <summary>
        /// 繪製圓角路徑
        /// </summary>
        /// <param name="rect"></param>
        /// <param name="radius"></param>
        /// <returns></returns>
        private GraphicsPath GetRoundedRectPath(Rectangle rect, int radius)
        {
            int diameter = radius;
            Rectangle arcRect = new Rectangle(rect.Location, new Size(diameter, diameter));
            GraphicsPath path = new GraphicsPath();
            

            // 左上角
            path.AddArc(arcRect, 180, 90);

            // 右上角
            arcRect.X = rect.Right - diameter;
            path.AddArc(arcRect, 270, 90);

            // 右下角
            arcRect.Y = rect.Bottom - diameter;
            path.AddArc(arcRect, 0, 90);

            // 左下角
            arcRect.X = rect.Left;
            path.AddArc(arcRect, 90, 90);
            path.CloseFigure();//闭合曲线
            return path;
        }

        /// <summary>
        /// 視窗size發生改變時重新設置Region屬性
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Resize(object sender, EventArgs e)
        {
            SetWindowRegion();
        }
        #endregion

        // [顯示日期]
        private void DisplayDays ()
        {
            // [當月1號]
            DateTime startMonth = new DateTime(year, month, 1);

            // [當月天數] 
            int days =DateTime.DaysInMonth(year, month);

            // [當月1號星期]
            int dayOfTheWeek =Convert.ToInt32(startMonth.DayOfWeek.ToString("d"));

            // [上月天數]
            if (month!=1)
            {
                lastMonthdays = DateTime.DaysInMonth(year, month - 1);
            }
            else
            {
                lastMonthdays = DateTime.DaysInMonth(year-1, 12);
            }

            // [下月日期]
            nextMonthDays = 1;

            // [上月剩餘格子]
            int restDay = dayOfTheWeek - 1;


            // [添加上月日期格子]
            for (int i = dayOfTheWeek; i > 1; i--)
            {
               BlankDate unblank = new BlankDate();
               unblank.BlankDays(lastMonthdays-restDay+1);
               daysPanel.Controls.Add(unblank);
               restDay--;
            }

            // [添加當月日期格子]
            for (int i = 1; i <= 42; i++)
            {
                if (i<=days)
                {
                    SingleDate ucdays = new SingleDate();
                    ucdays.days(i);
                    daysPanel.Controls.Add(ucdays);
                }
                else
                {
                    BlankDate unblank = new BlankDate();
                    unblank.BlankDays(nextMonthDays);
                    daysPanel.Controls.Add(unblank);
                    nextMonthDays++;
                }
            }
        }

        // [顯示月份]
        private void DisplayMonths()
        {
            DateTime startMonth = new DateTime(year, month, 1);
            CultureInfo ci = new CultureInfo("en-US");
            var month_name = startMonth.ToString("MMM", ci);
            monthLabel.Text = month_name;
        }

        // [顯示年分]
        private void DisplayYears()
        {
            yearLabel.Text = Convert.ToString(year);
        }

        // [點擊按鈕] 上個月
        private void leftBtn_Click(object sender, EventArgs e)
        {
            // [清除] daysPanel
            daysPanel.Controls.Clear();
            // [判斷] month > 12 || month < 0
            if (month > 1)
            {
                month--;
            }
            else if (month == 1)
            {
                month = 12;
                year--;
            }

            DisplayDays();
            DisplayMonths();
            DisplayYears();
        }

        // [點擊按鈕] 下個月
        private void RightBtn_Click(object sender, EventArgs e)
        {
            // [清除] daysPanel
            daysPanel.Controls.Clear();

            // [判斷] month > 12 || month == 12
            if (month < 12)
            {
                month++;
            }
            else if(month == 12)
            {
                month = 1;
                year++;
            }
            DisplayDays();
            DisplayMonths();
            DisplayYears();

        }
    }
}
