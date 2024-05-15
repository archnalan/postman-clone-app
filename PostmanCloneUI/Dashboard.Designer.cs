namespace PostmanCloneUI
{
	partial class Dashboard
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			formHeader = new Label();
			apiLabel = new Label();
			apiLink = new TextBox();
			resultsText = new TextBox();
			resultsLabel = new Label();
			callApi = new Button();
			statusStripLabel = new ToolStripStatusLabel();
			statusStrip = new StatusStrip();
			statusStrip.SuspendLayout();
			SuspendLayout();
			// 
			// formHeader
			// 
			formHeader.AutoSize = true;
			formHeader.Font = new Font("Montserrat", 23.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
			formHeader.Location = new Point(103, 9);
			formHeader.Name = "formHeader";
			formHeader.Size = new Size(399, 81);
			formHeader.TabIndex = 0;
			formHeader.Text = "Postman Clone";
			// 
			// apiLabel
			// 
			apiLabel.AutoSize = true;
			apiLabel.Font = new Font("Montserrat", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
			apiLabel.Location = new Point(91, 118);
			apiLabel.Name = "apiLabel";
			apiLabel.Size = new Size(93, 60);
			apiLabel.TabIndex = 0;
			apiLabel.Text = "API:";
			// 
			// apiLink
			// 
			apiLink.BorderStyle = BorderStyle.FixedSingle;
			apiLink.Location = new Point(190, 124);
			apiLink.Name = "apiLink";
			apiLink.Size = new Size(963, 42);
			apiLink.TabIndex = 1;
			// 
			// resultsText
			// 
			resultsText.BackColor = SystemColors.Window;
			resultsText.BorderStyle = BorderStyle.FixedSingle;
			resultsText.Location = new Point(103, 245);
			resultsText.Multiline = true;
			resultsText.Name = "resultsText";
			resultsText.ReadOnly = true;
			resultsText.ScrollBars = ScrollBars.Both;
			resultsText.Size = new Size(1188, 519);
			resultsText.TabIndex = 1;
			// 
			// resultsLabel
			// 
			resultsLabel.AutoSize = true;
			resultsLabel.Font = new Font("Montserrat", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
			resultsLabel.Location = new Point(91, 182);
			resultsLabel.Name = "resultsLabel";
			resultsLabel.Size = new Size(153, 60);
			resultsLabel.TabIndex = 0;
			resultsLabel.Text = "Results";
			// 
			// callApi
			// 
			callApi.Location = new Point(1175, 118);
			callApi.Name = "callApi";
			callApi.Size = new Size(112, 48);
			callApi.TabIndex = 3;
			callApi.Text = "Call";
			callApi.UseVisualStyleBackColor = true;
			callApi.Click += callApi_Click;
			// 
			// statusStripLabel
			// 
			statusStripLabel.Font = new Font("Montserrat", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
			statusStripLabel.Name = "statusStripLabel";
			statusStripLabel.Size = new Size(90, 40);
			statusStripLabel.Text = "Ready";
			// 
			// statusStrip
			// 
			statusStrip.BackColor = SystemColors.ControlLightLight;
			statusStrip.ImageScalingSize = new Size(24, 24);
			statusStrip.Items.AddRange(new ToolStripItem[] { statusStripLabel });
			statusStrip.Location = new Point(0, 799);
			statusStrip.Name = "statusStrip";
			statusStrip.Size = new Size(1440, 47);
			statusStrip.TabIndex = 2;
			statusStrip.Text = "statusStrip";
			// 
			// Dashboard
			// 
			AutoScaleDimensions = new SizeF(18F, 47F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.Window;
			ClientSize = new Size(1440, 846);
			Controls.Add(callApi);
			Controls.Add(statusStrip);
			Controls.Add(resultsText);
			Controls.Add(apiLink);
			Controls.Add(resultsLabel);
			Controls.Add(apiLabel);
			Controls.Add(formHeader);
			Font = new Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Margin = new Padding(5);
			Name = "Dashboard";
			Text = "Postman Clone by Nalitect studio";
			statusStrip.ResumeLayout(false);
			statusStrip.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label formHeader;
		private Label apiLabel;
		private TextBox apiLink;
		private TextBox resultsText;
		private Label resultsLabel;
		private Button callApi;
		private ToolStripStatusLabel statusStripLabel;
		private StatusStrip statusStrip;
	}
}