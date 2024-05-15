using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PostmanCloneUI
{
	public partial class Dashboard : Form
	{
		public Dashboard()
		{
			InitializeComponent();
		}

		//avoiding any actual backend code in the UI
		private async void callApi_Click(object sender, EventArgs e)
		{
			//Validate user input

			try
			{
				statusStripLabel.Text = "Calling api...";

				//Call the actual Api
				await Task.Delay(2000);

				statusStripLabel.Text = "Ready";

			}
			catch(Exception ex)
			{
				resultsText.Text ="Error" + ex.Message;

				statusStripLabel.Text = "Error";
			}
		}
	}
}
