using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheTabulator
{
    public partial class Calendar : UserControl
    {
        public Calendar()
        {
            InitializeComponent();
        }

        private void Calendar_Load(object sender, EventArgs e)
        {
            //Setting the vertical scroll to start 50% down to show the more relevant times people like
            calendarTable.VerticalScroll.Value = 50;
            
            //calendarTable.Controls.Clear

            Label label = new Label();
            label.BackColor = Color.MediumPurple;
            label.Text = "Event here";
            label.Dock = DockStyle.Fill;

            calendarTable.Controls.Add(label, 2, 2);

        }

        private void MonthLabel_Click(object sender, EventArgs e)
        {

        }

        //Needs to update the calendar labels for date numbers, month (if necessary), and year (if necessary)
        private void UpdateCalendarLabels()
        {

        }
    }
}
