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

        public EventScreen(EventScreenController controller)
        {
            _controller = controller;
            InitializeComponent();
        }

        /// <summary>
        /// Initialises the textbox inputs with the current values of the event.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="date"></param>
        /// <param name="location"></param>
        /// <param name="color"></param>
        public void InitialiseInputFields(string name, string startTime, string endTime, string date, string location, System.Drawing.Color color)
        {
            eventDateLabel.Text += date;
            nameInput.Text = name;
            startTimeInput.Text = startTime;
            endTimeInput.Text = endTime;
            colorDialog.Color = color;
            colorInput.Text = colorDialog.Color.Name;
            locationInput.Text = location;
        }


        /// <summary>
        /// Enacts the action of the controller when the EventScreen's primary button is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewEventButton_Click(object sender, EventArgs e)
        {
            //Checks that the name is not empty
            if (_controller.ValidateEvent(nameInput.Text, startTimeInput.Text, endTimeInput.Text, locationInput.Text, colorDialog.Color))
            {
                //Then tells the controller to do its action (either add the event or update the existing), 
                //before closing.
                _controller.Action();
                Close();
            }
        }

        /// <summary>
        /// Opens the ColorDialog window when the color textbox is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ColorInput_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();

            colorInput.Text = colorDialog.Color.Name;
        }

        /// <summary>
        /// Sets the text of the primary button of this form.
        /// </summary>
        public string ButtonText
        {
            set
            {
                eventButton.Text = value;
            }
        }
    }
}
