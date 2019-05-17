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
        private int _colIndex;
        private int _rowIndex;
        public AddEventScreen(int colIndex, int rowIndex)
        {
            colIndex = _colIndex;
            rowIndex = _rowIndex;
            InitializeComponent();
        }

        private void NewEventButton_Click(object sender, EventArgs e)
        {
            
        }

        private void ColorInput_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();

            //if (ShowDialog() == DialogResult.OK)
            {
                colorInput.Text = colorDialog.Color.Name;
            }
        }

        private void AddEventScreen_Load(object sender, EventArgs e)
        {
            colorInput.Text = colorDialog.Color.Name;

        }


    }
}
