using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forecast
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void forecastBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.forecastBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.forecastdata);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'forecastdata.forecast' table. You can move, or remove it, as needed.
            this.forecastTableAdapter.Fill(this.forecastdata.forecast);

        }

        private void savaData_Click(object sender, EventArgs e)
        {
            string temparature = idTextBox.Text.ToString();
            string humidy = temp_in_kelvinTextBox.Text.ToString();
            string speedFWind = speed_of_windTextBox.Text.ToString();
            string weather = weatherTextBox.Text.ToString();
            string city = cityTextBox.Text.ToString();
            string area = area_codeTextBox.Text.ToString();

            MessageBox.Show( "data saved successfully");




        }
    }
}
