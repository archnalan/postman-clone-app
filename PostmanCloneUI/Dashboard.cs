﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PostmanCloneLibrary;

namespace PostmanCloneUI
{
	public partial class Dashboard : Form
	{
		private readonly ApiAccess _apiAccess = new();
        
        public Dashboard()
		{
			InitializeComponent();
		}

		//avoiding any actual backend code in the UI
		private async void callApi_Click(object sender, EventArgs e)
		{
			resultsText.Text = "";
			
			statusStripLabel.Text = "Calling api...";

			//Validate user input
			if (_apiAccess.IsValidUrl(apiLink.Text) == false)
			{
				 statusStripLabel.Text = "INVALID URL";
				return;
			}

			try
			{	
				//Call the actual Api
				var results = await _apiAccess.CallApiAsync(apiLink.Text);

				resultsText.Text = results.ToString();

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
