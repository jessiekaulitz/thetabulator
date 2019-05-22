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
    public partial class EventScreen : Form
    {
        private EventScreenController _controller;
        public EventScreen(EventScreenController controller, string buttonName)
        {
            _controller = controller;
            InitializeComponent();

            StartPosition = FormStartPosition.CenterParent;

            newEventButton.Text = buttonName;
        }

        private void AddEventScreen_Load(object sender, EventArgs e)
        {



        }

        public void InitialiseInputFields(string name, string startTime, string endTime, string date)
        {
            colorDialog.Color = CalendarEvent.DEFAULT_COLOR;
            colorInput.Text = colorDialog.Color.Name;
            startTimeInput.Text = startTime;
            endTimeInput.Text = endTime;

            eventDateLabel.Text += date;
        }


        private void NewEventButton_Click(object sender, EventArgs e)
        {
            //Checks that the name is not empty
            if (_controller.ValidateEvent(nameInput.Text, startTimeInput.Text, endTimeInput.Text, locationInput.Text, colorDialog.Color))
            {
                //Then tells the controller to add its event to the CalendarController's
                //event list, before closing.
                _controller.Action();
                Close();
            }
        }

        private void ColorInput_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();

            colorInput.Text = colorDialog.Color.Name;
        }



        private void NameInput_TextChanged(object sender, EventArgs e)
        {
            //_controller.EventName = nameInput.Text;
        }

        private void LocationInput_TextChanged(object sender, EventArgs e)
        {
            //_controller.EventLocation = locationInput.Text;
        }
    }
}
