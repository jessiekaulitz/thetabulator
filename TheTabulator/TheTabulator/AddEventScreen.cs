using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheTabulator
{
    public partial class AddEventScreen : Form
    {
        private AddEventController _controller;
        public AddEventScreen(AddEventController controller)
        {
            _controller = controller;
            InitializeComponent();
        }

        private void AddEventScreen_Load(object sender, EventArgs e)
        {

            colorDialog.Color = CalendarEvent.DEFAULT_COLOR;

            startTimeInput.Text = _controller.StartTime;
            endTimeInput.Text = _controller.EndTime;
            colorInput.Text = colorDialog.Color.Name;

            eventDateLabel.Text += _controller.EventDate;
        }


        private void NewEventButton_Click(object sender, EventArgs e)
        {
            //Checks that the name is not empty
            if (_controller.ValidateEvent())
            {
                //Then tells the controller to add its event to the CalendarController's
                //event list, before closing.
                _controller.AddEvent();
                Close();
            }
            else
                MessageBox.Show("Please fill in all inputs");
        }

        private void ColorInput_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();

            colorInput.Text = colorDialog.Color.Name;
            _controller.EventColor = colorDialog.Color;
        }



        private void NameInput_TextChanged(object sender, EventArgs e)
        {
            _controller.EventName = nameInput.Text;
        }

        private void LocationInput_TextChanged(object sender, EventArgs e)
        {
            _controller.EventLocation = locationInput.Text;
        }
    }
}
